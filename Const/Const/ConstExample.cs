using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const
{
    class ConstExample
    {
        const string Var = "Hello";

        public int myAge { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public ConstExample(string firstName, string lastName, int myAge)
        {
            //First constructor
        }
        public ConstExample(string firstName, int myAge) : this(firstName, "Adeline", myAge)
        {
            //Second constructor
            this.myAge = myAge;
            myAge = 28;
        }
    }
}
