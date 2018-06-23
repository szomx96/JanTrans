using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Views
{
    interface INewOrder
    {
        string CustomerCompanyName { get; set; }
        string CustomerSurname { get; set; }
        string CustomerName { get; set; }
        string DriverName { get; set; }
        string DriverSurname { get; set; }
        string CommodityWeight { get; set; }
        string CommodityVolume { get; set; }
        string VehicleID { get; set; }
        string RouteLength { get; set; }
        string RouteFrom { get; set; }
        string RouteTo { get; set; }

    }
}
