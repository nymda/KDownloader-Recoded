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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kcore));
            this.tb_ipaddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_attack = new System.Windows.Forms.Button();
            this.lb_console = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tb_ipaddr
            // 
            this.tb_ipaddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ipaddr.Location = new System.Drawing.Point(79, 6);
            this.tb_ipaddr.Name = "tb_ipaddr";
            this.tb_ipaddr.Size = new System.Drawing.Size(265, 20);
            this.tb_ipaddr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address:";
            // 
            // btn_attack
            // 
            this.btn_attack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_attack.Location = new System.Drawing.Point(15, 32);
            this.btn_attack.Name = "btn_attack";
            this.btn_attack.Size = new System.Drawing.Size(329, 23);
            this.btn_attack.TabIndex = 2;
            this.btn_attack.Text = "Attack";
            this.btn_attack.UseVisualStyleBackColor = true;
            this.btn_attack.Click += new System.EventHandler(this.btn_attack_Click);
            // 
            // lb_console
            // 
            this.lb_console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_console.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lb_console.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_console.FormattingEnabled = true;
            this.lb_console.Location = new System.Drawing.Point(15, 61);
            this.lb_console.Name = "lb_console";
            this.lb_console.Size = new System.Drawing.Size(329, 238);
            this.lb_console.TabIndex = 3;
            this.lb_console.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lb_draw);
            // 
            // kcore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 314);
            this.Controls.Add(this.lb_console);
            this.Controls.Add(this.btn_attack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ipaddr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kcore";
            this.Text = "//proc/kcore | Foscam / Netwave";
            this.Load += new System.EventHandler(this.kcore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ipaddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_attack;
        private System.Windows.Forms.ListBox lb_console;
    }
}