using System;
using System.Collections.Generic;
using System.Text;

namespace CourierTycoon
{
    class LocationData
    {
        string city;
        string platePrefix;

        public LocationData setLocation(string city)
        {
            this.city = city;
            return this;
        }
    }
}
