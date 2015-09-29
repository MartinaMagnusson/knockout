using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Context : DbContext
    {
        public DbSet<StaticNumbers> StaticNumbers { get; set; }
        public DbSet<RandomNumbers> RandomNumbers { get; set; } 
        public DbSet<Numbers> Numbers { get; set; }
    }
}
