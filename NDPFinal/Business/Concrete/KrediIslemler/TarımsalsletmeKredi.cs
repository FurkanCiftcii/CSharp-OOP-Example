using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.KrediIslemler
{
  public  class TarımsalsletmeKredi:Krediler,IKrediler
    {
        
        
        public TarımsalsletmeKredi(string yetistirici):base(yetistirici)
        {

        }

        public override string YardımPaketi()
        {
            if (YetistiriciTuru == "Seracı")
            {

                UrunTuru = "100 adet domates fidesi";
                return UrunTuru;
            }
            else if (YetistiriciTuru == "Yetiştirici")
            {
                UrunTuru = "50 adet Simental ırk İnek";
                return UrunTuru;
            }
            else{
                UrunTuru = "250 adet Arı Kovanı";
                return UrunTuru;
            }
            



        }

        public override double Hibe()
        {
            if (YetistiriciTuru == "Seracı")
            {
                Hibeler = 4000;
                return Hibeler;
               
            }
            else if (YetistiriciTuru == "Yetiştirici")
            {
                Hibeler = 3000;
                return Hibeler;
            }
            else
            {
                Hibeler = 200000;
                return Hibeler;
            }
        }

        public decimal KrediNeKadar()
        {
            int fiyat = 320000;
            KrediMiktarı = Convert.ToDecimal(fiyat);

            return KrediMiktarı;
        }
    }
}
