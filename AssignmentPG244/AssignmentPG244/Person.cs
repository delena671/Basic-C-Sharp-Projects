﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG244
{
    public abstract class Person 
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name:" + firstName + lastName);
        }

        public string EmployeeA { get; set; }
        public void Person1()
        {
            Console.WriteLine(EmployeeA);
        }
    }
}
