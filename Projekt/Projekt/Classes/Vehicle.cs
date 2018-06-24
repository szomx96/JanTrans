using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Vehicle
    {
     
        string vehicleCapacity;
        string vehicleVolume;
        string vehicleRegistration;

        public Vehicle(string vehicleRegistration, string vehicleCapacity, string vehicleVolume)
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

        public string VehicleCapacity
        {
            get
            {
                return vehicleCapacity;
            }
        }

        public string VehicleVolume
        {
            get
            {
                return vehicleVolume;
            }
        }

    }
}
