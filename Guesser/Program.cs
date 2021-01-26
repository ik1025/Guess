using System;

namespace Guesser
{
    class Program
    {

        static int GenNumber(int min, int max){
            System.Random random = new System.Random();
            return random.Next(min, max);
        }

        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appversion = "1.0.0";
            string appauthor = "IK";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appversion, appauthor);
            Console.ResetColor();

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", name);
            Console.WriteLine("First let's set the range. Enter the min value");
            string min = Console.ReadLine();
            int smallnum = Int32.Parse(min);

            Console.WriteLine("Set the max value");
            string max = Console.ReadLine();
            int bignum =Int32.Parse(max);

            int correctNumber = GenNumber(smallnum, bignum);
            int guess = 0;

            Console.WriteLine("Guess a number between {0} and {1}",min,max);
            while(guess != correctNumber)
            {
                string input = Console.ReadLine();
                guess = Int32.Parse(input);
                
                if(guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number, please try again");
                    Console.ResetColor();
                }
            }

            Console.WriteLine("Correct! you win $100!");
            
        }
    }
}
