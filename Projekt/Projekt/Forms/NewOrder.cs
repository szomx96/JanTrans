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

            if (comboBoxProducts.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxProducts, "Wybierz produkt do dodania");
            }
            else
            {
                errorProvider.Clear();  
                string str = comboBoxProducts.SelectedItem.ToString();
                string index = str.Substring(str.LastIndexOf(':') + 1);
                int id = Int32.Parse(index);
                Product p = CreateProduct(id);
                if (OccupiedCapacity + p.Weight > MaxCapacity || OccupiedVolume + p.Volume > MaxVolume)
                {
                    errorProvider.SetError(buttonAddProduct, "Przekroczono ładowność!");
                }
                else
                {
                    OccupiedCapacity += p.Weight;
                    OccupiedVolume += p.Volume;
                    MaxCapacity = maxCapacity;
                    MaxVolume = maxVolume;
                    addedProducts.Add(p);
                    listBoxProducts.Items.Add(str);
                }
            }
            
        }

        public event Func<DateTime, DateTime, string[]> SelectDrivers;
        public event Func<List<Product>> SelectProducts;
        public event Func<int, Driver> LoadDriver;
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
            if(ProperValues())
            {
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
                {
                    dateTimePickerBegin.Value = DateTime.Now;
                    dateTimePickerEnd.Value = DateTime.Now;
                    labelDriverIDValue.Text = "0";
                    labelDriverNameValue.Text = "";
                    labelDriverSurnameValue.Text = "";
                    labelCapacityValue.Text = "-";
                    labelVolumeValue.Text = "-";
                    textBoxRouteFrom.Clear();
                    textBoxRouteTo.Clear();
                    textBoxRouteLength.Clear();
                    comboBoxDrivers.Items.Clear();
                    comboBoxProducts.Items.Clear();
                    labelFreeCValue.Text = "-";
                    labelFreeVValue.Text = "-";
                    listBoxProducts.Items.Clear();


                    MessageBox.Show("Dodano rekord!");
                }
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {

            comboBoxDrivers.Items.Clear();                     
            comboBoxDrivers.Items.AddRange(SelectDrivers(BeginDate,EndDate));
        }

        private bool ProperValues()
        {
            double d = 0.0;
            errorProvider.Clear();
            if(dateTimePickerBegin.Value > dateTimePickerEnd.Value)
            {
                errorProvider.SetError(dateTimePickerEnd, "Data końcowa musi być późniejsza niż początkowa!");
                return false;
            }
            if(DriverID==0)
            {
                errorProvider.SetError(comboBoxDrivers, "Wybierz kierowcę!");
                return false;
            }
            if (RouteFrom == "")
            {
                errorProvider.SetError(textBoxRouteFrom, "Podaj miejsce!");
                return false;
            }
            if (RouteTo == "")
            {
                errorProvider.SetError(textBoxRouteTo, "Podaj miejsce!");
                return false;
            }
            if (!Double.TryParse(RouteLength, out d) || d <= 0) 
            {
                errorProvider.SetError(textBoxRouteLength, "Podaj odpowiednią wartość!");
                return false;
            }
            if(listBoxProducts.Items.Count <=0)
            {
                errorProvider.SetError(listBoxProducts, "Dodaj przynajmniej 1 produkt!");
                return false;
            }

            return true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] driverInfo = comboBoxDrivers.SelectedItem.ToString().Split(' ');

            DriverID = int.Parse(driverInfo[0]);
            Driver = LoadDriver(DriverID);
            DriverName = Driver.DriverName;
            DriverSurname = Driver.DriverSurname;
            MaxCapacity = Driver.Vehicle.VehicleCapacity;
            MaxVolume = Driver.Vehicle.VehicleVolume;
            //dateTimePickerBegin.Enabled = false;
            //dateTimePickerEnd.Enabled = false;

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
                string cust = p.Customer.CustomerCompanyName;
                string all = name + " " + w + "kg " + v + "m^3" + " dla "+ cust+" ID:" + ind;
                comboBoxProducts.Items.Add(all);
            }
        }
    }
}
