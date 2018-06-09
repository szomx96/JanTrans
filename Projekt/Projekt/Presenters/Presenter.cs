using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Presenter
    {
        Model model;
        IView view;
        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;
            view.SendLogin += PresenterLogin;
        }
        private void PresenterLogin(string log, string pass)
        {

        }
    }
}