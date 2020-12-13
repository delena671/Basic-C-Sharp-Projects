using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123struct
{
    class Program
    {
        public static void Main(string[] args)
        {
            Number amountObj = new Number();
            amountObj.Amount = 32.5m;
            Console.WriteLine(amountObj.Amount);
            Console.ReadLine();
        }
        public struct Number
        {
            public decimal Amount;
        }
    }
}
