using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface IGiayRepositories
    {
        bool Add(Giay obj);
        bool Update(Giay obj);
        bool Delete(Giay obj);
        Giay GetByiD(Guid id);
        List<Giay> GetAll();
    }
}
