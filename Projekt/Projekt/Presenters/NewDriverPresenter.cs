using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Classes;
using Projekt.Models;
using Projekt.Views;

namespace Projekt.Presenters
{
    public class NewDriverPresenter
    {
        NewDriverModel model;
        IDriver view;

        public NewDriverPresenter(NewDriverModel model, IDriver view)
        {
            this.model = model;
            this.view = view;
            view.AddDriver += PresenterAddDriver;
        }

        private bool PresenterAddDriver(Driver driver, string password)
        {
            return model.InsertNewDriver(driver, password);
        }


    }
}