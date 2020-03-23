using System;
using System.Collections.Generic;
using System.Linq;
using YourGarage.Cars;
using YourGarage.Watercrafts;
using YourGarage.Aircrafts;

namespace YourGarage
{
    class Program
    {
        public static void Main()
        {
            // I made new instances of each car, aircraft, and watercraft
            var rougeSL = new Rouge();
            var barracuda = new Submarine();
            var chopper = new Helicopter();


            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()

            var canFly = new List<Aircraft> { chopper };
            foreach(var aircraft in canFly)
            {
                aircraft.Flying();
            }

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()

            var canOperateOnRoads = new List<Car> { rougeSL };
            foreach(var car in canOperateOnRoads)
            {
                car.Driving();
            }
            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            var canOperateOnWater = new List<Watercraft> { barracuda };
            foreach (var watercraft in canOperateOnWater)
            {
                watercraft.Driving();
            }
        }
    }
}
