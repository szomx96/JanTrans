using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Views
{
    interface IZleceniePodgladcs
    {
        string Driver { get; set; } //imie nazwisko
        string RegistrationNr { get; set; }
        string DateFrom { get; set; }
        string DateTo { get; set; }
        string RouteFrom { get; set; }
        string RouteTo { get; set; }

        string[] Commodity { get; set; }

    }
}
