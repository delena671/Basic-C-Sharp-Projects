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
            IQuittable quittable = new Employee();

            Employee employee = new Employee();
            quittable.Quit();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
            Console.ReadLine();

            //AssignmentPG252 Overloading operator
            Employee employee1 = new Employee();
            employee.id = 2;
            employee1.id = 3;
            Console.WriteLine(employee == employee1);
            Console.WriteLine(employee != employee1);
            Console.ReadLine();
        }
    }
}
