using System;
using System.Collections.Generic;
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

        #region selects
        //Select statements

            //select basic info about logged user
        public string[] SelectUserInfo (string userID)
        {
            List<string> answ = new List<string>();

            string query = "SELECT Imie, Nazwisko, Login, ID_kierowca FROM kierowcy, logowanie " +
                "WHERE ID_Kierowcy like ID_kierowca AND ID_Kierowcy like " + userID;

            MessageBox.Show(query);

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
            string query = "SELECT * FROM kierowca_zajety WHERE Id_kierowca LIKE "+drivID.ToString();

            List<DriverOccupied> dates = new List<DriverOccupied>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {                    
                    int DOID = (int)dataReader["Id_dat"];
                    int driverID = (int)dataReader["Id_kierowca"];
                    DateTime occBegin = DateTime.ParseExact(dataReader["Data_pocz"].ToString(), "MM.dd.yyyy H:mm:ss", null);
                    DateTime occEnd = DateTime.ParseExact(dataReader["Data_kon"].ToString(), "MM.dd.yyyy H:mm:ss", null);
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

        //select certain driver
        public Driver SelectCertainDriver(int drivID)
        {
            string query = "SELECT * FROM kierowcy WHERE ID_Kierowcy LIKE " + drivID.ToString();

            List<DriverOccupied> dates = new List<DriverOccupied>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int driverID = 1;
                int vehicleID = 1;
                string driverName = "";
                string driverSurname = "";
                double distanceTravelled = 1;
                Vehicle vehicle = null;
                List<DriverOccupied> occupied =null;
                while (dataReader.Read())
                {
                    driverID = (int)dataReader["ID_Kierowcy"];
                    vehicleID = (int)dataReader["Ciezarowka"];
                    driverName = dataReader["Imie"].ToString();
                    driverSurname = dataReader["Nazwisko"].ToString();
                    distanceTravelled = (double)dataReader["Trasa"];
                    vehicle = SelectCertainVehicle(vehicleID); // ID pojazdu NIE kierowcy!!!
                    occupied = SelectCertainDatesOfOccupation(driverID);
                }
                dataReader.Close();
                this.CloseConnection();
                return new Driver(driverID, driverName,driverSurname,distanceTravelled,vehicle,occupied);
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
                return new  Product(productID, productName, weight, volume, SelectCertainCustomer(customerID));
            }
            else
            {
                return null;
            }
            return null;
        }

        // select list of products from orderID
        public List<Product> SelectCertainProductList(int ordID)
        {
            List<Product> products = new List<Product>();
            string query = "SELECT Produkt FROM towar WHERE Zlecenie LIKE " + ordID.ToString();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int proID = (int)dataReader["Produkt"];
                    products.Add(SelectCertainProduct(proID));
                }
                dataReader.Close();
                this.CloseConnection();
                return products;
            }
            else
            {
                return null;
            }



        }

        //route generation
        public Route SelectRouteFromOrder(int ordID)
        {
            string query = "SELECT trasa, Koszt, Z, Do, Data_wyj, Data_pow FROM zlecenia WHERE ID_Zlecenia LIKE " + ordID.ToString(); //edit
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                double routeLength = 0, routePrice = 0;
                string routeFrom = "";
                string routeTo = "";
                DateTime departureDate = DateTime.Now, arrivalDate = DateTime.Now;
                while (dataReader.Read())
                {
                    routeLength = (double)dataReader["trasa"];
                    routePrice = (double)dataReader["Koszt"];
                    routeFrom = dataReader["Z"].ToString();
                    routeTo = dataReader["Do"].ToString();
                    departureDate = DateTime.ParseExact(dataReader["Data_wyj"].ToString(), "MM.dd.yyyy H:mm:ss", null);
                    arrivalDate = DateTime.ParseExact(dataReader["Data_pow"].ToString(), "MM.dd.yyyy H:mm:ss", null);
                }
                dataReader.Close();


                this.CloseConnection();
                return new Route(routeLength, routePrice, routeFrom, routeTo, departureDate, arrivalDate);
            }
            else
            {
                return null;
            }

        }


        // get certain order obj
        public Order SelectCertainOrder(int ordID)
        {
            string query = "SELECT * FROM zlecenia WHERE ID_Zlecenia LIKE " + ordID.ToString();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int orderID = ordID;
                Driver driver = null;
                double freeCapacity = 0, freeVolume = 0;
                Route route = SelectRouteFromOrder(orderID);                    ;
                List<Product> products = SelectCertainProductList(orderID);
                Vehicle vehicle = null;
                while (dataReader.Read())
                {
                    int driID = (int)dataReader["Kierowca"];
                    driver = SelectCertainDriver(driID);
                    freeCapacity = (double)dataReader["Pozostala_Ladownosc"];
                    freeVolume = (double)dataReader["Pozostala_Pojemnosc"];
                    vehicle = driver.vehicle;
                }
                dataReader.Close();
                this.CloseConnection();
                return new Order(orderID, driver, vehicle, freeCapacity, freeVolume, route, products);
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

