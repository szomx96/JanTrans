using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Vehicle
    {
        //lista zajetosci?
        string vehicleID;
        double vehicleCapacity;
        double vehicleVolume;
        string vehicleRegistration;

        Vehicle(string vehicleID, double vehicleCapacity, double vehicleVolume, string vehicleRegistration)
        {
            this.vehicleID = vehicleID;
            this.vehicleCapacity = vehicleCapacity;
            this.vehicleVolume = vehicleVolume;
            this.vehicleRegistration = vehicleRegistration;
        }

    }
}
