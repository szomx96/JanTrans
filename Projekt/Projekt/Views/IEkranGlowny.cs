using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Views
{
    interface IEkranGlowny
    {
        string CurrentDate { get; set; }
        string UserName { get; set; }
        string UserSurname { get; set; }
        string UserLogin { get; set; }
        int UserID { get; set; }

    }
}
