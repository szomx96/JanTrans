using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Customer
    {
        int customerID;
        string customerCompanyName;
        string customerName;
        string customerSurname;

        Customer(string customerCompanyName, string customerName, string customerSurname)
        {
            this.customerCompanyName = customerCompanyName;
            this.customerName = customerName;
            this.customerSurname = customerSurname;

        }


    }
}
