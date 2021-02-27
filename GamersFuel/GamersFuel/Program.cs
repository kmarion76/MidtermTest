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


            //string response;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Gamers Fuel Coffee Shop!" + "\n");
            Console.WriteLine("Here's our menu:" + "\n");
            database.Print();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n" + "What would you like? (Please enter a menu number: )");
            //Console.WriteLine(database.Get(menuChoice));
            Menu.UserChoice();


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
        //public void UserChoice()
        //{
        //    List<Menu> menuInput = new List<Menu>();
        //    var getMenu = new Database();
        //    var menuChoice = Console.ReadLine();
        //    menuInput.Add(getMenu.Get(menuChoice));
        //    menuChoice.Split('-');
        //    foreach (var item in menuInput)
        //    {
        //        Console.WriteLine(item + ",");
                
        //    }
        //}
    }
}
