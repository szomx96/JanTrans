using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class NewDriverModel
    {
        ModelContainer container = new ModelContainer();

        public NewDriverModel() { }

        public NewDriverModel(ModelContainer container)
        {
            this.container = container;
        }


    }
}
