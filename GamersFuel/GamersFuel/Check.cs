using System;
using System.Collections.Generic;
using System.Text;

namespace GamersFuel
{
    class Check : Payment
    {
        public string CheckNumber { get; set; }

        public string Type { get; set; }

        public Check(string checkNumber)
        {
            CheckNumber = checkNumber;
            Type = "Check";
        }

        public static Check GetPayment(double total)
        {
            Console.WriteLine($"{total:C2}");
            Console.WriteLine("Method of payment chosen: Check");
            Console.Write("Enter check number: ");
            var checkNumber = Console.ReadLine();
            long result;
            while (!long.TryParse(checkNumber, out result))
            {
                Console.WriteLine("Please enter a valid check number!");
                checkNumber = Console.ReadLine();
            }
            Console.WriteLine("Approved!");

            return new Check(checkNumber);
        }
    }
}
