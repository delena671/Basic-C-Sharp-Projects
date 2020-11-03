using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number between 0 and 3");
            int input1 = Convert.ToInt32(Console.ReadLine());
            string[] names = { "Adeline", "Joshua", "David", "Daniel" };

                if (input1 > 3 || input1 < 0)
                {
                    Console.WriteLine("Name found at index " + input1 + ":" + names[0]);
                }
                else
                {
                    Console.WriteLine(names[input1]);
                }

            Console.WriteLine("Pick a number between 0 and 4");
            int pickANumber = Convert.ToInt32(Console.ReadLine());
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 10;
            numArray[2] = 20;
            numArray[3] = 30;
            numArray[4] = 40;

                if (pickANumber > 5 || pickANumber < 5)
                {
                    Console.WriteLine("The value at index " + pickANumber + ":" + numArray[0]);
                }
                else
                {
                    Console.WriteLine(numArray[pickANumber]);
                }

            Console.ReadLine();

            Console.WriteLine("Pick a number between 0 and 2");
            List<string> animals = new List<string>() { "Dog", "Cat", "Bear" };
            int usersAnimal = Convert.ToInt32(Console.ReadLine());

                if (usersAnimal > 3 || usersAnimal < 3)
                {
                    Console.WriteLine("The value found at index " + usersAnimal + ":" + animals[0]);
                }
                else
                {
                    Console.WriteLine(animals[usersAnimal]);
                }

            Console.ReadLine();
        }
    }
}
