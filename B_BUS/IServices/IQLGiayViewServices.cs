using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLGiayViewServices
    {
        string Add(QLGiayView khv);
        string Update(QLGiayView khv);
        string Delete(Guid idGuid);
        List<QLGiayView> Getall();
    }
}
