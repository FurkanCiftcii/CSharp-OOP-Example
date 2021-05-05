namespace WebFormUI
{
    partial class UyeIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeIslemleri));
            this.dgwUyeIslem = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.LblAdres = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.gbxUYE = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAra = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblYetistirici = new System.Windows.Forms.Label();
            this.cbxYetistirici = new System.Windows.Forms.ComboBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUyeIslem)).BeginInit();
            this.gbxUYE.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUyeIslem
            // 
            this.dgwUyeIslem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUyeIslem.Location = new System.Drawing.Point(494, 83);
            this.dgwUyeIslem.Name = "dgwUyeIslem";
            this.dgwUyeIslem.RowHeadersWidth = 51;
            this.dgwUyeIslem.RowTemplate.Height = 24;
            this.dgwUyeIslem.Size = new System.Drawing.Size(828, 270);
            this.dgwUyeIslem.TabIndex = 0;
            this.dgwUyeIslem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUyeIslem_CellDoubleClick);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(214, 86);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(53, 17);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "UYE ID";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(169, 128);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(98, 17);
            this.lblTc.TabIndex = 2;
            this.lblTc.Text = "TC KİMLİK NO";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(188, 172);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(79, 17);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "AD SOYAD";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(195, 211);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(72, 17);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "TELEFON";
            // 
            // LblAdres
            // 
            this.LblAdres.AutoSize = true;
            this.LblAdres.Location = new System.Drawing.Point(212, 256);
            this.LblAdres.Name = "LblAdres";
            this.LblAdres.Size = new System.Drawing.Size(55, 17);
            this.LblAdres.TabIndex = 6;
            this.LblAdres.Text = "ADRES";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.ImageIndex = 0;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(48, 394);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 62);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "eklebuton.png");
            this.ımageList1.Images.SetKeyName(1, "iptalbuton.png");
            this.ımageList1.Images.SetKeyName(2, "guncellebuton.png");
            this.ımageList1.Images.SetKeyName(3, "SilmeButon.png");
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.ImageIndex = 3;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(189, 394);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 62);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.ImageIndex = 2;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(330, 394);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(120, 62);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "GUNCELLE";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // gbxUYE
            // 
            this.gbxUYE.Controls.Add(this.txtEmail);
            this.gbxUYE.Controls.Add(this.label1);
            this.gbxUYE.Controls.Add(this.lblAra);
            this.gbxUYE.Controls.Add(this.txtAra);
            this.gbxUYE.Controls.Add(this.btnIptal);
            this.gbxUYE.Controls.Add(this.txtAdres);
            this.gbxUYE.Controls.Add(this.lblYetistirici);
            this.gbxUYE.Controls.Add(this.cbxYetistirici);
            this.gbxUYE.Controls.Add(this.txtAdSoyad);
            this.gbxUYE.Controls.Add(this.txtTelefon);
            this.gbxUYE.Controls.Add(this.txtTc);
            this.gbxUYE.Controls.Add(this.txtID);
            this.gbxUYE.Controls.Add(this.dgwUyeIslem);
            this.gbxUYE.Controls.Add(this.btnGuncelle);
            this.gbxUYE.Controls.Add(this.lblId);
            this.gbxUYE.Controls.Add(this.btnSil);
            this.gbxUYE.Controls.Add(this.lblTc);
            this.gbxUYE.Controls.Add(this.btnEkle);
            this.gbxUYE.Controls.Add(this.lblAdSoyad);
            this.gbxUYE.Controls.Add(this.LblAdres);
            this.gbxUYE.Controls.Add(this.lblTelefon);
            this.gbxUYE.Location = new System.Drawing.Point(12, 12);
            this.gbxUYE.Name = "gbxUYE";
            this.gbxUYE.Size = new System.Drawing.Size(1356, 472);
            this.gbxUYE.TabIndex = 10;
            this.gbxUYE.TabStop = false;
            this.gbxUYE.Text = "UYE İSLEMLERİ";
            this.gbxUYE.Enter += new System.EventHandler(this.gbxUYE_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(289, 289);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 22);
            this.txtEmail.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Email";
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(957, 41);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(68, 17);
            this.lblAra.TabIndex = 19;
            this.lblAra.Text = "UYE ARA";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(1055, 41);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(267, 22);
            this.txtAra.TabIndex = 18;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIptal.ImageIndex = 1;
            this.btnIptal.ImageList = this.ımageList1;
            this.btnIptal.Location = new System.Drawing.Point(471, 394);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(120, 62);
            this.btnIptal.TabIndex = 17;
            this.btnIptal.Text = "IPTAL";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(289, 256);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(161, 22);
            this.txtAdres.TabIndex = 16;
            // 
            // lblYetistirici
            // 
            this.lblYetistirici.AutoSize = true;
            this.lblYetistirici.Location = new System.Drawing.Point(140, 329);
            this.lblYetistirici.Name = "lblYetistirici";
            this.lblYetistirici.Size = new System.Drawing.Size(127, 17);
            this.lblYetistirici.TabIndex = 15;
            this.lblYetistirici.Text = "YETİSTİRİCİ TURU";
            // 
            // cbxYetistirici
            // 
            this.cbxYetistirici.FormattingEnabled = true;
            this.cbxYetistirici.Items.AddRange(new object[] {
            "Seracı",
            "Yetiştirici",
            "Çiftci",
            "Arıcı"});
            this.cbxYetistirici.Location = new System.Drawing.Point(289, 329);
            this.cbxYetistirici.Name = "cbxYetistirici";
            this.cbxYetistirici.Size = new System.Drawing.Size(161, 24);
            this.cbxYetistirici.TabIndex = 14;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(289, 172);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(161, 22);
            this.txtAdSoyad.TabIndex = 12;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(289, 211);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(161, 22);
            this.txtTelefon.TabIndex = 12;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(289, 128);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(161, 22);
            this.txtTc.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(289, 83);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(161, 22);
            this.txtID.TabIndex = 10;
            // 
            // UyeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 541);
            this.Controls.Add(this.gbxUYE);
            this.Name = "UyeIslemleri";
            this.Text = "UYE ISLEMLERİ";
            this.Load += new System.EventHandler(this.UyeIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUyeIslem)).EndInit();
            this.gbxUYE.ResumeLayout(false);
            this.gbxUYE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUyeIslem;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label LblAdres;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox gbxUYE;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblYetistirici;
        private System.Windows.Forms.ComboBox cbxYetistirici;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
    }
}