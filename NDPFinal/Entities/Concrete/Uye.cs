using Business.Concrete.Atribute;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [ToTable("UyeTablosu")]
  public class Uye:IEntities
  {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Tc { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string YetistiriciTuru { get; set; }


  }
}
