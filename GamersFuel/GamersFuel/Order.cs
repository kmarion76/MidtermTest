using System;
using System.Collections.Generic;
using System.Text;

namespace GamersFuel
{
    public class Order : Menu
    {
        public Menu MenuItem { get; set; }

        public int Quantity { get; set; }

        public double Cost { get; set; }

        public string MenuNumber { get; set; }
        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
        public Order(Menu menuItem, int quantity, double cost)
        {
            MenuItem = menuItem;
            Quantity = quantity;
            Cost = cost;
        }

        public Order()
        {
        }

        public void FinalPrice()
        {
            Console.WriteLine($"{MenuItem} - {Quantity} - {Cost}");
            
        }
    }
}
