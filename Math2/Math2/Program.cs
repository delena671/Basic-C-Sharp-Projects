using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math2
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple math with C#

            double num1 = 7.03230923;
            float num2 = 50f;
            double total = num1 * num2;
            Console.WriteLine(total);
            Console.ReadLine();

            decimal num3 = 2.03230923m;
            int num4 = 25;
            decimal product = num3 + num4;
            Console.WriteLine(product);
            Console.ReadLine();

            double num5 = 132;
            float num6 = 12.5f;
            double quotient = num5 % num6;
            Console.WriteLine(quotient);
            Console.ReadLine();

            bool trueOrFalse = 780 > 50;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            int remainder = 55 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();





        }
    }
}
