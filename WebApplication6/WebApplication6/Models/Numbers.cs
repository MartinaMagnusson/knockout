using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Numbers
    {
       public StaticNumbers staticNumbers = new StaticNumbers();
       public RandomNumbers randomNumbers = new RandomNumbers();
        public Numbers()
        {

        }
        public Numbers(RandomNumbers randomNumbers)
        {
            this.randomNumbers = randomNumbers;
        }
    }
}