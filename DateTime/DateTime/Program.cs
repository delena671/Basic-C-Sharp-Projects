using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DateAndTime
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int user = Convert.ToInt32(Console.ReadLine());
            DateTime today = new DateTime(2020, 12, 18, 21, 28, 30);
            int time = today.Hour - user;
            Console.WriteLine();
            using (StreamWriter file = new StreamWriter(@"C:\Users\riseu\source\repos\DateTime\log.txt", true))
            {
                file.WriteLine(user);
            }
            Console.ReadLine();
        }
    }
}
