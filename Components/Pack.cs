using System;
using System.Collections.Generic;
using System.Text;

namespace CourierTycoon.Components
{
    class Pack
    {
        long id;
        string client;
        ParcelLocker parcelLocker;

        public Pack(Client client, ParcelLocker parcelLocker)
        {
            this.client = client;
            this.parcelLocker = parcelLocker;
        }
    }
}
