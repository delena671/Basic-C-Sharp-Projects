using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is today?");
            string value = Console.ReadLine();
            Everyday currentDay;
            try
            {
                currentDay = (Everyday)Enum.Parse(typeof(Everyday), value);
                Console.WriteLine("The day is" + currentDay);
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid day of the week.");
            }
            Console.ReadLine();
        }

    }
}
