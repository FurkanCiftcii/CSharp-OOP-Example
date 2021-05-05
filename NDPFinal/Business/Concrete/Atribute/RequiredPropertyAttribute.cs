using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Atribute
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple =true)]
  public  class RequiredPropertyAttribute:Attribute
    {
        public string Uyarı { get; set; }
        public RequiredPropertyAttribute(string _uyarı)
        {
            Uyarı = _uyarı;
        }
        

        


    }
}
