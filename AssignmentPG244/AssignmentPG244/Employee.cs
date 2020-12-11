using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG244
{
    public class Employee<T> : Person, IQuittable
    {
        public string things { get; set; }

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

        //Operator Overloading
        public int id { get; set; } //id property
        public static bool operator ==(Employee<T> employee, Employee<T> employeeA)  
        {    //True or False
            bool B = employee.id == employeeA.id;  
            return B;
        }
        public static bool operator !=(Employee<T> employee, Employee<T> employeeA)
        {
            bool C = employee.id != employeeA.id;
            return C;
        }
        
    }
}
