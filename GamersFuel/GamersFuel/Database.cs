﻿using System;
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

        public Menu Get(string number)
        {
            List<double> menuInput = new List<double>();

            foreach (var item in _products)
            {
                if (item.MenuNumber == number)
                {
                    Console.WriteLine($"Got it! You ordered: {item.Name}.");
                    menuInput.Add(item.Price);

                    Console.WriteLine($"Your total is {menuInput[0]}");
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
