using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT1
{
    internal class BeerMilk
    {
        public void Song()
        {
            // initialize to 99
            int BottleBeerMilk = 99;

            do
            {
                if (BottleBeerMilk > 1)
                {
                    Console.WriteLine(BottleBeerMilk + " bottles of beer on the wall, " + BottleBeerMilk + " bottles of beer. Take one down and pass it around,");
                }
                else if (BottleBeerMilk == 1)
                {
                    Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer. Take one down and pass it around.");
                }

                // Decrease the number of bottles 
                BottleBeerMilk--;
                // terminating statement untill all conditions are met
            } while (BottleBeerMilk > 0);
        }
    }
}

