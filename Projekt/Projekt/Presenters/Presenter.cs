using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Views;
namespace Projekt
{
    public class Presenter
    {
        Model model;
        ILogin view;
        public Presenter(Model model, ILogin view)
        {
            this.model = model;
            this.view = view;
            view.SendLogin += PresenterLogin;
        }
        private void PresenterLogin(string log, string pass)
        {
            if (model.CheckLogin(log, pass))
            {

                if (model.LogedAs == "admin")
                {
                    Ekran_glowny ekran = new Ekran_glowny();
                    ekran.Show();
                    view = ekran;
                    
                    //  TU DODAC +=
                }
                else if (model.LogedAs == "user")
                {
                    Ekran_glowny ekran = new Ekran_glowny();
                    ekran.Show();
                    // TU DODAC +=
                }
                
            }
            else
            {
                view.Error = "Zla nazwa uzytkownika lub haslo!";
            }
            
            Console.WriteLine(model.LogedAs+" hehe "+model.LoginID);
        }
    }
}