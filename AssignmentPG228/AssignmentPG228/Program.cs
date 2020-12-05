using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG228
{
    class Program
    {
        public static void Main(string[] args)
        {
            NoReturn classObj= new NoReturn();
            Console.WriteLine("Pick a number!");
            int input1 = Convert.ToInt32(Console.ReadLine());
            classObj.Method1(input1);
            Console.WriteLine("And a second number.");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            classObj.Method1(input1, input2);
            classObj.Method1(x: 5, y: 8);
            
        }
    }
}
