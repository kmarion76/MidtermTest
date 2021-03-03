using System;
using System.Collections.Generic;
using System.IO;

namespace GamersFuel
{
    class Program
    {

        static void Main(string[] args)
        {
            var database = new Database();
            database.LoadMenu();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Gamers Fuel Coffee Shop!" + "\n");
            Console.WriteLine("Here's our menu:" + "\n");
            database.Print();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n" + "What would you like? (Please enter a menu number): ");
            database.UserChoice();

            string response;
            do
            {
                bool isInvalid;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Would you like to order more? (y/n): ");
                response = Console.ReadLine().ToLower();
                isInvalid = response != "y" && response != "n";
                if (isInvalid)
                {
                    Console.Write("Please enter a valid selection ('y' or 'n')!" + "\n");
                }
                else if (response == "y")
                {
                    database.Print();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.Write("What menu number would you like? ");
                    database.UserChoice();
                }
                else if (response == "n")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Here's your receipt:");
                    Console.ForegroundColor = ConsoleColor.White;
                    database.Receipt();
                }
            } while (response == "y");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Thanks for visiting Gamers Fuel Coffee Shop!");

        }
    }
}
