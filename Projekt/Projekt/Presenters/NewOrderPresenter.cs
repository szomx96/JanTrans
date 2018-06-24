using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Views;
using Projekt.Models;
using Projekt.Classes;

namespace Projekt.Presenters
{
    class NewOrderPresenter
    {
        NewOrderModel model;
        INewOrder view;

        public NewOrderPresenter(NewOrderModel model, INewOrder view)
        {
            this.model = model;
            this.view = view;
            view.AddCustomer += PresenterAddCustomer;

        }

        private bool PresenterAddCustomer(Customer customer)
        {
            return model.InsertCustomer(customer);           
        }

    }
}
