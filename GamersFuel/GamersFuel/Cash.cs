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
            Console.WriteLine($"{total:C2}");
            Console.WriteLine("Payment method: Cash");
            Console.Write("Cash received: $ ");
            var userCash = double.Parse(Console.ReadLine());
            var userChnage = userCash - total;
            Console.WriteLine($"Change due: $ {userChnage:C2}");

        }
    }
}
