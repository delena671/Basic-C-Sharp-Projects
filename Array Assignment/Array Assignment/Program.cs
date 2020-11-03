using System;
using System.Collections.Generic;

namespace Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number between 0 and 3");
            int input1 = Convert.ToInt32(Console.ReadLine());
            string[] names = { "Adeline", "Joshua", "David", "Daniel" };

            for (int i = 0; i < names.Length; i++)
            {
                if (input1 == i)
                {
                    Console.WriteLine("Name found at index " + input1 + ":" + names[i]);
                }
                else if (input1 != i)
                {
                    Console.WriteLine("User input does not match this item in the array.");
                }

            }

            Console.WriteLine("Pick a number between 0 and 4");
            int pickANumber = Convert.ToInt32(Console.ReadLine());
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 10;
            numArray[2] = 20;
            numArray[3] = 30;
            numArray[4] = 40;

            for (int j = 0; j < numArray.Length; j++)
            {
                if (pickANumber == j)
                {
                    Console.WriteLine("The value at index " + pickANumber + ":" + numArray[j]);
                }
                else
                {
                    Console.WriteLine("Number is not in the index");
                }
            }
            Console.ReadLine();

            Console.WriteLine("Pick a number between 0 and 2");
            List<string> animals = new List<string>() { "Dog", "Cat", "Bear" };
            int usersAnimal = Convert.ToInt32(Console.ReadLine());

            for (int a = 0; a < animals.Count; a++ )
            {
                if (usersAnimal == a)
                {
                    Console.WriteLine("The value found at index " + usersAnimal + ":" + animals[a]);
                }
                else
                {
                    Console.WriteLine("Animal is not on the List");
                }
            }
            Console.ReadLine();

       

        }
    }
}
