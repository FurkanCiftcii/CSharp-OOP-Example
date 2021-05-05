using Business.Concrete;
using Business.Concrete.AnalizIslemler;
using Business.Concrete.Exceptions;
using Business.Concrete.Indexers;
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
    public partial class TarlaAnaliz : Form
    {
        public delegate void Analiz(int deger1, int deger2, int deger3, int deger4);//delegler olusturuluyor
        public void Renk(int deger1, int deger2, int deger3, int deger4)//delegenin fonksiyonu
        {
            int analizpuanlama = 0;

            if (deger1<50||deger2<50)
            {
                analizpuanlama += 1;
            }
            else
            {
                analizpuanlama += 3;
            }


            if (deger3<50 ||deger4<40)
            {
                analizpuanlama += 0;
            }
            else
            {
                analizpuanlama += 1;
            }

            if (analizpuanlama == 4)
            {
                btnTarla.BackColor = Color.Green;
                btnTarla.Text = "Tarla durumu :Çok iyi";
            }else if (analizpuanlama == 3)
            {
                btnTarla.BackColor = Color.Yellow;
                btnTarla.Text = "Tarla durumu :İyi";
            }
            else
            {
                btnTarla.BackColor = Color.Red;
                btnTarla.Text = "Tarla durumu :Kötü";
            }

            textBox1.Text = analizpuanlama.ToString();
        }
        public void Deger(int deger1, int deger2, int deger3, int deger4)//delegenin fonksiyonu
        {
            if (deger1 < 50)
            {
                lblGubre.Text = "Kalsiyum Amonyum Nitrat Gubresi,Dap,TSP ";
            }
            else
            {
                lblGubre.Text = " Amonyum Sülfat Gubresi,MAP ";
            }

            if (deger2 < 50||deger3<50)
            {
                lblEkinİlacı.Text = "Herbisit ";
                lblTakviyeUrunler.Text = "Kalsiyum,potasyum";
            }
            else
            {
                lblEkinİlacı.Text = " NH-95 ";
                lblTakviyeUrunler.Text = "Azot,Nitrat";
            }

            if (deger4 < 50)
            {
                lblEkilecekUrun.Text = "Buğday,Arpa,Nohut";
            }
            else
            {
                lblEkilecekUrun.Text = " Şeker Pancarı,kavun,patates ";
            }


        }

        enum ToprakTurleri//Enum yardımıyla cbxToprak ekleme yapıldı
        {
            Taşlı,Tınlı,Kumlu,Killi,Marnlı,Humuslu,Kireçli
        }


        public TarlaAnaliz()
        {
            InitializeComponent();
        }

      


        private void lblCıktılar_Click(object sender, EventArgs e)
        {

        }
        delegate string Sulama(string sulamaTuru);//isimsiz Fonksiyonlar çagırıldı
        delegate double AlanHesabı(double genislik, double uzunluk);//isimsiz fonksiyonlar cagırıldı 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {//Yuzde Hatası
                if (Convert.ToInt32(txtFosfat.Text) > 100 || Convert.ToInt32(txtMineral.Text) > 100 || Convert.ToInt32(txtPotasyum.Text) > 100 || Convert.ToInt32(txtOrganik.Text) > 100 || Convert.ToInt32(txtTuzluluk.Text) > 100)
                {
                    throw new YuzdeYuzHatası("Yuzeler Aşıldı");
                }
                else
                {
                    Analiz analiz = null;
                    analiz += new Analiz(Renk);
                    analiz += new Analiz(Deger);
                    analiz(Convert.ToInt32(txtFosfat.Text), Convert.ToInt32(txtOrganik.Text), Convert.ToInt32(txtPotasyum.Text), Convert.ToInt32(txtTuzluluk.Text));
                    AnalizHesap();

                    AnalizHesaplama analizHesaplama = new AnalizHesaplama();

                    lblMineral.Text = "kalsiyum |magnezyum |demir |oranı " + "\n " + analizHesaplama.MineralHesap(Convert.ToInt32(txtMineral.Text));

                }

                //Bos metin Hatası
                if (txtUzunluk.Text == null || txtGenislik.Text == null)
                {
                    throw new BosMetinHatası("Uzunluk veya genislik girmediniz");
                }
                else
                {
                    lblSulama.Text = sulama(cbxSulama.Text);
                    txtAlan.Text = alanHesabı(Convert.ToDouble(txtGenislik.Text), Convert.ToDouble(txtUzunluk.Text)).ToString();
                }

            }
            catch (YuzdeYuzHatası exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
            catch(BosMetinHatası ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatException exep)//Format hatası
            {
                MessageBox.Show(exep.Message);
            }
          
        }

        AlanHesabı alanHesabı = delegate (double g, double u)//Alan Hesaplayan isimsiz fonksiyon
        {

            double Alan = Math.Round(g * u, 2);
            return Alan;

        };



        Sulama sulama = delegate (string s)//Sulama turune gore oneri yapan fonksiyon
        {

            if (s == "yok")
            {
                return "sulama sistemi eklenmeli";
            }
            else if (s == "damla sulama")
            {

                return "sulama sistemi yenilenmeli";
            }
            else
            {
                return "sulama sistemi ideal";
            }

        };


        private void AnalizHesap()//Hesaplamalar
        {
            AnalizHesaplama analizHesaplama = new AnalizHesaplama(cbxToprak.Text, Convert.ToDouble(txtFosfat.Text), Convert.ToDouble(txtPotasyum.Text), Convert.ToDouble(txtOrganik.Text), Convert.ToDouble(txtTuzluluk.Text));
            lblAnaliz.Text = analizHesaplama.Degerler();
        }

        private void TarlaAnaliz_Load(object sender, EventArgs e)
        {
            CbxToprakDoldur();

            Reflectons();

            IndexleyiciCağır();

        }

        private void IndexleyiciCağır()//indexleyici yardımıyla Sulama comboboxun elemanları dolduruldu
        {
            Indexleyici ındexleyici = new Indexleyici();
            for (int i = 0; i < 3; i++)
            {

                cbxSulama.Items.Add(ındexleyici[i]);

            }
        }

        private void Reflectons()//reflection ile atributlerin isimleri getiren fonksiyon
        {
            System.Reflection.MemberInfo ınfo = typeof(FaizOran);
            object[] attributes = ınfo.GetCustomAttributes(true);

            for (int i = 0; i < attributes.Length; i++)
            {
                lblReflection.Text = attributes[i].ToString();
            }
        }

        private void CbxToprakDoldur()//Toprak Turleri dolduruldu
        {
            string[] ToprakDizi = ToprakTurleri.GetNames(typeof(ToprakTurleri));

            foreach (var item in ToprakDizi)
            {
                cbxToprak.Items.Add(item);
            }
        }
    }
}
