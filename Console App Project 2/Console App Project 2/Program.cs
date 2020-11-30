using System;
using System.Collections.Generic;

namespace Console_App_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment Part one
            Console.WriteLine("Write a car manufacturers name.");
            string input = Console.ReadLine();
            string [] Cars = { "Toyota", "Nissan", "Honda", "Lexus", "Infinity", "Acura" };  // Array of string objects

            for (int i = 0; i < Cars.Length; i++)  //This prints the values at 0, 1, 2, 3, 4, 5
            {
                Cars[i] = Cars[i] + input;
            }
            for(int i = 0; i<Cars.Length; i++)
            {
                Console.WriteLine(Cars[i]);
            }
            Console.ReadLine();
            //End Assignment Part one
            
            //Assignment part two
            List<int> carScores = new List<int>(); //List of integers
            carScores.Add(9);
            carScores.Add(10);
            carScores.Add(22);  //Index of the list. These are the car scores
            carScores.Add(26);
            carScores.Add(30);
            carScores.Add(59);

            foreach (int score in carScores)
            {
                if (score > 10)
                {
                    Console.WriteLine("Popular Car Brand: " + score);
                }
            }
            Console.ReadLine();
            //End Assignment part two

            //Assignment part three
            Console.WriteLine("What is your favorite car?");
            List<string> favoriteCars = new List<string>() { "Lexus GS", "Acura TLX", "Infinity G37", "Subaru WRX" }; //This is a list of my favorite cars
            string userInput = Console.ReadLine(); // This is the user input

            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine(k);
            }
            for (int j = 0; j <= favoriteCars.Count -1; j++)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();
            //End Assignment part three

            //Assignment part four
            List<string> carColors = new List<string>() { "Candy Apple Red", "White Pearl", "Black Pearl", "Blue", "Silver" };
            Console.WriteLine("What color car do you like?");
            string userColor = Console.ReadLine();

            foreach (var Item in carColors)
            {
                if (Item == userColor)
                {
                    Console.WriteLine(Item);
                }
                else
                {
                    Console.WriteLine("Match not found.");
                }
            }
            if (!carColors.Contains(userColor))
            {
                Console.WriteLine("List does not contain this item.");
            }
            Console.ReadLine();
            //End part four

            //Assignment part five
            List<string> similarCars = new List<string>() { "Honda Civic", "Honda", "Honda Accord", "Acura", "Acura" };
            Console.WriteLine("Enter a car name.");
            string userSimilarity = Console.ReadLine();

            for (var n = 0; n < similarCars.Count; n++)
            {
                if (similarCars[n] == userSimilarity)
                {
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine("Sorry your input is not on the list.");
                }
            }
            Console.ReadLine();
            //End part five

            //Assignment part six
            List<string> carPercentage = new List<string>() { "98", "99", "95", "99", "90", "89", "95" };
            List<string> carPopularity = new List<string>();

            foreach (string percent in carPercentage)
            {
                if (carPopularity.Contains(percent))
                {
                    Console.WriteLine(percent + "Has already appeared before");
                }
                    carPopularity.Add(percent);
            }
            Console.WriteLine(carPopularity.Count);
            Console.ReadLine();
        }

    }
}
