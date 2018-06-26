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



        internal bool ModelCreateOrder(string drivID, string route, string from, 
            string to, string dep, string arr, string cap, string vol, List<Product> prodIDs)
        {
            string[] ids = GetProductIDS(prodIDs);
            return container.Database.InsertOrder(drivID, route, from, to, dep, arr, cap, vol, ids);
        }

        private string[] GetProductIDS(List<Product> prodIDs)
        {
            List<string> ids = new List<string>();
            foreach (Product p in prodIDs)
            {
                ids.Add(p.ProductID.ToString());
            }
            return ids.ToArray();
        }

        internal Driver ModelCertainDriver(int id)
        {
            return container.Database.SelectCertainDriver(id);
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
        internal List<Product> GetProducts()
        {
            return container.Database.SelectProducts();
        }
        internal Product GetCertainProduct(int id)
        {
            return container.Database.SelectCertainProduct(id);
        }

        internal string[] SelectDrivers(DateTime beg, DateTime end)
        {
            List<Driver> driversList = container.Database.SelectAvailableDrivers(beg, end);
            List <string> driversNames = new List<string>();            

            foreach(Driver driver in driversList)
            {
                driversNames.Add(driver.DriverID + " " + driver.DriverName + " " + driver.DriverSurname);
            }
            
            return driversNames.ToArray();

        }



    }
}