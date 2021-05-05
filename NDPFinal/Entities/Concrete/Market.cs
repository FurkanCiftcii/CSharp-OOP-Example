using Business.Concrete.Atribute;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [ToTable("Market Tablosu")]
  public  class Market:IEntities
    {
        public int Id { get; set; }
        public string Adı { get; set; }
        public decimal Fiyatı { get; set; }
        public int Stok { get; set; }


    }
}
