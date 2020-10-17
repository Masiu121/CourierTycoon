using CourierTycoon.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourierTycoon
{
    class LocationData
    {
        string city;
        string platePrefix;
        List<ParcelLocker> lockers = new List<ParcelLocker>();

        public LocationData setLocation(string city)
        {
            this.city = city;
            return this;
        }

        public void addLocker(int capA, int capB, int capC)
        {
            ParcelLocker locker = new ParcelLocker(10, 10, 10);
            lockers.Add(locker);
        }
    }
}
