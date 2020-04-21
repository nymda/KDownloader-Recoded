namespace KDownloader_Recoded
{
    partial class Entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry));
            this.inputSelect = new System.Windows.Forms.Button();
            this.outputSelect = new System.Windows.Forms.Button();
            this.folderSelect = new System.Windows.Forms.Button();
            this.GBfiles = new System.Windows.Forms.GroupBox();
            this.LBcount = new System.Windows.Forms.Label();
            this.GBdata = new System.Windows.Forms.GroupBox();
            this.CbIpTag = new System.Windows.Forms.CheckBox();
            this.ESTlabel = new System.Windows.Forms.Label();
            this.CBrandOrd = new System.Windows.Forms.CheckBox();
            this.GBthreads = new System.Windows.Forms.GroupBox();
            this.CBthreadDebug = new System.Windows.Forms.CheckBox();
            this.LBthreads = new System.Windows.Forms.Label();
            this.NUDthreads = new System.Windows.Forms.NumericUpDown();
            this.GBcamBrand = new System.Windows.Forms.GroupBox();
            this.btnViewCdat = new System.Windows.Forms.Button();
            this.addCamera = new System.Windows.Forms.Button();
            this.CDATselect = new System.Windows.Forms.CheckedListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.GBfiles.SuspendLayout();
            this.GBdata.SuspendLayout();
            this.GBthreads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDthreads)).BeginInit();
            this.GBcamBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputSelect
            // 
            this.inputSelect.Location = new System.Drawing.Point(6, 19);
            this.inputSelect.Name = "inputSelect";
            this.inputSelect.Size = new System.Drawing.Size(129, 23);
            this.inputSelect.TabIndex = 0;
            this.inputSelect.Text = "Input";
            this.inputSelect.UseVisualStyleBackColor = true;
            this.inputSelect.Click += new System.EventHandler(this.inputSelect_Click);
            // 
            // outputSelect
            // 
            this.outputSelect.Location = new System.Drawing.Point(6, 48);
            this.outputSelect.Name = "outputSelect";
            this.outputSelect.Size = new System.Drawing.Size(129, 23);
            this.outputSelect.TabIndex = 1;
            this.outputSelect.Text = "Output (Optional)";
            this.outputSelect.UseVisualStyleBackColor = true;
            this.outputSelect.Click += new System.EventHandler(this.outputSelect_Click);
            // 
            // folderSelect
            // 
            this.folderSelect.Location = new System.Drawing.Point(6, 77);
            this.folderSelect.Name = "folderSelect";
            this.folderSelect.Size = new System.Drawing.Size(129, 23);
            this.folderSelect.TabIndex = 2;
            this.folderSelect.Text = "Image Folder";
            this.folderSelect.UseVisualStyleBackColor = true;
            this.folderSelect.Click += new System.EventHandler(this.folderSelect_Click);
            // 
            // GBfiles
            // 
            this.GBfiles.Controls.Add(this.inputSelect);
            this.GBfiles.Controls.Add(this.folderSelect);
            this.GBfiles.Controls.Add(this.outputSelect);
            this.GBfiles.Location = new System.Drawing.Point(12, 12);
            this.GBfiles.Name = "GBfiles";
            this.GBfiles.Size = new System.Drawing.Size(142, 110);
            this.GBfiles.TabIndex = 3;
            this.GBfiles.TabStop = false;
            this.GBfiles.Text = "Files";
            // 
            // LBcount
            // 
            this.LBcount.AutoSize = true;
            this.LBcount.Location = new System.Drawing.Point(6, 16);
            this.LBcount.Name = "LBcount";
            this.LBcount.Size = new System.Drawing.Size(59, 13);
            this.LBcount.TabIndex = 3;
            this.LBcount.Text = "IP count: 0";
            // 
            // GBdata
            // 
            this.GBdata.Controls.Add(this.CbIpTag);
            this.GBdata.Controls.Add(this.ESTlabel);
            this.GBdata.Controls.Add(this.CBrandOrd);
            this.GBdata.Controls.Add(this.LBcount);
            this.GBdata.Location = new System.Drawing.Point(12, 125);
            this.GBdata.Name = "GBdata";
            this.GBdata.Size = new System.Drawing.Size(142, 94);
            this.GBdata.TabIndex = 4;
            this.GBdata.TabStop = false;
            this.GBdata.Text = "Data";
            // 
            // CbIpTag
            // 
            this.CbIpTag.AutoSize = true;
            this.CbIpTag.Checked = true;
            this.CbIpTag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbIpTag.Location = new System.Drawing.Point(9, 71);
            this.CbIpTag.Name = "CbIpTag";
            this.CbIpTag.Size = new System.Drawing.Size(90, 17);
            this.CbIpTag.TabIndex = 6;
            this.CbIpTag.Text = "IP tag images";
            this.CbIpTag.UseVisualStyleBackColor = true;
            // 
            // ESTlabel
            // 
            this.ESTlabel.AutoSize = true;
            this.ESTlabel.Location = new System.Drawing.Point(6, 52);
            this.ESTlabel.Name = "ESTlabel";
            this.ESTlabel.Size = new System.Drawing.Size(90, 13);
            this.ESTlabel.TabIndex = 5;
            this.ESTlabel.Text = "EST. Time: 00:00";
            // 
            // CBrandOrd
            // 
            this.CBrandOrd.AutoSize = true;
            this.CBrandOrd.Location = new System.Drawing.Point(9, 32);
            this.CBrandOrd.Name = "CBrandOrd";
            this.CBrandOrd.Size = new System.Drawing.Size(93, 17);
            this.CBrandOrd.TabIndex = 4;
            this.CBrandOrd.Text = "Random order";
            this.CBrandOrd.UseVisualStyleBackColor = true;
            // 
            // GBthreads
            // 
            this.GBthreads.Controls.Add(this.CBthreadDebug);
            this.GBthreads.Controls.Add(this.LBthreads);
            this.GBthreads.Controls.Add(this.NUDthreads);
            this.GBthreads.Location = new System.Drawing.Point(12, 225);
            this.GBthreads.Name = "GBthreads";
            this.GBthreads.Size = new System.Drawing.Size(142, 68);
            this.GBthreads.TabIndex = 5;
            this.GBthreads.TabStop = false;
            this.GBthreads.Text = "Threading";
            // 
            // CBthreadDebug
            // 
            this.CBthreadDebug.AutoSize = true;
            this.CBthreadDebug.Checked = true;
            this.CBthreadDebug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBthreadDebug.Location = new System.Drawing.Point(9, 45);
            this.CBthreadDebug.Name = "CBthreadDebug";
            this.CBthreadDebug.Size = new System.Drawing.Size(86, 17);
            this.CBthreadDebug.TabIndex = 8;
            this.CBthreadDebug.Text = "Show debug";
            this.CBthreadDebug.UseVisualStyleBackColor = true;
            // 
            // LBthreads
            // 
            this.LBthreads.AutoSize = true;
            this.LBthreads.Location = new System.Drawing.Point(6, 21);
            this.LBthreads.Name = "LBthreads";
            this.LBthreads.Size = new System.Drawing.Size(49, 13);
            this.LBthreads.TabIndex = 7;
            this.LBthreads.Text = "Threads:";
            // 
            // NUDthreads
            // 
            this.NUDthreads.Location = new System.Drawing.Point(61, 19);
            this.NUDthreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDthreads.Name = "NUDthreads";
            this.NUDthreads.Size = new System.Drawing.Size(74, 20);
            this.NUDthreads.TabIndex = 6;
            this.NUDthreads.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NUDthreads.ValueChanged += new System.EventHandler(this.NUDthreads_ValueChanged);
            // 
            // GBcamBrand
            // 
            this.GBcamBrand.Controls.Add(this.btnViewCdat);
            this.GBcamBrand.Controls.Add(this.addCamera);
            this.GBcamBrand.Controls.Add(this.CDATselect);
            this.GBcamBrand.Location = new System.Drawing.Point(160, 12);
            this.GBcamBrand.Name = "GBcamBrand";
            this.GBcamBrand.Size = new System.Drawing.Size(200, 281);
            this.GBcamBrand.TabIndex = 6;
            this.GBcamBrand.TabStop = false;
            this.GBcamBrand.Text = "Camera brand";
            // 
            // btnViewCdat
            // 
            this.btnViewCdat.Location = new System.Drawing.Point(6, 252);
            this.btnViewCdat.Name = "btnViewCdat";
            this.btnViewCdat.Size = new System.Drawing.Size(43, 23);
            this.btnViewCdat.TabIndex = 2;
            this.btnViewCdat.Text = "View";
            this.btnViewCdat.UseVisualStyleBackColor = true;
            this.btnViewCdat.Click += new System.EventHandler(this.btnViewCdat_Click);
            // 
            // addCamera
            // 
            this.addCamera.Location = new System.Drawing.Point(55, 252);
            this.addCamera.Name = "addCamera";
            this.addCamera.Size = new System.Drawing.Size(139, 23);
            this.addCamera.TabIndex = 1;
            this.addCamera.Text = "Add";
            this.addCamera.UseVisualStyleBackColor = true;
            this.addCamera.Click += new System.EventHandler(this.addCamera_Click);
            // 
            // CDATselect
            // 
            this.CDATselect.FormattingEnabled = true;
            this.CDATselect.IntegralHeight = false;
            this.CDATselect.Location = new System.Drawing.Point(6, 19);
            this.CDATselect.Name = "CDATselect";
            this.CDATselect.Size = new System.Drawing.Size(188, 227);
            this.CDATselect.TabIndex = 0;
            this.CDATselect.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CDATselect_ItemCheck);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 299);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(348, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 329);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.GBcamBrand);
            this.Controls.Add(this.GBthreads);
            this.Controls.Add(this.GBdata);
            this.Controls.Add(this.GBfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Entry";
            this.Text = "Setup | [E] Exploit kit | [A] About";
            this.Load += new System.EventHandler(this.Entry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ent_keyDown);
            this.GBfiles.ResumeLayout(false);
            this.GBdata.ResumeLayout(false);
            this.GBdata.PerformLayout();
            this.GBthreads.ResumeLayout(false);
            this.GBthreads.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDthreads)).EndInit();
            this.GBcamBrand.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inputSelect;
        private System.Windows.Forms.Button outputSelect;
        private System.Windows.Forms.Button folderSelect;
        private System.Windows.Forms.GroupBox GBfiles;
        private System.Windows.Forms.Label LBcount;
        private System.Windows.Forms.GroupBox GBdata;
        private System.Windows.Forms.Label ESTlabel;
        private System.Windows.Forms.CheckBox CBrandOrd;
        private System.Windows.Forms.GroupBox GBthreads;
        private System.Windows.Forms.CheckBox CBthreadDebug;
        private System.Windows.Forms.Label LBthreads;
        private System.Windows.Forms.NumericUpDown NUDthreads;
        private System.Windows.Forms.GroupBox GBcamBrand;
        private System.Windows.Forms.Button addCamera;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnViewCdat;
        public System.Windows.Forms.CheckedListBox CDATselect;
        private System.Windows.Forms.CheckBox CbIpTag;
    }
}

