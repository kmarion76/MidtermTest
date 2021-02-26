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
            //var menu = Console.ReadLine();
            //Console.WriteLine(database.Get(menu));

            //string response;
            Console.WriteLine("Welcome to Gamers Fuel Coffee Shop!");
            Console.WriteLine("Here's our menu:");
            database.Print();
            //do
            //{
            //    var customerOrder = Console.ReadLine().ToLower();
            //    if (customerOrder == "1")
            //    {
            //        Console.WriteLine($"You ordered: test");
            //        Console.WriteLine("Your price is {$4.99}. Would you like anything else");
            //    }
            //    Console.WriteLine("Would you like anything else? (y/n)");
            //    response = Console.ReadLine().ToLower();

            //} while (response == "y");







        }

    }
}
