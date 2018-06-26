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
    
     public partial class LoginView : UserControl, ILogin
    {
        IViewChanger changer;

        public LoginView(IViewChanger changer)
        {
            InitializeComponent();
            this.changer = changer;
        }
        public string Login
        {
            get { return textBoxLogin.Text; }
            set { textBoxLogin.Text = value; }
        }
        public string Password
        {
            get { return textBoxPassword.Text; }
            set { textBoxPassword.Text = value; }
        }
        public string Error
        {
            set { errorProvider.SetError(buttonLogin, value); }
        }

        public event Func<string, string, string> SendLogin;


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            errorProvider.Clear();
            if (SendLogin(Login, Password) == "admin")
            {                
                changer.ShowAdminMain();
            }else if(SendLogin(Login, Password) == "user")
            {
                changer.ShowUserView();
            }
            else
            {
                textBoxLogin.Clear();
                textBoxPassword.Clear();
                errorProvider.SetError(textBoxPassword, "Błędna nazwa użytkownika lub hasło");

            }
        }
    }
}
