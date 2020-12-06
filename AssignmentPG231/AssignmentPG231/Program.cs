using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG231
{
    class Program
    {   
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            Class31.getValue(input);
            Console.ReadLine();
            
            string x = "1";
            string y = "4";
            Class31.getValue(x, y);

            int temp = Convert.ToInt32(Console.ReadLine());
            Class31.getAnswers(out temp);
            Console.ReadLine();
        }
    }
}
