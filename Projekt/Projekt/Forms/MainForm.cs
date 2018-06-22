using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projekt.Forms
{
    public partial class MainForm : Form, IViewChanger
    {
        UserControl control;
        ModelContainer session = new ModelContainer();
        public MainForm()
        {
            InitializeComponent();            
        }

        private void ShowControl(UserControl control)
        {
            Controls.Remove(this.control);
            this.control = control;
            Controls.Add(control);
        }
        public void ShowLogin()
        {
            var view = new LoginView(this);
            var model = new LoginModel(session); //sesja z userem
            var presenter = new Presenter(model, view); 
            
            ShowControl(control);
            //centerActualView();
        }

        public void ShowRegister()
        {
            throw new NotImplementedException();
        }

        public void ShowKibel()
        {
            throw new NotImplementedException();
        }
    }
}
