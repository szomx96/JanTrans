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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            changer.ShowAdminMain();
        }

        event Action<Driver, string> AddDriver;

        private void buttonDriverAdd_Click(object sender, EventArgs e)
        {
            if(textBoxDriverName.Text != "" && textBoxDriverSurname.Text != "")
            {
                if (textBoxPassword.Text != "")
                {
                    Driver driver = new Driver(DriverName, DriverSurname);
                    string password = textBoxPassword.Text;
                    AddDriver(driver, password);
                }
            }

           

        }
    }
}
