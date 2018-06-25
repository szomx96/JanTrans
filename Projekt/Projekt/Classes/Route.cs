using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Route
    {
        public double routeLength, routePrice;
        public string routeFrom;
        public string routeTo;
        public DateTime departureDate, arrivalDate;
        public Route(double routeLength, double routePrice, string routeFrom, string routeTo, DateTime departureDate, DateTime arrivalDate)
        {
            this.routeLength = routeLength;
            this.routePrice = routePrice;
            this.routeFrom = routeFrom;
            this.routeTo = routeTo;
            this.departureDate = departureDate;
            this.arrivalDate = arrivalDate;
        }

    }
}
