using System;
using System.Collections.Generic;
using System.Text;

namespace GamersFuel
{
    class Credit : Payment
    {
        public string CardNumber { get; set; }

        public string CardDate { get; set; }

        public string CardCVV { get; set; }

        public string Type { get; set; }
        public Credit(string cardNumber, string cardDate, string cardCVV)
        {
            CardNumber = cardNumber;
            CardDate = cardDate;
            CardCVV = cardCVV;
            Type = "Credit";
        }

        public static Credit GetPayment(double total)
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
            Console.Write("Please enter expiration date: (mmyy)");
            var cardDate = Console.ReadLine();
            while (!int.TryParse(cardDate, out results))
            {
                Console.WriteLine("Please enter a valid expiration date!");
                cardDate = Console.ReadLine();
            }
            Console.Write("Please enter CVV code: ");
            var cardCVV = Console.ReadLine();
            while (!int.TryParse(cardCVV, out results))
            {
                Console.WriteLine("Please enter a valid CVV number!");
                cardCVV = Console.ReadLine();
            }
            Console.WriteLine("...Approved!");

            return new Credit(cardNumber, cardDate, cardCVV);
        }
    }
}
