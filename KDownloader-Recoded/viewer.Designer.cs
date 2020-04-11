namespace KDownloader_Recoded
{
    partial class viewer
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
            this.mainPB = new System.Windows.Forms.PictureBox();
            this.subPBone = new System.Windows.Forms.PictureBox();
            this.subPBtwo = new System.Windows.Forms.PictureBox();
            this.subPBthree = new System.Windows.Forms.PictureBox();
            this.subPBfour = new System.Windows.Forms.PictureBox();
            this.BarMain = new System.Windows.Forms.ProgressBar();
            this.progressLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subPBone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subPBtwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subPBthree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subPBfour)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPB
            // 
            this.mainPB.Location = new System.Drawing.Point(12, 12);
            this.mainPB.Name = "mainPB";
            this.mainPB.Size = new System.Drawing.Size(640, 358);
            this.mainPB.TabIndex = 0;
            this.mainPB.TabStop = false;
            // 
            // subPBone
            // 
            this.subPBone.Location = new System.Drawing.Point(658, 12);
            this.subPBone.Name = "subPBone";
            this.subPBone.Size = new System.Drawing.Size(160, 85);
            this.subPBone.TabIndex = 1;
            this.subPBone.TabStop = false;
            // 
            // subPBtwo
            // 
            this.subPBtwo.Location = new System.Drawing.Point(658, 103);
            this.subPBtwo.Name = "subPBtwo";
            this.subPBtwo.Size = new System.Drawing.Size(160, 85);
            this.subPBtwo.TabIndex = 2;
            this.subPBtwo.TabStop = false;
            // 
            // subPBthree
            // 
            this.subPBthree.Location = new System.Drawing.Point(658, 194);
            this.subPBthree.Name = "subPBthree";
            this.subPBthree.Size = new System.Drawing.Size(160, 85);
            this.subPBthree.TabIndex = 3;
            this.subPBthree.TabStop = false;
            // 
            // subPBfour
            // 
            this.subPBfour.Location = new System.Drawing.Point(658, 285);
            this.subPBfour.Name = "subPBfour";
            this.subPBfour.Size = new System.Drawing.Size(160, 85);
            this.subPBfour.TabIndex = 4;
            this.subPBfour.TabStop = false;
            // 
            // BarMain
            // 
            this.BarMain.Location = new System.Drawing.Point(12, 376);
            this.BarMain.Name = "BarMain";
            this.BarMain.Size = new System.Drawing.Size(806, 23);
            this.BarMain.TabIndex = 5;
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.Location = new System.Drawing.Point(9, 402);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(71, 13);
            this.progressLbl.TabIndex = 6;
            this.progressLbl.Text = "Progress: 0/0";
            // 
            // viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 425);
            this.Controls.Add(this.progressLbl);
            this.Controls.Add(this.BarMain);
            this.Controls.Add(this.subPBfour);
            this.Controls.Add(this.subPBthree);
            this.Controls.Add(this.subPBtwo);
            this.Controls.Add(this.subPBone);
            this.Controls.Add(this.mainPB);
            this.Name = "viewer";
            this.Text = "Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.mainPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subPBone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subPBtwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subPBthree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subPBfour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPB;
        private System.Windows.Forms.PictureBox subPBone;
        private System.Windows.Forms.PictureBox subPBtwo;
        private System.Windows.Forms.PictureBox subPBthree;
        private System.Windows.Forms.PictureBox subPBfour;
        private System.Windows.Forms.ProgressBar BarMain;
        private System.Windows.Forms.Label progressLbl;
    }
}