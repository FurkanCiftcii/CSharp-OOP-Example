using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.KrediIslemler
{
  public  class KrediHesapla
    {

        public int Taksit { get; set; }
        public double faiz { get; set; }
        public  int kreditutar { get; set; }
        public double sonuc { get; set; }
        public decimal aylıkOdeme { get; set; }

        public KrediHesapla(int _taksit,double _faiz,int _kreditutar)
        {
            Taksit = _taksit;
            faiz = _faiz;
            kreditutar = _kreditutar;

        }

       public void SonucHesapla()
        {

            aylıkOdeme=Convert.ToDecimal((kreditutar / Taksit*faiz)+(kreditutar/Taksit));
            sonuc = Convert.ToDouble(aylıkOdeme * Taksit);
           

        }
    }
}
