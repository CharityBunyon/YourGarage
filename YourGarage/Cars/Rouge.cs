using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Cars
{
    class Rouge : Car
    {
        private const string Value = "Your ride is BOOORRRING!!!";
        
        public bool isMostPopularCar => true;

        public void NotSpecial()
        {
            if (isMostPopularCar)
            {
                Console.WriteLine(Value);
            }
            else
            {
                Console.WriteLine("Come on, let's ride!");
            }
        }
    }
}
