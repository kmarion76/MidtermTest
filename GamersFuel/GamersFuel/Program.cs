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

            do
            {
                Console.WriteLine("Here's our menu:" + "\n");
                database.Print();
                Console.ForegroundColor = ConsoleColor.Cyan;

                database.DisplayCart();

                Console.Write("\n" + "What would you like? (Please enter a menu number): ");
                database.UserChoice();

                Console.Write("Would you like to order more? (y/n): ");

            } while (Continue());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Here's your receipt:");
            Console.ForegroundColor = ConsoleColor.White;
            database.Receipt();
            var total = database.GetSubtotal();
            Checkout(total);

            Console.WriteLine();
            database.FinalReceipt();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Thanks for visiting Gamers Fuel Coffee Shop!");

        }




        private static bool Continue()
        {
            int counter = 3;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                string response = Console.ReadLine().ToLower();

                if (response == "y")
                {
                    Console.Clear();
                    return true;
                }

                if (response == "n")
                {
                    return false;
                }

                counter--;

                if (counter <= 0)
                {
                    return false;
                }
                Console.Write("Please enter a valid selection ('y' or 'n')!" + "\n");

            } while (true);
        }
        private static void Checkout(double total)
        {
            Database getSubtotal = new Database();
            Console.WriteLine("How would you like to pay? Cash, Credit or Check? ");
            string userPayment = Console.ReadLine();
            switch (userPayment.ToLower())
            {
                case "cash":
                    Cash.GetPayment(total * 1.06);
                    break;
                case "credit":
                    Credit.GetPayment(total * 1.06);
                    break;
                case "check":
                    Check.GetPayment(total * 1.06);
                    break;
                default:
                    Console.WriteLine("Please enter a valid payment method");
                    break;
            }

            //string userPayment = Console.ReadLine();
            //if (userPayment.Equals("Cash", StringComparison.OrdinalIgnoreCase))
            //{
            //    Cash.GetPayment(total * 1.06);
            //}
            //else if (userPayment.Equals("Credit", StringComparison.OrdinalIgnoreCase))
            //{
            //    Credit.GetPayment(total * 1.06);
            //}
            //else if (userPayment.Equals("Check", StringComparison.OrdinalIgnoreCase))
            //{
            //    Check.GetPayment(total * 1.06);
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid payment method");
            //}

        }
    }
}
