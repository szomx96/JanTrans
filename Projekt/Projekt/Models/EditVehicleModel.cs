using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class EditVehicleModel
    {
        ModelContainer container = new ModelContainer();

        public EditVehicleModel() { }

        public EditVehicleModel(ModelContainer container)
        {
            this.container = container;
        }


        internal string[] SelectVehicles()
        {

            List<Vehicle> vehiclesList = container.Database.SelectVehicles();
            List<string> vehiclesInfo = new List<string>();

            foreach (Vehicle vehicle in vehiclesList)
            {
                vehiclesInfo.Add(vehicle.VehicleID + " " + vehicle.VehicleRegistration +
                    " " + vehicle.VehicleCapacity + " " + vehicle.VehicleVolume);
            }

            return vehiclesInfo.ToArray();
        }

        internal bool UpdateVehicleInfo(int id, string registration, double capacity, double volume)
        {
            if (container.Database.UpdateVehicle(id, registration, capacity, volume))
            {
                return true;
            }
            return false;
        }





    }
}
