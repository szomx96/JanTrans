using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt.Views;
using Projekt.Classes;

namespace Projekt.Forms
{
    public partial class EditDriver : UserControl, IDriver
    {
        IViewChanger changer;

        public EditDriver(IViewChanger changer)
        {
            InitializeComponent();

            this.changer = changer;

        }

        public string DriverName {
            get
            {
                return textBoxDriverName.Text;
            }

            set
            {
                textBoxDriverName.Text = value;
            }

        }
        public string DriverSurname {

            get
            {
                return textBoxDriverSurname.Text;
            }

            set
            {
                textBoxDriverSurname.Text = value;
            }

        }

        public int DriverID { get; set; }
        public Driver Driver { get; set; }

        public event Func<Driver, string, bool> AddDriver;
        public event Func<string[]> SelectDrivers;

        private void buttonBack_Click(object sender, EventArgs e)
        {
            changer.ShowAdminMain();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(SelectDrivers());

        }
                     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] driverInfo = comboBox1.SelectedItem.ToString().Split(' ');

            DriverID = int.Parse(driverInfo[0]);
            DriverName = driverInfo[1];
            DriverSurname = driverInfo[2];

            Driver selectedDriver = new Driver(DriverID, DriverName, DriverSurname);
            Driver = selectedDriver;


        }

        public event Func<int, string, string, bool> UpdateDriverInfo;

        private void buttonDriverEdit_Click(object sender, EventArgs e)
        {
            if(textBoxDriverName.Text == "")
            {
                errorProvider1.SetError(textBoxDriverName, "Pole nie może być puste!");
            
            }else if(textBoxDriverSurname.Text == ""){
                errorProvider2.SetError(textBoxDriverSurname, "Pole nie może być puste!");
                
            }
            else
            {
                if (UpdateDriverInfo(DriverID, DriverName, DriverSurname))
                {
                    textBoxDriverName.Clear();
                    textBoxDriverSurname.Clear();
                    MessageBox.Show("Pomyślnie edytowano kierowcę.");
                }
                
            }
            


        }
    }
}
