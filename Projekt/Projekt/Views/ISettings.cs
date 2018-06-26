using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Views
{
    public interface ISettings
    {
        string OldPass { get; set; }
        string NewPass { get; set; }
        string NewPassRepeat { get; set; }

        event Func<int, string, string, bool> ChangePassword;
        event Func<string> GetUserID;
        event Func<string> CheckUserType;

    }
}
