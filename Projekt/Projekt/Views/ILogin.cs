using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public interface IView
    {
        string Login { get; set; }
        string Password { get; set; }

        event Action<string, string> SendLogin;

    }
}
