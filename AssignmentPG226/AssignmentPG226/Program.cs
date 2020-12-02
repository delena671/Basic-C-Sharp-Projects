using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG226
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass classObj = new MathClass();
            //Method1
            Console.WriteLine("Enter any number.");
            int input = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(classObj.Method1(input));
            Console.ReadLine();
            //End

            //Method2
            Console.WriteLine("Enter another number.");
            decimal input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(classObj.Method2(input2));
            Console.ReadLine();
            //End

            //Method3
            Console.WriteLine("Final number.");
            string input3 = Console.ReadLine();
            Console.WriteLine(input3);
            Console.ReadLine();

            //End
        }
    }
}
