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
            IQuittable quittable = new Employee<string>();

            Employee<string> employee = new Employee<string>();
            quittable.Quit();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
            Console.ReadLine();

            //AssignmentPG252 Overloading operator
            Employee<string> employee1 = new Employee<string>();
            employee.id = 2;
            employee1.id = 3;
            Console.WriteLine(employee == employee1);
            Console.WriteLine(employee != employee1);
            Console.ReadLine();

            // AssignmentPG255 Generics

            Employee<string> things = new Employee<string>();    //object instantiation
            things.Things = new List<string>() { "Chair", "Desk", "Paper Work" }; //accessing the list
            //property with the Employee object
            foreach(string i in things.Things)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            Employee<int> thingNum = new Employee<int>();
            thingNum.Things = new List<int>() { 0, 1, 2 };

            foreach(int i in thingNum.Things)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
