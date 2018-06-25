using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Classes;

namespace Projekt.Models
{
    public class AddProductModel
    {
        ModelContainer container = new ModelContainer();

        public AddProductModel() { }

        public AddProductModel(ModelContainer container)
        {
            this.container = container;
        }

        internal List<Customer> SelectCustomers()
        {
            return container.Database.SelectAllCustomers();
            //List<string> customerNames = new List<string>();

            //foreach (Customer customer in customersList)
            //{
            //    customerNames.Add(customer.CustomerCompanyName + " " +
            //        customer.CustomerName + " " + customer.CustomerSurname);
            //}

            //return customerNames;

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

    }
}
