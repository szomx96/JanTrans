using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Zlecenie
    {
        Customer customer;
        Driver driver;
        Commodity commodity;
        Vehicle vehicle;
        Route route;
        


        Zlecenie(Customer customer, Driver driver, Commodity commodity, Vehicle vehicle, Route route)
        {
            this.customer = customer;
            this.driver = driver;
            this.commodity = commodity;
            this.vehicle = vehicle;
            this.route = route;
        }

    }
}
