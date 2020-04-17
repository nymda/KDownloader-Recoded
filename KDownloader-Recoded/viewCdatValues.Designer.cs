namespace KDownloader_Recoded
{
    partial class viewCdatValues
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
            this.rtbView = new System.Windows.Forms.RichTextBox();
            this.btnDeleteCdat = new System.Windows.Forms.Button();
            this.cbConfirmDelete = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rtbView
            // 
            this.rtbView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbView.Location = new System.Drawing.Point(12, 12);
            this.rtbView.Name = "rtbView";
            this.rtbView.ReadOnly = true;
            this.rtbView.Size = new System.Drawing.Size(360, 198);
            this.rtbView.TabIndex = 0;
            this.rtbView.Text = "";
            // 
            // btnDeleteCdat
            // 
            this.btnDeleteCdat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteCdat.Enabled = false;
            this.btnDeleteCdat.Location = new System.Drawing.Point(12, 216);
            this.btnDeleteCdat.Name = "btnDeleteCdat";
            this.btnDeleteCdat.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCdat.TabIndex = 1;
            this.btnDeleteCdat.Text = "Delete";
            this.btnDeleteCdat.UseVisualStyleBackColor = true;
            this.btnDeleteCdat.Click += new System.EventHandler(this.btnDeleteCdat_Click);
            // 
            // cbConfirmDelete
            // 
            this.cbConfirmDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbConfirmDelete.AutoSize = true;
            this.cbConfirmDelete.Location = new System.Drawing.Point(93, 220);
            this.cbConfirmDelete.Name = "cbConfirmDelete";
            this.cbConfirmDelete.Size = new System.Drawing.Size(91, 17);
            this.cbConfirmDelete.TabIndex = 2;
            this.cbConfirmDelete.Text = "Enable delete";
            this.cbConfirmDelete.UseVisualStyleBackColor = true;
            this.cbConfirmDelete.CheckedChanged += new System.EventHandler(this.cbConfirmDelete_CheckedChanged);
            // 
            // viewCdatValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 250);
            this.Controls.Add(this.cbConfirmDelete);
            this.Controls.Add(this.btnDeleteCdat);
            this.Controls.Add(this.rtbView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "viewCdatValues";
            this.Text = "Data view";
            this.Load += new System.EventHandler(this.viewCdatValues_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbView;
        private System.Windows.Forms.Button btnDeleteCdat;
        private System.Windows.Forms.CheckBox cbConfirmDelete;
    }
}