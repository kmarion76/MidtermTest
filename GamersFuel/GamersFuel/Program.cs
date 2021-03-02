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
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.Write("Would you like to order more? (y/n): ");
                Console.WriteLine();
                response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    database.Print();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.Write("What menu number would you like? ");
                    database.UserChoice();
                }
            } while (response == "y");

            Order final = new Order();
            final.FinalPrice();

            Console.WriteLine("Thanks for visiting Gamers Fuel Coffee Shop!");
        }
    }
}
