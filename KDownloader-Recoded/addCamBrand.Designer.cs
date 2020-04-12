namespace KDownloader_Recoded
{
    partial class addCamBrand
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
            this.NameInput = new System.Windows.Forms.TextBox();
            this.LblNaim = new System.Windows.Forms.Label();
            this.LblPath = new System.Windows.Forms.Label();
            this.PathInput = new System.Windows.Forms.TextBox();
            this.LblShowPathHelp = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.PassInput = new System.Windows.Forms.TextBox();
            this.CBnoUser = new System.Windows.Forms.CheckBox();
            this.CBnoPass = new System.Windows.Forms.CheckBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(59, 12);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(215, 20);
            this.NameInput.TabIndex = 0;
            // 
            // LblNaim
            // 
            this.LblNaim.AutoSize = true;
            this.LblNaim.Location = new System.Drawing.Point(12, 15);
            this.LblNaim.Name = "LblNaim";
            this.LblNaim.Size = new System.Drawing.Size(41, 13);
            this.LblNaim.TabIndex = 1;
            this.LblNaim.Text = "Name: ";
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Location = new System.Drawing.Point(18, 41);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(35, 13);
            this.LblPath.TabIndex = 3;
            this.LblPath.Text = "Path: ";
            // 
            // PathInput
            // 
            this.PathInput.Location = new System.Drawing.Point(59, 38);
            this.PathInput.Name = "PathInput";
            this.PathInput.Size = new System.Drawing.Size(215, 20);
            this.PathInput.TabIndex = 2;
            // 
            // LblShowPathHelp
            // 
            this.LblShowPathHelp.AutoSize = true;
            this.LblShowPathHelp.Location = new System.Drawing.Point(280, 41);
            this.LblShowPathHelp.Name = "LblShowPathHelp";
            this.LblShowPathHelp.Size = new System.Drawing.Size(28, 13);
            this.LblShowPathHelp.TabIndex = 4;
            this.LblShowPathHelp.Text = "[ ? ] ";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(18, 67);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(35, 13);
            this.LblUser.TabIndex = 6;
            this.LblUser.Text = "User: ";
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(59, 64);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(215, 20);
            this.UserInput.TabIndex = 5;
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Location = new System.Drawing.Point(18, 93);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(33, 13);
            this.LblPass.TabIndex = 8;
            this.LblPass.Text = "Pass:";
            // 
            // PassInput
            // 
            this.PassInput.Location = new System.Drawing.Point(59, 90);
            this.PassInput.Name = "PassInput";
            this.PassInput.Size = new System.Drawing.Size(215, 20);
            this.PassInput.TabIndex = 7;
            // 
            // CBnoUser
            // 
            this.CBnoUser.AutoSize = true;
            this.CBnoUser.Location = new System.Drawing.Point(280, 66);
            this.CBnoUser.Name = "CBnoUser";
            this.CBnoUser.Size = new System.Drawing.Size(52, 17);
            this.CBnoUser.TabIndex = 9;
            this.CBnoUser.Text = "None";
            this.CBnoUser.UseVisualStyleBackColor = true;
            this.CBnoUser.CheckedChanged += new System.EventHandler(this.CBnoUser_CheckedChanged);
            // 
            // CBnoPass
            // 
            this.CBnoPass.AutoSize = true;
            this.CBnoPass.Location = new System.Drawing.Point(280, 93);
            this.CBnoPass.Name = "CBnoPass";
            this.CBnoPass.Size = new System.Drawing.Size(52, 17);
            this.CBnoPass.TabIndex = 10;
            this.CBnoPass.Text = "None";
            this.CBnoPass.UseVisualStyleBackColor = true;
            this.CBnoPass.CheckedChanged += new System.EventHandler(this.CBnoPass_CheckedChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(15, 116);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // addCamBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 151);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CBnoPass);
            this.Controls.Add(this.CBnoUser);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.PassInput);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.LblShowPathHelp);
            this.Controls.Add(this.LblPath);
            this.Controls.Add(this.PathInput);
            this.Controls.Add(this.LblNaim);
            this.Controls.Add(this.NameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "addCamBrand";
            this.Text = "Add brand";
            this.Load += new System.EventHandler(this.addCamBrand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label LblNaim;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.TextBox PathInput;
        private System.Windows.Forms.Label LblShowPathHelp;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.TextBox PassInput;
        private System.Windows.Forms.CheckBox CBnoUser;
        private System.Windows.Forms.CheckBox CBnoPass;
        private System.Windows.Forms.Button BtnSave;
    }
}