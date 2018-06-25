using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Classes;
using Projekt.Views;

namespace Projekt.Models
{
    public class NewOrderModel
    {

        ModelContainer container = new ModelContainer();


        public NewOrderModel() { }

        //public string DriverName { get; set; }
        //public string DriverSurname { get; set; }
       


        public NewOrderModel(ModelContainer container)
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


        internal string[] SelectDrivers()
        {
            List<Driver> driversList = container.Database.SelectAllDrivers();
            List <string> driversNames = new List<string>();            

            foreach(Driver driver in driversList)
            {
                driversNames.Add(driver.DriverID + " " + driver.DriverName + " " + driver.DriverSurname);
            }
            
            return driversNames.ToArray();

        }



    }
}