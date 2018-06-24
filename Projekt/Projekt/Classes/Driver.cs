using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Driver
    {
        //lista zajetosci?
        int driverID;
        string driverName;
        string driverSurname;
        double distanceTravelled;
        Vehicle vehicle;
        Driver(string driverName, string driverSurname)
        {
            this.driverName = driverName;
            this.driverSurname = driverSurname;
        }

    }
}
