using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public interface IView
    {
        event Action<string, string> SendLogin;

    }
}
