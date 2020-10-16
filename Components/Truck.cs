using System;
using System.Collections.Generic;
using System.Text;

namespace CourierTycoon.Components
{
    class Truck
    {
        Hub owner;
        int capacity;
        string plate;

        public Truck(Hub owner, int capacity)
        {
            this.owner = owner;
            this.capacity = capacity;
        }
    }
}
