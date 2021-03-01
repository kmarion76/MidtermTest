using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GamersFuel
{
    public class Menu
    {
        public string MenuNumber { get; set; }
        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public Menu()
        {

        }
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
                }
                else
                {
                    Console.WriteLine("Please pick a valid menu option!");
                    menuChoice = Console.ReadLine();

                }
            } while (result > 12 || result <= 0);


        }

    }
}
