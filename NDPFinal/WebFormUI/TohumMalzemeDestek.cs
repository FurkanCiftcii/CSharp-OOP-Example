using Business.Concrete.Atribute;
using Business.Concrete.Exceptions;
using Business.Concrete.IndirimIslemler;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebFormUI
{
    public partial class TohumMalzemeDestek : Form
    {
        public TohumMalzemeDestek()
        {
            InitializeComponent();
        }

        Contexts contexts2 = new Contexts();
        Contexts contexts3 = new Contexts();
        private void TohumMalzemeDestek_Load(object sender, EventArgs e)//Sayfa yuklendiginde contextler ile veriler cekildi
        {
            dgwUye.DataSource = contexts2.uyes.ToList();
            dgvUrun.DataSource = contexts3.desteks.ToList();

        }

        private void dgwUye_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//cift tıklandıgında verileri getirir
        {
            txtId.Text = dgwUye.CurrentRow.Cells[0].Value.ToString();
            txtAdSoyad.Text = dgwUye.CurrentRow.Cells[1].Value.ToString();  
            txtTc.Text = dgwUye.CurrentRow.Cells[2].Value.ToString();
            txtYetistirici.Text = dgwUye.CurrentRow.Cells[6].Value.ToString();
        }
        [MethodAttribute("Ekleme")]
        private void btnEkle_Click(object sender, EventArgs e)//Ekleme islemi
        {
            var tbl = new Destek();
            tbl.UrunAdi = txtUrunAdı.Text;
            tbl.UrunTuru = txtUrunTur.Text;
            tbl.UrunMiktarı = Convert.ToInt32(txtUrunMiktar.Text);
            tbl.Fiyat = Convert.ToDecimal(txtUrunFiyat.Text);
            contexts3.desteks.Add(tbl);
            contexts3.SaveChanges();
            MessageBox.Show("kayıt Eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvUrun.DataSource = contexts3.desteks.ToList();
        }

        private void dgvUrun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunId.Text = dgvUrun.CurrentRow.Cells[0].Value.ToString();
            txtUrunTur.Text= dgvUrun.CurrentRow.Cells[2].Value.ToString();
            txtUrunAdı.Text = dgvUrun.CurrentRow.Cells[1].Value.ToString();
            txtUrunMiktar.Text = dgvUrun.CurrentRow.Cells[3].Value.ToString();
            txtUrunFiyat.Text = dgvUrun.CurrentRow.Cells[4].Value.ToString();
        }
        #region Silme
        private void btnSil_Click(object sender, EventArgs e)//Silme islemi yapıldı
        {
            int ID = int.Parse(dgvUrun.CurrentRow.Cells[0].Value.ToString());
            var tbl = contexts3.desteks.FirstOrDefault(x => x.Id == ID);
            contexts3.desteks.Remove(tbl);
            contexts3.SaveChanges();
            MessageBox.Show("kayıt silindi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvUrun.DataSource = contexts3.desteks.ToList();
        }
        #endregion
        #region Guncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtUrunId.Text);
            var tbl = contexts3.desteks.FirstOrDefault(x => x.Id == ID);
            tbl.UrunAdi = txtUrunAdı.Text;
            tbl.UrunMiktarı = Convert.ToInt32(txtUrunMiktar.Text);
            tbl.UrunTuru = txtUrunTur.Text;
            tbl.Fiyat = Convert.ToDecimal(txtUrunFiyat.Text);
            

            contexts3.SaveChanges();
            MessageBox.Show("kayıt guncellendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvUrun.DataSource = contexts3.desteks.ToList();
        }
        #endregion
        private void btnSatıs_Click(object sender, EventArgs e)
        {
            try
            {//Urun miktarından alınacak miktar cıkarılıyor ve negatif cıkarsa Miktar hatası veriyor
                if (Convert.ToInt32(txtUrunMiktar.Text) - Convert.ToInt32(txtAlınacakMiktar.Text) < 0)
                {
                    throw new Miktar_Hatası("stokta yeterli adet bulunmuyor");
                }
                else
                {
                    Indirimler ındirimler = new Indirimler(Convert.ToInt32(txtAlınacakMiktar.Text), Convert.ToDouble(txtUrunFiyat.Text), Convert.ToInt32(txtİndirimOranı.Text));
                    txtOdenecekTutar.Text = ındirimler.IndirimHesapla().ToString();
                    lblAd.Text = txtAdSoyad.Text;
                    lblUrun.Text = txtUrunAdı.Text;
                    lblAdet2.Text = txtUrunMiktar.Text;
                    lblTutar2.Text = txtOdenecekTutar.Text;
                    int ID = int.Parse(txtUrunId.Text);
                    var tbl = contexts3.desteks.FirstOrDefault(x => x.Id == ID);
                    tbl.UrunMiktarı = Convert.ToInt32(txtUrunMiktar.Text) - Convert.ToInt32(txtAlınacakMiktar.Text);
                    dgvUrun.DataSource = contexts3.desteks.ToList();
                }
            }
            catch (Miktar_Hatası exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
            catch(FormatException ex)//Format Hatası
            {
                MessageBox.Show(ex.Message);
            }
           
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)//ıslem bittikten sonra sıfırlama islemi
        {
            txtAlınacakMiktar.Text= "";
            txtOdenecekTutar.Text = "";
            txtİndirimOranı.Text = "";
            lblAd.Text = "";
            lblUrun.Text = "";
            lblAdet2.Text = "";
            lblTutar2.Text = "";
                
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)//arama islemi
        {
            var ara = from x in contexts3.desteks select x;
            if (txtUrunAra.Text != null)
            {
                dgvUrun.DataSource = ara.Where(x => x.UrunAdi.Contains(txtUrunAra.Text)).ToList();

            }
        }
    }
}
