using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Views;
using Projekt.Presenters;
using Projekt.Classes;

namespace Projekt.Models
{
    public class EditDriverModel
    {
        ModelContainer container = new ModelContainer();

        public EditDriverModel() { }

        public EditDriverModel(ModelContainer container)
        {
            this.container = container;
        }

        internal string[] SelectDrivers()
        {
            List<Driver> driversList = container.Database.SelectAllDrivers();
            List<string> driversNames = new List<string>();

            foreach (Driver driver in driversList)
            {
                driversNames.Add(driver.DriverID + " " + driver.DriverName + " " + driver.DriverSurname);
            }

            return driversNames.ToArray();

        }


        internal bool UpdateDriverInfo(int id, string driverName, string driverSurname)
        {
            if (container.Database.UpdateDriver(id, driverName, driverSurname))
            {
                return true;
            }
            return false;
        }


    }
}
