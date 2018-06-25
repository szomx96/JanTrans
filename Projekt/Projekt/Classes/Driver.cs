using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Driver
    {
        
        public int driverID;
        public string driverName;
        public string driverSurname;
        public double distanceTravelled;
        public Vehicle vehicle;
        public List<DriverOccupied> occupied;
        public Driver(int driverID, string driverName, string driverSurname, double distanceTravelled, Vehicle vehicle, List<DriverOccupied> occupied)
        {
            this.driverID = driverID;
            this.driverName = driverName;
            this.driverSurname = driverSurname;
            this.distanceTravelled = distanceTravelled;
            this.vehicle = vehicle;
            this.occupied = occupied;
        }

    }
}
