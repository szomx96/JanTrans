using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt.Forms;
namespace Projekt
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //LoginModel model = new LoginModel();
            //MainForm view = new MainForm();
            //Presenter p = new Presenter(model, view);
            //Application.Run(view);


            var formMain = new MainForm();


            Application.Run(formMain);
        }
    }
}
