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
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours per Week?");
            Console.WriteLine("hoursPerWeek");
            int hoursPerWeek1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours per Week?");
            Console.WriteLine("hoursPerWeek");
            int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of person 1:");
            int annualSalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual salary of person 2:");
            int annualSalary2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            string makesMore = Console.ReadLine();
            bool isPerson1 = true;
            Console.ReadLine();

        }
    }
}
