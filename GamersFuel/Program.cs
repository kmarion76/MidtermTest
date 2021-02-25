using System;

namespace GamersFuel
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double total = 0;
            Console.WriteLine("How would you like to pay? Cash, Credit or Check? ");

            string userPayment = Console.ReadLine();
            if (userPayment.Equals("Cash", StringComparison.OrdinalIgnoreCase))
            {
                Cash.getPayment(total);
            }
            else if (userPayment.Equals("Credit", StringComparison.OrdinalIgnoreCase))
            {
                Credit.getPayment(total);
            }
            else if (userPayment.Equals("Check", StringComparison.OrdinalIgnoreCase))
            {
                Check.getPayment(total);
            }
            else
            {
                Console.WriteLine("Please enter a valid payment method");
            }
        }


    }
}
