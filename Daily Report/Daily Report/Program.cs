﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple daily report
            Console.WriteLine("The Tech Accademy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("The course you are on: " + courseName);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need any help with anything? please answer \"true\" or \"false");
            string needHelp = Console.ReadLine();
            Console.WriteLine("You need help: " + needHelp);
            Console.ReadLine();
            bool isHelp = true;

            Console.WriteLine("Were there any positive experiences you'd like to share? please give specifics.");
            string positiveFeedback = Console.ReadLine();
            Console.WriteLine("Your feedback: " + positiveFeedback);
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide?");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("Thanks for sharing, I will let them know: " + otherFeedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hoursStuddied = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Let us know if you need help with anything else.");
            string moreHelp = Console.ReadLine();
            Console.WriteLine("Perfect! We will be looking forward to it: " + moreHelp);
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();



        }
    }
}
