using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Models;
using Projekt.Views;
using Projekt.Classes;

namespace Projekt.Presenters
{
    public class SettingsPresenter
    {
        SettingsModel model;
        ISettings view;

        public SettingsPresenter(SettingsModel model, ISettings view)
        {
            this.model = model;
            this.view = view;
            view.GetUserID += PresenterGetUserID;
            view.ChangePassword += PresenterChangePassword;
            view.CheckUserType += PresenterCheckUserType;
            
        }

        private string PresenterCheckUserType()
        {
            return model.GetUserType();
        }

        private bool PresenterChangePassword(int id, string oldPass, string newPass)
        {
            return model.ChangePassword(id, oldPass, newPass);
        }

        private string PresenterGetUserID()
        {
            return model.GetUserID();
        }


    }
}
