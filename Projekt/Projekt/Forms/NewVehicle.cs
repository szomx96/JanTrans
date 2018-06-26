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

    public partial class NewVehicle : UserControl, IVehicle
    {
        CultureInfo culture = new CultureInfo("en-GB");
        IViewChanger changer;

        public NewVehicle(IViewChanger changer)
        {
            InitializeComponent();

            this.changer = changer;

        }

        public NewVehicle()
        {
            InitializeComponent();
        }



        public string RegistrationNr
        {
            get
            {
                return textBoxRegistrationNrValue.Text;
            }

            set
            {
                textBoxRegistrationNrValue.Text = value;
            }

        }
        public double Capacity
        {

            get
            {
                return double.Parse(textBoxCapacityValue.Text, culture);
            }

            set
            {
                textBoxCapacityValue.Text = value.ToString();
            }
        }
        public double Volume
        {
            get
            {
                return double.Parse(textBoxVolumeValue.Text, culture);
            }

            set
            {
                textBoxVolumeValue.Text = value.ToString();
            }


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            changer.ShowAdminMain();
        }

        public event Func<Vehicle, bool> AddVehicle;
        public event Func<string[]> SelectVehicles;
        public event Func<int, string, double, double, bool> UpdateVehicleInfo;


        private void buttonVehicleAdd_Click_1(object sender, EventArgs e)
        {
            textBoxCapacityValue.Text = textBoxCapacityValue.Text.Replace(',', '.');
            textBoxVolumeValue.Text = textBoxVolumeValue.Text.Replace(',', '.');

            if (textBoxCapacityValue.Text == "")
            {
                errorProvider1.SetError(textBoxCapacityValue, "Pole nie moze byc puste!");
            }
            else if (textBoxVolumeValue.Text == "")
            {
                errorProvider2.SetError(textBoxVolumeValue, "Pole nie moze byc puste!");
            }
            else if (textBoxRegistrationNrValue.Text == "")
            {
                errorProvider3.SetError(textBoxRegistrationNrValue, "Pole nie moze byc puste!");
            }
            else
            {


                double capacity, volume;
                if (double.TryParse(textBoxCapacityValue.Text, NumberStyles.Any, culture, out capacity) &&
                    double.TryParse(textBoxVolumeValue.Text, NumberStyles.Any, culture, out volume))
                {
                    RegistrationNr = RegistrationNr.ToUpper();
                    Vehicle vehicle = new Vehicle(RegistrationNr, Capacity, Volume);

                    if (AddVehicle(vehicle))
                    {
                        textBoxRegistrationNrValue.Clear();
                        textBoxCapacityValue.Clear();
                        textBoxVolumeValue.Clear();
                        MessageBox.Show("Pomyślnie dodano pojazd");
                    }
                    
                }
                else
                {
                    errorProvider1.SetError(textBoxCapacityValue, "Zly typ danych");
                    errorProvider2.SetError(textBoxVolumeValue, "Zly typ danych");
                }
            }

        }
    }
}