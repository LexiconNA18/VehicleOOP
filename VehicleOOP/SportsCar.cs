using System;

namespace VehicleOOP
{
    class SportsCar : Car
    {
        public SportsCar() 
            : base(120)
        {
            fuelConsumtion = 1.9f;
        }

        public SportsCar(float fuelLevel) 
            : base(fuelLevel)
        { }

        protected override void SoundStart()
        {
            Console.WriteLine("WRAOUM");
        }
        protected override void DriveSound(float distance)
        {
            Console.WriteLine($"WRÖÖÖRN x {distance:0:0}");
        }
    }
}

