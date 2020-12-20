using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssignmentPG314
{
    class Program
    {
        public static void TryInt( int Try)
        {
            if(Try == 0)
            {
                throw new Exception();
            }
        }
        public static void Main(string[] args)
        {
            DOB birthday = new DOB();
            Console.WriteLine("Hello, let's start by telling me your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            DateTime yOB = DateTime.Now;
            int year = yOB.Year - userAge;
            Console.WriteLine(year);
            Console.ReadLine();

            Console.WriteLine("Enter a number.");
            try
            {
                string answer = Console.ReadLine();
                int age = Int32.Parse(answer);
                TryInt(age);      
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
