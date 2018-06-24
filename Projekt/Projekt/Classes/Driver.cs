using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Driver
    {
        
        int driverID;
        string driverName;
        string driverSurname;
        double distanceTravelled;
        Vehicle vehicle;
        List<DriverOccupied> occupied;
        Driver(int driverID, string driverName, string driverSurname, double distanceTravelled, Vehicle vehicle, List<DriverOccupied> occupied)
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
