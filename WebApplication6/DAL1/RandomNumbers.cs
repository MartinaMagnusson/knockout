using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class RandomNumbers
    {
        public List<int> numbers { get; set; }
        public RandomNumbers()
        {
            numbers = new List<int>();
            Thread.Sleep(1000);
        }
    }
}
