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


        private void buttonVehicleAdd_Click_1(object sender, EventArgs e)
        {
            textBoxCapacityValue.Text = textBoxCapacityValue.Text.Replace(',', '.');
            textBoxVolumeValue.Text = textBoxVolumeValue.Text.Replace(',', '.');

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
                }
                else
                {
                    //error provider ze nie dalo sie dodac pojazdu
                }
            }
            else
            {
                //error provider ze nie da sie parsowac do double

            }

        }
    }
}