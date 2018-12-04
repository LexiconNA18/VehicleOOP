using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var fleet = new List<Vehicle>();
            fleet.Add(new Car(100f));
            fleet.Add(new Car(50));
            fleet.Add(new SportsCar());
            fleet.Add(new SportsCar(140));
            fleet.Add(new Motorcycle());

            foreach (var v in fleet)
            {
                v.Start();
                v.Drive(10);
            }

            Motorcycle m = new Motorcycle();
            m.Wheelie();
        }
    }
}

