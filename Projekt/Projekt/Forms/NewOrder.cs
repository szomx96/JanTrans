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

        public string CustomerCompanyName {

            get
            {
                return textBoxCustomerCompanyName.Text;

            }

            set
            {
                textBoxCustomerCompanyName.Text = value;
            }
        }
        public string CustomerSurname {
            get
            {
                return textBoxCustomerSurname.Text;
            }

            set
            {
                textBoxCustomerSurname.Text = value;
            }
        }
        public string CustomerName {
            get
            {
                return textBoxCustomerName.Text;
            }

            set
            {
                textBoxCustomerName.Text = value;
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
        public string CommodityWeight {
            get
            {
                return textBoxCommodityWeight.Text;
            }

            set
            {
                textBoxCommodityWeight.Text = value;
            }
        }
        public string CommodityVolume {
            get
            {
                return textBoxCommodityVolume.Text;
            }

            set
            {
                textBoxCommodityVolume.Text = value;
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
#endregion

        private void buttonBack_Click(object sender, EventArgs e)
        {
            changer.ShowAdminMain();
        }
    }
}
