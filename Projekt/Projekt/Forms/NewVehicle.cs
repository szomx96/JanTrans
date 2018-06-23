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


namespace Projekt.Forms { 

    public partial class NewVehicle : UserControl, IVehicle
    {
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

       

        public string RegistrationNr {
            get
            {
                return textBoxRegistrationNrValue.Text;
            }

            set
            {
                textBoxRegistrationNrValue.Text = value;
            }

        }
        public string Capacity {

            get
            {
                return textBoxCapacityValue.Text;
            }

            set
            {
                textBoxCapacityValue.Text = value;
            }
        }
        public string Volume {
            get
            {
                return textBoxVolumeValue.Text;
            }

            set
            {
                textBoxVolumeValue.Text = value;
            }


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            changer.ShowAdminMain();
        }
    }
}
