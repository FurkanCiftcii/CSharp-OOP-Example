using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.IndirimIslemler
{
  public  class Indirimler : IIndirim
    {

        public int Indirim { get; set; }
        public int Adet { get; set; }
        public double Fiyat { get; set; }
        public decimal IndirimliFiyat { get; set; }
        public Indirimler(int _Adet,double _Fiyat)
        {
            Adet = _Adet;
            Fiyat = _Fiyat;
            Indirim = 1;
        }
        public Indirimler(int _Adet, double _Fiyat,int _Indirim)
        {
           
            Adet = _Adet;
            Fiyat = _Fiyat;
            Indirim = _Indirim;
           
        }

        #region İndirimHesabı
        public decimal IndirimHesapla()
        {
            IndirimliFiyat = Convert.ToDecimal((Fiyat*Adet)-(Adet * Fiyat* Indirim/100));
            return IndirimliFiyat;
        }
        #endregion
    }
}
