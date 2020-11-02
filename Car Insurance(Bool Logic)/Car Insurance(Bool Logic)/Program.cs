using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Bool_Logic_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?");
            bool input2 = Convert.ToBoolean(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Qualified?");
            bool isQualified = (input2 == false && yourAge > 15 && input1 <= 3); 
            Console.WriteLine(isQualified);
            Console.ReadLine();


        }
    }
}
