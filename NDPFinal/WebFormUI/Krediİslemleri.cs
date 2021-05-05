using Business.Concrete;
using Business.Concrete.KrediIslemler;
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
    public partial class Krediİslemleri : Form
    {
        public Krediİslemleri()
        {
            InitializeComponent();
        }
        Contexts contexts4 = new Contexts();
        Contexts contexts5 = new Contexts();
        private void Krediİslemleri_Load(object sender, EventArgs e)
        {
            dgwUye.DataSource = contexts4.uyes.ToList();
            dgwKredi.DataSource = contexts4.kredis.ToList();
        }

        private void dgwUye_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUyeId.Text = dgwUye.CurrentRow.Cells[0].Value.ToString();
            txtTc.Text = dgwUye.CurrentRow.Cells[2].Value.ToString();
            txtAdSoyad.Text = dgwUye.CurrentRow.Cells[1].Value.ToString();
            txtYetistirici.Text = dgwUye.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnKrediEkle_Click(object sender, EventArgs e)//Ekleme islemi Yapıldı
        {
           
            var tbl = new Kredi();
            tbl.AdıSoyadı = txtAdSoyad.Text;
            tbl.AylıkOdeme = Convert.ToDecimal(txtAylıkOdeme.Text);
            tbl.Tutar = Convert.ToDecimal(txtTutar.Text);
            tbl.TC = txtTc.Text;
            tbl.KrediTuru = cbxKrediTur.Text;
            tbl.KrediAdı = cbxKrediAd.Text;
            tbl.FaizOranı = float.Parse((txtAylıkFaiz.Text));
         
            contexts4.kredis.Add(tbl);
            contexts4.SaveChanges();
            MessageBox.Show("kayıt Eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgwKredi.DataSource = contexts4.kredis.ToList();

            lblAylıkOdenecekMiktar.Text = txtAylıkOdeme.Text;
            lblToplamTutar.Text = txtTutar.Text;


        }

        private void cbxKrediTur_SelectedIndexChanged(object sender, EventArgs e)//secilen indexe gore kredi getirildi
        {

            try
            {
                cbxKrediAd.Items.Clear();
                if (cbxKrediTur.SelectedIndex == 0)
                {

                    cbxKrediAd.Items.Add("Yetistirici kredisi");    
                    cbxKrediAd.Items.Add("Tarımsal Arac gerec kredisi");
                   

                }
              else if (cbxKrediTur.SelectedIndex == 1)
                {
                    cbxKrediAd.Items.Add("ihtiyaç kredisi");
                   

                }
                else if (cbxKrediTur.SelectedIndex == 2)
                {
                   
                    cbxKrediAd.Items.Add("Kalkınma kredisi");

                }



            }
            catch  { }
            

            


        }

        private void txtKrediMiktarı_TextChanged(object sender, EventArgs e)
        {
            double girilenMiktar=Convert.ToDouble(txtKrediMiktarı.Text);

            if (girilenMiktar>100000)
            {
                DusukFaiz dusukFaiz = new DusukFaiz(girilenMiktar);
               txtAylıkFaiz.Text=(dusukFaiz.Hesapla()).ToString();
            }else if(girilenMiktar>50000){

                OrtaFaiz ortaFaiz = new OrtaFaiz(girilenMiktar);
                txtAylıkFaiz.Text = (ortaFaiz.Hesapla()).ToString();


            }
            else
            {
                YuksekFaiz yuksekFaiz = new YuksekFaiz(girilenMiktar);
                txtAylıkFaiz.Text = (yuksekFaiz.Hesapla()).ToString();
            }
        }

        private void cbxKrediAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yetistiriciTuru = txtYetistirici.Text;
            TarımsalsletmeKredi tarımsalsletmeKredi = new TarımsalsletmeKredi(yetistiriciTuru);
            TarımsalAracGerecler tarımsalAracGerecler = new TarımsalAracGerecler(yetistiriciTuru);
            KalkınmaKredisi kalkınmaKredisi = new KalkınmaKredisi(yetistiriciTuru);
            İhtiyacKredisi ihtiyacKredisi = new İhtiyacKredisi(yetistiriciTuru);

            if (cbxKrediTur.SelectedIndex == 0)//indexler degistiginde fonksiyonları getiriyor
            {
               
                if (cbxKrediAd.SelectedIndex == 0)
                {
                    lblDestekPaketi.Text = tarımsalsletmeKredi.YardımPaketi();
                    lblHibe.Text = tarımsalsletmeKredi.Hibe().ToString();
                    txtKrediMiktarı.Text = tarımsalsletmeKredi.KrediNeKadar().ToString();
                }
                else if (cbxKrediAd.SelectedIndex == 1)
                {
                    
                    lblDestekPaketi.Text = tarımsalAracGerecler.YardımPaketi();
                    lblHibe.Text = tarımsalAracGerecler.Hibe().ToString();
                    txtKrediMiktarı.Text = tarımsalAracGerecler.KrediNeKadar().ToString();
                }

            }
            else if(cbxKrediAd.SelectedIndex==1)
            {
                lblDestekPaketi.Text = ihtiyacKredisi.YardımPaketi();
                lblHibe.Text = ihtiyacKredisi.Hibe().ToString();
                txtKrediMiktarı.Text = ihtiyacKredisi.KrediNeKadar().ToString();



                lblDestekPaketi.Text = "0";
                lblHibe.Text = "0";
            }
            else 
            {
                lblDestekPaketi.Text = kalkınmaKredisi.YardımPaketi();
                lblHibe.Text = Convert.ToString(kalkınmaKredisi.Hibe());
                txtKrediMiktarı.Text = kalkınmaKredisi.KrediNeKadar().ToString();



                lblDestekPaketi.Text = "0";
                lblHibe.Text = "0";
            }

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            KrediHesapla krediHesapla = new KrediHesapla(Convert.ToInt32(txtTaksit.Text),Convert.ToDouble(txtAylıkFaiz.Text),Convert.ToInt32(txtKrediMiktarı.Text));
            krediHesapla.SonucHesapla();
            txtAylıkOdeme.Text = krediHesapla.aylıkOdeme.ToString();
            txtTutar.Text = krediHesapla.sonuc.ToString();
            lblhibeliFiyat.Text = (Convert.ToInt32(txtKrediMiktarı.Text) + Convert.ToInt32(lblHibe.Text)).ToString();
            lblHibesizFiyat.Text = txtKrediMiktarı.Text;
        }

        private void btnKrediSil_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dgwKredi.CurrentRow.Cells[0].Value.ToString());
            var tbl = contexts4.kredis.FirstOrDefault(x => x.Id == ID);
            contexts4.kredis.Remove(tbl);
            contexts4.SaveChanges();
            MessageBox.Show("kayıt silindi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgwKredi.DataSource = contexts4.kredis.ToList();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {







        }
    }
}
