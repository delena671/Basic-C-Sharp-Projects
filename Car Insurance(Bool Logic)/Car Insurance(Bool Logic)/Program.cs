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
            int input2 = Convert.ToInt32(Console.ReadLine());
            int noDUI = 0;
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Qualified?");
            int minAge = 15;
            bool isApplicantAge = yourAge > minAge;
            int absoluteNoDui = 0;
            bool isApplicantDUI = noDUI == absoluteNoDui;
            int minSpeedingTickets = 3;
            bool isApplicantSTicket = input1 < minSpeedingTickets;
            Console.WriteLine("True");
            Console.ReadLine();




        }
    }
}
