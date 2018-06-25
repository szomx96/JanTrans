using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class DriverOccupied
    {
        int DOID;
        int driverID;
        DateTime occBegin, occEnd;

        public DriverOccupied(int DOISD, int driverID, DateTime occBegin, DateTime occEnd)
        {
            this.DOID = DOISD;
            this.driverID = driverID;
            this.occBegin = occBegin;
            this.occEnd = occEnd;
        }
    }
}
