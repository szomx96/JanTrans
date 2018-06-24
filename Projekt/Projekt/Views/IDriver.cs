using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Classes;

namespace Projekt.Views
{
    public interface IDriver
    {
        string DriverName { get; set; }
        string DriverSurname { get; set; }
        event Func<Driver, string, bool> AddDriver;

    }
}
