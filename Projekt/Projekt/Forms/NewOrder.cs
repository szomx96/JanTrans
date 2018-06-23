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

        public string CustomerCompanyName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerSurname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DriverName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DriverSurname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CommodityWeight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CommodityVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string VehicleID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string RouteLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string RouteFrom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string RouteTo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
