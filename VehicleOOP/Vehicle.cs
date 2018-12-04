using System;

namespace VehicleOOP
{
    abstract class Vehicle
    {
        private float fuel = 100;
        public float Fuel
        {
            get { return fuel; }
            protected set { fuel = (float)Math.Round(value, 1); }
        }

        public abstract void Start();
        public abstract void Drive(float distance);
    }
}