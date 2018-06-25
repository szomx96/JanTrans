using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class DriverOccupied
    {
        private int dOID;
        private int driverID;
        private DateTime occBegin, occEnd;

        public DriverOccupied(int DOISD, int driverID, DateTime occBegin, DateTime occEnd)
        {
            this.dOID = DOISD;
            this.driverID = driverID;
            this.occBegin = occBegin;
            this.occEnd = occEnd;
        }

        public int DOID
        {
            get
            {
                return dOID;
            }

            set
            {
                dOID = value;
            }
        }
        public int DriverID
        {
            get
            {
                return driverID;
            }

            set
            {
                driverID = value;
            }
        }
        public DateTime OccBegin
        {
            get
            {
                return occBegin;
            }

            set
            {
                occBegin = value;
            }
        }

        public DateTime OccEnd
        {
            get
            {
                return occEnd;
            }

            set
            {
                occEnd = value;
            }
        }



    }
}
