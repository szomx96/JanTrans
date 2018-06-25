using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt.Classes;
using Projekt.Views;

namespace Projekt.Forms
{
    public partial class AddProductForm : Form, IProduct
    {
        CultureInfo culture = new CultureInfo("en-GB");

        public AddProductForm()
        {
            InitializeComponent();
        }
        public double CommodityWeight
        {
            get
            {
                return double.Parse(textBoxCommodityWeight.Text);
            }

            set
            {
                textBoxCommodityWeight.Text = value.ToString();
            }
        }
        public double CommodityVolume
        {
            get
            {
                return double.Parse(textBoxCommodityVolume.Text);
            }

            set
            {
                textBoxCommodityVolume.Text = value.ToString();
            }
        }

        public string CustomerCompanyName
        {

            get
            {
                return textBoxCustomerCompanyName.Text;

            }

            set
            {
                textBoxCustomerCompanyName.Text = value;
            }
        }
        public string CustomerSurname
        {
            get
            {
                return textBoxCustomerSurname.Text;
            }

            set
            {
                textBoxCustomerSurname.Text = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return textBoxCustomerName.Text;
            }

            set
            {
                textBoxCustomerName.Text = value;
            }
        }

        public int CustomerID { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public List<Product> ProductList { get; set; }



        //private void buttonBack_Click(object sender, EventArgs e)
        //{
        //    changer.ShowNewOrder();
        //}


        public event Func<Customer, bool> AddCustomer;


        private void buttonCustomerAdd_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerCompanyName.Text != "" && textBoxCustomerName.Text != ""
                && textBoxCustomerSurname.Text != "")
            {
                Customer customer = new Customer(CustomerCompanyName, CustomerName, CustomerSurname);
                
                if (AddCustomer(customer))
                {
                    textBoxCustomerCompanyName.Enabled = false;
                    textBoxCustomerName.Enabled = false;
                    textBoxCustomerSurname.Enabled = false;
                }
            }
            else
            {
                //errorprovider;
            }
        }

        public event Func<List<Customer>> SelectCustomers;

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            foreach (Customer c in SelectCustomers())
            {
                comboBox1.Items.Add(c.CustomerCompanyName + " | " + c.CustomerName + " | " +
                    c.CustomerSurname);
            }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            textBoxCustomerCompanyName.Enabled = false;
            textBoxCustomerName.Enabled = false;
            textBoxCustomerSurname.Enabled = false;

            string[] customerInfo = comboBox1.SelectedItem.ToString().Split('|');

            //CustomerID = int.Parse(customerInfo[0]);
            CustomerCompanyName = customerInfo[0];
            CustomerName = customerInfo[1];
            CustomerSurname = customerInfo[2];

            Customer selectedCustomer = new Customer(CustomerCompanyName, CustomerName,
                CustomerSurname);
            Customer = selectedCustomer;

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if(textBoxCommodityVolume.Text == "") {// error provider 
            }
            else if(textBoxCommodityWeight.Text == "") { //error provider
            }
            else
            {
                textBoxCommodityVolume.Text = textBoxCommodityVolume.Text.Replace(',', '.');
                textBoxCommodityWeight.Text = textBoxCommodityWeight.Text.Replace(',', '.');

                double volume, weight;

                double.TryParse(textBoxCommodityVolume.Text, NumberStyles.Any, culture,
                    out volume);
                double.TryParse(textBoxCommodityWeight.Text, NumberStyles.Any, culture,
                    out weight);

                CommodityVolume = volume;
                CommodityWeight = weight;

                Product product = new Product(CommodityWeight, CommodityVolume, Customer);
                Product = product;
                ProductList.Add(Product);

                                
            }
        }
    }


}

