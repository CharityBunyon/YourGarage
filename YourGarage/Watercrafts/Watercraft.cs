using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    abstract class Watercraft : Vehicle
    {
        public void Refueling()
        {
            Console.WriteLine("Grabbing gas for my watercraft.");
        }

        public void Driving()
        {
            Console.WriteLine("Currently driving my watercraft.");
        }
    }
}
