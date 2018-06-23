using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class AdminMainModel
    {
        ModelContainer container = new ModelContainer();
        AdminMainModel()
        {

        }

        public AdminMainModel(ModelContainer container)
        {
            this.container = container;
        }


    }

}
