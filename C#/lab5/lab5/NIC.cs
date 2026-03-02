using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    enum NICType
    {
        Ethernet,
        TokenRing
    }
    internal class NIC
    {
        public string Manufacture { get;  }
        public string MACAddress { get;  }
        public NICType Type { get; }

        private static NIC instance;
        private NIC(string manufacture, string mac, NICType type)
        {
            Manufacture = manufacture;
            MACAddress = mac;
            Type = type;
        }

        public static NIC GetInstance(string manufacture, string mac, NICType type)
        {
            if (instance == null)
            {
                instance = new NIC(manufacture, mac, type);
            }

            return instance;
        }

    }
}
