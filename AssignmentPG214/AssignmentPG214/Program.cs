using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG214
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myNumber = new List<int>() { 0, 1, 2, 3, 4, 5 };

            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            Console.ReadLine();
            foreach (int Number in myNumber)
            {
                Console.WriteLine(Number / numberOne);
            }
            Console.ReadLine();
        }
    }
}
