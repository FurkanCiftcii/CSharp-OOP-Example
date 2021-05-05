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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUyeIslemleri_Click(object sender, EventArgs e)
        {
            UyeIslemleri uyeIslemleri = new UyeIslemleri();
            uyeIslemleri.ShowDialog();
        }

        private void btnKrediİslemleri_Click(object sender, EventArgs e)
        {
            Krediİslemleri krediIslemleri = new Krediİslemleri();
            krediIslemleri.ShowDialog();
        }

        private void btnTohumMalzeme_Click(object sender, EventArgs e)
        {
            TohumMalzemeDestek tohumMalzemeDestek = new TohumMalzemeDestek();
            tohumMalzemeDestek.ShowDialog();
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            KooperatifMarket kooperatifMarket = new KooperatifMarket();
            kooperatifMarket.ShowDialog();

        }

        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            TarlaAnaliz tarlaAnaliz = new TarlaAnaliz();
            tarlaAnaliz.ShowDialog();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
