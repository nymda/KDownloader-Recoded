﻿namespace KDownloader_Recoded
{
    partial class kcore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kcore));
            this.tb_ipaddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_attack = new System.Windows.Forms.Button();
            this.lb_console = new System.Windows.Forms.ListBox();
            this.btn_cut = new System.Windows.Forms.Button();
            this.failsafeTimer = new System.Windows.Forms.Timer(this.components);
            this.successPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.successPB)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ipaddr
            // 
            this.tb_ipaddr.Location = new System.Drawing.Point(73, 6);
            this.tb_ipaddr.Name = "tb_ipaddr";
            this.tb_ipaddr.Size = new System.Drawing.Size(284, 20);
            this.tb_ipaddr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address:";
            // 
            // btn_attack
            // 
            this.btn_attack.Location = new System.Drawing.Point(9, 32);
            this.btn_attack.Name = "btn_attack";
            this.btn_attack.Size = new System.Drawing.Size(267, 23);
            this.btn_attack.TabIndex = 2;
            this.btn_attack.Text = "Attack";
            this.btn_attack.UseVisualStyleBackColor = true;
            this.btn_attack.Click += new System.EventHandler(this.btn_attack_Click);
            // 
            // lb_console
            // 
            this.lb_console.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lb_console.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_console.FormattingEnabled = true;
            this.lb_console.IntegralHeight = false;
            this.lb_console.Location = new System.Drawing.Point(9, 61);
            this.lb_console.Name = "lb_console";
            this.lb_console.Size = new System.Drawing.Size(348, 345);
            this.lb_console.TabIndex = 3;
            this.lb_console.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lb_draw);
            // 
            // btn_cut
            // 
            this.btn_cut.Location = new System.Drawing.Point(281, 32);
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.Size = new System.Drawing.Size(75, 23);
            this.btn_cut.TabIndex = 4;
            this.btn_cut.Text = "Cut DL";
            this.btn_cut.UseVisualStyleBackColor = true;
            this.btn_cut.Click += new System.EventHandler(this.btn_cut_Click);
            // 
            // failsafeTimer
            // 
            this.failsafeTimer.Interval = 5000;
            this.failsafeTimer.Tick += new System.EventHandler(this.failsafeTimer_Tick);
            // 
            // successPB
            // 
            this.successPB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.successPB.Location = new System.Drawing.Point(363, 6);
            this.successPB.Name = "successPB";
            this.successPB.Size = new System.Drawing.Size(533, 400);
            this.successPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.successPB.TabIndex = 5;
            this.successPB.TabStop = false;
            // 
            // kcore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 416);
            this.Controls.Add(this.successPB);
            this.Controls.Add(this.btn_cut);
            this.Controls.Add(this.lb_console);
            this.Controls.Add(this.btn_attack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ipaddr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kcore";
            this.Text = "//proc/kcore | Foscam / Netwave | [U] Copy user [P] Copy pass";
            this.Load += new System.EventHandler(this.kcore_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kcore_kp);
            ((System.ComponentModel.ISupportInitialize)(this.successPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ipaddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_attack;
        private System.Windows.Forms.ListBox lb_console;
        private System.Windows.Forms.Button btn_cut;
        private System.Windows.Forms.Timer failsafeTimer;
        private System.Windows.Forms.PictureBox successPB;
    }
}