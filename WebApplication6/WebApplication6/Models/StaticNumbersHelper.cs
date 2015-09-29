using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.HelperClasses
{
    public class StaticNumbersHelper
    {
        public int RequestId { get; set; }

        public string Color { get; set; }

        public List<int> Numbers
        {
            get
            {
                return new List<int>() { };
            }
        }
    }
}
