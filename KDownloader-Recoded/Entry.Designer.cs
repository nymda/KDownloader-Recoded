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
            this.gbGraphics = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.lbWidth = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rb169 = new System.Windows.Forms.RadioButton();
            this.rb43 = new System.Windows.Forms.RadioButton();
            this.cbNormalise = new System.Windows.Forms.CheckBox();
            this.gbStyle = new System.Windows.Forms.GroupBox();
            this.rbBarBottom = new System.Windows.Forms.RadioButton();
            this.btnFont = new System.Windows.Forms.Button();
            this.rbFancy = new System.Windows.Forms.RadioButton();
            this.rbBasic = new System.Windows.Forms.RadioButton();
            this.cbIpStamp = new System.Windows.Forms.CheckBox();
            this.rbBarTop = new System.Windows.Forms.RadioButton();
            this.cbCenNames = new System.Windows.Forms.CheckBox();
            this.setFontDialog = new System.Windows.Forms.FontDialog();
            this.GBfiles.SuspendLayout();
            this.GBdata.SuspendLayout();
            this.GBthreads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDthreads)).BeginInit();
            this.GBcamBrand.SuspendLayout();
            this.gbGraphics.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.gbStyle.SuspendLayout();
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
            this.GBdata.Controls.Add(this.cbCenNames);
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
            // gbGraphics
            // 
            this.gbGraphics.Controls.Add(this.groupBox1);
            this.gbGraphics.Controls.Add(this.gbStyle);
            this.gbGraphics.Location = new System.Drawing.Point(366, 12);
            this.gbGraphics.Name = "gbGraphics";
            this.gbGraphics.Size = new System.Drawing.Size(200, 310);
            this.gbGraphics.TabIndex = 8;
            this.gbGraphics.TabStop = false;
            this.gbGraphics.Text = "Visual settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudHeight);
            this.groupBox1.Controls.Add(this.nudWidth);
            this.groupBox1.Controls.Add(this.lbWidth);
            this.groupBox1.Controls.Add(this.lbHeight);
            this.groupBox1.Controls.Add(this.rbCustom);
            this.groupBox1.Controls.Add(this.rb169);
            this.groupBox1.Controls.Add(this.rb43);
            this.groupBox1.Controls.Add(this.cbNormalise);
            this.groupBox1.Location = new System.Drawing.Point(6, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 113);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // nudHeight
            // 
            this.nudHeight.Enabled = false;
            this.nudHeight.Location = new System.Drawing.Point(128, 85);
            this.nudHeight.Maximum = new decimal(new int[] {
            2160,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(54, 20);
            this.nudHeight.TabIndex = 18;
            this.nudHeight.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.nudHeight.ValueChanged += new System.EventHandler(this.nudHeight_ValueChanged);
            // 
            // nudWidth
            // 
            this.nudWidth.Enabled = false;
            this.nudWidth.Location = new System.Drawing.Point(128, 59);
            this.nudWidth.Maximum = new decimal(new int[] {
            3840,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(54, 20);
            this.nudWidth.TabIndex = 17;
            this.nudWidth.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.nudWidth.ValueChanged += new System.EventHandler(this.nudWidth_ValueChanged);
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Location = new System.Drawing.Point(84, 61);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(38, 13);
            this.lbWidth.TabIndex = 15;
            this.lbWidth.Text = "Width:";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(81, 86);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(41, 13);
            this.lbHeight.TabIndex = 16;
            this.lbHeight.Text = "Height:";
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Enabled = false;
            this.rbCustom.Location = new System.Drawing.Point(6, 88);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(60, 17);
            this.rbCustom.TabIndex = 14;
            this.rbCustom.Text = "Custom";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // rb169
            // 
            this.rb169.AutoSize = true;
            this.rb169.Checked = true;
            this.rb169.Enabled = false;
            this.rb169.Location = new System.Drawing.Point(6, 42);
            this.rb169.Name = "rb169";
            this.rb169.Size = new System.Drawing.Size(46, 17);
            this.rb169.TabIndex = 9;
            this.rb169.TabStop = true;
            this.rb169.Text = "16:9";
            this.rb169.UseVisualStyleBackColor = true;
            this.rb169.CheckedChanged += new System.EventHandler(this.rb169_CheckedChanged);
            // 
            // rb43
            // 
            this.rb43.AutoSize = true;
            this.rb43.Enabled = false;
            this.rb43.Location = new System.Drawing.Point(6, 65);
            this.rb43.Name = "rb43";
            this.rb43.Size = new System.Drawing.Size(40, 17);
            this.rb43.TabIndex = 10;
            this.rb43.Text = "4:3";
            this.rb43.UseVisualStyleBackColor = true;
            this.rb43.CheckedChanged += new System.EventHandler(this.rb43_CheckedChanged);
            // 
            // cbNormalise
            // 
            this.cbNormalise.AutoSize = true;
            this.cbNormalise.Location = new System.Drawing.Point(6, 19);
            this.cbNormalise.Name = "cbNormalise";
            this.cbNormalise.Size = new System.Drawing.Size(124, 17);
            this.cbNormalise.TabIndex = 13;
            this.cbNormalise.Text = "Normalise image size";
            this.cbNormalise.UseVisualStyleBackColor = true;
            this.cbNormalise.CheckedChanged += new System.EventHandler(this.cbNormalise_CheckedChanged);
            // 
            // gbStyle
            // 
            this.gbStyle.Controls.Add(this.rbBarBottom);
            this.gbStyle.Controls.Add(this.btnFont);
            this.gbStyle.Controls.Add(this.rbFancy);
            this.gbStyle.Controls.Add(this.rbBasic);
            this.gbStyle.Controls.Add(this.cbIpStamp);
            this.gbStyle.Controls.Add(this.rbBarTop);
            this.gbStyle.Location = new System.Drawing.Point(6, 19);
            this.gbStyle.Name = "gbStyle";
            this.gbStyle.Size = new System.Drawing.Size(188, 166);
            this.gbStyle.TabIndex = 14;
            this.gbStyle.TabStop = false;
            this.gbStyle.Text = "Stamp";
            // 
            // rbBarBottom
            // 
            this.rbBarBottom.AutoSize = true;
            this.rbBarBottom.Location = new System.Drawing.Point(6, 111);
            this.rbBarBottom.Name = "rbBarBottom";
            this.rbBarBottom.Size = new System.Drawing.Size(76, 17);
            this.rbBarBottom.TabIndex = 14;
            this.rbBarBottom.Text = "Bottom bar";
            this.rbBarBottom.UseVisualStyleBackColor = true;
            this.rbBarBottom.CheckedChanged += new System.EventHandler(this.rbBarBottom_CheckedChanged);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(6, 136);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(176, 23);
            this.btnFont.TabIndex = 13;
            this.btnFont.Text = "Set font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // rbFancy
            // 
            this.rbFancy.AutoSize = true;
            this.rbFancy.Checked = true;
            this.rbFancy.Location = new System.Drawing.Point(6, 42);
            this.rbFancy.Name = "rbFancy";
            this.rbFancy.Size = new System.Drawing.Size(54, 17);
            this.rbFancy.TabIndex = 10;
            this.rbFancy.TabStop = true;
            this.rbFancy.Text = "Fancy";
            this.rbFancy.UseVisualStyleBackColor = true;
            this.rbFancy.CheckedChanged += new System.EventHandler(this.rbFancy_CheckedChanged);
            // 
            // rbBasic
            // 
            this.rbBasic.AutoSize = true;
            this.rbBasic.Location = new System.Drawing.Point(6, 65);
            this.rbBasic.Name = "rbBasic";
            this.rbBasic.Size = new System.Drawing.Size(51, 17);
            this.rbBasic.TabIndex = 11;
            this.rbBasic.Text = "Basic";
            this.rbBasic.UseVisualStyleBackColor = true;
            this.rbBasic.CheckedChanged += new System.EventHandler(this.rbBasic_CheckedChanged);
            // 
            // cbIpStamp
            // 
            this.cbIpStamp.AutoSize = true;
            this.cbIpStamp.Checked = true;
            this.cbIpStamp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIpStamp.Location = new System.Drawing.Point(6, 19);
            this.cbIpStamp.Name = "cbIpStamp";
            this.cbIpStamp.Size = new System.Drawing.Size(69, 17);
            this.cbIpStamp.TabIndex = 9;
            this.cbIpStamp.Text = "IP Stamp";
            this.cbIpStamp.UseVisualStyleBackColor = true;
            this.cbIpStamp.CheckedChanged += new System.EventHandler(this.cbIpStamp_CheckedChanged);
            // 
            // rbBarTop
            // 
            this.rbBarTop.AutoSize = true;
            this.rbBarTop.Location = new System.Drawing.Point(6, 88);
            this.rbBarTop.Name = "rbBarTop";
            this.rbBarTop.Size = new System.Drawing.Size(62, 17);
            this.rbBarTop.TabIndex = 12;
            this.rbBarTop.Text = "Top bar";
            this.rbBarTop.UseVisualStyleBackColor = true;
            this.rbBarTop.CheckedChanged += new System.EventHandler(this.rbBarTop_CheckedChanged);
            // 
            // cbCenNames
            // 
            this.cbCenNames.AutoSize = true;
            this.cbCenNames.Enabled = false;
            this.cbCenNames.Location = new System.Drawing.Point(9, 71);
            this.cbCenNames.Name = "cbCenNames";
            this.cbCenNames.Size = new System.Drawing.Size(106, 17);
            this.cbCenNames.TabIndex = 6;
            this.cbCenNames.Text = "Censor filenames";
            this.cbCenNames.UseVisualStyleBackColor = true;
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 329);
            this.Controls.Add(this.gbGraphics);
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
            this.gbGraphics.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.gbStyle.ResumeLayout(false);
            this.gbStyle.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbGraphics;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rb169;
        private System.Windows.Forms.RadioButton rb43;
        private System.Windows.Forms.CheckBox cbNormalise;
        private System.Windows.Forms.GroupBox gbStyle;
        private System.Windows.Forms.RadioButton rbBarBottom;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.RadioButton rbFancy;
        private System.Windows.Forms.RadioButton rbBasic;
        private System.Windows.Forms.CheckBox cbIpStamp;
        private System.Windows.Forms.RadioButton rbBarTop;
        private System.Windows.Forms.CheckBox cbCenNames;
        private System.Windows.Forms.FontDialog setFontDialog;
    }
}

