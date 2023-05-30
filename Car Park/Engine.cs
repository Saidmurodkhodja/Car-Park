using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Car_Park
{
    public class Engine
    {
        public int Power { get; set; }
        public double Volume { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }

        public Engine(int power, double volume, string type, string serialNumber) { 
            Power = power;
            Volume = volume;
            Type = type;
            SerialNumber = serialNumber;
        }
    }
}
