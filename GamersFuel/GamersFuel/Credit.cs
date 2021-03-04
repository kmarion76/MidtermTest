using System;
using System.Collections.Generic;
using System.Text;

namespace GamersFuel
{
    class Credit : Payment
    {
        public Credit()
        {

        }

        public static void GetPayment(double total)
        {
            Console.WriteLine($"{total:C2}");
            Console.WriteLine("Payment method: Credit");
            Console.Write("Please enter card number: ");
            var cardNumber = Console.ReadLine();
            long result;
            int results;
            while (!long.TryParse(cardNumber, out result))
            {
                Console.WriteLine("Please enter a card number!");
                cardNumber = Console.ReadLine();
            }
            Console.Write("Please enter expiration date: ");
            var cardDate = Console.ReadLine();
            while (!int.TryParse(cardDate, out results))
            {
                Console.WriteLine("Please enter a valid expiration date!");
                cardDate = Console.ReadLine();
            }
            Console.Write("Please enter CVV code: ");
            string cardCVV = Console.ReadLine();
            while (!int.TryParse(cardCVV, out results))
            {
                Console.WriteLine("Please enter a valid CVV number!");
                cardCVV = Console.ReadLine();
            }
            Console.WriteLine("...Approved!");


        }
    }
}
