using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
  public  interface IProductDal<T,entitites> where T:class
    {
        void Add(T entitites);
        void Update(T entities);
        void Delete(T entitites);
    }
}
