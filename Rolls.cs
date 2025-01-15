using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class Rolls
    {
        public int[] Roll(int numRolls)
        {
            // create an empty array that has numRolls number of spots to store the sum from each roll
            int[] rollTotals = new int[numRolls];
          
            // for every roll generate two random numbers 1-6 and find the total
            // store this total to the rollTotals array and then return the array
            for (int roll = 0; roll < numRolls; roll++)
            {

                int rollValue1 = 0;
                int rollValue2 = 0;

                Random rnd = new Random();
                rollValue1 = rnd.Next(1, 7);
                rollValue2 = rnd.Next(1, 7);
                rollTotals[roll] = rollValue1 + rollValue2;

            }

            return rollTotals;
        }
    }
}
