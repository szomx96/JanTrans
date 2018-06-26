using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Classes;

namespace Projekt.Views
{
    interface INewOrder
    {
        int DriverID { get; set; }
        string DriverName { get; set; }
        string DriverSurname { get; set; }        
        //string VehicleID { get; set; }
        string RouteLength { get; set; }
        string RouteFrom { get; set; }
        string RouteTo { get; set; }

        //Driver driver { get; set; }
        //Route route { get; set; }
        //Vehicle vehicle { get; set; }
        //List<Product> products { get; set; }
        event Func<int, Product> CreateProduct;
        event Func<DateTime, DateTime, string[]> SelectDrivers;
        event Func<int, Driver> LoadDriver;
        event Func<string, string, string, string, string, string, string, string, List<Product>, bool> CreateOrder;
        event Func<List<Product>> SelectProducts;
    }
}
