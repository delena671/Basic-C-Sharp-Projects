using System;
using System.Collections.Generic;

namespace Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Adeline";
            string greeting = "Hey";


            List<string> intList = new List<string>();
            intList.Add("Hey");
            intList.Add("Adeline");
            //intList.Remove("Adeline");
            Console.WriteLine(intList[0]);
            Console.ReadLine();

            int[] numArray = new int[10];
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

            int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            numArray2[5] = 650;

            Console.WriteLine(numArray2[3]);
            Console.ReadLine();

            Console.WriteLine("The index you chose does not exist.");
            Console.ReadLine();

            List<string> colors = new List<string>() { "Pink", "Purple", "Lavender", "Lilac", "Blues" };
            
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            Console.ReadLine();

        }
    }
}
