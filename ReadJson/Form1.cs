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

namespace ReadJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOneFile_Click_1(object sender, EventArgs e)
        {
            try
            {
                var result = Class1.ReadJson(txtOneFile.Text, txtPathSyntax.Text);
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
            string path = Application.StartupPath.ToString();
            lblPath.Text = path;
            try
            {
                DirectoryInfo direct = new DirectoryInfo(urlAllFile);
                FileInfo[] Files = direct.GetFiles("*.json");

                pBar.Minimum = 0;
                pBar.Maximum = Files.Length;
                pBar.Step = 1;

                foreach (FileInfo file in Files)
                {
                    string filePath = path + "\\" + file.Name;
                    filePath = filePath.Replace(".json", ".csv");
                    var csv = new StringBuilder();

                    Tuple<string, string> result = Class1.ReadJson(file.FullName, txtPathSyntax.Text);
                    string newLine = string.Format("{0}", result.Item2);
                    csv.AppendLine(newLine);
                    File.WriteAllText(filePath, csv.ToString());
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

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string urlReplaceInput = txtReplaceInput.Text;
            string fileType = comboBox1.Text;
            try
            {
                Tuple<List<string>, List<string>> configList = Class1.ReadConfig(txtReplaceConfig.Text);

                FileInfo[] urlList = Class1.GetListFile(urlReplaceInput, fileType);
                if (urlList.Length == 0)
                {
                    MessageBox.Show("Can not found", "Exception", MessageBoxButtons.OK);
                }
                else
                {
                    foreach (FileInfo fileInfo in urlList)
                    {
                        string strContent = Class1.ReadFile(fileInfo.FullName);
                        richTextBox1.Text += strContent + "\n\n";
                        for (int i = 0; i< configList.Item1.Count; i++)
                        {
                            strContent = strContent.Replace(configList.Item1[i], configList.Item2[i]);
                        }
                        string output = Class1.ChangeFileName(fileInfo);
                        Class1.WriteFile(output, strContent);
                        richTextBox2.Text += strContent + "\n\n";
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Exception error", MessageBoxButtons.OK);
            }
        }
    }
}
