using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Game object and call its method
            Game game = new Game();
            int total = game.RollThreeDice();
            Console.WriteLine("Total of three dice rolls: " + total);

            // Create a Testing object to verify the output and operation of other classes
            Testing.TestDie();
            Testing.TestGame();
        }
    }
}