using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLChucVuViewServices
    {
        string Add(QLChucVuView khv);
        string Update(QLChucVuView khv);
        string Delete(Guid idGuid);
        List<QLChucVuView> Getall();
    }
}
