using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Views
{
    public interface ILogin
    {
        string Login { get; set; }
        string Password { get; set; }
        string Error { set; }
        event Func<string, string, string> SendLogin;

    }
}
