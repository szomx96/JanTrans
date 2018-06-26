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
    public class AddCommodityPresenter
    {
        AddCommodityModel model;
        ICommodity view;

        public AddCommodityPresenter(AddCommodityModel model, ICommodity view)
        {
            this.model = model;
            this.view = view;
            view.InsertCommodity += PresenterAddCommodity;
            view.SelectCustomers += PresenterSelectCustomers;
          
        }

        private bool PresenterAddCommodity(Commodity commodity)
        {
            return model.InsertCommodity(commodity);
        }

        private List<Customer> PresenterSelectCustomers()
        {
            
            return model.SelectCustomers();
        }

    }
}
