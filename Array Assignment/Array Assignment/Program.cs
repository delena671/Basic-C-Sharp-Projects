using System;
using System.Collections.Generic;

namespace Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "Adeline", "Joshua", "David", "Daniel" };
            string input1 = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                if (input1 == names[i])
                {
                    Console.WriteLine("Match found at index " + i);
                }
                else
                {
                    Console.WriteLine("User input does not match this item in the array.");
                }
            }

            int[] numArray = new int[10];
            int input2 = Convert.ToInt32(Console.ReadLine());

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
            string userColor = Console.ReadLine();

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            Console.ReadLine();

        }
    }
}
