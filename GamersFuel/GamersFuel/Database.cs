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

        //public Menu Get(string userInput)
        //{
        //    List<double> menuInput = new List<double>();
        //    var getMenu = new Database();
        //    getMenu.LoadMenu();
        //    int number = 0;
        //    userInput = Console.ReadLine();
        //    do
        //    {
        //        foreach (var item in _products)
        //        {
        //            while (!int.TryParse(userInput, out number))
        //            {
        //                Console.WriteLine("Please pick a number!");
        //                userInput = Console.ReadLine();
        //            }
        //            if (item.MenuNumber == number || number <= 12 || number != 0)
        //            {
        //                Console.WriteLine($"Got it! You ordered: {item.Name}.");
        //                menuInput.Add(item.Price);

        //                Console.WriteLine($"Your total is {menuInput[0]}");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Please pick a valid menu option!");
        //                userInput = Console.ReadLine();
        //            }
        //        }
        //    } while (number <= 12 && number != 0);

        //    var sum = menuInput.Sum();
        //    return null;
        //}

        public void UserChoice()
        {
            var getMenu = new Database();
            getMenu.LoadMenu();
            int result;
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
            List<double> menuInput = new List<double>();
            foreach (var item in _products)
            {
                if (double.Parse(item.MenuNumber) == number)
                {
                    Console.WriteLine($"You ordered the {item.Name}.");
                    menuInput.Add(item.Price);
                    Console.WriteLine($"Your total is ${menuInput[0]}");
                }
            }
            var sum = menuInput.Sum();
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
