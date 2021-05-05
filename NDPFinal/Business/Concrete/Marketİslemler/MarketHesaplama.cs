using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Marketİslemler
{
   public static class MarketHesaplama
    {

     public static decimal UrunFiyatHesapla(double UrunFiyat,int UrunAdet)
        {

            decimal ToplamFiyat = Convert.ToDecimal(UrunFiyat*UrunAdet);

            return ToplamFiyat;
        }

    }
}
