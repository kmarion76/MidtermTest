using System;
using System.Collections.Generic;
using System.Text;

namespace GamersFuel
{
    class Check : Payment
    {
        public Check()
        {

        }

        public static void getPayment(double total)
        {
            Console.WriteLine("Total: $" + Math.Round(total, 2));
            Console.WriteLine("Method of payment chosen: Check");
            Console.WriteLine("Enter check number");
            int checkNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Approved!");
            

        }
    }
}
