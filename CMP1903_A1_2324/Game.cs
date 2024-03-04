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

        // Constructor
        public Game()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }

        // Method to roll three dice, sum their values, and report the total
        public int RollDice()
        {
            int total = 0;
            for (int i = 0; i < dice.Length; i++)
            {
                total += dice[i].Roll();
            }
            Console.WriteLine($"Total of three dice rolls: {total}");
            return total;
        }
    }
}