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


        internal bool InsertCustomer(Customer customer)
        {
            string customerCompanyName = customer.CustomerCompanyName;
            string customerName = customer.CustomerName;
            string customerSurname = customer.CustomerSurname;

            if (container.Database.InsertCustomer(customerCompanyName, customerName, customerSurname))
            {
                return true;
            }

            return false;

        }

        internal bool InsertNewDriver(Driver driver, string password)
        {
            string driverName = driver.DriverName;
            string driverSurname = driver.DriverSurname;

            if (container.Database.InsertDriver(driverName, driverSurname, password))
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