using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Route
    {
        string routeLength;
        string routeFrom;
        string routeTo;

        Route(string routeLength, string routeFrom, string routeTo)
        {
            this.routeLength = routeLength;
            this.routeFrom = routeFrom;
            this.routeTo = routeTo;
        }

    }
}
