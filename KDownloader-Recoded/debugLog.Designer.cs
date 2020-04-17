namespace KDownloader_Recoded
{
    partial class debugLog
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
            this.dbgList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dbgList
            // 
            this.dbgList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbgList.FormattingEnabled = true;
            this.dbgList.IntegralHeight = false;
            this.dbgList.Location = new System.Drawing.Point(12, 12);
            this.dbgList.Name = "dbgList";
            this.dbgList.Size = new System.Drawing.Size(457, 568);
            this.dbgList.TabIndex = 0;
            // 
            // debugLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 592);
            this.Controls.Add(this.dbgList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "debugLog";
            this.Text = "Debug";
            this.Load += new System.EventHandler(this.debugLog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox dbgList;
    }
}