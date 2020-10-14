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

        public ParcelLocker(int capA, int capB, int capC)
        {
            capacityA = capA;
            capacityB = capB;
            capacityC = capC;
        }
    }
}
