using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projekt
{
    public class MySQLConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public MySQLConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "jantrans";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";SslMode=none;convert zero datetime=True";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }

        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

       

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        #region inserts

        //Insert statement
        public void Insert()
        {

        }

        //Insert statement
        public bool InsertDriver(string driverName, string driverSurname, string password)
        {
            try
            {
                string query = string.Format("INSERT INTO kierowcy (Imie, Nazwisko) values ('{0}', '{1}')",
                    driverName, driverSurname);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                int id = (int)cmd.LastInsertedId;
                connection.Close();

                string username = (driverName + "." + driverSurname).ToLower();
                query = string.Format("INSERT INTO logowanie values ({0}, 'user', '{1}', '{2}')",
                    id, username, password);

                cmd = new MySqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch 
            {
                return false;
            }

            return true;
        }

        public bool InsertVehicle(string vehicleRegistration, string vehicleCapacity, string vehicleVolume)
        {
            try
            {
                string query = string.Format("INSERT INTO ciezarowki (Ladownosc, Pojemnosc, Rejestracja)" +
                    " values ('{0}', '{1}', '{2}')", vehicleCapacity, vehicleVolume, vehicleRegistration);
              
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                int id = (int)cmd.LastInsertedId;
                connection.Close();

            }
            catch
            {
                return false;
            }
            return true;

        }

        #endregion



        #region selects
        //Select statement

        public string[] SelectUserInfo (string userID)
        {
            List<string> answ = new List<string>();

            string query = "SELECT Imie, Nazwisko, Login, ID_kierowca FROM kierowcy, logowanie " +
                "WHERE ID_Kierowcy like ID_kierowca AND ID_Kierowcy like " + userID;

            if(this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    answ.Add(dataReader["Imie"] + "");
                    answ.Add(dataReader["Nazwisko"] + "");
                    answ.Add(dataReader["Login"] + "");
                    answ.Add(dataReader["ID_kierowca"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return answ.ToArray();
            }
            else
            {
                return null;
            }

        }

        public string[] SelectLogin(string log, string pass)
        {
            List<string> answ = new List<string>();
            string query = "SELECT Typ, ID_kierowca FROM logowanie WHERE Login like \""+log+"\" AND Haslo like \""+pass+"\"";
         

            if (this.OpenConnection() == true)
            {
                
                MySqlCommand cmd = new MySqlCommand(query, connection);
               
                MySqlDataReader dataReader = cmd.ExecuteReader();

              
                while (dataReader.Read())
                {
                    answ.Add(dataReader["Typ"] + "");
                    answ.Add(dataReader["ID_kierowca"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return answ.ToArray();
            }
            else
            {
                return null;
            }
        }
        public List<Vehicle> SelectVehicles()
        {
            string query = "SELECT * FROM ciezarowki";

            List<Vehicle> vehicles = new List<Vehicle>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                while (dataReader.Read())
                {
                    int id = (int)dataReader["ID_Pojazdu"];
                    double vehicleCapacity = (double)dataReader["Ladownosc"];
                    double vehicleVolume = (double)dataReader["Pojemnosc"];
                    string vehicleRegistration = dataReader["Rejestracja"].ToString();
                }
                dataReader.Close();
                this.CloseConnection();
                return vehicles;
            }
            else
            {
                return null;
            }
        }

        public List<string>[] Select()
        {
            string query = "SELECT k.*, Data_pocz, Data_kon FROM kierowcy k, kierowca_zajety z WHERE ID_Kierowcy = Id_kierowca";

            //Create a list to store the result
            List<string>[] list = new List<string>[8];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID_Kierowcy"] + "");
                    list[1].Add(dataReader["Imie"] + "");
                    list[2].Add(dataReader["Nazwisko"] + "");
                    list[3].Add(dataReader["Trasa"] + "");
                    list[4].Add(dataReader["Ciezarowka"] + "");
                    list[5].Add(dataReader["Zlecenie"] + "");
                    list[6].Add(dataReader["Zajety_od"] + "");
                    list[7].Add(dataReader["Zajety_do"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }

        }
        #endregion
        //Count statement
        public int Count()
        {
            return 1;
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}

