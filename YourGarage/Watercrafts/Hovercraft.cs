using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Watercrafts
{
    class Hovercraft : Watercraft
    {
        public bool CanMoveOnSand = true;

        public void ShootMissle()
        {
            if (CanMoveOnSand)
            {
                Console.WriteLine("I'm a hovercraft, watch me soar!");
            }
        }

    }
}
