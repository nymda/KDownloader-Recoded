namespace KDownloader_Recoded
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
            this.tb_ipaddr.Location = new System.Drawing.Point(118, 9);
            this.tb_ipaddr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ipaddr.Name = "tb_ipaddr";
            this.tb_ipaddr.Size = new System.Drawing.Size(396, 27);
            this.tb_ipaddr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address:";
            // 
            // btn_attack
            // 
            this.btn_attack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_attack.Location = new System.Drawing.Point(22, 47);
            this.btn_attack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_attack.Name = "btn_attack";
            this.btn_attack.Size = new System.Drawing.Size(494, 34);
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
            this.lb_console.Location = new System.Drawing.Point(22, 89);
            this.lb_console.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_console.Name = "lb_console";
            this.lb_console.Size = new System.Drawing.Size(492, 342);
            this.lb_console.TabIndex = 3;
            this.lb_console.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lb_draw);
            // 
            // kcore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 459);
            this.Controls.Add(this.lb_console);
            this.Controls.Add(this.btn_attack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ipaddr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "kcore";
            this.Text = "//proc/kcore | Foscam / Netwave";
            this.Load += new System.EventHandler(this.kcore_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kcore_kp);
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