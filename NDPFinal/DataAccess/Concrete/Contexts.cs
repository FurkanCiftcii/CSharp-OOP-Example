using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
   public class Contexts:DbContext
    {

        public DbSet<Destek> desteks { get; set; }
        public  DbSet<Kredi> kredis { get; set; }
        public DbSet<Market> markets { get; set; }

        public DbSet<Uye> uyes { get; set; }


    }
}
