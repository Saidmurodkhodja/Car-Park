using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Park
{
    public class Bus
    {
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }
        public string UniqueField { get; set; }

        public Bus (Engine engine, Chassis chassis, Transmission transmission, string uniqueField)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            UniqueField = uniqueField;
        }   
        public void ShowInformation()
        {

            Console.WriteLine("Bus");
            Console.WriteLine("Engine Power: " + Engine.Power);
            Console.WriteLine("Engine Volume: " + Engine.Volume);
            Console.WriteLine("Engine Type: " + Engine.Type);
            Console.WriteLine("Engine Serial Number: " + Engine.SerialNumber);
            Console.WriteLine("Chassis Wheels Number: " + Chassis.WheelsNumber);
            Console.WriteLine("Chassis Number: " + Chassis.Number);
            Console.WriteLine("Chassis Permissible Load: " + Chassis.PermissibleLoad);
            Console.WriteLine("Transmission Type: " + Transmission.Type);
            Console.WriteLine("Transmission Number of Gears: " + Transmission.NumberOfGears);
            Console.WriteLine("Transmission Manufacturer: " + Transmission.Manufacturer);
            Console.WriteLine("Truck Unique Field: " + UniqueField);
        }
    }
}
