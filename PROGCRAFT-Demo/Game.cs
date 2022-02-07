using static PROGCRAFT_Demo.Utility;
using static System.Console;
using static PROGCRAFT_Demo.Utilities.LoadData;
using System.Collections.Generic;

namespace PROGCRAFT_Demo
{
    class Game
    {
        Person Player = new Person();
        Person Trader = new Person();
        public void Run()
        {
            AddItemsIntoInventory(Player);
            Print(ShowAllItemsInList(Player.Inventory));


            Pause();
            SetUpGame();
            ShowWelcome();
            Pause();
            Print("This is what is in your inventory...");
            Print(ShowAllItemsInList(Player.Inventory));
            //Item redDye = new Item();
            //redDye.Name = "Red Dye";
            //redDye.Price = 3.50f;
            //Print($"{redDye.Name} is {redDye.Price.ToString("c")} per vial.");

            //Utility.Pause();
            Pause();
        }
        private void SetUpGame()
        {
            Player.Name = "Anonymous Player";
            Title = "Crafting System Demo";
        }
        private void ShowWelcome()
        {
            //concatenation
            //Print("Welcome " + Player.Name);

            //composite formatting
            //Print("Welcome {0}", Player.Name);

            //interpolation formatting
            Print($"Welcome {Player.Name}");
            //pull in welcome text from external file
            Print(LoadTextFromFile("../../data/welcome.txt"));

            //pull in instructions from external file and show them
            Print(LoadTextFromFile("../../data/instructions.txt"));

            Player.Inventory = CreateItemsFromTextFile("../../data/items.txt");
        }

        


    }
    }



