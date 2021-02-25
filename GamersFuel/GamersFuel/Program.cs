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
            var menuList = new List<string>();
            do
            {
                using (var reader = new StreamReader("Menu.txt"))
                {
                    string fileContents;
                    while ((fileContents = reader.ReadLine()) != null)
                    {
                        menuList.Add(fileContents);
                        string[] menuArray = menuList.ToArray();
                        menuArray = fileContents.Split('|');
                        Console.WriteLine(menuArray[2]);
                    }

                }
                Console.WriteLine("Would you like to order more? (y/n)");
                response = Console.ReadLine().ToLower();
            } while (response == "y");


            //Console.WriteLine("What do you want?");
            //var response = Console.ReadLine().ToLower();
            //if (response == "n")
            //{
            //    Console.WriteLine(arrayMenu[0]);
            //}

            //Menu myObj = new Menu();
            //myObj.Name = arrayMenu[0];
            //myObj.Category = arrayMenu[1];
            //Console.WriteLine(myObj.Name);
            //Console.WriteLine(myObj.Category);
        }
    }
}
