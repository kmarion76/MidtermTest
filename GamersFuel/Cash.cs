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

        public static void GetPayment(double total)
        {
            Console.WriteLine("Total: $" + Math.Round(total, 2));
            Console.WriteLine("Payment method: cash");
            Console.WriteLine("Cash received: $");
            double userCash = double.Parse(Console.ReadLine());
            double userChnage = userCash - total;
            Console.WriteLine("Change due: $" + Math.Round(userChnage, 2));

        }
    }
}
