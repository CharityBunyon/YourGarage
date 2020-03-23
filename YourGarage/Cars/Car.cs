using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    abstract class Car : Vehicle
    {
        // need methods fore refueling, driving, and braking
        public void Refueling()
        {
            Console.WriteLine("Grabbing gas for my car.");
        }

        public void Driving()
        {
            Console.WriteLine("Currently driving my car.");
        }

        public void Braking()
        {
            Console.WriteLine("Currently stopping my car.");
        }
    }
}
