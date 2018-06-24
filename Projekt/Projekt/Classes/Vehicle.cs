using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Vehicle
    {
     
        double vehicleCapacity;
        double vehicleVolume;
        string vehicleRegistration;

        public Vehicle(string vehicleRegistration, double vehicleCapacity, double vehicleVolume)
        {            
            this.vehicleCapacity = vehicleCapacity;
            this.vehicleVolume = vehicleVolume;
            this.vehicleRegistration = vehicleRegistration;
        }

        public string VehicleRegistration
        {
            get
            {
                return vehicleRegistration;
            }
        }

        public double VehicleCapacity
        {
            get
            {
                return vehicleCapacity;
            }
        }

        public double VehicleVolume
        {
            get
            {
                return vehicleVolume;
            }
        }

    }
}
