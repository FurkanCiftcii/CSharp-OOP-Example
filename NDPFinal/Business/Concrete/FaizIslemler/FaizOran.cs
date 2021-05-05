using Business.Concrete.Atribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    [HelpsAttribute("Faiz Hesaplama") ]
  public  class FaizOran
    {
       
        [RequiredProperty("Sabit Sayi")]
        public const float faiz = 1;
        
        public double Miktar { get; set; }
        public FaizOran()
        {

        }

        public FaizOran(double _miktar)
        {
            Miktar = _miktar;

        }
        public virtual float Hesapla()
        { 

            return  faiz;
        } 
    }
}
