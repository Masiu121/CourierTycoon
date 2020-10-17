using System;
using System.Collections.Generic;
using System.Text;

namespace CourierTycoon.Components
{
    class ParcelLocker
    {
        int capacityA;
        int capacityB;
        int capacityC;
        int id;
        List<Pack> packs;

        public ParcelLocker(int capA, int capB, int capC)
        {
            capacityA = capA;
            capacityB = capB;
            capacityC = capC;
            packs = new List<Pack>();
        }

        public void addPack(Pack pack)
        {
            packs.Add(pack);
        }

        public void removePack(Pack pack)
        {
            packs.Remove(pack);
        }
    }
}
