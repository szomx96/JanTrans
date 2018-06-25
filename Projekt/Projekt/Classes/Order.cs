using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Order
    {
        public int orderID;
        public Driver driver;
        public double freeCapacity, freeVolume;
        public Route route;
        public List<Product> products;
        public Vehicle vehicle;
        //Order_Product op;

        public Order(int orderID, Driver driver, Vehicle vehicle, double freeCapacity,
            double freeVolume, Route route, List<Product> products)
        {
            this.orderID = orderID;
            this.driver = driver;
            this.vehicle = vehicle;
            this.freeCapacity = freeCapacity;
            this.freeVolume = freeVolume;
            this.route = route;
            this.products = products;
            //this.op = op;
        }





        //Order(Customer customer, Driver driver, Commodity commodity, Vehicle vehicle, Route route)
        //{
        //    this.customer = customer;
        //    this.driver = driver;
        //    this.commodity = commodity;
        //    this.vehicle = vehicle;
        //    this.route = route;
        //}

    }
}
