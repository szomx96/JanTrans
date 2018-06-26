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
    public class AdminMainPresenter //reeeee ///normies out reeee
    {
        AdminMainModel model;
        IAdminMainView view;

        public AdminMainPresenter(AdminMainModel model, IAdminMainView view)
        {
            this.model = model;
            this.view = view;
            view.LoadUserInfo += PresenterUserInfo;
            view.GetCurrentDate += PresenterGetDate;
            view.GetMyOrders += PresenterGetMyOrders;
        }

        private string[] PresenterUserInfo()
        {
            return model.SelectUserInfo();   
        }

        private string PresenterGetDate()
        {
            return model.GetDate();
        }

        private List<Route> PresenterGetMyOrders(int userID)
        {
            return model.GetMyOrders(userID);
        }
    }
}
