using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //Insert statement
        public void Insert()
        {

        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
        public string[] SelectLogin(string log, string pass)
        {
            List<string> ansv = new List<string>();
            string query = "SELECT Typ, ID_kierowca FROM logowanie WHERE Login like \""+log+"\" AND Haslo like \""+pass+"\"";
            Console.WriteLine(query);

            if (this.OpenConnection() == true)
            {
                
                MySqlCommand cmd = new MySqlCommand(query, connection);
               
                MySqlDataReader dataReader = cmd.ExecuteReader();

              
                while (dataReader.Read())
                {
                    ansv.Add(dataReader["Typ"] + "");
                    ansv.Add(dataReader["ID_kierowca"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return ansv.ToArray();
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

