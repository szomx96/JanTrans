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
using Projekt.Models;
using Projekt.Presenters;

namespace Projekt.Forms
{
    public partial class NewOrder : UserControl, INewOrder
    {
        IViewChanger changer;

        public NewOrder(IViewChanger changer)
        {
            InitializeComponent();
            this.changer = changer;
        }

        #region properties

        public int DriverID
        {
            get
            {
                return int.Parse(labelDriverIDValue.Text);
            }

            set
            {
                labelDriverIDValue.Text = value.ToString();
            }
        }

        public string DriverName {
            get
            {
                return labelDriverNameValue.Text;
            }

            set
            {
                labelDriverNameValue.Text = value;
            }
        }
        public string DriverSurname {
            get
            {
                return labelDriverSurnameValue.Text;
            }

            set
            {
                labelDriverSurnameValue.Text = value;
            }
        }
       
        public string VehicleID {
            get
            {
                return labelVehicleIDValue.Text;
            }

            set
            {
                labelVehicleIDValue.Text = value;
            }
        }
        public string RouteLength {
            get
            {
                return textBoxRouteLength.Text;
            }

            set
            {
                textBoxRouteLength.Text = value;
            }
        }
        public string RouteFrom {
            get
            {
                return textBoxRouteFrom.Text;
            }

            set
            {
                textBoxRouteFrom.Text = value;
            }
        }
        public string RouteTo {
            get
            {
                return textBoxRouteTo.Text;
            }

            set
            {
                textBoxRouteTo.Text = value;
            }
        }

        public Driver Driver { get; set; }
        public Route Route { get; set; }
        public Vehicle Vehicle { get; set; }
        public List<Product> Products { get; set; }
        
        

        #endregion

        private void buttonBack_Click(object sender, EventArgs e)
        {
            changer.ShowAdminMain();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm productForm = new AddProductForm();
            var model = new AddProductModel();
            var presenter = new AddProductPresenter(model, productForm);
            productForm.ShowDialog();
        }

        public event Func<string[]> SelectDrivers;
        public event Func<Customer, bool> AddCustomer;


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
    }
}
