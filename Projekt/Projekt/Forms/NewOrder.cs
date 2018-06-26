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
        List<Product> products = new List<Product>();
        List<Product> addedProducts = new List<Product>();
        double maxCapacity, maxVolume, actualCapacity, actualVolume;


        #region properties

        public DateTime BeginDate
        {
            get { return dateTimePickerBegin.Value; }
            set { dateTimePickerBegin.Value = DateTime.Now; }
        }
        public DateTime EndDate
        {
            get { return dateTimePickerEnd.Value; }
            set { dateTimePickerEnd.Value = DateTime.Now; }
        }
        public double OccupiedCapacity { get; set; }
        public double OccupiedVolume { get; set; }
        public double MaxCapacity
        {
            get { return maxCapacity; }
            set
            {
                maxCapacity = value;
                labelCapacityValue.Text = maxCapacity.ToString();
                labelFreeCValue.Text = (maxCapacity - OccupiedCapacity).ToString();
            }
        }
        public double MaxVolume
        {
            get { return maxVolume; }
            set
            {
                maxVolume = value;
                labelVolumeValue.Text = maxVolume.ToString();
                labelFreeVValue.Text = (maxVolume - OccupiedVolume).ToString();
            }
        }
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
       
        //public string VehicleID {
        //    get
        //    {
        //        return labelVehicleIDValue.Text;
        //    }

        //    set
        //    {
        //        labelVehicleIDValue.Text = value;
        //    }
        //}
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
            //AddProductForm productForm = new AddProductForm();
            //var model = new AddProductModel();
            //var presenter = new AddProductPresenter(model, productForm);
            //productForm.ShowDialog();
            string str = comboBoxProducts.SelectedIndex.ToString();
            string index = str.Substring(str.LastIndexOf(':') + 1);            
            int id = Int32.Parse(index)+1;
            Product p = CreateProduct(id);
            OccupiedCapacity += p.Weight;
            OccupiedVolume += p.Volume;
            MaxCapacity = maxCapacity;
            MaxVolume = maxVolume;
            addedProducts.Add(p);
            listBoxProducts.Items.Add(p.ProductName+" "+p.Weight+ " "+p.Volume);
            
        }

        public event Func<DateTime, DateTime, string[]> SelectDrivers;
        public event Func<List<Product>> SelectProducts;
        public event Func<int ,Driver> LoadDriver;
        public event Func<int, Product> CreateProduct;
        public event Func<string, string, string, string, string, string, string, string, List<Product>, bool> CreateOrder;


        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            int ind = listBoxProducts.SelectedIndex;
            OccupiedCapacity -= addedProducts[ind].Weight;
            OccupiedVolume -= addedProducts[ind].Volume;
            addedProducts.RemoveAt(ind);
            listBoxProducts.Items.RemoveAt(ind);
            MaxCapacity = maxCapacity;
            MaxVolume = maxVolume;
            buttonDeleteProduct.Enabled = false;
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteProduct.Enabled = true;
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            //string drivID, string route, string from, string to, string dep, string arr, string cap, string vol
            string drID = Driver.DriverID.ToString();
            string route = textBoxRouteLength.Text;
            string from = textBoxRouteFrom.Text;
            string to = textBoxRouteTo.Text;
            string format = "yyyy-MM-dd HH:mm:ss";
            string dep = EndDate.ToString(format);
            string arr = BeginDate.ToString(format);
            string cap = labelFreeCValue.Text;
            string vol = labelFreeVValue.Text;
            if (CreateOrder(drID, route, from, to, dep, arr, cap, vol, addedProducts))
                MessageBox.Show("Dodano rekord!");

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {

            comboBoxDrivers.Items.Clear();                     
            comboBoxDrivers.Items.AddRange(SelectDrivers(BeginDate,EndDate));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] driverInfo = comboBoxDrivers.SelectedItem.ToString().Split(' ');

            DriverID = int.Parse(driverInfo[0]);
            Driver = LoadDriver(DriverID);
            MaxCapacity = Driver.Vehicle.VehicleCapacity;
            MaxVolume = Driver.Vehicle.VehicleVolume;
            

        }

        private void comboBoxProducts_DropDown(object sender, EventArgs e)
        {
            comboBoxProducts.Items.Clear();
            products=SelectProducts();
            foreach(Product p in products)
            {
                string name = p.ProductName;
                string w = p.Weight.ToString();
                string v = p.Volume.ToString();
                string ind = p.ProductID.ToString();
                string all = name + " " + w + "kg " + v + "m^3" + " ID:" + ind;
                comboBoxProducts.Items.Add(all);
            }
        }
    }
}
