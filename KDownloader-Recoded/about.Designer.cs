namespace KDownloader_Recoded
{
    partial class about
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
            this.components = new System.ComponentModel.Container();
            this.aboutRTB = new System.Windows.Forms.RichTextBox();
            this.rainbow = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // aboutRTB
            // 
            this.aboutRTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutRTB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutRTB.Location = new System.Drawing.Point(12, 12);
            this.aboutRTB.Name = "aboutRTB";
            this.aboutRTB.ReadOnly = true;
            this.aboutRTB.Size = new System.Drawing.Size(494, 102);
            this.aboutRTB.TabIndex = 0;
            this.aboutRTB.Text = "~KDownloader Recoded~\n\n©Knedit 2020\nWritten by Knedit (http://knedit.pw).\nFree to" +
    " use and modify.\nCreated for educational purposes.\n\nKDownloader is released unde" +
    "r the GNU General Public License v2.0";
            // 
            // rainbow
            // 
            this.rainbow.Tick += new System.EventHandler(this.rainbow_Tick);
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 126);
            this.Controls.Add(this.aboutRTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "about";
            this.Text = "About";
            this.Load += new System.EventHandler(this.about_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox aboutRTB;
        private System.Windows.Forms.Timer rainbow;
    }
}