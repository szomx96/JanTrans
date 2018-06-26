using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Commodity
    {
        private int commodityID;
        private string commodityName;
        private double commodityVolume;
        private double commodityWeight;

        public Commodity(int id, string commodityName, double commodityVolume, double commodityWeight)
        {
            this.commodityID = id;
            this.commodityName = commodityName;
            this.commodityVolume = commodityVolume;
            this.commodityWeight = commodityWeight;
        }

        public Commodity(string commodityName, double commodityVolume, double commodityWeight)
        {
            this.commodityName = commodityName;
            this.commodityVolume = commodityVolume;
            this.commodityWeight = commodityWeight;
        }

        public int CommodityID
        {
            get
            {
                return commodityID;
            }

            set
            {
                commodityID = value;
            }
        }

        public string CommodityName
        {
            get
            {
                return commodityName;
            }

            set
            {
                commodityName = value;
            }
        }

        public double CommodityVolume
        {
            get
            {
                return commodityVolume;
            }

            set
            {
                commodityVolume = value;
            }
        }

        public double CommodityWeight
        {
            get
            {
                return commodityWeight;
            }

            set
            {
                commodityWeight = value;
            }

        }

    }
}
