using System;
using System.Collections.Generic;
using System.IO;

namespace GamersFuel
{
    class Program
    {

        static void Main(string[] args)
        {
            string response;
            var menuList = new List<string>();
            string fileContents;
            string[] menuArray;
            string customerOrder;
            Menu myObj = new Menu();

            Console.WriteLine("What do you want?");
            do
            {
                using (var reader = new StreamReader("Menu.txt"))
                {
                    while ((fileContents = reader.ReadLine()) != null)
                    {
                        menuList.Add(fileContents);
                        menuArray = menuList.ToArray();
                        menuArray = fileContents.Split('|');
                        myObj.Price = menuArray[3];

                    }


                }

                customerOrder = Console.ReadLine().ToLower();
                if (customerOrder == "1")
                {
                    Console.WriteLine("You ordered: {Noob Tears}");
                    Console.WriteLine("Your price is {$4.99}. Would you like anything else");
                }
                Console.WriteLine("Would you like anything else? (y/n)");
                response = Console.ReadLine().ToLower();
            } while (response == "y");







        }

    }
}
