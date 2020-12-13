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
            Everyday day = Everyday.Friday;

            try
            {
                string Today = { "Days" };
                Console.WriteLine(Today[Friday]);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.WriteLine("The try/catch is finished, and today is friday.");
            }
        }

    }
}
