using System;
using System.Collections.Generic;
using System.Text;

namespace CourierTycoon.Components
{
    class Hub
    {
        LocationData location;
        List<Pack> packs;
        List<Truck> trucks;
        List<Van> vans;

        public Hub(string location)
        {
            this.location.setLocation(location);
            trucks = new List<Truck>();
            vans = new List<Van>();
        }

        public void addTruck(int capacity)
        {
            Truck truck = new Truck(this, capacity);
            trucks.Add(truck);
        }

        public void addVan(int capacity)
        {
            Van van = new Van(this, capacity);
            vans.Add(van);
        }

        public void addParcel(ParcelLocker parcelLocker, Client client)
        {
            Pack pack = new Pack(client, parcelLocker);
            packs.Add(pack);
        }
    }
}
