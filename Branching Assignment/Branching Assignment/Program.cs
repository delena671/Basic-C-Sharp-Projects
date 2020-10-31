using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Package Weight");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            
            int rightWeight = 50;
            if (input1 > rightWeight)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
            }

            Console.WriteLine("Package Width");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Package Height");
            int input3 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine(); 
            
            Console.WriteLine("Package Length");
            int input4 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            int total = input2 + input3 + input4;
            if (total > 50)
            {
                Console.WriteLine("This package is too big to be shipped via Package Express.");
            }

            int product = input2 * input3 * input4;
            int product2 = product * input1;
            int quotient = product2 / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $ " + quotient);
            Console.ReadLine();
        }
    }
}
