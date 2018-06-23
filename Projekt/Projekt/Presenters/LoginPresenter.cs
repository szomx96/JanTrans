using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Views;
using Projekt.Models;

namespace Projekt.Presenters
{
    public class LoginPresenter
    {
        LoginModel model;
        ILogin view;
        public LoginPresenter(LoginModel model, ILogin view)
        {
            this.model = model;
            this.view = view;
            view.SendLogin += PresenterLogin;
        }

        private string PresenterLogin(string log, string pass)
        {
            if (model.CheckLogin(log, pass))
            {
                return model.LoggedAs;
            }
            else return "";
            //    if (model.LogedAs == "admin")
            //    {
                   
            //        AdminMainView ekran = new AdminMainView();
            //        ekran.Show();
            //        //view = ekran;
                    
            //        //  TU DODAC +=
            //    }
            //    else if (model.LogedAs == "user")
            //    {
            //        AdminMainView ekran = new AdminMainView();
            //        ekran.Show();
            //        // TU DODAC +=
            //    }
                
            //}
            //else
            //{
            //    view.Error = "Zla nazwa uzytkownika lub haslo!";
            //}
            
            //Console.WriteLine(model.LogedAs+" hehe "+model.LoginID);
        }
    }
}