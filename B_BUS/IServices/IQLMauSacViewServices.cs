using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLMauSacViewServices
    {
        string Add(QLMauSacview khv);
        string Update(QLMauSacview khv);
        string Delete(Guid idGuid);
        List<QLMauSacview> Getall();
    }
}
