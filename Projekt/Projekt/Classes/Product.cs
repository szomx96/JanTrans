using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Product
    {
        int productID;
        string productName;
        double weight, volume;
        Customer customer;
        
        public Product(int productID, string productName, double weight, double volume, Customer customer)
        {
            this.productID = productID;
            this.productName = productName;
            this.weight = weight;
            this.volume = volume;
            this.customer = customer;
        }
    }
}
