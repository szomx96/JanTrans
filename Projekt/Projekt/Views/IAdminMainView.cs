using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Classes;

namespace Projekt.Views
{
    public interface IAdminMainView
    {
        string CurrentDate { get; set; }
        string UserName { get; set; }
        string UserSurname { get; set; }
        string UserLogin { get; set; }
        
        int UserID { get; set; }

        event Func<string[]> LoadUserInfo;
        event Func<string> GetCurrentDate;
        event Func<int, List<Route>> GetMyOrders;

    }
}
