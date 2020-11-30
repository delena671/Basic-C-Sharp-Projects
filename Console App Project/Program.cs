using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Toyota", "Nissan", "Lexus", "Infinity", "Acura", "Honda", "Subaru" };
            int[] myNum = { 10, 20, 30, 40, 50, 60, 70 };
            Console.WriteLine(cars[3]);
            Console.ReadLine();

            string[] colors = { "Red", "Blue", "Purple", "Pink" };

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }
            Console.ReadLine();

            List<int> gameScores = new List<int>();
            gameScores.Add(6);
            gameScores.Add(10);
            gameScores.Add(22);
            gameScores.Add(26);
            gameScores.Add(30);

            foreach (int score in gameScores)
            {
                if (score > 22)
                {
                    Console.WriteLine("Winner: " + score);
                }
            }
            Console.ReadLine();

            List<string> familyNames = new List<string>() { "Roque", "Suki", "David and Grace", "Daniel and Ahn", "Joshua and Yuri", "Adeline, Shogun and Chicka" };
            string userInput = Console.ReadLine();

            foreach (string name in familyNames)
            {
                if (userInput == name)
                {
                    Console.WriteLine(name);
                }
                else
                {
                    Console.Write("Text is not on the list");
                }
            }
            Console.ReadLine();

            List<string> names = new List<string>() { "Johnson, Bill", "Johnson, Patricia", "Dejesus, Dolores", "Dejesus, Steve" };
            Console.WriteLine("Type in a Last and First Name");
            string userName = Console.ReadLine();
            Console.ReadLine();

            foreach (string i in names)
            {
                if (userName == i)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("Text is not listed in the list");
                }
            }
            Console.ReadLine();

            List<string> A = new List<string>() { "a", "b", "ab", "ac" };
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a Number for a letter");

            foreach (string C in A)
            {
                if (B == 0)
                {
                    Console.WriteLine("C");
                }
                else
                {
                    Console.WriteLine(A[B]);
                }
            }
            Console.ReadLine();

            Console.WriteLine("Vampire Movies");
            List<string> movies = new List<string>() { "Twilight", "Twilight", "Saga", "Vampires", "Movies"};
            List<string> matchList = new List<string>();
            string userMovie = Console.ReadLine();

            foreach (string movie in movies)
            if(matchList.IndexOf(movie)== -1)
            {
                matchList.Add(movie);
                Console.WriteLine(movie);
            }
            else
            {
                Console.WriteLine(movies + "has already appeared on the list");
                matchList.Add(movie);
            }
            Console.ReadLine();



        }

    }
}
