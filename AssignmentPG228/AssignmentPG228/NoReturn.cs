using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG228
{
    public class NoReturn
    {
        public void Method1(int x, int y = 3)
        {
            int result = x + y;
            Console.WriteLine(y);
        }
    }
}
