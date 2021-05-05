using Business.Concrete.Atribute;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [ToTable("Kredi Tablosu")]
 public class Kredi:IEntities
    {
        public int Id { get; set; }
        public string AdıSoyadı { get; set; }
        public string TC { get; set; }
        public string KrediTuru { get; set; }
        public string KrediAdı{ get; set; }

        public float FaizOranı { get; set; }
        public decimal AylıkOdeme { get; set; }
        public decimal Tutar { get; set; }
    }
}
