namespace KDownloader_Recoded
{
    partial class accountsReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accountsReset));
            this.output = new System.Windows.Forms.ListBox();
            this.setPwdBtn = new System.Windows.Forms.Button();
            this.newPwBox = new System.Windows.Forms.TextBox();
            this.newPwLbl = new System.Windows.Forms.Label();
            this.accListBox = new System.Windows.Forms.ComboBox();
            this.gbAddAcc = new System.Windows.Forms.GroupBox();
            this.createAccBtn = new System.Windows.Forms.Button();
            this.readonlyUIDtb = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbCreatedPassword = new System.Windows.Forms.Label();
            this.lbCreatedUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbCreatedUID = new System.Windows.Forms.Label();
            this.gbSetAcc = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.gbAddAcc.SuspendLayout();
            this.gbSetAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.output.FormattingEnabled = true;
            this.output.IntegralHeight = false;
            this.output.Location = new System.Drawing.Point(12, 266);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(254, 130);
            this.output.TabIndex = 0;
            this.output.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.oDraw);
            this.output.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // setPwdBtn
            // 
            this.setPwdBtn.Location = new System.Drawing.Point(6, 72);
            this.setPwdBtn.Name = "setPwdBtn";
            this.setPwdBtn.Size = new System.Drawing.Size(168, 23);
            this.setPwdBtn.TabIndex = 1;
            this.setPwdBtn.Text = "Set password";
            this.setPwdBtn.UseVisualStyleBackColor = true;
            this.setPwdBtn.Click += new System.EventHandler(this.setPwdBtn_Click);
            // 
            // newPwBox
            // 
            this.newPwBox.Location = new System.Drawing.Point(93, 46);
            this.newPwBox.Name = "newPwBox";
            this.newPwBox.Size = new System.Drawing.Size(151, 20);
            this.newPwBox.TabIndex = 2;
            // 
            // newPwLbl
            // 
            this.newPwLbl.AutoSize = true;
            this.newPwLbl.Location = new System.Drawing.Point(6, 49);
            this.newPwLbl.Name = "newPwLbl";
            this.newPwLbl.Size = new System.Drawing.Size(81, 13);
            this.newPwLbl.TabIndex = 3;
            this.newPwLbl.Text = "New Password:";
            // 
            // accListBox
            // 
            this.accListBox.FormattingEnabled = true;
            this.accListBox.Location = new System.Drawing.Point(6, 19);
            this.accListBox.Name = "accListBox";
            this.accListBox.Size = new System.Drawing.Size(238, 21);
            this.accListBox.TabIndex = 4;
            this.accListBox.Text = "<Select account>";
            // 
            // gbAddAcc
            // 
            this.gbAddAcc.Controls.Add(this.createAccBtn);
            this.gbAddAcc.Controls.Add(this.readonlyUIDtb);
            this.gbAddAcc.Controls.Add(this.tbPassword);
            this.gbAddAcc.Controls.Add(this.lbCreatedPassword);
            this.gbAddAcc.Controls.Add(this.lbCreatedUsername);
            this.gbAddAcc.Controls.Add(this.tbUsername);
            this.gbAddAcc.Controls.Add(this.lbCreatedUID);
            this.gbAddAcc.Location = new System.Drawing.Point(12, 128);
            this.gbAddAcc.Name = "gbAddAcc";
            this.gbAddAcc.Size = new System.Drawing.Size(254, 132);
            this.gbAddAcc.TabIndex = 5;
            this.gbAddAcc.TabStop = false;
            this.gbAddAcc.Text = "Create account (No permissions)";
            // 
            // createAccBtn
            // 
            this.createAccBtn.Location = new System.Drawing.Point(12, 97);
            this.createAccBtn.Name = "createAccBtn";
            this.createAccBtn.Size = new System.Drawing.Size(226, 23);
            this.createAccBtn.TabIndex = 5;
            this.createAccBtn.Text = "Create account";
            this.createAccBtn.UseVisualStyleBackColor = true;
            this.createAccBtn.Click += new System.EventHandler(this.createAccBtn_Click);
            // 
            // readonlyUIDtb
            // 
            this.readonlyUIDtb.Location = new System.Drawing.Point(73, 19);
            this.readonlyUIDtb.Name = "readonlyUIDtb";
            this.readonlyUIDtb.ReadOnly = true;
            this.readonlyUIDtb.Size = new System.Drawing.Size(165, 20);
            this.readonlyUIDtb.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(73, 71);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(165, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // lbCreatedPassword
            // 
            this.lbCreatedPassword.AutoSize = true;
            this.lbCreatedPassword.Location = new System.Drawing.Point(11, 74);
            this.lbCreatedPassword.Name = "lbCreatedPassword";
            this.lbCreatedPassword.Size = new System.Drawing.Size(56, 13);
            this.lbCreatedPassword.TabIndex = 2;
            this.lbCreatedPassword.Text = "Password:";
            // 
            // lbCreatedUsername
            // 
            this.lbCreatedUsername.AutoSize = true;
            this.lbCreatedUsername.Location = new System.Drawing.Point(9, 49);
            this.lbCreatedUsername.Name = "lbCreatedUsername";
            this.lbCreatedUsername.Size = new System.Drawing.Size(58, 13);
            this.lbCreatedUsername.TabIndex = 1;
            this.lbCreatedUsername.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(73, 45);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(165, 20);
            this.tbUsername.TabIndex = 3;
            // 
            // lbCreatedUID
            // 
            this.lbCreatedUID.AutoSize = true;
            this.lbCreatedUID.Location = new System.Drawing.Point(38, 22);
            this.lbCreatedUID.Name = "lbCreatedUID";
            this.lbCreatedUID.Size = new System.Drawing.Size(29, 13);
            this.lbCreatedUID.TabIndex = 0;
            this.lbCreatedUID.Text = "UID:";
            // 
            // gbSetAcc
            // 
            this.gbSetAcc.Controls.Add(this.btnDel);
            this.gbSetAcc.Controls.Add(this.accListBox);
            this.gbSetAcc.Controls.Add(this.setPwdBtn);
            this.gbSetAcc.Controls.Add(this.newPwBox);
            this.gbSetAcc.Controls.Add(this.newPwLbl);
            this.gbSetAcc.Location = new System.Drawing.Point(12, 12);
            this.gbSetAcc.Name = "gbSetAcc";
            this.gbSetAcc.Size = new System.Drawing.Size(254, 110);
            this.gbSetAcc.TabIndex = 0;
            this.gbSetAcc.TabStop = false;
            this.gbSetAcc.Text = "Account management";
            // 
            // btnDel
            // 
            this.btnDel.ForeColor = System.Drawing.Color.Red;
            this.btnDel.Location = new System.Drawing.Point(180, 72);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(64, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // accountsReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 408);
            this.Controls.Add(this.gbSetAcc);
            this.Controls.Add(this.gbAddAcc);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "accountsReset";
            this.Text = "Account handler";
            this.Load += new System.EventHandler(this.accountsReset_Load);
            this.gbAddAcc.ResumeLayout(false);
            this.gbAddAcc.PerformLayout();
            this.gbSetAcc.ResumeLayout(false);
            this.gbSetAcc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox output;
        private System.Windows.Forms.Button setPwdBtn;
        private System.Windows.Forms.TextBox newPwBox;
        private System.Windows.Forms.Label newPwLbl;
        private System.Windows.Forms.ComboBox accListBox;
        private System.Windows.Forms.GroupBox gbAddAcc;
        private System.Windows.Forms.Button createAccBtn;
        private System.Windows.Forms.TextBox readonlyUIDtb;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbCreatedPassword;
        private System.Windows.Forms.Label lbCreatedUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbCreatedUID;
        private System.Windows.Forms.GroupBox gbSetAcc;
        private System.Windows.Forms.Button btnDel;
    }
}