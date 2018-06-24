using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class NewVehicleModel
    {
        ModelContainer container = new ModelContainer();

        public NewVehicleModel() { }

        public NewVehicleModel(ModelContainer container)
        {
            this.container = container;
        }

        internal bool InsertNewVehicle(Vehicle vehicle)
        {
            string vehicleRegistration = vehicle.VehicleRegistration;
            double vehicleCapacity = vehicle.VehicleCapacity;
            double vehicleVolume = vehicle.VehicleVolume;

            if(container.Database.InsertVehicle(vehicleRegistration, vehicleCapacity, vehicleVolume))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
