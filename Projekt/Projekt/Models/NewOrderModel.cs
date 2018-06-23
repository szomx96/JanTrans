using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class NewOrderModel
    {

        ModelContainer container = new ModelContainer();

        public NewOrderModel() { }


        public NewOrderModel(ModelContainer container)
        {
            this.container = container;
        }



    }
}
