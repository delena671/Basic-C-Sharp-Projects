using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG223
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 classObject = new Class1();

            Console.WriteLine("Choose any number.");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(classObject.Math1(input));
            Console.ReadLine();

            Console.WriteLine("Choose another number");
            int inputTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(classObject.Math2(inputTwo));
            Console.ReadLine();

            Console.WriteLine("How about another number.");
            int inputThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(classObject.Math3(inputThree));
            Console.ReadLine();
            
        }
    }
}
