using Business.Concrete.Marketİslemler;
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
    public partial class KooperatifMarket : Form
    {
        public KooperatifMarket()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        Contexts contexts6 = new Contexts();
        Contexts contexts7 = new Contexts();

        private void KooperatifMarket_Load(object sender, EventArgs e)
        {
           
            dgwMarket.DataSource = contexts7.markets.ToList();
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {





        }

        private void dgwMarket_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunId.Text = dgwMarket.CurrentRow.Cells[0].Value.ToString();
            txtUrunAd.Text = dgwMarket.CurrentRow.Cells[1].Value.ToString();
            txtUrunAdAlınacak.Text = dgwMarket.CurrentRow.Cells[1].Value.ToString();
            txtFiyat.Text = dgwMarket.CurrentRow.Cells[2].Value.ToString();
            txtUrunStok.Text = dgwMarket.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            var tbl = new Market();
            tbl.Adı = txtUrunAd.Text;
            tbl.Fiyatı =Convert.ToInt32(txtFiyat.Text);
            tbl.Stok =Convert.ToInt32(txtUrunStok.Text);
           
            contexts7.markets.Add(tbl);
            contexts7.SaveChanges();
            MessageBox.Show("kayıt Eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgwMarket.DataSource = contexts7.markets.ToList();






        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dgwMarket.CurrentRow.Cells[0].Value.ToString());
            var tbl = contexts7.markets.FirstOrDefault(x => x.Id == ID);
            contexts7.markets.Remove(tbl);
            contexts7.SaveChanges();
            MessageBox.Show("kayıt silindi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgwMarket.DataSource = contexts7.markets.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtUrunId.Text);
            var tbl = contexts7.markets.FirstOrDefault(x => x.Id == ID);
            tbl.Adı = txtUrunAd.Text;
            tbl.Fiyatı = Convert.ToInt32(txtFiyat.Text);
            tbl.Stok = Convert.ToInt32(txtUrunStok.Text);

            contexts7.SaveChanges();
            MessageBox.Show("kayıt guncellendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgwMarket.DataSource = contexts7.markets.ToList();
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTutar.Text = Convert.ToString(MarketHesaplama.UrunFiyatHesapla(Convert.ToDouble(txtFiyat.Text), Convert.ToInt32(txtAdet.Text)));
            }
            catch 
            {

                
            }
               
           
      



        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtUrunId.Text);
            var tbl = contexts7.markets.FirstOrDefault(x => x.Id == ID);
            try
            {
                tbl.Stok = Convert.ToInt32(txtUrunStok.Text) - Convert.ToInt32(txtAdet.Text);
                dgwMarket.DataSource = contexts7.markets.ToList();
                txtUrunStok.Text = dgwMarket.CurrentRow.Cells[3].Value.ToString();

                lbxUrunAd.Items.Add(txtUrunAd.Text);
                lbxUrunAdet.Items.Add(txtAdet.Text);
                lbxFiyat.Items.Add(txtTutar.Text);
                lblToplamTutar.Text = "0";
            }
            catch(FormatException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
          

        }

        private void btnSatısYap_Click(object sender, EventArgs e)
        {
            double fiyatlar = 0;
            for (int i = 0; i <lbxFiyat.Items.Count ; i++)
            {
               

                fiyatlar += Convert.ToDouble(lbxFiyat.Items[i]);
            }
            lblToplamTutar.Text = fiyatlar.ToString();

            lbxUrunAd.Items.Clear();
            lbxUrunAdet.Items.Clear();
            lbxFiyat.Items.Clear();


        }

        private void gbxTutar_Enter(object sender, EventArgs e)
        {

        }
    }
}
