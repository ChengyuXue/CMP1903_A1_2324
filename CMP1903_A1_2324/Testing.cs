using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        // Method to test the Die class
        public static void TestDie()
        {
            Die die = new Die();
            int rollResult = die.Roll();
            
            // Test that the rolled value is between 1 and 6
            Debug.Assert(rollResult >= 1 && rollResult <= 6, "Die roll result is out of range.");
            Console.WriteLine("Die Roll Result: " + rollResult);
        }

        // Method to test the Game class
        public static void TestGame()
        {
            int expectedTotal = 0;
            for (int i = 0; i < 3; i++)
            {
                expectedTotal += new Die().Roll(); // Roll a die and add its value to the expected total
            }

            int actualTotal = Game.RollThreeDice();

            // Test that the total of three dice rolls matches the expected total
            Debug.Assert(actualTotal == expectedTotal, "Total of three dice rolls does not match the expected total.");
            Console.WriteLine("Total of three dice rolls: " + actualTotal);
        }

        // Main method to run the tests
        public static void Main(string[] args)
        {
            TestDie();
            TestGame();
        }
    }
}