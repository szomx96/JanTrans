using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Order
    {
        private int orderID;
        private Driver driver;
        private double freeCapacity, freeVolume;
        private Route route;
        private List<Product> products;
        private Vehicle vehicle;
        //Order_Product op;

        public Order()
        {

        }

        public Order(Driver driver, Route route, Vehicle vehicle, List<Product> products)
        {
            this.driver = driver;
            this.route = route;
            this.vehicle = vehicle;
            this.products = products;

        }

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


        public int OrderID
        {
            get
            {
                return orderID;
            }

            set
            {
                orderID = value;
            }
        }
        public Driver Driver
        {
            get
            {
                return driver;
            }

            set
            {
                driver = value;
            }
        }
      
        public double FreeCapacity
        {
            get
            {
                return freeCapacity;
            }

            set
            {
                freeCapacity = value;
            }
        }
        public double FreeVolume
        {
            get
            {
                return freeVolume;
            }

            set
            {
                freeVolume = value;
            }
        }
        public Route Route
        {
            get
            {
                return route;
            }

            set
            {
               route = value;
            }
        }
        public List<Product> Products
        {
            get
            {
                return products;
            }

            set
            {
               products = value;
            }
        }
        public Vehicle Vehicle
        {
            get
            {
                return vehicle;
            }

            set
            {
                vehicle = value;
            }
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
