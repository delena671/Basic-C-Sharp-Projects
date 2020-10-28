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

            Console.WriteLine("Enter A Number");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int product = input1 * 50;
            Console.WriteLine("Your number times 50: " + product);
            Console.ReadLine();

            Console.WriteLine("Enter A Number");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int total = input2 + 25;
            Console.WriteLine("Your number plus 25 is: " + total);
            Console.ReadLine();

            Console.WriteLine("Enter A Number");
            int input3 = Convert.ToInt32(Console.ReadLine());
            double quotient = input3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + quotient);
            Console.ReadLine();

            Console.WriteLine("Enter A Number");
            int input4 = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = input4 > 50;
            Console.Write("Is your number bigger than 50?: " + trueOrFalse.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter A Number");
            int input5 = Convert.ToInt32(Console.ReadLine());
            int remainder = input5 % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + remainder);
            Console.ReadLine();





        }
    }
}
