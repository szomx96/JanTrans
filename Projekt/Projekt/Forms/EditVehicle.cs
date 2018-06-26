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
using System.Globalization;

namespace Projekt.Forms
{
    public partial class EditVehicle : UserControl, IVehicle
    {
        CultureInfo culture = new CultureInfo("en-GB");
        IViewChanger changer;

        public EditVehicle(IViewChanger changer)
        {
            InitializeComponent();

            this.changer = changer;

        }

        public string RegistrationNr
        {
            get
            {
                return textBoxRegistrationNumerValue.Text;
            }

            set
            {
                textBoxRegistrationNumerValue.Text = value;
            }
        }
        public double Capacity {
            get
            {
                return double.Parse(textBoxCapacityValue.Text, culture);
            }

            set
            {
                textBoxCapacityValue.Text = value.ToString();
            }


        }
        public double Volume {

            get
            {
                return double.Parse(textBoxVolumeValue.Text, culture);
            }

            set
            {
                textBoxVolumeValue.Text = value.ToString();
            }
        }

        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }

        public event Func<Vehicle, bool> AddVehicle;

        private void buttonBack_Click(object sender, EventArgs e)
        {
            changer.ShowAdminMain();
        }


        public event Func<string[]> SelectVehicles;

        private void comboBox1_DropDown(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(SelectVehicles());

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] vehicleInfo = comboBox1.SelectedItem.ToString().Split(' ');

            VehicleID = int.Parse(vehicleInfo[0]);
            RegistrationNr = vehicleInfo[1];
            Capacity = double.Parse(vehicleInfo[2]);
            Volume = double.Parse(vehicleInfo[3]);

            Vehicle selectedVehicle = new Vehicle(VehicleID, Capacity, Volume, RegistrationNr);
            Vehicle = selectedVehicle;


        }

        public event Func<int, string, double, double, bool> UpdateVehicleInfo;

        private void buttonVehicleEdit_Click(object sender, EventArgs e)
        {
            

            if(textBoxRegistrationNumerValue.Text == "")
            {
                errorProvider1.SetError(textBoxRegistrationNumerValue, "Pole nie może być puste!");
            }else if(textBoxCapacityValue.Text == "")
            {
                errorProvider2.SetError(textBoxCapacityValue, "Pole nie może być puste!");
            }
            else if(textBoxVolumeValue.Text == "")
            {
                errorProvider3.SetError(textBoxVolumeValue, "Pole nie może być puste!");
            }
            else
            {
                textBoxVolumeValue.Text = textBoxVolumeValue.Text.Replace(',', '.');
                textBoxCapacityValue.Text = textBoxCapacityValue.Text.Replace(',', '.');

                double capacity, volume;
                if (double.TryParse(textBoxCapacityValue.Text, NumberStyles.Any, culture, out capacity)
                    && double.TryParse(textBoxVolumeValue.Text, NumberStyles.Any, culture, out volume))
                {
                    RegistrationNr = RegistrationNr.ToUpper();

                    if (UpdateVehicleInfo(VehicleID, RegistrationNr, Capacity, Volume))
                    {
                        textBoxRegistrationNumerValue.Clear();
                        textBoxCapacityValue.Clear();
                        textBoxVolumeValue.Clear();
                        MessageBox.Show("Pomyślnie edytowano pojazd.");
                    }
                }
                else
                {
                    errorProvider1.SetError(textBoxCapacityValue, "Nieprawidlowa wartosc");
                }
            }
        }
    }
}
