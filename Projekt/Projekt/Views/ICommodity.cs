using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Classes;

namespace Projekt.Views
{
    public interface ICommodity
    {
        string CommodityName { get; set; }
        double CommodityWeight { get; set; }
        double CommodityVolume { get; set; }

        event Func<Commodity, bool> InsertCommodity;
        event Func<List<Customer>> SelectCustomers;

    }
}
