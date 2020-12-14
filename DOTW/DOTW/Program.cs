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
            string value = "Friday";
            Everyday everyday;
            if (Enum.TryParse(value, out everyday))
            {
                Console.WriteLine(everyday == Everyday.Friday);
            }
            Console.ReadLine();
        }

    }
}
