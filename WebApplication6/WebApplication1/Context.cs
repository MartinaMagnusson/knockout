using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Context : DbContext
    {
        public DbSet<StaticNumbers> StaticNumbers { get; set; }
        public DbSet<RandomNumbers> RandomNumbers { get; set; }

    }
}
