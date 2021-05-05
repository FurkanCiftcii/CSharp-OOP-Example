namespace WebFormUI
{
    partial class KooperatifMarket
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
            this.dgwMarket = new System.Windows.Forms.DataGridView();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSatısYap = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtUrunAdAlınacak = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxUrunEkleme = new System.Windows.Forms.GroupBox();
            this.cbxSatıs = new System.Windows.Forms.GroupBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.lbxUrunAd = new System.Windows.Forms.ListBox();
            this.lbxUrunAdet = new System.Windows.Forms.ListBox();
            this.lbxFiyat = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbxTutar = new System.Windows.Forms.GroupBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblTutarGosterge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMarket)).BeginInit();
            this.cbxUrunEkleme.SuspendLayout();
            this.cbxSatıs.SuspendLayout();
            this.gbxTutar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMarket
            // 
            this.dgwMarket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMarket.Location = new System.Drawing.Point(40, 12);
            this.dgwMarket.Name = "dgwMarket";
            this.dgwMarket.RowHeadersWidth = 51;
            this.dgwMarket.RowTemplate.Height = 24;
            this.dgwMarket.Size = new System.Drawing.Size(916, 220);
            this.dgwMarket.TabIndex = 0;
            this.dgwMarket.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMarket_CellDoubleClick);
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(338, 73);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(178, 22);
            this.txtUrunId.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(338, 123);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(178, 22);
            this.txtUrunAd.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Urun Adı";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(338, 169);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(178, 22);
            this.txtFiyat.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Urun fiyatı";
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.Location = new System.Drawing.Point(338, 219);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(178, 22);
            this.txtUrunStok.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Stok";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(114, 129);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(178, 22);
            this.txtAdet.TabIndex = 23;
            this.txtAdet.TextChanged += new System.EventHandler(this.txtAdet_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Adet";
            // 
            // btnSatısYap
            // 
            this.btnSatısYap.Location = new System.Drawing.Point(1345, 522);
            this.btnSatısYap.Name = "btnSatısYap";
            this.btnSatısYap.Size = new System.Drawing.Size(109, 46);
            this.btnSatısYap.TabIndex = 24;
            this.btnSatısYap.Text = "SatısYap";
            this.btnSatısYap.UseVisualStyleBackColor = true;
            this.btnSatısYap.Click += new System.EventHandler(this.btnSatısYap_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(114, 170);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(178, 22);
            this.txtTutar.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tutar";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(119, 269);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 46);
            this.btnEkle.TabIndex = 27;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(254, 269);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 46);
            this.btnSil.TabIndex = 28;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(407, 269);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(109, 46);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.Text = "GUNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtUrunAdAlınacak
            // 
            this.txtUrunAdAlınacak.Location = new System.Drawing.Point(114, 90);
            this.txtUrunAdAlınacak.Name = "txtUrunAdAlınacak";
            this.txtUrunAdAlınacak.Size = new System.Drawing.Size(178, 22);
            this.txtUrunAdAlınacak.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Urun Adı";
            // 
            // cbxUrunEkleme
            // 
            this.cbxUrunEkleme.Controls.Add(this.txtFiyat);
            this.cbxUrunEkleme.Controls.Add(this.label1);
            this.cbxUrunEkleme.Controls.Add(this.btnGuncelle);
            this.cbxUrunEkleme.Controls.Add(this.txtUrunId);
            this.cbxUrunEkleme.Controls.Add(this.btnSil);
            this.cbxUrunEkleme.Controls.Add(this.label2);
            this.cbxUrunEkleme.Controls.Add(this.btnEkle);
            this.cbxUrunEkleme.Controls.Add(this.txtUrunAd);
            this.cbxUrunEkleme.Controls.Add(this.txtUrunStok);
            this.cbxUrunEkleme.Controls.Add(this.label3);
            this.cbxUrunEkleme.Controls.Add(this.label4);
            this.cbxUrunEkleme.Location = new System.Drawing.Point(40, 238);
            this.cbxUrunEkleme.Name = "cbxUrunEkleme";
            this.cbxUrunEkleme.Size = new System.Drawing.Size(565, 337);
            this.cbxUrunEkleme.TabIndex = 32;
            this.cbxUrunEkleme.TabStop = false;
            this.cbxUrunEkleme.Text = "URUN EKLEME";
            // 
            // cbxSatıs
            // 
            this.cbxSatıs.Controls.Add(this.btnSepeteEkle);
            this.cbxSatıs.Controls.Add(this.txtTutar);
            this.cbxSatıs.Controls.Add(this.label5);
            this.cbxSatıs.Controls.Add(this.txtUrunAdAlınacak);
            this.cbxSatıs.Controls.Add(this.txtAdet);
            this.cbxSatıs.Controls.Add(this.label7);
            this.cbxSatıs.Controls.Add(this.label6);
            this.cbxSatıs.Location = new System.Drawing.Point(620, 250);
            this.cbxSatıs.Name = "cbxSatıs";
            this.cbxSatıs.Size = new System.Drawing.Size(336, 325);
            this.cbxSatıs.TabIndex = 33;
            this.cbxSatıs.TabStop = false;
            this.cbxSatıs.Text = "SATIS ISLEMLERİ";
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(183, 227);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(109, 46);
            this.btnSepeteEkle.TabIndex = 32;
            this.btnSepeteEkle.Text = "SEPETE EKLE";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // lbxUrunAd
            // 
            this.lbxUrunAd.FormattingEnabled = true;
            this.lbxUrunAd.ItemHeight = 16;
            this.lbxUrunAd.Location = new System.Drawing.Point(989, 274);
            this.lbxUrunAd.Name = "lbxUrunAd";
            this.lbxUrunAd.Size = new System.Drawing.Size(151, 228);
            this.lbxUrunAd.TabIndex = 34;
            // 
            // lbxUrunAdet
            // 
            this.lbxUrunAdet.FormattingEnabled = true;
            this.lbxUrunAdet.ItemHeight = 16;
            this.lbxUrunAdet.Location = new System.Drawing.Point(1146, 274);
            this.lbxUrunAdet.Name = "lbxUrunAdet";
            this.lbxUrunAdet.Size = new System.Drawing.Size(151, 228);
            this.lbxUrunAdet.TabIndex = 35;
            // 
            // lbxFiyat
            // 
            this.lbxFiyat.FormattingEnabled = true;
            this.lbxFiyat.ItemHeight = 16;
            this.lbxFiyat.Location = new System.Drawing.Point(1303, 274);
            this.lbxFiyat.Name = "lbxFiyat";
            this.lbxFiyat.Size = new System.Drawing.Size(151, 228);
            this.lbxFiyat.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(986, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "URUN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1143, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "ALINAN ADET";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1300, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "FİYAT";
            // 
            // gbxTutar
            // 
            this.gbxTutar.Controls.Add(this.lblToplamTutar);
            this.gbxTutar.Controls.Add(this.lblTutarGosterge);
            this.gbxTutar.Location = new System.Drawing.Point(1097, 508);
            this.gbxTutar.Name = "gbxTutar";
            this.gbxTutar.Size = new System.Drawing.Size(200, 77);
            this.gbxTutar.TabIndex = 42;
            this.gbxTutar.TabStop = false;
            this.gbxTutar.Text = "Tutar";
            this.gbxTutar.Enter += new System.EventHandler(this.gbxTutar_Enter);
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(149, 42);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(16, 17);
            this.lblToplamTutar.TabIndex = 40;
            this.lblToplamTutar.Text = "0";
            // 
            // lblTutarGosterge
            // 
            this.lblTutarGosterge.AutoSize = true;
            this.lblTutarGosterge.Location = new System.Drawing.Point(35, 42);
            this.lblTutarGosterge.Name = "lblTutarGosterge";
            this.lblTutarGosterge.Size = new System.Drawing.Size(97, 17);
            this.lblTutarGosterge.TabIndex = 39;
            this.lblTutarGosterge.Text = "ToplamTutar :";
            // 
            // KooperatifMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 596);
            this.Controls.Add(this.gbxTutar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbxFiyat);
            this.Controls.Add(this.lbxUrunAdet);
            this.Controls.Add(this.lbxUrunAd);
            this.Controls.Add(this.btnSatısYap);
            this.Controls.Add(this.cbxSatıs);
            this.Controls.Add(this.cbxUrunEkleme);
            this.Controls.Add(this.dgwMarket);
            this.Name = "KooperatifMarket";
            this.Text = "KooperatifMarket";
            this.Load += new System.EventHandler(this.KooperatifMarket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMarket)).EndInit();
            this.cbxUrunEkleme.ResumeLayout(false);
            this.cbxUrunEkleme.PerformLayout();
            this.cbxSatıs.ResumeLayout(false);
            this.cbxSatıs.PerformLayout();
            this.gbxTutar.ResumeLayout(false);
            this.gbxTutar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMarket;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSatısYap;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtUrunAdAlınacak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox cbxUrunEkleme;
        private System.Windows.Forms.GroupBox cbxSatıs;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.ListBox lbxUrunAd;
        private System.Windows.Forms.ListBox lbxUrunAdet;
        private System.Windows.Forms.ListBox lbxFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbxTutar;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblTutarGosterge;
    }
}