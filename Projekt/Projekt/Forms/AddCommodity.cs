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
using Projekt.Classes;

namespace Projekt.Forms
{
    public partial class AddCommodity : UserControl, ICommodity
    {
        CultureInfo culture = new CultureInfo("en-GB");

        IViewChanger changer;

        public AddCommodity(IViewChanger changer)
        {
            InitializeComponent();

            this.changer = changer;

        }

        public AddCommodity()
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

        public string CommodityName {
            get
            {
                return textBoxCommodityName.Text;
            }

            set
            {
                textBoxCommodityName.Text = value;
            }
        }

        public event Func<Commodity, bool> InsertCommodity;

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (textBoxCommodityVolume.Text == "")
            {
                errorProvider1.SetError(textBoxCommodityVolume, "Pole nie moze byc puste!");
            }
            else if (textBoxCommodityWeight.Text == "")
            {
                errorProvider2.SetError(textBoxCommodityWeight, "Pole nie moze byc puste!");
            }else if(textBoxCommodityName.Text == ""){

                errorProvider3.SetError(textBoxCommodityName, "Pole nie moze byc puste!");
            }else if(comboBox1.SelectedIndex == -1)
            {
                errorProvider4.SetError(comboBox1, "Wybierz klienta");
            }
            else
            {
                textBoxCommodityVolume.Text = textBoxCommodityVolume.Text.Replace(',', '.');
                textBoxCommodityWeight.Text = textBoxCommodityWeight.Text.Replace(',', '.');

                double volume, weight;

                if(
                double.TryParse(textBoxCommodityVolume.Text, NumberStyles.Any, culture,
                    out volume) &&
                double.TryParse(textBoxCommodityWeight.Text, NumberStyles.Any, culture,
                    out weight)
                    )
                {
                    CommodityVolume = volume;
                    CommodityWeight = weight;

                    string[] customerInfo = comboBox1.SelectedItem.ToString().Split(' ');

                    int id = int.Parse(customerInfo[0]);

                    Commodity commodity = new Commodity(id, CommodityName, CommodityVolume, CommodityWeight);

                    if (InsertCommodity(commodity))
                    {
                        textBoxCommodityName.Clear();
                        textBoxCommodityVolume.Clear();
                        textBoxCommodityWeight.Clear();
                        comboBox1.Items.Clear();
                        MessageBox.Show("Pomyślnie dodano towar");
                    }

                }
                else
                {
                    errorProvider1.SetError(textBoxCommodityVolume, "Nieprawidlowe wartosci");
                }





            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            changer.ShowAdminMain();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
   
        }

        public event Func<List<Customer>> SelectCustomers;

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            foreach (Customer c in SelectCustomers())
            {
                comboBox1.Items.Add(c.CustomerID + " " +c.CustomerCompanyName + " " 
                    + c.CustomerName + " " + c.CustomerSurname);
            }


        }

      
    }
}
