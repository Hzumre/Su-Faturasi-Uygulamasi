namespace WFA_SuFaturası
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtSonIndex = new System.Windows.Forms.TextBox();
            this.txtIlkIndex = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMesken = new System.Windows.Forms.RadioButton();
            this.rdUmumi = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lstAdSoyad = new System.Windows.Forms.ListBox();
            this.lstKSuMiktari = new System.Windows.Forms.ListBox();
            this.lstFaturaTutari = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Su Faturası";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Son Index:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "İlk Index:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(163, 91);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(303, 27);
            this.txtAdSoyad.TabIndex = 4;
            // 
            // txtSonIndex
            // 
            this.txtSonIndex.Location = new System.Drawing.Point(163, 132);
            this.txtSonIndex.Name = "txtSonIndex";
            this.txtSonIndex.Size = new System.Drawing.Size(303, 27);
            this.txtSonIndex.TabIndex = 5;
            // 
            // txtIlkIndex
            // 
            this.txtIlkIndex.Location = new System.Drawing.Point(163, 165);
            this.txtIlkIndex.Name = "txtIlkIndex";
            this.txtIlkIndex.Size = new System.Drawing.Size(303, 27);
            this.txtIlkIndex.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdMesken);
            this.groupBox1.Controls.Add(this.rdUmumi);
            this.groupBox1.Location = new System.Drawing.Point(46, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 59);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanım Yeri";
            // 
            // rdMesken
            // 
            this.rdMesken.AutoSize = true;
            this.rdMesken.Location = new System.Drawing.Point(145, 29);
            this.rdMesken.Name = "rdMesken";
            this.rdMesken.Size = new System.Drawing.Size(80, 24);
            this.rdMesken.TabIndex = 1;
            this.rdMesken.TabStop = true;
            this.rdMesken.Text = "Mesken";
            this.rdMesken.UseVisualStyleBackColor = true;
            // 
            // rdUmumi
            // 
            this.rdUmumi.AutoSize = true;
            this.rdUmumi.Location = new System.Drawing.Point(44, 29);
            this.rdUmumi.Name = "rdUmumi";
            this.rdUmumi.Size = new System.Drawing.Size(78, 24);
            this.rdUmumi.TabIndex = 0;
            this.rdUmumi.TabStop = true;
            this.rdUmumi.Text = "Umumi";
            this.rdUmumi.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(363, 224);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(103, 36);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lstAdSoyad
            // 
            this.lstAdSoyad.FormattingEnabled = true;
            this.lstAdSoyad.ItemHeight = 20;
            this.lstAdSoyad.Location = new System.Drawing.Point(12, 365);
            this.lstAdSoyad.Name = "lstAdSoyad";
            this.lstAdSoyad.Size = new System.Drawing.Size(167, 244);
            this.lstAdSoyad.TabIndex = 9;
            // 
            // lstKSuMiktari
            // 
            this.lstKSuMiktari.FormattingEnabled = true;
            this.lstKSuMiktari.ItemHeight = 20;
            this.lstKSuMiktari.Location = new System.Drawing.Point(191, 365);
            this.lstKSuMiktari.Name = "lstKSuMiktari";
            this.lstKSuMiktari.Size = new System.Drawing.Size(172, 244);
            this.lstKSuMiktari.TabIndex = 10;
            // 
            // lstFaturaTutari
            // 
            this.lstFaturaTutari.FormattingEnabled = true;
            this.lstFaturaTutari.ItemHeight = 20;
            this.lstFaturaTutari.Location = new System.Drawing.Point(377, 365);
            this.lstFaturaTutari.Name = "lstFaturaTutari";
            this.lstFaturaTutari.Size = new System.Drawing.Size(170, 244);
            this.lstFaturaTutari.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ad Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(219, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kul. Su Miktarı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(409, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fatura Tutarı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 643);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstFaturaTutari);
            this.Controls.Add(this.lstKSuMiktari);
            this.Controls.Add(this.lstAdSoyad);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtIlkIndex);
            this.Controls.Add(this.txtSonIndex);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAdSoyad;
        private TextBox txtSonIndex;
        private TextBox txtIlkIndex;
        private GroupBox groupBox1;
        private RadioButton rdMesken;
        private RadioButton rdUmumi;
        private Button btnHesapla;
        private ListBox lstAdSoyad;
        private ListBox lstKSuMiktari;
        private ListBox lstFaturaTutari;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}