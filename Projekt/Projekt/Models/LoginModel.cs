using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class LoginModel
    {
        private string loginMode;
        private string userID;
        ModelContainer container;

        //private string loginMode = "none";
        //private string userID = "";
        //ModelContainer container = new ModelContainer();
      //  MySQLConnect database = new MySQLConnect();

        public LoginModel()
        {
            
            
        }
        public LoginModel(ModelContainer container)
        {
            this.container = container;
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

        internal bool CheckLogin(string log, string pass)
        {
            string[] wynik = container.Database.SelectLogin(log, pass);
            if (wynik.Length == 0 )
                return false;
            else
            {
                container.LoginID = wynik[1];
                container.LoggedAs = wynik[0];
                loginMode = wynik[0];
                userID = wynik[1];
                return true;
            }
            
        }
        //MySqlConnection connect; // zmienna referencja pozwalająca na nawiązanie połączenia z BD

        //MySqlDataReader read; // zmienna referencyjna wykonująca zapytanie oraz pobierająca odpowiedź z bazy

        //string server = &quot;000.00.000.00&quot;; // IP serwera bazy danych

        //string dataBase = &quot; exampleDataBase&quot;; // nazwa bazy danych

        //string user = &quot; exampleUser&quot;; // użytkownik bazy danych

        //string password = &quot; examplePass&quot;; // hasło bazy danych
    }
}
