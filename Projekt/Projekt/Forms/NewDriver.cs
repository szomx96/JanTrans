using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Classes;
using System.Windows.Forms;
using Projekt.Views;


namespace Projekt.Forms
{
    public partial class NewDriver : UserControl, IDriver
    {
        IViewChanger changer;

        public NewDriver(IViewChanger changer)
        {
            InitializeComponent();

            this.changer = changer;

        }

        public string DriverName
        {

            get
            {
                return textBoxDriverName.Text;

            }

            set
            {
                textBoxDriverName.Text = value;
            }

        }
        public string DriverSurname
        {

            get
            {
                return textBoxDriverSurname.Text;
            }

            set
            {
                textBoxDriverSurname.Text = value;
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            changer.ShowAdminMain();
        }

        public event Func<Driver, string, Vehicle, bool> AddDriver;
        public event Func<string[]> SelectDrivers;
        public event Func<int, string, string, bool> UpdateDriverInfo;


        private void buttonDriverAdd_Click_1(object sender, EventArgs e)
        {

            if(textBoxDriverName.Text == "")
            {
                errorProvider1.SetError(textBoxDriverName, "Pole nie moze byc puste!");
            }else if(textBoxDriverSurname.Text == "")
            {
                errorProvider2.SetError(textBoxDriverSurname, "Pole nie moze byc puste!");
            }else if(textBoxPassword.Text == "")
            {
                errorProvider3.SetError(textBoxPassword, "Pole nie moze byc puste!");
            }else if(comboBox1.SelectedIndex == -1)
            {
                errorProvider4.SetError(comboBox1, "Wybierz pojazd");
            }
            else
            {
                string[] vehicleInfo = comboBox1.SelectedItem.ToString().Split(' ');
                
                int vehicleID = int.Parse(vehicleInfo[0]);
                string vehicleRegistration = vehicleInfo[1];
                double vehicleCapacity = double.Parse(vehicleInfo[2]);
                double vehicleVolume = double.Parse(vehicleInfo[3]);

                Vehicle vehicle = new Vehicle(vehicleID, vehicleCapacity, vehicleVolume, vehicleRegistration);

                Driver driver = new Driver(DriverName, DriverSurname, vehicle);
                string password = textBoxPassword.Text;

                if (AddDriver(driver, password, vehicle))
                {
                    textBoxDriverName.Clear();
                    textBoxDriverSurname.Clear();
                    textBoxPassword.Clear();
                    comboBox1.Items.Clear();
                    MessageBox.Show("Pomyślnie dodano kierowcę!");
                }
                
            }

            

        }

        public event Func<List<Vehicle>> SelectVehicles;

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            foreach (Vehicle v in SelectVehicles())
            {
                comboBox1.Items.Add(v.VehicleID + " " + v.VehicleRegistration + " " + v.VehicleCapacity 
                    + " " + v.VehicleVolume);
            }
        }
    }
}