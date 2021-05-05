using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.KrediIslemler
{
    public class İhtiyacKredisi : Krediler,IKrediler
    {
        public İhtiyacKredisi(string yetistirici):base(yetistirici)
        {


        }
        public override double Hibe()
        {
            int a = 0;
            return a;
        }

        public decimal KrediNeKadar()
        {
            int fiyat = 300000;
            KrediMiktarı = Convert.ToDecimal(fiyat);

            return KrediMiktarı;
        }

        public override string YardımPaketi()
        {
            return "bulunmamaktadır";
        }
    }
}
