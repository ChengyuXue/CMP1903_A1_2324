using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        // Property to hold the current die value
        public int Value { get; private set; }

        // Random number generator for rolling the die
        private static Random random = new Random();

        // Method to roll the die and return the result
        public int Roll()
        {
            // Generate a random number between 1 and 6 for the die roll
            Value = random.Next(1, 7);
            return Value;
        }
    }
}
