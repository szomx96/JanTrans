using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Classes;

namespace Projekt.Models
{
    public class NewOrderModel
    {

        ModelContainer container = new ModelContainer();
         

        public NewOrderModel() { }


        public NewOrderModel(ModelContainer container)
        {
            this.container = container;
        }

        internal bool InsertCustomer(Customer customer)
        {
            string customerCompanyName = customer.CustomerCompanyName;
            string customerName = customer.CustomerName;
            string customerSurname = customer.CustomerSurname;

            if(container.Database.InsertCustomer(customerCompanyName, customerName, customerSurname))
            {
                return true;
            }

            return false;

        }



    }
}
