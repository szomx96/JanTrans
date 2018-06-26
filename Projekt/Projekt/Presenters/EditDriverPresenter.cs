using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Models;
using Projekt.Views;

namespace Projekt.Presenters
{
    public class EditDriverPresenter
    {
        EditDriverModel model;
        IDriver view;

        public EditDriverPresenter(EditDriverModel model, IDriver view)
        {
            this.model = model;
            this.view = view;
            view.SelectDrivers += PresenterSelectDrivers;
            view.UpdateDriverInfo += PresenterUpdateDriverInfo;
        }

        private string[] PresenterSelectDrivers()
        {

            return model.SelectDrivers();
        }

        private bool PresenterUpdateDriverInfo(int id, string driverName, string driverSurname)
        {
            return model.UpdateDriverInfo(id, driverName, driverSurname);
        }


    }
}
