using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Aircrafts
{
    class HotAirBalloon : Aircraft
    {
        public bool HasHotAir => true;

        public void IsFloating()
        {
            if (HasHotAir == true)
            {
                Console.WriteLine("$I think I'm getting sick.");
            }
        }

    }

}
