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
            view.SelectDrivers += PresenterSelectDrivers;
            view.LoadDriver += PresenteLoadDriver;
            view.SelectProducts += PresenterSelectProducts;
            view.CreateProduct += PresenterCertainProduct;
            view.CreateOrder += PresenterCreateOrder;
        }
       
        private bool PresenterCreateOrder(string drivID, string route, string from, string to, 
            string dep, string arr, string cap, string vol, List<Product> prodIDs)
        {
            return model.ModelCreateOrder(drivID, route, from, to, dep, arr, cap, vol, prodIDs);
        }
        private Product PresenterCertainProduct(int index)
        {
            return model.GetCertainProduct(index);
        }
        private List<Product> PresenterSelectProducts()
        {
            return model.GetProducts();
        }
        private string[] PresenterSelectDrivers(DateTime beg, DateTime end)
        {
           
            return model.SelectDrivers(beg, end);
        }

        private Driver PresenteLoadDriver( int id)
        {
            return model.ModelCertainDriver(id);
        }

    }
}
