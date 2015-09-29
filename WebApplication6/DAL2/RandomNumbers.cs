using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class RandomNumbers
    {
        public int Numbers { get; set; }
        public RandomNumbers()
        {
            Thread.Sleep(1000);
        }
    }
}
