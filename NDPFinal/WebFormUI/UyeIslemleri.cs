using Business.Concrete.Atribute;
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
    public partial class UyeIslemleri : Form
    {
        public UyeIslemleri()
        {
            InitializeComponent();
        }


        Contexts contexts1 = new Contexts();

        private void UyeIslemleri_Load(object sender, EventArgs e)
        {
            dgwUyeIslem.DataSource = contexts1.uyes.ToList();//Uye Tablosundan Veriyi Çeker
        }

        private void dgwUyeIslem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGetir();

        }
        [MethodAttribute("bilgileri getirir")]
        private void DataGetir()//Uyler Tablosundaki verileri Controllere ekler
        {
            txtID.Text = dgwUyeIslem.CurrentRow.Cells[0].Value.ToString();
            txtTc.Text = dgwUyeIslem.CurrentRow.Cells[2].Value.ToString();
            txtAdSoyad.Text = dgwUyeIslem.CurrentRow.Cells[1].Value.ToString();
            txtTelefon.Text = dgwUyeIslem.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text = dgwUyeIslem.CurrentRow.Cells[5].Value.ToString();
            cbxYetistirici.Text = dgwUyeIslem.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dgwUyeIslem.CurrentRow.Cells[4].Value.ToString();
        }

        private void gbxUYE_Enter(object sender, EventArgs e)
        {

        }
        [HelpsAttribute("Add")]
        private void btnEkle_Click(object sender, EventArgs e)//Uye tablomuza ekleme işlemi yapar
        {

            var tbl = new Uye();//Üyeye erişmek icin oluşturuldu
            tbl.Tc = txtTc.Text;
            tbl.AdSoyad = txtAdSoyad.Text;
            tbl.Telefon = txtTelefon.Text;
            tbl.Adres = txtAdres.Text;
            tbl.Email = txtEmail.Text;
            tbl.YetistiriciTuru = cbxYetistirici.Text;
            contexts1.uyes.Add(tbl);
            contexts1.SaveChanges();//değisiklikler kaydedildi
            MessageBox.Show("kayıt Eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            dgwUyeIslem.DataSource = contexts1.uyes.ToList();


        }

        private void btnSil_Click(object sender, EventArgs e)//silme işlemi yapıldı
        {

            int ID = int.Parse(dgwUyeIslem.CurrentRow.Cells[0].Value.ToString());//Uyeislem datagridwievinde 0. indexteki veriyi atadık
            var tbl = contexts1.uyes.FirstOrDefault(x => x.Id == ID);//Id ile ID eslesmesine bakıldı
            contexts1.uyes.Remove(tbl);
            contexts1.SaveChanges();//degisiklikler kaydedildi
            MessageBox.Show("kayıt silindi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            dgwUyeIslem.DataSource = contexts1.uyes.ToList();//veriler tekrardan listelendi



        }

        private void btnGuncelle_Click(object sender, EventArgs e)//Guncelleme islmi yapıldı
        {
            int ID = int.Parse(txtID.Text);
            var tbl = contexts1.uyes.FirstOrDefault(x => x.Id == ID);
            tbl.Tc = txtTc.Text;
            tbl.AdSoyad = txtAdSoyad.Text;
            tbl.Telefon = txtTelefon.Text;
            tbl.Adres = txtAdres.Text;
            tbl.Email = txtEmail.Text;
            tbl.YetistiriciTuru = cbxYetistirici.Text;

            contexts1.SaveChanges();
            MessageBox.Show("kayıt guncellendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            dgwUyeIslem.DataSource = contexts1.uyes.ToList();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)//Arama işlemi yapıldı
        {
            var ara = from x in contexts1.uyes select x;//context yardımıya uyede aramak icin x aldık
            if (txtAra.Text != null)
            {
                dgwUyeIslem.DataSource = ara.Where(x => x.AdSoyad.Contains(txtAra.Text)).ToList();//Ara textbox icin adsoyad iceriyormu diye bakıldı

            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();//islemin iptali
        }
    }
}
