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
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(638, 604);
            this.tabControl1.TabIndex = 0;
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
            // tabPage1
            // 
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
            this.tabPage1.Text = "Json";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Path Syntax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Directory";
            // 
            // txtPathSyntax
            // 
            this.txtPathSyntax.Location = new System.Drawing.Point(75, 65);
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
            this.btnAllFile.Location = new System.Drawing.Point(385, 37);
            this.btnAllFile.Name = "btnAllFile";
            this.btnAllFile.Size = new System.Drawing.Size(75, 23);
            this.btnAllFile.TabIndex = 21;
            this.btnAllFile.Text = "All files";
            this.btnAllFile.UseVisualStyleBackColor = true;
            this.btnAllFile.Click += new System.EventHandler(this.btnAllFile_Click_1);
            // 
            // btnOneFile
            // 
            this.btnOneFile.Location = new System.Drawing.Point(385, 8);
            this.btnOneFile.Name = "btnOneFile";
            this.btnOneFile.Size = new System.Drawing.Size(75, 23);
            this.btnOneFile.TabIndex = 20;
            this.btnOneFile.Text = "One file";
            this.btnOneFile.UseVisualStyleBackColor = true;
            this.btnOneFile.Click += new System.EventHandler(this.btnOneFile_Click_1);
            // 
            // txtAllFile
            // 
            this.txtAllFile.Location = new System.Drawing.Point(75, 39);
            this.txtAllFile.Name = "txtAllFile";
            this.txtAllFile.Size = new System.Drawing.Size(304, 20);
            this.txtAllFile.TabIndex = 19;
            // 
            // txtOneFile
            // 
            this.txtOneFile.Location = new System.Drawing.Point(75, 10);
            this.txtOneFile.Name = "txtOneFile";
            this.txtOneFile.Size = new System.Drawing.Size(304, 20);
            this.txtOneFile.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 629);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
    }
}

