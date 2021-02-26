using System;
using System.Collections.Generic;
using System.IO;
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
                        Price = parts[4]
                    });
                }
            }
        }

        public Menu Get(string number)
        {
            foreach (var item in _products)
            {
                if (item.MenuNumber == number)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
