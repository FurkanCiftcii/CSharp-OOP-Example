using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Atribute
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)]
   public class ToTableAttribute:Attribute
    {
       private string  TableName { get; set; }
        public ToTableAttribute(string _TableName)
        {
            TableName = _TableName;
        }


    }
}
