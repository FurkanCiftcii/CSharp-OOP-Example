using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.KrediIslemler
{
    public class KalkınmaKredisi : Krediler, IKrediler
    {
        public KalkınmaKredisi(string yetistirici):base(yetistirici)
        {

        }


        public override double Hibe()
        {
            double a = 0;
            return a;
        }

        public decimal KrediNeKadar()
        {
            int fiyat = 500000;
            KrediMiktarı = Convert.ToDecimal(fiyat);

            return KrediMiktarı;
        }

        public override string YardımPaketi()
        {
            return "bulunmamaktadır";
        }
    }
}
