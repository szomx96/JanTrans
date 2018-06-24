using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Vehicle
    { 
        int vehicleID;
        double vehicleCapacity;
        double vehicleVolume;
        string vehicleRegistration;

        public Vehicle(int vehicleID, double vehicleCapacity, double vehicleVolume, string vehicleRegistration)
        {
            this.vehicleID = vehicleID;
            this.vehicleCapacity = vehicleCapacity;
            this.vehicleVolume = vehicleVolume;
            this.vehicleRegistration = vehicleRegistration;
        }

    }
}
