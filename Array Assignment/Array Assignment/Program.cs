using System;
using System.Collections.Generic;

namespace Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a name");
            Console.ReadLine();
            string[] names = { "Adeline", "Joshua", "David", "Daniel" };
            int input1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < names.Length; i++)
            {
                if (input1 == i)
                {
                    Console.WriteLine("Match found at index " + names[i]);
                }
                else
                {
                    Console.WriteLine("User input does not match this item in the array.");
                }
            }

            Console.WriteLine("Pick a number");
            Console.ReadLine();
            int pickANumber = Convert.ToInt32(Console.ReadLine());
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 10;
            numArray[2] = 20;
            numArray[3] = 30;
            numArray[4] = 40;
            
            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            int[] numArray2 = { 5, 2, 10, 200, 5000 };

            numArray2[5] = 650;

            Console.WriteLine(numArray2[3]);
            Console.ReadLine();

            for (int j = 0; j < numArray.Length; j++)
            {
                if (pickANumber == j)
                {
                    Console.WriteLine("Match found at index " + numArray[j]);
                }
                else
                {
                    Console.WriteLine("User input does not match this item in the array.");
                }
            }
            Console.ReadLine();

            Console.WriteLine("Choose a color");
            Console.ReadLine();

            List<string> colors = new List<string>() { "Pink", "Purple", "Lavender", "Lilac", "Blues" };
            string userColor = Console.ReadLine();

            foreach (string i in colors)
            {
                    Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
