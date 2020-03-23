using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Cars
{
    class MiniCoupe : Car
    {
        public bool isMini => true;

        public void NotForTallPeople()
        {
            if (isMini)
            {
                Console.WriteLine("Sorry, but you can't fit in this car!");
            }
            else
            {
                Console.WriteLine("Come on, let's ride!");
            }
        }
    }
}
