using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG231
{
    public class Class31
    {
        public void getValue(int x)
        {
            int result = x / 2;
            Console.WriteLine(result);
        }
    }

    public static void Add(string x, string y)
    {
        string answer = x + " " + y;
        Console.WriteLine(answer);
    }

    public void getAnswers(out int x)
    {
        int temp = 5;
        x = temp;
    }
}
