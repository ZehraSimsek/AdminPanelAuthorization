namespace adminpanelyetiki
{
    partial class FormAna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.satisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalkontrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hAKKIMIZDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toptanciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.welcomeStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satisToolStripMenuItem,
            this.stokToolStripMenuItem,
            this.toptanciToolStripMenuItem,
            this.personalkontrlToolStripMenuItem,
            this.hAKKIMIZDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // satisToolStripMenuItem
            // 
            this.satisToolStripMenuItem.Name = "satisToolStripMenuItem";
            this.satisToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.satisToolStripMenuItem.Text = "SATIŞ";
            this.satisToolStripMenuItem.Click += new System.EventHandler(this.satisToolStripMenuItem_Click);
            // 
            // personalkontrlToolStripMenuItem
            // 
            this.personalkontrlToolStripMenuItem.Enabled = false;
            this.personalkontrlToolStripMenuItem.Name = "personalkontrlToolStripMenuItem";
            this.personalkontrlToolStripMenuItem.Size = new System.Drawing.Size(211, 29);
            this.personalkontrlToolStripMenuItem.Text = "PERSONAL KONTROL";
            this.personalkontrlToolStripMenuItem.Click += new System.EventHandler(this.personalkontrlToolStripMenuItem_Click);
            // 
            // hAKKIMIZDAToolStripMenuItem
            // 
            this.hAKKIMIZDAToolStripMenuItem.Name = "hAKKIMIZDAToolStripMenuItem";
            this.hAKKIMIZDAToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.hAKKIMIZDAToolStripMenuItem.Text = "HAKKIMIZDA";
            this.hAKKIMIZDAToolStripMenuItem.Click += new System.EventHandler(this.hAKKIMIZDAToolStripMenuItem_Click);
            // 
            // stokToolStripMenuItem
            // 
            this.stokToolStripMenuItem.Name = "stokToolStripMenuItem";
            this.stokToolStripMenuItem.Size = new System.Drawing.Size(164, 29);
            this.stokToolStripMenuItem.Text = "STOK KONTROL";
            this.stokToolStripMenuItem.Click += new System.EventHandler(this.stokToolStripMenuItem_Click);
            // 
            // toptanciToolStripMenuItem
            // 
            this.toptanciToolStripMenuItem.Enabled = false;
            this.toptanciToolStripMenuItem.Name = "toptanciToolStripMenuItem";
            this.toptanciToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.toptanciToolStripMenuItem.Text = "TOPTANCI";
            this.toptanciToolStripMenuItem.Click += new System.EventHandler(this.toptanciToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 663);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1004, 32);
            this.statusStrip1.TabIndex = 2;
            // 
            // welcomeStripStatusLabel1
            // 
            this.welcomeStripStatusLabel1.Name = "welcomeStripStatusLabel1";
            this.welcomeStripStatusLabel1.Size = new System.Drawing.Size(24, 25);
            this.welcomeStripStatusLabel1.Text = "...";
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 695);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAna";
            this.Text = "FormAna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem satisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hAKKIMIZDAToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem toptanciToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem personalkontrlToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel welcomeStripStatusLabel1;
    }
}