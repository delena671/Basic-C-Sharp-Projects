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
            //Interface
            IQuittable quittable = new Employee<T>();

            Employee<T> employee = new Employee<T>();
            quittable.Quit();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
            Console.ReadLine();

            //AssignmentPG252 Overloading operator
            Employee<T> employee1 = new Employee<T>();
            employee.id = 2;
            employee1.id = 3;
            Console.WriteLine(employee == employee1);
            Console.WriteLine(employee != employee1);
            Console.ReadLine();

            // AssignmentPG255 Generics
            Employee<string> things = new Employee<string>();
            List<string> Thing1 = new List<string>() { "Ball", "Toys", "Shoes" };

            foreach (string stuff in Thing1)
            {
                Console.WriteLine(stuff);
            }
        }
    }
}
