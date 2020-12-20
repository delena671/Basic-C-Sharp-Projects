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
        }
        public static void Main(string[] args)
        {
            DOB birthday = new DOB();
            try
            {
                Console.WriteLine("Hello, let's start by telling me your age?");
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge <= 0)
                {
                    throw new Exception();
                }

                DateTime yOB = DateTime.Now;
                int year = yOB.Year - userAge;
                Console.WriteLine("You were born in the year:" + year);
                string answer = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
