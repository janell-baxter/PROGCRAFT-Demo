using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static PROGCRAFT_Demo.Utility;

namespace PROGCRAFT_Demo
{
    class Game
    {

        public void Run()
        {
            Person Player = new Person();
            Player.Name = "Anonymous Player";

            Title = "Crafting System Demo";
            //concatenation
            WriteLine("Welcome " + Player.Name);

            //composite formatting
            WriteLine("Welcome {0}", Player.Name);

            //interpolation formatting
            WriteLine($"Welcome {Player.Name}");

            Item redDye = new Item();
            redDye.Name = "Red Dye";
            redDye.Price = 3.50f;
            WriteLine($"{redDye.Name} is {redDye.Price.ToString("c")} per vial.");

            //Utility.Pause();
            Pause();
        }
    }
}
