using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Classes;

namespace Projekt.Models
{
    public class NewDriverModel
    {
        ModelContainer container = new ModelContainer();

        public NewDriverModel() { }

        public NewDriverModel(ModelContainer container)
        {
            this.container = container;
        }

        internal void InsertNewDriver(Driver driver, string password)
        {
            string driverName = driver.DriverName;
            string driverSurname = driver.DriverSurname;

            container.Database.InsertDriver(driverName, driverSurname, password);

        }


    }
}
