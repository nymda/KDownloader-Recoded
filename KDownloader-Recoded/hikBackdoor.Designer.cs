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
            this.SuspendLayout();
            // 
            // ipTextbox
            // 
            this.ipTextbox.Location = new System.Drawing.Point(76, 12);
            this.ipTextbox.Name = "ipTextbox";
            this.ipTextbox.Size = new System.Drawing.Size(172, 20);
            this.ipTextbox.TabIndex = 0;
            // 
            // ipAdrLbl
            // 
            this.ipAdrLbl.AutoSize = true;
            this.ipAdrLbl.Location = new System.Drawing.Point(9, 15);
            this.ipAdrLbl.Name = "ipAdrLbl";
            this.ipAdrLbl.Size = new System.Drawing.Size(61, 13);
            this.ipAdrLbl.TabIndex = 1;
            this.ipAdrLbl.Text = "IP Address:";
            // 
            // testVulnBtn
            // 
            this.testVulnBtn.Location = new System.Drawing.Point(12, 38);
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
            this.snapBtn.Location = new System.Drawing.Point(12, 67);
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
            this.accountsBtn.Location = new System.Drawing.Point(133, 67);
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
            this.confBtn.Location = new System.Drawing.Point(12, 96);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(115, 42);
            this.confBtn.TabIndex = 6;
            this.confBtn.Text = "Download configuration";
            this.confBtn.UseVisualStyleBackColor = true;
            // 
            // decConfBtn
            // 
            this.decConfBtn.Enabled = false;
            this.decConfBtn.Location = new System.Drawing.Point(133, 96);
            this.decConfBtn.Name = "decConfBtn";
            this.decConfBtn.Size = new System.Drawing.Size(115, 42);
            this.decConfBtn.TabIndex = 7;
            this.decConfBtn.Text = "Decrypt configuration";
            this.decConfBtn.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.output.FormattingEnabled = true;
            this.output.Location = new System.Drawing.Point(12, 144);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(236, 251);
            this.output.TabIndex = 8;
            this.output.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.oDraw);
            // 
            // hikBackdoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 408);
            this.Controls.Add(this.output);
            this.Controls.Add(this.decConfBtn);
            this.Controls.Add(this.confBtn);
            this.Controls.Add(this.accountsBtn);
            this.Controls.Add(this.snapBtn);
            this.Controls.Add(this.testVulnBtn);
            this.Controls.Add(this.ipAdrLbl);
            this.Controls.Add(this.ipTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hikBackdoor";
            this.Text = "Hikvision Backdoor";
            this.Load += new System.EventHandler(this.hikBackdoor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}