using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    abstract class Vehicle
    {
        public int Feul { get; set; }
        public ColorOfVehicle Color { get; set; }
        public int People { get; set; }

        public virtual void Refuel(int gallons)
        {
            Console.WriteLine($"You need {gallons} to refeul.");
        }
    }

    enum ColorOfVehicle
    {
        Goldenrod,
        Blue,
        Pink,
        MotherOfPearl,
        Black,
        Silver
    }
}
