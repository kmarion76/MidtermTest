using System;
using System.Collections.Generic;
using System.Text;

namespace GamersFuel
{
    public class Cash : Payment
    {
        public string UserCash { get; set; }

        public Cash(string userCash)
        {
            UserCash = userCash;
            Type = "Cash";
        }

        public static Cash GetPayment(double total)
        {
            Console.WriteLine($"Grand Total: {total:C2}");
            Console.WriteLine("Payment method: Cash");
            Console.Write("Cash received: $ ");
            var userCash = double.Parse(Console.ReadLine());
            var userChange = userCash - total;
            Console.WriteLine($"Change due: $ {userChange:C2}");

            return new Cash(userCash.ToString());
        }

    }
}
