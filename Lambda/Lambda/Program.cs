using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Part one
            List<Employee> employee = new List<Employee>
            {
                new Employee {firstName= "Joe", lastName= "Cruz", id = 1},
                new Employee {firstName= "Adeline", lastName= "Castro", id = 2},
                new Employee {firstName= "Suki", lastName= "Cruise", id = 3},
                new Employee {firstName= "John", lastName= "Johnson", id = 4},
                new Employee {firstName= "David", lastName= "Bailey", id = 5},
                new Employee {firstName= "Jake", lastName= "DeJesus", id = 6},
                new Employee {firstName= "Joe", lastName= "Marston", id= 7},
                new Employee {firstName= "Soo", lastName= "Min", id = 8},
                new Employee {firstName= "Duran", lastName= "Willson", id = 9},
                new Employee {firstName= "Jessica", lastName= "Hoyle", id = 10}
            };
            //Part Two
            List<Employee> Joes1 = employee.Where(x => x.firstName == "Joe").ToList();
            foreach(Employee empJ in Joes1)
            {
                Console.WriteLine(empJ.firstName + ' ' + empJ.lastName);
            }
             //Part Three
            List<Employee> Joes2 = employee.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee empJ2 in Joes2)
            {
                Console.WriteLine(empJ2.firstName);
            }
            Console.ReadLine();
            //Part Four
            List<Employee> idsGreaterThanFive = employee.Where(x => x.id > 5).ToList();
            foreach(Employee empID in idsGreaterThanFive)
            {
                Console.WriteLine(empID.id);
            }
            Console.ReadLine();
        }
    }
}
