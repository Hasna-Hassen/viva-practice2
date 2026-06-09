using System;
using System.Collections.Generic;
using System.Text;

namespace viva_practice2
{
    public abstract class Vehicle
    {
        private string vehicleID;
        private string vehicleBrand;
        private double rentalPricePerDay;

        public List<Vehicle> vehicles = new List<Vehicle>();

        protected Vehicle(string vehicleID, string vehicleBrand, double rentalPricePerDay)
        {
            this.vehicleID = vehicleID;
            this.vehicleBrand = vehicleBrand;
            this.rentalPricePerDay = rentalPricePerDay;
        }

        public string VehicleID { get => vehicleID; set => vehicleID = value; }
        public string VehicleBrand { get => vehicleBrand; set => vehicleBrand = value; }
        public double RentalPricePerDay { get => rentalPricePerDay; set => rentalPricePerDay = value; }

        public virtual void ToString()
        {
            Console.WriteLine($"Vehicle ID: {vehicleID}, Brand: {vehicleBrand}, Rental Price per Day: {rentalPricePerDay}");
        }
    }
}
