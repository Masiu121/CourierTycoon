using System;
using System.Collections.Generic;
using System.Text;

namespace CourierTycoon.Components
{
    class Pack
    {
        long id;
        int cap; //capA - 0, capB - 1, capC - 2
        Client client;
        ParcelLocker parcelLocker;

        public Pack(Client client, ParcelLocker parcelLocker)
        {
            this.client = client;
            this.parcelLocker = parcelLocker;
        }
    }
}
