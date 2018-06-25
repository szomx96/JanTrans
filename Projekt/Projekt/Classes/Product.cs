using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Product
    {
        private int productID;
        private string productName;
        private double weight, volume;
        private Customer customer;

        public Product(double commodityWeight, double commodityVolume, Customer customer)
        {
            this.weight = commodityWeight;
            this.volume = commodityVolume;
            this.customer = customer;
        }
        
        public Product(int productID, string productName, double weight, double volume, Customer customer)
        {
            this.productID = productID;
            this.productName = productName;
            this.weight = weight;
            this.volume = volume;
            this.customer = customer;
        }

        public int ProductID
        {
            get
            {
                return productID;
            }

            set
            {
                productID = value;
            }
        }
        public string ProductName
        {
            get
            {
                return productName;
            }

            set
            {
               productName = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }
        public double Volume
        {
            get
            {
                return volume;
            }

            set
            {
               volume = value;
            }
        }
        public Customer Customer
        {
            get
            {
                return customer;
            }

            set
            {
               customer = value;
            }
        }


    }
}
