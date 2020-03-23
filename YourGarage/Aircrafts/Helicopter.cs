using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Aircrafts
{
    class Helicopter : Aircraft
    {
        public bool HasRotors => true;
        public bool HasWings => true;
        public void NotAnAirplane()
        {
            if(HasRotors && HasWings)
            {
                Console.WriteLine("You are a helicopter!");
            }
        }
       
    }
}
