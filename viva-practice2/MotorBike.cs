using System;
using System.Collections.Generic;
using System.Text;

namespace viva_practice2
{
    internal class MotorBike : Vehicle
    {
        private int engineCC;
        public MotorBike(string vehicleID, string vehicleBrand, double rentalPricePerDay, int engineCC) : base(vehicleID, vehicleBrand, rentalPricePerDay)
        {
            this.engineCC = engineCC;
        }

        public int EngineCC { get => engineCC; set => engineCC = value; }

        public override void ToString()
        {
            base.ToString();
            Console.WriteLine($"Engine CC: {engineCC}");
        }
    }
}
