using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class DriverOccupied
    {
        public int DOID;
        public int driverID;
        public DateTime occBegin, occEnd;
        public DriverOccupied(int DOISD, int driverID, DateTime occBegin, DateTime occEnd)
        {
            this.DOID = DOID;
            this.driverID = driverID;
            this.occBegin = occBegin;
            this.occEnd = occEnd;
        }
    }
}
