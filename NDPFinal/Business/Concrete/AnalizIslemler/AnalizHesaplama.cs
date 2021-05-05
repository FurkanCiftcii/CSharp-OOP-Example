using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.AnalizIslemler
{
  public  struct AnalizHesaplama
    {
        private string Toprak { get; set; }
        private double Fosfat { get; set; }
        private double Potasyum { get; set; }
        private double Organik  { get; set; }
        private double Tuzluluk { get; set; }

        public AnalizHesaplama(string _Toprak, double _fosfat,double _potasyum,double _organik,double _tuzluluk)
        {
            Toprak =_Toprak ;
            Fosfat = _fosfat;
            Potasyum = _potasyum;
            Organik = _organik;
            Tuzluluk = _tuzluluk;

        }
        #region ToprakDegeri
        public string Degerler()
        {
            if (Toprak== "Taşlı"||Toprak=="Tınlı"|| Toprak == "Kireçli")
            {
                if (Fosfat<50||Potasyum<40||Organik<50||Tuzluluk>50)
                {

                    return "Kireç mitarı ve Tuz miktarı ideal değil Toprak verimi dusuk";
                }
                else
                {
                    return "ideal verim";
                }
                

             }
            else if(Toprak=="Kumlu"||Toprak=="Killi")
            {
                if (Fosfat < 30 || Potasyum < 40 || Organik < 50 || Tuzluluk > 35) {

                    return "m^2 verimli toprak miktarı ideal değil";
                } else
                {
                    return "m^2 verimli toprak miktarı ideal";
                }
            }
            else
            {
                return "Humus miktarı ideal  ";
            }
                        

        }
        #endregion

        #region OranRandomFunctionOverrideKullanımı
        public string MineralHesap(int oran)
        {
            Random random1 = new Random();

            double sayi1 = random1.NextDouble();
            double sayi2 = random1.NextDouble();
            double sayi3 = random1.NextDouble();

            string kalsiyum =Math.Round((sayi1 * oran),2).ToString();
            string demir =Math.Round((sayi2 * oran),2).ToString();
            string magnezyum =Math.Round((sayi3 * oran),2).ToString();
            return kalsiyum +"|"+ magnezyum + "|" + demir+"|";
        }
        public string MineralHesap(int oran,int kalsiyum)
        {
            Random random2 = new Random();
            double sayi = random2.NextDouble();
            string demir =(sayi * oran).ToString();
            string magnezyum = (sayi * oran).ToString();
            return kalsiyum.ToString() + demir + magnezyum;
        }
        public string MineralHesap(int oran,int kalsiyum ,int demir)
        {

            return oran.ToString() + kalsiyum.ToString() + demir.ToString();
        }


        #endregion
    }
}
