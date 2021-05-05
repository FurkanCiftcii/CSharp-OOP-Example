using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Exceptions
{
  public  class BosMetinHatası:Exception
    {

        public BosMetinHatası(string message) : base(message)
        {

        }

    }
}
