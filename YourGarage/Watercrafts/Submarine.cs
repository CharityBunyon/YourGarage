using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Watercrafts
{
    class Submarine : Watercraft
    {
        public bool IsWarVessel = true;

        public void ShootMissle()
        {
            if (IsWarVessel)
            {
                Console.WriteLine("It's about to go down!");
            }
        }

        
    }
}
