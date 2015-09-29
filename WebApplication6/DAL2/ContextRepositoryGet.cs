using DAL2.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContextRepositoryGet
    {
        public ContextRepositoryGet()
        {

        }
        public IQueryable<NumbersHelper> GetAllNumbers()
        {
            using (var _context = new Context())
            {
                var number = (from n in _context.Numbers
                        select new NumbersHelper()
                        {
                            randomNumbersHelper = new RandomNumbersHelper()
                            {
                                Numbers = n.randomNumbers.Numbers,
                            },
                            staticNumbersHelper = new StaticNumbersHelper()
                            {
                                Numbers = n.staticNumbers.Numbers
                            }
                        });
                return number;
            }
        }
    }
}
