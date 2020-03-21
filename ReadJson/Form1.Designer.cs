namespace ReadJson
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabVoxCel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCheckedFileType = new System.Windows.Forms.Label();
            this.radiobtnXml = new System.Windows.Forms.RadioButton();
            this.radiobtnJson = new System.Windows.Forms.RadioButton();
            this.lblPath = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathSyntax = new System.Windows.Forms.TextBox();
            this.richOutput = new System.Windows.Forms.RichTextBox();
            this.richInput = new System.Windows.Forms.RichTextBox();
            this.btnAllFile = new System.Windows.Forms.Button();
            this.btnOneFile = new System.Windows.Forms.Button();
            this.txtAllFile = new System.Windows.Forms.TextBox();
            this.txtOneFile = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReplaceConfig = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReplaceInput = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtVoxCelBrowse = new System.Windows.Forms.TextBox();
            this.richVoxCel = new System.Windows.Forms.RichTextBox();
            this.btnVoxCelBrowse = new System.Windows.Forms.Button();
            this.btnVoxCelConvert = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.richTest = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabVoxCel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabVoxCel
            // 
            this.tabVoxCel.Controls.Add(this.tabPage1);
            this.tabVoxCel.Controls.Add(this.tabPage2);
            this.tabVoxCel.Controls.Add(this.tabPage3);
            this.tabVoxCel.Controls.Add(this.tabPage4);
            this.tabVoxCel.Location = new System.Drawing.Point(13, 13);
            this.tabVoxCel.Name = "tabVoxCel";
            this.tabVoxCel.SelectedIndex = 0;
            this.tabVoxCel.Size = new System.Drawing.Size(638, 604);
            this.tabVoxCel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCheckedFileType);
            this.tabPage1.Controls.Add(this.radiobtnXml);
            this.tabPage1.Controls.Add(this.radiobtnJson);
            this.tabPage1.Controls.Add(this.lblPath);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.pBar);
            this.tabPage1.Controls.Add(this.lblEndTime);
            this.tabPage1.Controls.Add(this.lblStartTime);
            this.tabPage1.Controls.Add(this.lblTime);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtPathSyntax);
            this.tabPage1.Controls.Add(this.richOutput);
            this.tabPage1.Controls.Add(this.richInput);
            this.tabPage1.Controls.Add(this.btnAllFile);
            this.tabPage1.Controls.Add(this.btnOneFile);
            this.tabPage1.Controls.Add(this.txtAllFile);
            this.tabPage1.Controls.Add(this.txtOneFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(630, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "JsonAndXmlToCsv";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCheckedFileType
            // 
            this.lblCheckedFileType.AutoSize = true;
            this.lblCheckedFileType.Location = new System.Drawing.Point(4, 52);
            this.lblCheckedFileType.Name = "lblCheckedFileType";
            this.lblCheckedFileType.Size = new System.Drawing.Size(46, 13);
            this.lblCheckedFileType.TabIndex = 39;
            this.lblCheckedFileType.Text = "File type";
            // 
            // radiobtnXml
            // 
            this.radiobtnXml.AutoSize = true;
            this.radiobtnXml.Location = new System.Drawing.Point(9, 28);
            this.radiobtnXml.Name = "radiobtnXml";
            this.radiobtnXml.Size = new System.Drawing.Size(47, 17);
            this.radiobtnXml.TabIndex = 38;
            this.radiobtnXml.TabStop = true;
            this.radiobtnXml.Text = "*.xml";
            this.radiobtnXml.UseVisualStyleBackColor = true;
            this.radiobtnXml.CheckedChanged += new System.EventHandler(this.SelectFileType);
            // 
            // radiobtnJson
            // 
            this.radiobtnJson.AutoSize = true;
            this.radiobtnJson.Location = new System.Drawing.Point(9, 7);
            this.radiobtnJson.Name = "radiobtnJson";
            this.radiobtnJson.Size = new System.Drawing.Size(51, 17);
            this.radiobtnJson.TabIndex = 37;
            this.radiobtnJson.TabStop = true;
            this.radiobtnJson.Text = "*.json";
            this.radiobtnJson.UseVisualStyleBackColor = true;
            this.radiobtnJson.CheckedChanged += new System.EventHandler(this.SelectFileType);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(219, 140);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 35;
            this.lblPath.Text = "Path";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "End Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Start time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Time";
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(6, 159);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(614, 23);
            this.pBar.TabIndex = 31;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(72, 117);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(0, 13);
            this.lblEndTime.TabIndex = 30;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(72, 93);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(0, 13);
            this.lblStartTime.TabIndex = 29;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(72, 143);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Path Syntax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Directory";
            // 
            // txtPathSyntax
            // 
            this.txtPathSyntax.Location = new System.Drawing.Point(217, 65);
            this.txtPathSyntax.Name = "txtPathSyntax";
            this.txtPathSyntax.Size = new System.Drawing.Size(304, 20);
            this.txtPathSyntax.TabIndex = 24;
            // 
            // richOutput
            // 
            this.richOutput.Location = new System.Drawing.Point(314, 188);
            this.richOutput.Name = "richOutput";
            this.richOutput.Size = new System.Drawing.Size(306, 384);
            this.richOutput.TabIndex = 23;
            this.richOutput.Text = "";
            // 
            // richInput
            // 
            this.richInput.Location = new System.Drawing.Point(6, 188);
            this.richInput.Name = "richInput";
            this.richInput.Size = new System.Drawing.Size(302, 384);
            this.richInput.TabIndex = 22;
            this.richInput.Text = "";
            // 
            // btnAllFile
            // 
            this.btnAllFile.Location = new System.Drawing.Point(527, 37);
            this.btnAllFile.Name = "btnAllFile";
            this.btnAllFile.Size = new System.Drawing.Size(75, 23);
            this.btnAllFile.TabIndex = 21;
            this.btnAllFile.Text = "All files";
            this.btnAllFile.UseVisualStyleBackColor = true;
            this.btnAllFile.Click += new System.EventHandler(this.btnAllFile_Click_1);
            // 
            // btnOneFile
            // 
            this.btnOneFile.Location = new System.Drawing.Point(527, 8);
            this.btnOneFile.Name = "btnOneFile";
            this.btnOneFile.Size = new System.Drawing.Size(75, 23);
            this.btnOneFile.TabIndex = 20;
            this.btnOneFile.Text = "One file";
            this.btnOneFile.UseVisualStyleBackColor = true;
            this.btnOneFile.Click += new System.EventHandler(this.btnOneFile_Click_1);
            // 
            // txtAllFile
            // 
            this.txtAllFile.Location = new System.Drawing.Point(217, 39);
            this.txtAllFile.Name = "txtAllFile";
            this.txtAllFile.Size = new System.Drawing.Size(304, 20);
            this.txtAllFile.TabIndex = 19;
            // 
            // txtOneFile
            // 
            this.txtOneFile.Location = new System.Drawing.Point(217, 10);
            this.txtOneFile.Name = "txtOneFile";
            this.txtOneFile.Size = new System.Drawing.Size(304, 20);
            this.txtOneFile.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.btnReplace);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtReplaceConfig);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtReplaceInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(630, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Replace";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(319, 218);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(305, 354);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 218);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 354);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "File type";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "*.json",
            "*.xml",
            "*.txt",
            "*.csv"});
            this.comboBox1.Location = new System.Drawing.Point(106, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(423, 54);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(97, 46);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Config";
            // 
            // txtReplaceConfig
            // 
            this.txtReplaceConfig.Location = new System.Drawing.Point(106, 80);
            this.txtReplaceConfig.Name = "txtReplaceConfig";
            this.txtReplaceConfig.Size = new System.Drawing.Size(311, 20);
            this.txtReplaceConfig.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directory";
            // 
            // txtReplaceInput
            // 
            this.txtReplaceInput.Location = new System.Drawing.Point(106, 54);
            this.txtReplaceInput.Name = "txtReplaceInput";
            this.txtReplaceInput.Size = new System.Drawing.Size(311, 20);
            this.txtReplaceInput.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtVoxCelBrowse);
            this.tabPage3.Controls.Add(this.richVoxCel);
            this.tabPage3.Controls.Add(this.btnVoxCelBrowse);
            this.tabPage3.Controls.Add(this.btnVoxCelConvert);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(630, 578);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "VoxCel";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtVoxCelBrowse
            // 
            this.txtVoxCelBrowse.Location = new System.Drawing.Point(92, 8);
            this.txtVoxCelBrowse.Name = "txtVoxCelBrowse";
            this.txtVoxCelBrowse.Size = new System.Drawing.Size(416, 20);
            this.txtVoxCelBrowse.TabIndex = 3;
            // 
            // richVoxCel
            // 
            this.richVoxCel.Location = new System.Drawing.Point(6, 51);
            this.richVoxCel.Name = "richVoxCel";
            this.richVoxCel.Size = new System.Drawing.Size(618, 498);
            this.richVoxCel.TabIndex = 2;
            this.richVoxCel.Text = "";
            // 
            // btnVoxCelBrowse
            // 
            this.btnVoxCelBrowse.Location = new System.Drawing.Point(11, 6);
            this.btnVoxCelBrowse.Name = "btnVoxCelBrowse";
            this.btnVoxCelBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnVoxCelBrowse.TabIndex = 1;
            this.btnVoxCelBrowse.Text = "Browse";
            this.btnVoxCelBrowse.UseVisualStyleBackColor = true;
            this.btnVoxCelBrowse.Click += new System.EventHandler(this.btnVoxCelBrowse_Click);
            // 
            // btnVoxCelConvert
            // 
            this.btnVoxCelConvert.Location = new System.Drawing.Point(514, 6);
            this.btnVoxCelConvert.Name = "btnVoxCelConvert";
            this.btnVoxCelConvert.Size = new System.Drawing.Size(110, 23);
            this.btnVoxCelConvert.TabIndex = 0;
            this.btnVoxCelConvert.Text = "Convert";
            this.btnVoxCelConvert.UseVisualStyleBackColor = true;
            this.btnVoxCelConvert.Click += new System.EventHandler(this.btnVoxCelConvert_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.richTest);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.treeView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(630, 578);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTest
            // 
            this.richTest.Location = new System.Drawing.Point(420, 127);
            this.richTest.Name = "richTest";
            this.richTest.Size = new System.Drawing.Size(204, 383);
            this.richTest.TabIndex = 2;
            this.richTest.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(21, 21);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(393, 489);
            this.treeView1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 629);
            this.Controls.Add(this.tabVoxCel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabVoxCel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabVoxCel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathSyntax;
        private System.Windows.Forms.RichTextBox richOutput;
        private System.Windows.Forms.RichTextBox richInput;
        private System.Windows.Forms.Button btnAllFile;
        private System.Windows.Forms.Button btnOneFile;
        private System.Windows.Forms.TextBox txtAllFile;
        private System.Windows.Forms.TextBox txtOneFile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtReplaceInput;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReplaceConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RadioButton radiobtnXml;
        private System.Windows.Forms.RadioButton radiobtnJson;
        private System.Windows.Forms.Label lblCheckedFileType;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnVoxCelBrowse;
        private System.Windows.Forms.Button btnVoxCelConvert;
        private System.Windows.Forms.RichTextBox richVoxCel;
        private System.Windows.Forms.TextBox txtVoxCelBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTest;
        private System.Windows.Forms.Button button2;
    }
}

