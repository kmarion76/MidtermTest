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

        public string Price { get; set; }

        public Menu()
        {

        }
        public List<int> UserChoice()
        {
            List<int> menuInput = new List<int>();
            //var getMenu = new Database();
            //getMenu.LoadMenu();
            Menu getPrice = new Menu();
            int result;
            do
            {
                var menuChoice = Console.ReadLine();

                while (!int.TryParse(menuChoice, out result))
                {
                    Console.WriteLine("Please pick a valid menu option!");
                    menuChoice = Console.ReadLine();
                }
                if (result <= 12 && result != 0)
                {
                    menuInput.Add(result);
                    Console.WriteLine($"Got it! You wanted the number {result}.");
                    getPrice.GetPrice(); // New
                }
                else
                {
                    Console.WriteLine("Please pick a valid menu option!");

                }
            } while (result > 12 || result == 0);


            return menuInput;

            //List<Menu> menuInput = new List<Menu>();
            //var getMenu = new Database();
            //getMenu.LoadMenu();
            //var menuChoice = Console.ReadLine();
            //while (!double.TryParse(menuChoice, out double result))
            //{
            //    Console.WriteLine("Please pick a number!");
            //    menuChoice = Console.ReadLine();
            //}
            //menuInput.Add(getMenu.Get(menuChoice));
        }

        public List<string> GetPrice()
        {
            Database getMenu = new Database();
            Menu choice = new Menu();
            var getChoice = choice.UserChoice();
            getMenu.LoadMenu();

            if (getChoice.Contains(0))
            {
                Console.WriteLine($"Your total: {MenuNumber}");
                
            }

            return null;
        }

    }
}
