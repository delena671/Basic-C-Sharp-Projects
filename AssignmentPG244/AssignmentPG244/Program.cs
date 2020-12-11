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
            EmployeeA employee = new EmployeeA();
            employee.firstName = "Adeline";
            person += EmployeeA;

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
