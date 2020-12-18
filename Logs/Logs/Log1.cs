using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logs
{
    public class Log1
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Age { get; set; }
        public Log1(string firstName, string lastName, int Age)
        {
            //First Constructor that passes firstName, lastName and Age
        }
        public Log1(string firstName, int Age): this (firstName, "John", Age )
        {
            //Second Constructor passes the firstName "John" and and Age
            this.Age = Age;
            Age = 30;
        }
    }
}
