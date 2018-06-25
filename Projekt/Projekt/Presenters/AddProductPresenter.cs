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
    public class AddProductPresenter
    {
        AddProductModel model;
        IProduct view;

        public AddProductPresenter(AddProductModel model, IProduct view)
        {
            this.model = model;
            this.view = view;

            view.AddCustomer += PresenterAddCustomer;
            view.SelectCustomers += PresenterSelectCustomers;

        }

        private List<Customer> PresenterSelectCustomers()
        {
            // view.DriverName;
            return model.SelectCustomers();
        }

        private bool PresenterAddCustomer(Customer customer)
        {
            return model.InsertCustomer(customer);
        }




    }
}
