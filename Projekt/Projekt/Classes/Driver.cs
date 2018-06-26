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


        public Driver(string driverName, string driverSurname)
        {
            this.driverName = driverName;
            this.driverSurname = driverSurname;
        }

        public Driver(string driverName, string driverSurname, Vehicle vehicle)
        {
            this.driverName = driverName;
            this.driverSurname = driverSurname;
            this.vehicle = vehicle;
        }


        public Driver(int id, string driverName, string driverSurname)
        {
            this.driverID = id;
            this.driverName = driverName;
            this.driverSurname = driverSurname;
        }

        public Driver(int driverID, string driverName, string driverSurname, double distanceTravelled, Vehicle vehicle, List<DriverOccupied> occupied)
        {
            this.driverID = driverID;
            this.driverName = driverName;
            this.driverSurname = driverSurname;
            this.distanceTravelled = distanceTravelled;
            this.vehicle = vehicle;
            this.occupied = occupied;
        }

        public int DriverID
        {
            get
            {
                return driverID;
            }

            set
            {
                driverID = value;
            }
        }

        public string DriverName
        {
            get
            {
                return driverName;
            }

            set
            {
                driverName = value;
            }
        }

        public string DriverSurname
        {
            get
            {
                return driverSurname;
            }

            set
            {
                driverSurname = value;
            }
        }

        public double DistanceTravelled
        {
            get
            {
                return distanceTravelled;
            }

            set
            {
                distanceTravelled = value;
            }
        }
        public Vehicle Vehicle
        {
            get
            {
                return vehicle;
            }

            set
            {
                vehicle = value;
            }
        }
        public List<DriverOccupied> Occupied
        {
            get
            {
                return occupied;
            }

            set
            {
                occupied = value;
            }
        }

    }
}
