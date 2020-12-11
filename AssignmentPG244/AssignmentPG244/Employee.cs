using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG244
{
    public class Employee : Person, IQuittable
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name:" + firstName + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("Sorry" + firstName + lastName + "You have been let go");
        }
        public static Person operator +(Person person, Employee employee)
        {
            person.Employee.Add(employee);
            return person;
        }
        public static Person operator -(Person person, Employee employee)
        {
            person.Employee.Remove(employee);
            return person;
        }
    }
}
