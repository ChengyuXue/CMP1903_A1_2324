using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private static Random random = new Random();

        private static int RollDie()
        {
            return random.Next(1,7)
        }

        public static int RollThreeDice()
        {
            int total = 0:
            for(int i = 0; i < 3; i++)
            {
                total +=RollDie()
            }
            return total
        }

        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods

    }
}
