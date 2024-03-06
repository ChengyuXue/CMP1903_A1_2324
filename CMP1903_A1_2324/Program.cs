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
            // Create a Testing object to verify the output and operation of the other classes
            Game game = Testing.Test();

            // Roll dice continuously until the user decides to stop
            while (true)
            {
                // Ask the user if they want to roll again
                Console.WriteLine("Press (Y) to roll again or press anyother key to exit the game");
                char response = char.ToUpper(Console.ReadKey().KeyChar);
                // An if else statement that will either run the RollDice method or exit the loop
                if (response == 'Y')
                {
                    Console.WriteLine("\nRolling dice");
                    game.RollDice();
                }
                else
                {
                    Console.WriteLine("\nExiting the program");
                    break;
                }

            }
        }

    }
}
