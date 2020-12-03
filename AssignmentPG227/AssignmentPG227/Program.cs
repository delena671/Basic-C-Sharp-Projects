using System;

namespace AssignmentPG227
{
    class Program
    {
        static void Main(string[] args)
        {
            Money classObj = new Money();

            //Method1
            Console.WriteLine("Please enter any two numbers (One at a time), you may not need to enter a second number if you like.");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(classObj.Method1(input));
            Console.ReadLine();
        }
    }
}
