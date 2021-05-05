using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.KrediIslemler
{
   public class TarımsalAracGerecler : Krediler,IKrediler
    {
       
        public TarımsalAracGerecler(string _yetistirici):base(_yetistirici)
        {
            YetistiriciTuru = _yetistirici;
        }


        public override double Hibe()
        {
           
            if (YetistiriciTuru == "Seracı")
            {
                Hibeler =30000;
                return Hibeler;

            }
            else if (YetistiriciTuru == "Yetiştirici")
            {
                Hibeler =20000;
                return Hibeler;
            }
            else
            {
                Hibeler = 25000;
                return Hibeler;
            }
        }

        public override string YardımPaketi()
        {
            if (YetistiriciTuru == "Seracı")
            {

                UrunTuru = "1000 adet profil demiri,sera icin malzemeler";
                return UrunTuru;
            }
            else if (YetistiriciTuru == "Yetiştirici")
            {
                UrunTuru = "inek sağma makinesı,yem dağıtım makinesi";
                return UrunTuru;
            }
            else
            {
                UrunTuru = "Bal üretim makinesi";
                return UrunTuru;
            }
            
        }
        public decimal KrediNeKadar()
        {
           int fiyat = 100000;
            KrediMiktarı = Convert.ToDecimal(fiyat);

            return KrediMiktarı;
        }
    }
}
