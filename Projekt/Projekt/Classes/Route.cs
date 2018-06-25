using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Route
    {
        double routeLength;
        string routeFrom;
        string routeTo;
        DateTime departureDate, arrivalDate;

        Route(double routeLength, string routeFrom, string routeTo, DateTime departureDate, DateTime arrivalDate)
        {
            this.routeLength = routeLength;
            this.routeFrom = routeFrom;
            this.routeTo = routeTo;
            this.departureDate = departureDate;
            this.arrivalDate = arrivalDate;
        }

    }
}
