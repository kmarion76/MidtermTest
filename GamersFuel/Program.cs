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
            string userContinue;
            string menuChoice;
            List<Menu> menuInput = new List<Menu>();
            double total = 0;


            //Intro
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Gamers Fuel Coffee Shop!" + "\n");
            Console.WriteLine("Here's our menu:" + "\n");

            //Call method to display menu
            database.Print();
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Get order and calculate total
            do
            {
                Console.WriteLine("\n" + "What would you like? (Please enter a menu number: )");
                menuChoice = Console.ReadLine();

                //Call method to match user's choice with price from that item
                total += database.total(menuChoice);

                menuInput.Add(database.Get(menuChoice));
                menuChoice.Split('-');
                Console.WriteLine("Would you like to order something else? ");
                userContinue = Console.ReadLine();

                //Ask if user wants anything else
                if (userContinue.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    database.Print();
                    Console.WriteLine(string.Empty);
                    Console.WriteLine("What else would you like to order from the menU?");
                }
            } while (userContinue.Equals("y", StringComparison.OrdinalIgnoreCase));

            //Display total
            Console.WriteLine("Total: ");
            Console.Write("$" + Math.Round((total * 1.06), 2));

            foreach (var item in menuInput)
            {
                Console.WriteLine(item);
            }

            Checkout(total);

        }

        private static void Checkout(double total)
        {
            while (true)
            {
                Console.WriteLine("How would you like to pay? Cash, Credit or Check? ");

                string userPayment = Console.ReadLine();
                if (userPayment.Equals("Cash", StringComparison.OrdinalIgnoreCase))
                {
                    Cash.GetPayment(total * 1.06);
                }
                else if (userPayment.Equals("Credit", StringComparison.OrdinalIgnoreCase))
                {
                    Credit.GetPayment(total * 1.06);
                }
                else if (userPayment.Equals("Check", StringComparison.OrdinalIgnoreCase))
                {
                    Check.GetPayment(total * 1.06);
                }
                else
                {
                    Console.WriteLine("Please enter a valid payment method");
                }
            }
        }

    }
}
