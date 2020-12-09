using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG244
{
    class Program
    {
        public static void Main(string[] args)
        {
            IQuittable quittable = new Employee();
            IQuittable.firstName = "Sample";
            IQuittable.lastName = "Student";
            IQuittable.SayName();

            quittable.Quit();
            Console.ReadLine();

        }
    }
}
