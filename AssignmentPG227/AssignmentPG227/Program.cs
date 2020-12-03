using System;

namespace AssignmentPG227
{
    class Program
    {
        static void Main(string[] args)
        {
            Money classObj = new Money();
            Console.WriteLine("Please enter any two numbers (One at a time), you may not need to enter a second number if you like.");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Again this is optional, type your second number here.");
            string num2 = Console.ReadLine();
            if (num2 == "")
            {
                //int num3 = Convert.ToInt32(num2);
                Console.WriteLine(classObj.Method1(num));
            }
            else
            {
                int num3 = Convert.ToInt32(num2);
                Console.WriteLine(classObj.Method1(num, num3));
            }
            Console.ReadLine();


            //Money money = new Money();
            //money = Shuffle(money);

            ////Method1
            //Console.WriteLine("Please enter any two numbers (One at a time), you may not need to enter a second number if you like.");
            //int input = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(classObj.Method1(input));
            //Console.ReadLine();
        }

        //public static Money Shuffle(Money money, int times = 1)
        //{
        //    Money classObj = new Money();
        //    //Method1

        //    for (int i = 0; i < times; i++)
        //    {
        //        Console.WriteLine("Please enter any two numbers (One at a time), you may not need to enter a second number if you like.");
        //        int input = Convert.ToInt32(Console.ReadLine());

        //        Console.WriteLine(classObj.Method1(input));
        //        Console.ReadLine();
        //    }
        //}
    }
}
