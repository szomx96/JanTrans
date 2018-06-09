using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Views
{
    interface IUstawienia
    {
        string CurrentPassword { get; set; }
        string NewPassword1 { get; set; }
        string NewPassword2 { get; set; }
    }
}
