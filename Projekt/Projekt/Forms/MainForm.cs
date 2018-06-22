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
            var presenter = new LoginPresenter(model, view); 
            
            ShowControl(view);
            centerActualView();
        }

        public void ShowAdminMain()
        {
            var view = new AdminMainView(this);
            var model = new AdminMainModel(session);
            var presenter = new AdminMainPresenter(model, view);

            ShowControl(view);
            //niech ktos to przesunie gdzie trzeba plox dzieki

        }

        public void ShowKibel()
        {
            throw new NotImplementedException();
        }
        private void centerActualView()
        {
            control.Left = (this.Width - control.Width) / 2;
            control.Top = (this.Height - control.Height) / 2;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowLogin();
        }

      
    }
}
