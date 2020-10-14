using System;
using System.Collections.Generic;
using System.Text;

namespace CourierTycoon.Components
{
    class Hub
    {
        LocationData location;
        int packs;
        int trucksCount;
        int vansCount;

        public Hub(string location)
        {
            this.location.setLocation(location);
        }
    }
}
