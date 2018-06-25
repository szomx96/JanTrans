using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Route
    {
        private double routeLength, routePrice;
        private string routeFrom;
        private string routeTo;
        private DateTime departureDate, arrivalDate;

        public Route(double routeLength, double routePrice, string routeFrom, string routeTo, DateTime departureDate, DateTime arrivalDate)
        {
            this.routeLength = routeLength;
            this.routePrice = routePrice;
            this.routeFrom = routeFrom;
            this.routeTo = routeTo;
            this.departureDate = departureDate;
            this.arrivalDate = arrivalDate;
        }


        public double RouteLength
        {
            get
            {
                return routeLength;
            }

            set
            {
                routeLength = value;
            }
        }
        public double RoutePrice
        {
            get
            {
                return routePrice;
            }

            set
            {
                routePrice = value;
            }
        }
        public string RouteFrom
        {
            get
            {
                return routeFrom;
            }

            set
            {
                routeFrom = value;
            }
        }
        public string RouteTo
        {
            get
            {
                return routeTo;
            }

            set
            {
               routeTo = value;
            }
        }
        public DateTime DepartureDate
        {
            get
            {
                return departureDate;
            }

            set
            {
                departureDate = value;
            }
        }
        public DateTime ArrivalDate
        {
            get
            {
                return arrivalDate;
            }

            set
            {
               arrivalDate = value;
            }
        }

    }
}
