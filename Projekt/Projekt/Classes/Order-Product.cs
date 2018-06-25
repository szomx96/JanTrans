using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Order_Product
    { 
        private List<Product> products;

        public Order_Product(List <Product> products)
        {
            this.products = products;
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

    }
}
