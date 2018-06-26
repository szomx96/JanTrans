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
    public partial class Settings : UserControl, ISettings
    {

        IViewChanger changer;

        public Settings(IViewChanger changer)
        {
            InitializeComponent();

            this.changer = changer;

        }


        public string OldPass {

            get
            {
                return textBoxOldPass.Text;   
            }

            set
            {
                textBoxOldPass.Text = value;
            }

        }
        public string NewPass {

            get
            {
                return textBoxNewPass.Text;
            }

            set
            {
                textBoxNewPass.Text = value;
            }

        }
        public string NewPassRepeat {

            get
            {
                return textBoxNewPassRepeat.Text;
            }

            set
            {
                textBoxNewPass.Text = value;
            }

        }

        public event Func<int, string, string, bool> ChangePassword;
        public event Func<string> GetUserID;
        public event Func<string> CheckUserType;

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            int id = int.Parse(GetUserID());

            if(textBoxOldPass.Text == "")
            {
                errorProvider1.SetError(textBoxOldPass, "Pole nie moze byc puste!");
            }else if(textBoxNewPass.Text == ""){
                errorProvider2.SetError(textBoxNewPass, "Pole nie moze byc puste!");
            }else if(textBoxNewPassRepeat.Text == "")
            {
                errorProvider3.SetError(textBoxNewPassRepeat, "Pole nie moze byc puste!");
            }

            if (NewPass != NewPassRepeat)
            {
                errorProvider1.SetError(textBoxNewPass, "Hasla nie sa takie same.");
            }
            else
            {

                if (ChangePassword(id, OldPass, NewPass))
                {
                    textBoxOldPass.Clear();
                    textBoxNewPass.Clear();
                    textBoxNewPassRepeat.Clear();
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (CheckUserType() == "admin")
            {
                changer.ShowAdminMain();
            }else if (CheckUserType() == "user")
            {
                changer.ShowUserView();
            }
        }
    }
}
