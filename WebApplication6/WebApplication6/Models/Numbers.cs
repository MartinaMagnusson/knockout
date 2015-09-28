using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace WebApplication6.Models
{
    public class ColoredNumber
    {
        public int value;
        public string color;

        public ColoredNumber(int value)
        {
            this.value = value;
        }
    }
    public class RandomNumbers
    {
        public int RequestID { get; set; }
        public List<int> numbers {
            get {
                return new List<int>() { };
            }
        }
        public RandomNumbers()
        {
            Thread.Sleep(1000);
        }  
    }

    public class StaticNumbers
    {
        public List<int> numbers
        {
            get
            {
                return new List<int>() {};
            }
        }
    }

    public class Numbers
    {
        public RandomNumbers randomNumbers = new RandomNumbers();
        public StaticNumbers staticNumbers = new StaticNumbers();   
        public ColoredNumber color { get; set; }
    }
}   