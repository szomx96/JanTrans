using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Customer
    {
        public int customerID;
        public string customerCompanyName;
        public string customerName;
        public string customerSurname;

        public Customer(int customerID, string customerCompanyName, string customerName, string customerSurname)
        {
            this.customerID = customerID;
            this.customerCompanyName = customerCompanyName;
            this.customerName = customerName;
            this.customerSurname = customerSurname;

        }


    }
}
