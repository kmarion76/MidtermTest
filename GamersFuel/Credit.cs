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

        public static void getPayment(double total)
        {
            Console.WriteLine("Total: $" + Math.Round(total, 2));
            Console.WriteLine("Payment method: Credit");
            Console.WriteLine("Please enter card number: ");
            int cardNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter expiration date");
            string cardDate = Console.ReadLine();
            Console.WriteLine("...Approved!");


        }
    }
}
