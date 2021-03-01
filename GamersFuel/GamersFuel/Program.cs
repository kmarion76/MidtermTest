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
            Menu getMenu = new Menu();
            database.LoadMenu();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Gamers Fuel Coffee Shop!" + "\n");
            Console.WriteLine("Here's our menu:" + "\n");
            database.Print();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n" + "What would you like? (Please enter a menu number): ");
            getMenu.UserChoice();
            //was Menu.UserChoice();

        }
    }
}
