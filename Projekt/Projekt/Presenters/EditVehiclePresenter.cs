using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Models;
using Projekt.Views;

namespace Projekt.Presenters
{
    public class EditVehiclePresenter
    {
        EditVehicleModel model;
        IVehicle view;

        public EditVehiclePresenter(EditVehicleModel model, IVehicle view)
        {
            this.model = model;
            this.view = view;
            view.SelectVehicles += PresenterSelectVehicles;
            view.UpdateVehicleInfo += PresenterUpdateVehicleInfo;
                       
        }

        private string[] PresenterSelectVehicles()
        {

            return model.SelectVehicles();
        }

        private bool PresenterUpdateVehicleInfo(int id, string registration, double capacity, double volume)
        {
            return model.UpdateVehicleInfo(id, registration, capacity, volume);
        }

    }
}
