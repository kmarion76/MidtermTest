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
          
            double total = 0;


            //Intro
           

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
