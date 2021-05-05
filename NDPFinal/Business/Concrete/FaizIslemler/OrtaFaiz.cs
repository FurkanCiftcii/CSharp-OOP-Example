using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class OrtaFaiz:FaizOran,IFaiz
    {
        public OrtaFaiz(double miktar) : base(miktar)
        {

        }

        public override float Hesapla()
        {
            return faiz * 0.5f;
        }

    }
}
