using System;
using System.Collections.Generic;
using System.Text;

namespace viva_practice2
{
    internal class Car:Vehicle
    {
        private int numberOfDoors;
        public Car(string vehicleID, string vehicleBrand, double rentalPricePerDay, int numberOfDoors) : base(vehicleID, vehicleBrand, rentalPricePerDay)
        {
            this.numberOfDoors = numberOfDoors;
        }

        public int NumberOfDoors { get => numberOfDoors; set => numberOfDoors = value; }

        public override void ToString()
        {
            base.ToString();
            Console.WriteLine($"Number of Doors: {numberOfDoors}");
        }
    }
}
