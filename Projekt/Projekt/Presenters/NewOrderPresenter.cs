using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Views;
using Projekt.Models;

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

        }

    }
}
