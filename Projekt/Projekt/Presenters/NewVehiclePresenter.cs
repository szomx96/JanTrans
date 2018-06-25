using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Views;
using Projekt.Models;

namespace Projekt.Presenters
{
    public class NewVehiclePresenter
    {
        NewVehicleModel model;
        IVehicle view;

        public NewVehiclePresenter(NewVehicleModel model, IVehicle view)
        {
            this.model = model;
            this.view = view;
            view.AddVehicle += PresenterAddVehicle;
        }

        private bool PresenterAddVehicle(Vehicle vehicle)
        {
            return model.InsertNewVehicle(vehicle);
        }

    }
}