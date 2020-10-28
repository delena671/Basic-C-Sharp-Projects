using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours per Week?");
            int input2 = Convert.ToInt32(Console.ReadLine());
            
            int product = input1 * input2;

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int input3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours per Week?");
            int input4 = Convert.ToInt32(Console.ReadLine());

            int total = input3 * input4;

            Console.WriteLine("Annual salary of person 1:");
            int totalWeeks = 52;
            float annualSalary = product * totalWeeks;
            Console.WriteLine(annualSalary);
            Console.ReadLine();

            Console.WriteLine("Annual salary of person 2:");
            float annualSalary1 = total * totalWeeks;
            Console.WriteLine(annualSalary1);
            Console.ReadLine();
            
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isPerson1 = annualSalary > annualSalary1;
            Console.WriteLine(isPerson1);
            Console.ReadLine();

        }
    }
}
