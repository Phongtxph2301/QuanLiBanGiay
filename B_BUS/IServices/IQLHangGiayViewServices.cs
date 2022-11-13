using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLHangGiayViewServices
    {
        string Add(QLHangGiayView khv);
        string Update(QLHangGiayView khv);
        string Delete(Guid idGuid);
        List<QLHangGiayView> Getall();
    }
}
