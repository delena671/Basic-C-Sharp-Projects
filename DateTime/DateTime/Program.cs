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
            DateTime time = DateTime.Now;
            time = time.AddHours(user);
            //DateTime totalTime = new DateTime(time);
            Console.WriteLine(time);
            Console.ReadLine();
        }
    }
}
