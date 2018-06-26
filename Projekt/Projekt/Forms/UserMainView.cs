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
    public partial class UserMainView : UserControl, IAdminMainView
    {
        IViewChanger changer;

        public UserMainView(IViewChanger changer)
        {
            InitializeComponent();
            this.changer = changer;
        }

        #region properties

        public string CurrentDate
        {
            get
            {
                return labelCurrentDate.Text;
            }

            set
            {
                labelCurrentDate.Text = value;
            }
        }

        public string UserName
        {
            get
            {
                return labelUserNameValue.Text;
            }

            set
            {
                labelUserNameValue.Text = value;
            }
        }

        public string UserSurname
        {
            get
            {
                return labelUserSurnameValue.Text;
            }

            set
            {
                labelUserSurnameValue.Text = value;
            }
        }

        public string UserLogin
        {
            get
            {
                return labelUserLoginValue.Text;
            }

            set
            {
                labelUserLoginValue.Text = value;
            }
        }

        public int UserID
        {
            get
            {
                return int.Parse(labelUserIDValue.Text);
            }

            set
            {
                labelUserIDValue.Text = value.ToString();
            }
        }

        #endregion

        public event Func<string[]> LoadUserInfo;
        public event Func<string> GetCurrentDate;

        private void UserMainView_Load(object sender, EventArgs e)
        {
            string[] info = LoadUserInfo();

            CurrentDate = GetCurrentDate();
            UserName = info[0];
            UserSurname = info[1];
            UserLogin = info[2];
            UserID = int.Parse(info[3]);
        }


        private void buttonSettings_Click(object sender, EventArgs e)
        {
            changer.ShowSettings();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            changer.ShowLogin();
        }
    }
}
