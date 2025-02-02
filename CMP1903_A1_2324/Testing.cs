﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        // Method to test the Die and Game classes
        public static Game Test()
        {
            Console.WriteLine("Testing Die class and Game class");

            // Test Die class
            Die die = new Die();
            int rollValue = die.Roll();
            Debug.Assert(rollValue >= 1 && rollValue <= 6, "Error: Die roll should be between 1 and 6");
            Console.WriteLine("Die class test passed");


            // Test Game class
            Game game = new Game();
            int sum = game.RollDice();
            Debug.Assert(sum >= 3 && sum <= 18, "Error: Sum of three dice should be between 3 and 18");
            Console.WriteLine("Game class test passed");

            // Return the game object for use in roll dice continuously
            return game;
        }
    }
}
