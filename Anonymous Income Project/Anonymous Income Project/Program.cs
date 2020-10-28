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
            Console.WriteLine("hoursPerWeek");
            int input2 = Convert.ToInt32(Console.ReadLine());
            
            int payRate = 15;
            int hoursAWeek = 40;
            int product = payRate * hoursAWeek;
            Console.WriteLine(product);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int input3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours per Week?");
            Console.WriteLine("hoursPerWeek");
            int input4 = Convert.ToInt32(Console.ReadLine());

            int paidRate = 28;
            int hoursWeekly = 40;
            int total = paidRate * hoursWeekly;
            Console.WriteLine(total);

            Console.WriteLine("Annual salary of person 1:");
            int hourlyRate = 15;
            float hourPerWeek = 40;
            int numberOfWeeks = 52;
            float annualSalary = (hourlyRate * hourPerWeek) * numberOfWeeks;
            Console.WriteLine(annualSalary);
            Console.ReadLine();

            Console.WriteLine("Annual salary of person 2:");
            int ratePerHour = 28;
            float hoursWorkedWeekly = 32;
            int numOfWeeks = 52;
            float annualSalary1 = (ratePerHour * hoursWorkedWeekly) * numOfWeeks;
            Console.WriteLine(annualSalary1);
            Console.ReadLine();
            
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            string makesMore = Console.ReadLine();
            bool isPerson1 = false;
            Console.WriteLine("false");
            Console.ReadLine();

        }
    }
}
