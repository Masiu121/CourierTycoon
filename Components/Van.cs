using System;
using System.Collections.Generic;
using System.Text;

namespace CourierTycoon.Components
{
    class Van
    {
        Hub owner;
        int capacity;
        string plate;

        public Van(Hub owner, int capacity)
        {
            this.owner = owner;
            this.capacity = capacity;
        }
    }
}
