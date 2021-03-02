using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GamersFuel
{
    public class Database
    {
        private readonly List<Menu> _products = new List<Menu>();

        private readonly List<Order> _orders = new List<Order>();

        public void LoadMenu()
        {

            using (var reader = new StreamReader("Menu.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var parts = line.Split('|');
                    _products.Add(new Menu
                    {
                        MenuNumber = parts[0],
                        Name = parts[1],
                        Category = parts[2],
                        Description = parts[3],
                        Price = double.Parse(parts[4])
                    });
                }
            }
        }

        public void UserChoice()
        {
            var getMenu = new Database();
            getMenu.LoadMenu();
            int result;
            Console.ForegroundColor = ConsoleColor.Cyan;

            var menuChoice = Console.ReadLine();
            do
            {
                while (!int.TryParse(menuChoice, out result))
                {
                    Console.WriteLine("Please pick a number!");
                    menuChoice = Console.ReadLine();
                }
                if (result <= 12 && result != 0)
                {
                    Console.WriteLine($"Got it! You wanted the number {result}.");
                    Get(result);
                }
                else
                {
                    Console.WriteLine("Please pick a valid menu option!");
                    menuChoice = Console.ReadLine();
                }
            } while (result > 12 || result <= 0);
        }

        public Menu Get(double number)
        {
            Order getReceipt = new Order();
            double total = 0;
            foreach (var item in _products)
            {
                if (double.Parse(item.MenuNumber) == number)
                {
                    Console.WriteLine($"You ordered the {item.Name}.");
                    Console.WriteLine("How many of those would you like?");
                    var quantity = (!int.TryParse(Console.ReadLine(), out int result));
                    _orders.Add(new Order(item, result, item.Price));
                }
            }
            foreach (var item in _orders)
            {
                total += (item.MenuItem.Price) * (item.Quantity);
            }
            Console.WriteLine(total);

            return null;
        }

        public void Print()
        {
            foreach (var item in _products)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{item.MenuNumber} - {item.Name} | {item.Category} | {item.Description} | ${item.Price}");
                Console.ResetColor();
            }

        }


    }
}
