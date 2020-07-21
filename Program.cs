using System;
using System.Reflection.Metadata.Ecma335;

namespace daily_lab_07_21_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuePrompt = "y";

            while (continuePrompt == "y" || continuePrompt == "y")
            {
                Console.WriteLine("Please input a number between 1 and 100");
                int num = int.Parse(Console.ReadLine());

                if (num > 1 && num < 26 && num % 2 == 0)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if (num % 2 != 0)
                {
                    Console.WriteLine(num + " and odd ");
                }
                else if (num % 2 == 0 && num >= 26 && num <= 60)
                {
                    Console.WriteLine("Even");
                }



                Console.WriteLine("would you like to continue? (y/n)");
                continuePrompt = Console.ReadLine();

               
            }
                Console.WriteLine("bye"); 





        }

    }
}


