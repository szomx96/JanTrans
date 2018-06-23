using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class ModelContainer
    {

        private MySQLConnect database = new MySQLConnect();
        

        private string loginMode = "none";
        private string userID = "";

        public MySQLConnect Database
        {
            get
            {
                return database;
            }
        }

        public string LoggedAs 
        {
            get { return loginMode; }
            set { loginMode = value; }
        }

        public string LoginID
        {
            get { return userID; }
            set { userID = value; }
        }


    }
}
