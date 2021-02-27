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
        public static void UserChoice()
        {
            List<Menu> menuInput = new List<Menu>();
            var getMenu = new Database();
            getMenu.LoadMenu();
            var menuChoice = Console.ReadLine();
            menuInput.Add(getMenu.Get(menuChoice));
            menuChoice.Split('-');
            foreach (var item in menuInput)
            {
                Console.WriteLine(item);
            }
        }


    }
}
