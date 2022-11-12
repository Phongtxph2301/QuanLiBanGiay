using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface IGiaoCaRepositories
    {
        bool Add(GiaoCa obj);
        bool Update(GiaoCa obj);
        bool Delete(GiaoCa obj);
        GiaoCa GetByiD(Guid id);
        List<GiaoCa> GetAll();
    }
}
