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
        double Capacity { get; set; }
        double Volume { get; set; }

        event Func<Vehicle, bool> AddVehicle;
        event Func<string[]> SelectVehicles;
        event Func<int, string, double, double, bool> UpdateVehicleInfo;
    }
}