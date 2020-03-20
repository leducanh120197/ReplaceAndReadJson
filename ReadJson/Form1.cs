using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.XPath;
using System.Xml;
using System.Diagnostics;

namespace ReadJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //----------Convert Json and Xem to csv
        private void SelectFileType(object sender, EventArgs e)
        {
            if (radiobtnJson.Checked)
            {
                lblCheckedFileType.Text = "*.json";
            }
            if (radiobtnXml.Checked)
            {
                lblCheckedFileType.Text = "*.xml";
            }
        }
        
        private void btnOneFile_Click_1(object sender, EventArgs e)
        {
            try
            {
                var result = JsonAndXml.AnalysisFileContent(txtOneFile.Text, txtPathSyntax.Text, lblCheckedFileType.Text);
                richInput.Text = result.Item1;
                richOutput.Clear();
                richOutput.Text = result.Item2;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Exception", MessageBoxButtons.OK);
            }
            // $.phoneNumbers[:3].number
        }

        private void btnAllFile_Click_1(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.Now;
            string urlAllFile = txtAllFile.Text;
            string fileType = lblCheckedFileType.Text;
            string path = Application.StartupPath.ToString();
            lblPath.Text = path;
            try
            {
                FileInfo[] Files = JsonAndXml.GetListFile(urlAllFile, fileType);

                pBar.Minimum = 0;
                pBar.Maximum = Files.Length;
                pBar.Step = 1;

                foreach (FileInfo file in Files)
                {
                    string output = file.FullName.Replace(file.Extension, ".csv");
                    var csv = new StringBuilder();

                    Tuple<string, string> result = JsonAndXml.AnalysisFileContent(file.FullName, txtPathSyntax.Text, lblCheckedFileType.Text);
                    richInput.Text += result.Item1;
                    richOutput.Text += result.Item2;
                    string newLine = string.Format("{0}", result.Item2);
                    csv.AppendLine(newLine);
                    File.WriteAllText(output, csv.ToString());
                    pBar.PerformStep();
                }
            }//      $.phoneNumbers[:3].number
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Exception", MessageBoxButtons.OK);
            }

            DateTime endTime = DateTime.Now;
            TimeSpan duration = endTime - startTime;
            lblStartTime.Text = startTime.ToString("MM/dd/yyyy h:mm tt");
            lblEndTime.Text = endTime.ToString("MM/dd/yyyy h:mm tt");
            lblTime.Text = duration.ToString();
        }

        // ----------Replace----------
        private void btnReplace_Click(object sender, EventArgs e)
        {
            string urlReplaceInput = txtReplaceInput.Text;
            string fileType = comboBox1.Text;
            try
            {
                Tuple<List<string>, List<string>> configList = JsonAndXml.ReadConfig(txtReplaceConfig.Text);

                FileInfo[] urlList = JsonAndXml.GetListFile(urlReplaceInput, fileType);
                if (urlList.Length == 0)
                {
                    MessageBox.Show("Can not found", "Exception", MessageBoxButtons.OK);
                }
                else
                {
                    foreach (FileInfo fileInfo in urlList)
                    {
                        string strContent = JsonAndXml.ReadFile(fileInfo.FullName);
                        richTextBox1.Text += strContent + "\n\n";
                        for (int i = 0; i< configList.Item1.Count; i++)
                        {
                            strContent = strContent.Replace(configList.Item1[i], configList.Item2[i]);
                        }
                        string output = JsonAndXml.ChangeFileName(fileInfo);
                        JsonAndXml.WriteFile(output, strContent);
                        richTextBox2.Text += strContent + "\n\n";
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Exception error", MessageBoxButtons.OK);
            }
        }

        // ----------VoxCel----------
        private void btnVoxCelConvert_Click(object sender, EventArgs e)
        {
            try
            {
                string urlExcelFile = txtVoxCelBrowse.Text;
                Microsoft.Office.Interop.Excel.Range xlRange = Utils.XlsxUtils.ReadFileExcel(urlExcelFile);
                string jsonContent = Repositories.VoxCel.WriteJson(xlRange);
                richVoxCel.Text = jsonContent;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Exception error", MessageBoxButtons.OK);
            }
        }

        private void btnVoxCelBrowse_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
                {
                    txtVoxCelBrowse.Text = ofd.FileName;
                }
            }
        }

        //--------------------------------------------------------------------
        //--------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"E:\CSharp\ReadJson\ReadJson\bin\Debug\test\path2.json"))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var root = JToken.Load(jsonReader);
                DisplayTreeView(root, Path.GetFileNameWithoutExtension(@"E:\CSharp\ReadJson\ReadJson\bin\Debug\test\path2.json"));
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"E:\CSharp\ReadJson\ReadJson\bin\Debug\test\path2.json"))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var root = JToken.Load(jsonReader);
                DisplayTreeView(root, Path.GetFileNameWithoutExtension(@"E:\CSharp\ReadJson\ReadJson\bin\Debug\test\path2.json"));
            }
        }


        private void DisplayTreeView(JToken root, string rootName)
        {
            treeView1.BeginUpdate();
            try
            {
                //treeView1.Nodes.Clear();
                var tNode = treeView1.Nodes[treeView1.Nodes.Add(new TreeNode(rootName))];
                tNode.Tag = root;

                AddNode(root, tNode);

                //treeView1.ExpandAll();
            }
            finally
            {
                treeView1.EndUpdate();
            }
        }

        private void AddNode(JToken token, TreeNode inTreeNode)
        {
            if (token == null)
                return;
            if (token is JValue)
            {
                var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(token.ToString()))];
                childNode.Tag = token;
            }
            else if (token is JObject)
            {
                var obj = (JObject)token;
                foreach (var property in obj.Properties())
                {
                    var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(property.Name))];
                    childNode.Tag = property;
                    AddNode(property.Value, childNode);
                }
            }
            else if (token is JArray)
            {
                var array = (JArray)token;
                for (int i = 0; i < array.Count; i++)
                {
                    var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(array[i].First.ToString()))];
                    childNode.Tag = array[i];
                    AddNode(array[i], childNode);
                }
            }
            else
            {
                Debug.WriteLine(string.Format("{0} not implemented", token.Type)); // JConstructor, JRaw
            }
        }


    }
}
