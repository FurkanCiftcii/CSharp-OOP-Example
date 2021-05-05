using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Atribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public  class MethodAttribute:Attribute
    {
        public string Metod { get; set; }
        public MethodAttribute(string _metotismi)
        {
            Metod = _metotismi;
        }




    }
}
