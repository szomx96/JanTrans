using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Views;
using Projekt.Classes;

namespace Projekt.Models
{
    public class SettingsModel
    {
        ModelContainer container = new ModelContainer();
        
        public SettingsModel() { } 
        

        public SettingsModel(ModelContainer container)
        {
            this.container = container;
        }

        internal bool ChangePassword(int id, string oldPass, string newPass)
        {
            try
            {
                container.Database.UpdatePassword(id, oldPass, newPass);
            }
            catch
            {
                return false;
            }

            return true;
        }

        internal string GetUserID()
        {
            return container.LoginID;
        }


    }
}
