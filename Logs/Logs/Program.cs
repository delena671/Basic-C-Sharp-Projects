using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            //string text = "input";
            //File.WriteAllText(@"C:\Users\riseu\source\repos\log.txt", text);
            using (StreamWriter file = new StreamWriter(@"C:\Users\riseu\source\repos\log.txt", true))
            {
                file.WriteLine(input);
            }
            Console.ReadLine();
        }
    }
}
