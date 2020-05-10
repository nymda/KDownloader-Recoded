namespace KDownloader_Recoded
{
    partial class hikBackdoor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hikBackdoor));
            this.ipTextbox = new System.Windows.Forms.TextBox();
            this.ipAdrLbl = new System.Windows.Forms.Label();
            this.testVulnBtn = new System.Windows.Forms.Button();
            this.snapBtn = new System.Windows.Forms.Button();
            this.accountsBtn = new System.Windows.Forms.Button();
            this.confBtn = new System.Windows.Forms.Button();
            this.decConfBtn = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.ListBox();
            this.gbSetIP = new System.Windows.Forms.GroupBox();
            this.gbGenFunc = new System.Windows.Forms.GroupBox();
            this.gbConfFiles = new System.Windows.Forms.GroupBox();
            this.cbSaveOutput = new System.Windows.Forms.CheckBox();
            this.cbPurgeNonprint = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSetIP.SuspendLayout();
            this.gbGenFunc.SuspendLayout();
            this.gbConfFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipTextbox
            // 
            this.ipTextbox.Location = new System.Drawing.Point(76, 19);
            this.ipTextbox.Name = "ipTextbox";
            this.ipTextbox.Size = new System.Drawing.Size(172, 20);
            this.ipTextbox.TabIndex = 0;
            // 
            // ipAdrLbl
            // 
            this.ipAdrLbl.AutoSize = true;
            this.ipAdrLbl.Location = new System.Drawing.Point(9, 22);
            this.ipAdrLbl.Name = "ipAdrLbl";
            this.ipAdrLbl.Size = new System.Drawing.Size(61, 13);
            this.ipAdrLbl.TabIndex = 1;
            this.ipAdrLbl.Text = "IP Address:";
            // 
            // testVulnBtn
            // 
            this.testVulnBtn.Location = new System.Drawing.Point(12, 45);
            this.testVulnBtn.Name = "testVulnBtn";
            this.testVulnBtn.Size = new System.Drawing.Size(236, 23);
            this.testVulnBtn.TabIndex = 2;
            this.testVulnBtn.Text = "Set IP";
            this.testVulnBtn.UseVisualStyleBackColor = true;
            this.testVulnBtn.Click += new System.EventHandler(this.testVulnBtn_Click);
            // 
            // snapBtn
            // 
            this.snapBtn.Enabled = false;
            this.snapBtn.Location = new System.Drawing.Point(12, 19);
            this.snapBtn.Name = "snapBtn";
            this.snapBtn.Size = new System.Drawing.Size(115, 23);
            this.snapBtn.TabIndex = 4;
            this.snapBtn.Text = "Snapshot";
            this.snapBtn.UseVisualStyleBackColor = true;
            this.snapBtn.Click += new System.EventHandler(this.snapBtn_Click);
            // 
            // accountsBtn
            // 
            this.accountsBtn.Enabled = false;
            this.accountsBtn.Location = new System.Drawing.Point(133, 19);
            this.accountsBtn.Name = "accountsBtn";
            this.accountsBtn.Size = new System.Drawing.Size(115, 23);
            this.accountsBtn.TabIndex = 5;
            this.accountsBtn.Text = "Accounts";
            this.accountsBtn.UseVisualStyleBackColor = true;
            this.accountsBtn.Click += new System.EventHandler(this.accountsBtn_Click);
            // 
            // confBtn
            // 
            this.confBtn.Enabled = false;
            this.confBtn.Location = new System.Drawing.Point(6, 19);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(115, 42);
            this.confBtn.TabIndex = 6;
            this.confBtn.Text = "Download configuration";
            this.confBtn.UseVisualStyleBackColor = true;
            this.confBtn.Click += new System.EventHandler(this.confBtn_Click);
            // 
            // decConfBtn
            // 
            this.decConfBtn.Location = new System.Drawing.Point(6, 67);
            this.decConfBtn.Name = "decConfBtn";
            this.decConfBtn.Size = new System.Drawing.Size(115, 42);
            this.decConfBtn.TabIndex = 7;
            this.decConfBtn.Text = "Decrypt configuration";
            this.decConfBtn.UseVisualStyleBackColor = true;
            this.decConfBtn.Click += new System.EventHandler(this.decConfBtn_Click);
            // 
            // output
            // 
            this.output.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.output.FormattingEnabled = true;
            this.output.IntegralHeight = false;
            this.output.Location = new System.Drawing.Point(276, 22);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(236, 251);
            this.output.TabIndex = 8;
            this.output.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.oDraw);
            // 
            // gbSetIP
            // 
            this.gbSetIP.Controls.Add(this.ipTextbox);
            this.gbSetIP.Controls.Add(this.ipAdrLbl);
            this.gbSetIP.Controls.Add(this.testVulnBtn);
            this.gbSetIP.Location = new System.Drawing.Point(12, 12);
            this.gbSetIP.Name = "gbSetIP";
            this.gbSetIP.Size = new System.Drawing.Size(258, 77);
            this.gbSetIP.TabIndex = 9;
            this.gbSetIP.TabStop = false;
            this.gbSetIP.Text = "Set IP";
            // 
            // gbGenFunc
            // 
            this.gbGenFunc.Controls.Add(this.accountsBtn);
            this.gbGenFunc.Controls.Add(this.snapBtn);
            this.gbGenFunc.Location = new System.Drawing.Point(12, 95);
            this.gbGenFunc.Name = "gbGenFunc";
            this.gbGenFunc.Size = new System.Drawing.Size(258, 54);
            this.gbGenFunc.TabIndex = 10;
            this.gbGenFunc.TabStop = false;
            this.gbGenFunc.Text = "General";
            // 
            // gbConfFiles
            // 
            this.gbConfFiles.Controls.Add(this.label1);
            this.gbConfFiles.Controls.Add(this.cbPurgeNonprint);
            this.gbConfFiles.Controls.Add(this.cbSaveOutput);
            this.gbConfFiles.Controls.Add(this.confBtn);
            this.gbConfFiles.Controls.Add(this.decConfBtn);
            this.gbConfFiles.Location = new System.Drawing.Point(12, 155);
            this.gbConfFiles.Name = "gbConfFiles";
            this.gbConfFiles.Size = new System.Drawing.Size(258, 118);
            this.gbConfFiles.TabIndex = 11;
            this.gbConfFiles.TabStop = false;
            this.gbConfFiles.Text = "Config files";
            // 
            // cbSaveOutput
            // 
            this.cbSaveOutput.AutoSize = true;
            this.cbSaveOutput.Checked = true;
            this.cbSaveOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSaveOutput.Location = new System.Drawing.Point(127, 69);
            this.cbSaveOutput.Name = "cbSaveOutput";
            this.cbSaveOutput.Size = new System.Drawing.Size(84, 17);
            this.cbSaveOutput.TabIndex = 8;
            this.cbSaveOutput.Text = "Save output";
            this.cbSaveOutput.UseVisualStyleBackColor = true;
            this.cbSaveOutput.CheckedChanged += new System.EventHandler(this.cbSaveOutput_CheckedChanged);
            // 
            // cbPurgeNonprint
            // 
            this.cbPurgeNonprint.AutoSize = true;
            this.cbPurgeNonprint.Checked = true;
            this.cbPurgeNonprint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPurgeNonprint.Location = new System.Drawing.Point(127, 92);
            this.cbPurgeNonprint.Name = "cbPurgeNonprint";
            this.cbPurgeNonprint.Size = new System.Drawing.Size(106, 17);
            this.cbPurgeNonprint.TabIndex = 9;
            this.cbPurgeNonprint.Text = "Save strings only";
            this.cbPurgeNonprint.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOTE: Not all vulnerable\r\ncameras can be decrypted.\r\nSome have different keys!";
            // 
            // hikBackdoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 283);
            this.Controls.Add(this.gbConfFiles);
            this.Controls.Add(this.gbGenFunc);
            this.Controls.Add(this.gbSetIP);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hikBackdoor";
            this.Text = "Hikvision Backdoor";
            this.Load += new System.EventHandler(this.hikBackdoor_Load);
            this.gbSetIP.ResumeLayout(false);
            this.gbSetIP.PerformLayout();
            this.gbGenFunc.ResumeLayout(false);
            this.gbConfFiles.ResumeLayout(false);
            this.gbConfFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ipTextbox;
        private System.Windows.Forms.Label ipAdrLbl;
        private System.Windows.Forms.Button testVulnBtn;
        private System.Windows.Forms.Button snapBtn;
        private System.Windows.Forms.Button accountsBtn;
        private System.Windows.Forms.Button confBtn;
        private System.Windows.Forms.Button decConfBtn;
        private System.Windows.Forms.ListBox output;
        private System.Windows.Forms.GroupBox gbSetIP;
        private System.Windows.Forms.GroupBox gbGenFunc;
        private System.Windows.Forms.GroupBox gbConfFiles;
        private System.Windows.Forms.CheckBox cbPurgeNonprint;
        private System.Windows.Forms.CheckBox cbSaveOutput;
        private System.Windows.Forms.Label label1;
    }
}