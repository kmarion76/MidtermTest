using System;
using System.Collections.Generic;
using System.Text;

namespace GamersFuel
{
    public class Menu
    {
        public string MenuNumber { get; set; }
        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        public Menu()
        {

        }

        public static double Total(double price)
        {
            return price + price;
        }

        
    }
}
