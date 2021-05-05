using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.KrediIslemler
{
  abstract public class Krediler
    {
   
        public decimal KrediMiktarı { get; set; }
        public string YetistiriciTuru { get; set; }
        public double Hibeler { get; set; }
        public string UrunTuru { get; set; }
        public Krediler(string _Yetistirici)
        {
            YetistiriciTuru = _Yetistirici;
        }

        public abstract string YardımPaketi();
        public abstract double Hibe();
            
        

    }
}
