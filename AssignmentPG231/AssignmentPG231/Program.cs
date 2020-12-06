using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPG231
{
    class Program
    {   
        static void Main(string[] args)
        {
            Class31 classOut = new Class31();
            Console.WriteLine("Please enter a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            classOut.getValue(input);
            Console.ReadLine();

            classOut.Add(input);
            Class31.getAnswers(input);
           
        }
    }
}
