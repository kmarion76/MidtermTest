using System;
using System.Collections.Generic;
using System.Text;

namespace GamersFuel
{
    class Cash : Payment
    {
        public Cash()
        {

        }

        public static void getPayment(double total)
        {
            Console.WriteLine("Total: $" + total);
            Console.WriteLine("Payment method: cash");
            Console.WriteLine("Cash received: ");
            double userCash = int.Parse(Console.ReadLine());
            double userChnage = userCash - total;
            Console.WriteLine("Change due: " + userChnage);

        }
    }
}
