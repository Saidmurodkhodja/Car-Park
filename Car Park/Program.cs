using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Park
{
    public class Program
    {
        static void Main(string[] args)
        {
            Engine carEngine = new Engine(250, 2.5,"Diesel","UZ123");
            Chassis carChassis = new Chassis(4, 7574, 550);
            Transmission carTransmission = new Transmission("Manual", 7, "BMW");
            Passenger_Car car = new Passenger_Car(carEngine, carChassis, carTransmission, "123456");
            car.ShowInformation();

            Engine truckEngine = new Engine(400, 0.0, "Electric", "D5678");
            Chassis truckChassis = new Chassis(8, 4586, 5000);
            Transmission truckTransmission = new Transmission("Manual", 8, "BYD");
            Truck truck = new Truck(truckEngine, truckChassis, truckTransmission, "UniqueField456");
            truck.ShowInformation();
        }
    }
}
