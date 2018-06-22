using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt.Forms
{
    public partial class AdminMainView : UserControl, IAdminMainView
    {
        IViewChanger changer;
        public AdminMainView(IViewChanger changer)
        {
            InitializeComponent();
            this.changer = changer;
        }

        //delet dis
        public string CurrentDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserSurname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserLogin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int UserID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
