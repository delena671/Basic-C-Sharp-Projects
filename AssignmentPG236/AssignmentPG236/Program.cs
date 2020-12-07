using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG236
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person People = new Person();

            Employee person = new Employee();

            Console.WriteLine("What is your name");
            People.Method1("FisrtName", "LastName"); //This begins with the OBJ 
            //name "People" because it is not static.
            string name = 
            Person.FulName("FisrtName, LastName"); //This begins with the class 
            //name "Person" because it is static.
            Console.ReadLine();
        }
    }
}
