using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Indexers
{
   public class Indexleyici
    {
        private string[] Sulama = { "yok", "damla sulama", "sprey sulama" };

        public string this[int Indeks]
        {
            get
            {
                if (Indeks<0||Indeks>=Sulama.Length)
                {
                    return null;
                }
                else
                {
                    return Sulama[Indeks];
                }
            }
            set
            {
                if (!(Indeks < 0 || Indeks >= Sulama.Length))
                    Sulama[Indeks] = value;
            }
        }



    }
}
