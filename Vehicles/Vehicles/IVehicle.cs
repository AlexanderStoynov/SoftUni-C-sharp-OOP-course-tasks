﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicle
    {
        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public double TankCapacity { get; set; }

        public bool IsEmpty { get; set; }

        public bool CanDrive(double km);
        public void Refuel(double fuel);
        public void Drive(double km);
       
    }
}
