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
        private Random _randomNumber;
        public int[] numbers {
            get {
                return new int[] { _randomNumber.Next(0,100), _randomNumber.Next(0, 100), _randomNumber.Next(0, 100), _randomNumber.Next(0, 100), _randomNumber.Next(0, 100), _randomNumber.Next(0, 100) };
            }
        }
        public RandomNumbers()
        {
            _randomNumber = new Random();
            Thread.Sleep(100);
        }  
    }

    public class StaticNumbers
    {
        private Random _randomStaticNumber;
        public List<int> numbers
        {
            get
            {
                return new List<int>() {};
            }
        }
        public StaticNumbers()
        {
            _randomStaticNumber = new Random();
        }
    }

    public class Numbers
    {
        public RandomNumbers randomNumbers = new RandomNumbers();
        public StaticNumbers staticNumbers = new StaticNumbers();   
        public ColoredNumber color { get; set; }
    }
}   