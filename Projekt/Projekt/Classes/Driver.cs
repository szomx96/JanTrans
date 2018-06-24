using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Driver
    {
        private string driverName;
        private string driverSurname;
        

        public Driver(string driverName, string driverSurname)
        {
            this.driverName = driverName;
            this.driverSurname = driverSurname;

        }

        public string DriverName
        {
            get
            {
                return driverName;
            }
        }

        public string DriverSurname
        {
            get
            {
                return driverSurname;
            }
        }
       



    }
}
