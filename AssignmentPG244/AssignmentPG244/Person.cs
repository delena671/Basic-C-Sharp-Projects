using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG244
{
    public abstract class Person
    {
        string firstName { get; set; }
        string lastName { get; set; }
        
        public abstract void SayName();  
    }
}
