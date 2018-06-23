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
    public partial class AdminMainView : UserControl, IAdminMainView
    {
        IViewChanger changer;
        

        public AdminMainView(IViewChanger changer)
        {
            InitializeComponent();
            this.changer = changer;
        }  


      
        public string CurrentDate {
            get
            {
                return labelCurrentDate.Text;
            }

            set
            {
                labelCurrentDate.Text = value;
            }
        }


        public string UserName {

            get
            {
                return labelUserNameValue.Text;
            }

            set
            {
                labelUserNameValue.Text = value;
            }

        }
        public string UserSurname {

            get
            {
                return labelUserSurnameValue.Text;
            }

            set
            {
                labelUserNameValue.Text = value;
            }

        }

        public string UserLogin {

            get
            {
                return labelUserLoginValue.Text;
            }

            set
            {
                labelUserLoginValue.Text = value;
            }

        }
        public int UserID {

            get
            {
                return int.Parse(labelUserIDValue.Text);
            }

            set
            {
                labelUserIDValue.Text = value.ToString();
            }
        }

        private void noweZlecenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changer.ShowNewOrder();
        }

        private void kierowcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changer.ShowNewDriver();
        }
    }
}
