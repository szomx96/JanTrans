using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Views
{
    public interface IVehicle
    {
        string RegistrationNr { get; set; }
        string Capacity { get; set; }
        string Volume { get; set; }
    }
}
