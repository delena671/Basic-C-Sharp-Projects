using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG231
{
    public static class Class31
    {
        public static void getValue(int x)
        {
            int result = x / 2;
            Console.WriteLine(result);
        }
        public static void getValue(string x, string y)
        {
            string answer = x + " " + y;
            Console.WriteLine(answer);
        }

        public static void getAnswers(out int x)
        {
            int temp = 5;
            x = temp;
            Console.WriteLine(x);
        }
    }
}
