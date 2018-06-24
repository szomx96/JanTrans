using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class AdminMainModel
    {
        ModelContainer container;
        //ModelContainer container = new ModelContainer();
        AdminMainModel()
        {

        }

        public AdminMainModel(ModelContainer container)
        {
            this.container = container;
        }

        internal string[] SelectUserInfo()
        {
            string[] info = container.Database.SelectUserInfo(container.LoginID);
            return info;
        }


    }

}
