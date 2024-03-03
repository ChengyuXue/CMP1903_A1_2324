using System;
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
        public static void Test()
        {
            // Test Die class
            Die die = new Die();
            int rollValue = die.Roll();
            Debug.Assert(rollValue >= 1 && rollValue <= 6, "Die roll should be between 1 and 6");

            // Test Game class
            Game game = new Game();
            int sum = game.RollDice();
            Debug.Assert(sum >= 3 && sum <= 18, "Sum of three dice should be between 3 and 18");
        }
    }
}
