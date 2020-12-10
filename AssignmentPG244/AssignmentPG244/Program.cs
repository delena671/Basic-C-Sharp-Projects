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
            Person person = new Employee();
            Employee employee = new Employee();
            employee.firstName = "Adeline";
            person += Employee;

            IQuittable quittable = new Employee();
            //Employee employee = new Employee();
            quittable.Quit();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
            Console.ReadLine();

        }
    }
}
