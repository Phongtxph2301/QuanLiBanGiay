using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLNsxViewServices
    {
        string Add(QLNsxView khv);
        string Update(QLNsxView khv);
        string Delete(Guid idGuid);
        List<QLNsxView> Getall();
    }
}
