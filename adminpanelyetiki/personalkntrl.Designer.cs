namespace adminpanelyetiki
{
    partial class personalkntrolForm
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkidColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EKLEbutton1 = new System.Windows.Forms.Button();
            this.GUNCELLEbutton2 = new System.Windows.Forms.Button();
            this.SILbutton3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ADtextBox1 = new System.Windows.Forms.TextBox();
            this.SOYADtextBox2 = new System.Windows.Forms.TextBox();
            this.SIFREtextBox3 = new System.Windows.Forms.TextBox();
            this.YETKIDtextBox4 = new System.Windows.Forms.TextBox();
            this.bilgilergroupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn1,
            this.adColumn2,
            this.soyadColumn3,
            this.sifreColumn4,
            this.yetkidColumn5});
            this.dataGridView1.Location = new System.Drawing.Point(41, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1094, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // idColumn1
            // 
            this.idColumn1.HeaderText = "ID";
            this.idColumn1.MinimumWidth = 8;
            this.idColumn1.Name = "idColumn1";
            this.idColumn1.ReadOnly = true;
            this.idColumn1.Width = 150;
            // 
            // adColumn2
            // 
            this.adColumn2.HeaderText = "AD";
            this.adColumn2.MinimumWidth = 8;
            this.adColumn2.Name = "adColumn2";
            this.adColumn2.ReadOnly = true;
            this.adColumn2.Width = 150;
            // 
            // soyadColumn3
            // 
            this.soyadColumn3.HeaderText = "SOYAD";
            this.soyadColumn3.MinimumWidth = 8;
            this.soyadColumn3.Name = "soyadColumn3";
            this.soyadColumn3.ReadOnly = true;
            this.soyadColumn3.Width = 150;
            // 
            // sifreColumn4
            // 
            this.sifreColumn4.HeaderText = "ŞİFRE";
            this.sifreColumn4.MinimumWidth = 8;
            this.sifreColumn4.Name = "sifreColumn4";
            this.sifreColumn4.ReadOnly = true;
            this.sifreColumn4.Width = 150;
            // 
            // yetkidColumn5
            // 
            this.yetkidColumn5.HeaderText = "YETKİ ID";
            this.yetkidColumn5.MinimumWidth = 8;
            this.yetkidColumn5.Name = "yetkidColumn5";
            this.yetkidColumn5.ReadOnly = true;
            this.yetkidColumn5.Width = 150;
            // 
            // EKLEbutton1
            // 
            this.EKLEbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EKLEbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EKLEbutton1.Location = new System.Drawing.Point(874, 30);
            this.EKLEbutton1.Name = "EKLEbutton1";
            this.EKLEbutton1.Size = new System.Drawing.Size(216, 73);
            this.EKLEbutton1.TabIndex = 1;
            this.EKLEbutton1.Text = "EKLE";
            this.EKLEbutton1.UseVisualStyleBackColor = true;
            // 
            // GUNCELLEbutton2
            // 
            this.GUNCELLEbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GUNCELLEbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUNCELLEbutton2.Location = new System.Drawing.Point(874, 126);
            this.GUNCELLEbutton2.Name = "GUNCELLEbutton2";
            this.GUNCELLEbutton2.Size = new System.Drawing.Size(216, 73);
            this.GUNCELLEbutton2.TabIndex = 2;
            this.GUNCELLEbutton2.Text = "GÜNCELLE";
            this.GUNCELLEbutton2.UseVisualStyleBackColor = true;
            // 
            // SILbutton3
            // 
            this.SILbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SILbutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SILbutton3.Location = new System.Drawing.Point(874, 220);
            this.SILbutton3.Name = "SILbutton3";
            this.SILbutton3.Size = new System.Drawing.Size(216, 73);
            this.SILbutton3.TabIndex = 3;
            this.SILbutton3.Text = "SİL";
            this.SILbutton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(206, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(180, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = " Soyad :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(196, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(169, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yetki ID :";
            // 
            // ADtextBox1
            // 
            this.ADtextBox1.Location = new System.Drawing.Point(275, 62);
            this.ADtextBox1.Name = "ADtextBox1";
            this.ADtextBox1.Size = new System.Drawing.Size(288, 26);
            this.ADtextBox1.TabIndex = 8;
            // 
            // SOYADtextBox2
            // 
            this.SOYADtextBox2.Location = new System.Drawing.Point(275, 101);
            this.SOYADtextBox2.Name = "SOYADtextBox2";
            this.SOYADtextBox2.Size = new System.Drawing.Size(288, 26);
            this.SOYADtextBox2.TabIndex = 9;
            // 
            // SIFREtextBox3
            // 
            this.SIFREtextBox3.Location = new System.Drawing.Point(275, 142);
            this.SIFREtextBox3.Name = "SIFREtextBox3";
            this.SIFREtextBox3.Size = new System.Drawing.Size(288, 26);
            this.SIFREtextBox3.TabIndex = 10;
            // 
            // YETKIDtextBox4
            // 
            this.YETKIDtextBox4.Location = new System.Drawing.Point(275, 185);
            this.YETKIDtextBox4.Name = "YETKIDtextBox4";
            this.YETKIDtextBox4.Size = new System.Drawing.Size(288, 26);
            this.YETKIDtextBox4.TabIndex = 11;
            // 
            // bilgilergroupBox1
            // 
            this.bilgilergroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilgilergroupBox1.Location = new System.Drawing.Point(159, 36);
            this.bilgilergroupBox1.Name = "bilgilergroupBox1";
            this.bilgilergroupBox1.Size = new System.Drawing.Size(471, 251);
            this.bilgilergroupBox1.TabIndex = 12;
            this.bilgilergroupBox1.TabStop = false;
            this.bilgilergroupBox1.Text = "BİLGİLER";
            // 
            // personalkntrolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 711);
            this.Controls.Add(this.YETKIDtextBox4);
            this.Controls.Add(this.SIFREtextBox3);
            this.Controls.Add(this.SOYADtextBox2);
            this.Controls.Add(this.ADtextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SILbutton3);
            this.Controls.Add(this.GUNCELLEbutton2);
            this.Controls.Add(this.EKLEbutton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bilgilergroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "personalkntrolForm";
            this.Text = "PERSONAL KONTROL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkidColumn5;
        public System.Windows.Forms.Button EKLEbutton1;
        public System.Windows.Forms.Button GUNCELLEbutton2;
        public System.Windows.Forms.Button SILbutton3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox ADtextBox1;
        public System.Windows.Forms.TextBox SOYADtextBox2;
        public System.Windows.Forms.TextBox SIFREtextBox3;
        public System.Windows.Forms.TextBox YETKIDtextBox4;
        public System.Windows.Forms.GroupBox bilgilergroupBox1;
    }
}

