using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG226
{
    public class MathClass
    {
        public int Method1 (int x)
        {
            int result = x * 5;
            return result;
        }

        public int Method2(decimal x)
        {
            decimal result = x / 65;
            int num = Convert.ToInt32(result);
            return num;
        }

        public int Method3(string x)
        { 
            int num = Convert.ToInt32(x);
            int prod = num + 5;
            return prod;
        }
    }
}
