using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Atribute
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class HelpsAttribute:Attribute
    {
        public readonly string Url;
        public string Konu { get { return konu; } set {Konu=value; } }

        public HelpsAttribute(string _Url)
        {
            this.Url = _Url;
        }
        private  string konu { get; set; }
    }
}
