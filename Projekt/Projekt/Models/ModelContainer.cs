using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class ModelContainer
    {
<<<<<<< HEAD
        private MySQLConnect database = new MySQLConnect();

=======
        public MySQLConnect database = new MySQLConnect();
>>>>>>> 47216ec824e96332d66a97331ff08e2e27a7a267
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
