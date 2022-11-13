using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLChieuCaoDeGiayViewServices
    {
        string Add(QLChieuCaoDeGiayView khv);
        string Update(QLChieuCaoDeGiayView khv);
        string Delete(Guid idGuid);
        List<QLChieuCaoDeGiayView> Getall();
    }
}
