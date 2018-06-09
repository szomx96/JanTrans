using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Views
{
    interface IPojazd
    {
        string RegistrationNr { get; set; }
        string Capacity { get; set; }
        string Volume { get; set; }
    }
}
