using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Guess a number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            bool isYouGuessed = number1 == 22;

            while (!isYouGuessed)
            {
                switch (number1)
                {
                    case 1:
                        Console.WriteLine("You guessed 1. Try again.");
                        Console.WriteLine("Guess a number");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. Try again.");
                        Console.WriteLine("Guess a number");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 60:
                        Console.WriteLine("You guessed 60. Try again.");
                        Console.WriteLine("Guess a number");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 52:
                        Console.WriteLine("You guessed 52. Try again.");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3. Try again.");
                        Console.WriteLine("Guess a number");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 22:
                        Console.WriteLine("You guessed the number 22. That is correct.");
                        isYouGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }   
            Console.ReadLine();

            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 22;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1. Try again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. Try again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 60:
                        Console.WriteLine("You guessed 60. Try again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 52:
                        Console.WriteLine("You guessed 52. Try again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3. Try again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 22:
                        Console.WriteLine("You guessed the number 22. That is correct.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);

            Console.ReadLine();
        }
    }
}
