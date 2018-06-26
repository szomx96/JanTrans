using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Classes;

namespace Projekt.Models
{
    public class AddCommodityModel
    {
        ModelContainer container = new ModelContainer();

        public AddCommodityModel() { }

        public AddCommodityModel(ModelContainer container)
        {
            this.container = container;
        }

        internal bool InsertCommodity(Commodity commodity)
        {
            int id = commodity.CommodityID;
            string commodityName = commodity.CommodityName;
            double commodityVolume = commodity.CommodityVolume;
            double commodityWeight = commodity.CommodityWeight;            

            if (container.Database.InsertCommodity(id, commodityName, commodityVolume, commodityWeight))
            {
                return true;
            }

            return false;

        }

        internal List<Customer> SelectCustomers()
        {
            return container.Database.SelectAllCustomers();
            
        }



    }
}
