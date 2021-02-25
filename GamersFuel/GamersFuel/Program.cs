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
            var menuList = new List<Menu>();
            Console.WriteLine("What do you want?");
            do
            {
                using (var reader = new StreamReader("Menu.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var parts = line.Split('|');
                        var menu = new Menu
                        {
                            MenuNumber = parts[0],
                            Name = parts[1],
                            Category = parts[2],
                            Description = parts[3],
                            Price = parts[4]
                        };
                        menuList.Add(menu);
                    }
                }
                foreach (var item in menuList)
                {
                    Console.WriteLine(item);
                }
                //var customerOrder = Console.ReadLine().ToLower();
                //if (customerOrder == "1")
                //{
                //    Console.WriteLine($"You ordered: {newMenu[0]}");
                //    Console.WriteLine("Your price is {$4.99}. Would you like anything else");
                //}
                Console.WriteLine("Would you like anything else? (y/n)");
                response = Console.ReadLine().ToLower();
            } while (response == "y");







        }

    }
}
