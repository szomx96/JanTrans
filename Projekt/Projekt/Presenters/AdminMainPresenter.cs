using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class AdminMainPresenter //reeeee ///normies out reeee
    {
        AdminMainModel model;
        IAdminMainView view;

        public AdminMainPresenter(AdminMainModel model, IAdminMainView view)
        {
            this.model = model;
            this.view = view;           
        }
    }
}
