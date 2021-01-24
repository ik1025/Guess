using System;

namespace Guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appversion = "1.0.0";
            string appauthor = "IK";

            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appversion, appauthor);
        }
    }
}
