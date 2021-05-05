using Business.Concrete.Atribute;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [ToTable("Destek Tablosu")]
  public  class Destek:IEntities
    {
        public int Id { get; set; }
        public string UrunAdi  { get; set; }
        public string UrunTuru { get; set; }
        public int UrunMiktarı { get; set; }
        public decimal Fiyat { get; set; }
    }
}
