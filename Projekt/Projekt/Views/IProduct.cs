using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Classes;

namespace Projekt.Views
{
    public interface IProduct
    {
        double CommodityWeight { get; set; }
        double CommodityVolume { get; set; }
        string CustomerCompanyName { get; set; }
        string CustomerSurname { get; set; }
        string CustomerName { get; set; }

        event Func<Customer, bool> AddCustomer;
        event Func<List<Customer>> SelectCustomers;

    }
}
