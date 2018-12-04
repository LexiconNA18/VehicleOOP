using System;

namespace VehicleOOP
{
    class Car : Vehicle {
       
        protected bool started = false;
        protected float fuelConsumtion = 1.5f;

        public Car(float fuelLevel)
        {
            Fuel = fuelLevel;
        }

        public override void Start()
        {
            started = true;
            SoundStart();
        }

        protected virtual void SoundStart()
        {
            Console.WriteLine("Wroom");
        }

        public override void Drive(float distance) {
            if (started && Fuel > 0)
            {
                float maxDistance = Fuel / fuelConsumtion;
                distance = Math.Min(distance, maxDistance);
                Fuel = Fuel - distance * fuelConsumtion;
                DriveSound(distance);
            }
            else {
                Console.WriteLine("...");
            }
        }

        protected virtual void DriveSound(float distance)
        {
            Console.WriteLine($"Ööörn x {distance:0.0}");
        }
    }
}

