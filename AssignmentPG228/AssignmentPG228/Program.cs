using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG228
{
    class Program
    {
        public static void Main(string[] args)
        {
            NoReturn classObj= new NoReturn();
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            NoReturn.Method1(x, y);
        }
    }
}
