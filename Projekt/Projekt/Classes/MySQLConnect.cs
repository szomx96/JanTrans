using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using Projekt.Classes;
namespace Projekt
{
    public class MySQLConnect
    {
        CultureInfo culture = new CultureInfo("en-GB");

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
            password = "toor";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";SslMode=none;convert zero datetime=True";

            connection = new MySqlConnection(connectionString);
        }
        #region connection
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
        #endregion

        #region inserts
        //Insert statement
        public bool InsertOrder(string drivID, string route, string from, string to, 
            string dep, string arr, string cap, string vol, string[] prodIDs)
        {
            string ordID="";
            string query = string.Format(" START TRANSACTION;" +
                "INSERT kierowca_zajety(Id_kierowca, Data_pocz, Data_kon)"+
                "values( {0}, '{4}', '{5}');" +
                "INSERT zlecenia(Kierowca, trasa, Z, Do, Data_wyj, Data_pow," +
                " Pozostala_Ladownosc, Pozostala_Pojemnosc) VALUES ({0}, {1}, '{2}', '{3}', '{4}', '{5}', {6}, {7});" +
                "COMMIT;", drivID, route, from, to, dep, arr, cap, vol);
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                //ordID = cmd.LastInsertedId.ToString();
                connection.Close();
            }
            catch
            {
                return false;
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT MAX(ID_Zlecenia) FROM zlecenia", connection);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    ordID = dataReader["MAX(ID_Zlecenia)"].ToString();
                }
                connection.Close();
            }
            catch
            {
                return false;
            }
            foreach (string id in prodIDs)
            {
                query = string.Format("INSERT towar(Zlecenie, Produkt) VALUES ({0},{1})", ordID, id);
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();                    
                    connection.Close();
                }
                catch
                {
                    return false;
                }                    
            }
            
            return true;
        }
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

        public bool InsertVehicle(string vehicleRegistration, double vehicleCapacity, double vehicleVolume)
        {
            try
            {
                string query = string.Format(culture, "INSERT INTO ciezarowki (Ladownosc, Pojemnosc, Rejestracja)" +
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

        public bool InsertCustomer(string customerCompanyName, string customerName, string customerSurname)
        {
            try
            {
                string query = string.Format("INSERT INTO klienci (nazwa, Imie_wlasciciel, Nazwisko_wlasciciel)" +
                       " values ('{0}', '{1}', '{2}')", customerCompanyName,
                       customerName, customerSurname);


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

        #region updates
        //Update statement
        public void Update()
        {


        }

        public bool UpdatePassword(int id, string oldPass, string newPass)
        {
            try
            {
                string query = string.Format("UPDATE logowanie SET Haslo = '{0}' WHERE ID_kierowca like '{1}'" +
                    " AND Haslo like '{2}'",
                      newPass, id, oldPass);

                MessageBox.Show(query);


                MySqlCommand cmd = new MySqlCommand(query, connection);
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

        #endregion

        //Delete statement
        public void Delete()
        {
        }

        #region selects
        //Select statements

        //select basic info about logged user
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

        //selects login and psswd for login compare
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
        
        //select all products
        public List<Product> SelectProducts()
        {
            string query = "SELECT * FROM produkt";

            List<Product> products = new List<Product>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int proID = (int)dataReader["ID_Produkt"];
                    int custID = (int)dataReader["Klient"];
                    //Customer customer = SelectCertainCustomer(custID);///////////////POPRAWA
                    string productName = dataReader["Nazwa"].ToString();
                    double weight = (double)dataReader["Waga"];
                    double volume = (double)dataReader["Objetosc"];

                    products.Add(new Product(proID, custID, productName, weight, volume));
                }
                dataReader.Close();
                this.CloseConnection();

                foreach(Product p in products)
                {
                    Customer c = SelectCertainCustomer(p.CustomerID);
                    p.Customer = c;
                }

                return products;
            }
            else
            {
                return null;
            }
        }

        public List<Customer> SelectAllCustomers()
        {
            string query = "SELECT * FROM klienci";

            List<Customer> customers = new List<Customer>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = (int)dataReader["ID_Klienta"];
                    string customerCompanyName = dataReader["nazwa"].ToString();
                    string customerName = dataReader["Imie_wlasciciel"].ToString();
                    string customerSurname = dataReader["Nazwisko_wlasciciel"].ToString();
                    customers.Add(new Customer(id, customerCompanyName, customerName, customerSurname));
                }
                dataReader.Close();
                this.CloseConnection();
                return customers;
            }
            else
            {
                return null;
            }


        }

        public List<Driver> SelectAllDrivers()
        {
            string query = "SELECT * FROM kierowcy";

            List<Driver> drivers = new List<Driver>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = (int)dataReader["ID_Kierowcy"];
                    string driverName = dataReader["Imie"].ToString();
                    string driverSurname = dataReader["Nazwisko"].ToString();
                    drivers.Add(new Driver(id, driverName, driverSurname));
                }
                dataReader.Close();
                this.CloseConnection();
                return drivers;
            }
            else
            {
                return null;
            }
        }
        //select that returns all drivers available between 2 dates
        public List<Driver> SelectAvailableDrivers(DateTime begin, DateTime end)
        {
            string format = "yyyy-MM-dd HH:mm:ss";            
            string query =String.Format( " SELECT * FROM kierowcy" +
                " WHERE ID_Kierowcy NOT IN(SELECT Id_kierowca FROM kierowca_zajety WHERE " +
                "((Data_pocz  BETWEEN '{0}' AND '{1}')" +
                " OR (Data_kon BETWEEN '{0}' AND '{1}') OR " +
                "('{0}' BETWEEN Data_pocz AND Data_kon) " +
                "OR ('{1}' BETWEEN Data_pocz AND Data_kon)))", begin.ToString(format), end.ToString(format));
            Console.WriteLine(query);
            List<Driver> drivers = new List<Driver>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = (int)dataReader["ID_Kierowcy"];
                    string driverName = dataReader["Imie"].ToString();
                    string driverSurname = dataReader["Nazwisko"].ToString();
                    drivers.Add(new Driver(id, driverName, driverSurname));
                }
                dataReader.Close();
                this.CloseConnection();
                return drivers;
            }
            else
            {
                return null;
            }


        }

        // selects all vehicles from database as a collection
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
                    vehicles.Add(new Vehicle(id, vehicleCapacity, vehicleVolume, vehicleRegistration));
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



        #region sepcific selects

        //Select vehicle with inp id
        public Vehicle SelectCertainVehicle(int vehID)
        {
            string query = "SELECT * FROM ciezarowki WHERE ID_Pojazdu LIKE " + vehID.ToString();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int vehicleID = 11;
                double vehicleCapacity = 11;
                double vehicleVolume = 11;
                string vehicleRegistration = "";
                while (dataReader.Read())
                {
                    vehicleID = (int)dataReader["ID_Pojazdu"];
                    vehicleCapacity = (double)dataReader["Ladownosc"];
                    vehicleVolume = (double)dataReader["Pojemnosc"];
                    vehicleRegistration = dataReader["Rejestracja"].ToString();
                }
                dataReader.Close();
                this.CloseConnection();
                return new Vehicle(vehicleID, vehicleCapacity, vehicleVolume, vehicleRegistration);
            }
            else
            {
                return null;
            }

        }

        //SELECT specific customer defined by input id
        public Customer SelectCertainCustomer(int cusID)
        {
            string query = "SELECT * FROM klienci WHERE ID_Klienta LIKE " + cusID.ToString();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();   
                int customerID = 1;
                string customerCompanyName = "";
                string customerName = "";
                string customerSurname= "";
                while (dataReader.Read())
                {
                    customerID = (int)dataReader["ID_Klienta"];
                    customerCompanyName = dataReader["nazwa"].ToString();
                    customerName = dataReader["Imie_wlasciciel"].ToString();
                    customerSurname = dataReader["Nazwisko_wlasciciel"].ToString();
                }
                dataReader.Close();


                this.CloseConnection();
                return new Customer(customerID, customerCompanyName, customerName, customerSurname);
            }
            else
            {
                return null;
            }

        }

        //select returning collection of dates for specific driver represented by its id
        public List<DriverOccupied> SelectCertainDatesOfOccupation(int drivID)
        {
            string query = "SELECT * FROM kierowca_zajety WHERE Id_kierowca LIKE " + drivID.ToString();

            List<DriverOccupied> dates = new List<DriverOccupied>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string format = "yyyy-MM-dd HH:mm:ss";
                    int DOID = (int)dataReader["Id_dat"];
                    int driverID = (int)dataReader["Id_kierowca"];
                    Console.WriteLine(dataReader["Data_pocz"].ToString());
                    DateTime occBegin = DateTime.Parse(dataReader["Data_pocz"].ToString());//, "yyyy-MMM-dd HH:mm:ss tt", null);
                    DateTime occEnd = DateTime.Parse(dataReader["Data_kon"].ToString());//, "yyyy-MMM-dd HH:mm:ss tt", null);
                    dates.Add(new DriverOccupied(DOID, driverID, occBegin, occEnd));
                }
                dataReader.Close();
                this.CloseConnection();
                return dates;
            }
            else
            {
                return null;
            }

        }

        //select certain driver by id
        public Driver SelectCertainDriver(int driID)
        {
            string query = "SELECT * FROM kierowcy WHERE ID_Kierowcy LIKE " + driID.ToString();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int driverID = 1;
                int vehicleID = 1;
                string name = "";
                string surname = "";
                double distance = 0;
                
                while (dataReader.Read())
                {
                    driverID = (int)dataReader["ID_Kierowcy"];
                    vehicleID = (int)dataReader["Ciezarowka"];
                    name = dataReader["Imie"].ToString();
                    surname = dataReader["Nazwisko"].ToString();
                    distance = (double)dataReader["Trasa"];
                }
                dataReader.Close();


                this.CloseConnection();
                Driver d = new Driver(driverID, name, surname, distance, null, null);
                d.Vehicle = SelectCertainVehicle(driverID);
                d.Occupied = SelectCertainDatesOfOccupation(driverID);
                return d;
            }
            else
            {
                return null;
            }
        }

        // select Product with specific ID
        public Product SelectCertainProduct(int proID)
        {
            
            string query = "SELECT * FROM produkt WHERE ID_Produkt LIKE " + proID.ToString();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int productID=1;
                int customerID=1;
                string productName="";
                double weight=0;
                double volume=0;
                while (dataReader.Read())
                {
                    productID = (int)dataReader["ID_Produkt"];
                    customerID = (int)dataReader["Klient"];
                    productName = dataReader["Nazwa"].ToString();
                    weight = (double)dataReader["Waga"];
                    volume = (double)dataReader["Objetosc"];
                }
                dataReader.Close();

                
                this.CloseConnection();
                Product p = new Product(productID, customerID, productName, weight, volume);//, SelectCertainCustomer(customerID));
                p.Customer = SelectCertainCustomer(p.CustomerID);
                return p;
            }
            else
            {
                return null;
            }
          
        }

        #endregion

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

