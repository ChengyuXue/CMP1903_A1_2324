using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        //Array to hold three dice objects
        private Die[] dice = new Die[3];

        // Constuctor to initialise the game object with three Die objects
        public Game()
        {
            // Loop thourgh each element of the array and initialise it with new Die object
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }

        // Method to roll three dice, sum their values, and report the total and individual die rolls
        public int RollDice()
        {
            int total = 0;
            // Check to ensure that dice array is not null before attempting to access its elements
            if (dice != null)
            {
                for (int i = 0; i < dice.Length; i++)
                {
                    int rollResult = dice[i].Roll();
                    Console.WriteLine($"Die {i + 1} rolled: {rollResult}");
                    total += rollResult;
                }
            }
            else
            {
                Console.WriteLine("Error: Dice array is not initialised properly.");
                return -1;
            }
            Console.WriteLine($"Total of three dice rolls: {total}");
            return total;
        }
    }
}
