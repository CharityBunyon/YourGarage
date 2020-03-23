using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Aircraft : Vehicle
    {
        // need methods fore refueling, flying, and landing
        public void Refueling()
        {
            Console.WriteLine("Grabbing gas for my aircraft.");
        }

        public void Flying()
        {
            Console.WriteLine("Currently flying my aircraft.");
        }

        public void Landing()
        {
            Console.WriteLine("Currently landing my aircraft.");
        }
    }
}
