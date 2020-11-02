using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Approval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int usersAge = Convert.ToInt32(Console.ReadLine());
            bool userInput = usersAge >= 15;

            Console.WriteLine("Have you ever had a DUI?");
            bool isDuiT = true;
            bool isDuiF = false;
            bool isApplicant = 
            Console.WriteLine(isDuiT);
            Console.WriteLine(isDuiF);

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}
