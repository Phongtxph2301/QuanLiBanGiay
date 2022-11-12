using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface IHangGiayRepositories
    {
        bool Add(HangGiay obj);
        bool Update(HangGiay obj);
        bool Delete(HangGiay obj);
        HangGiay GetByiD(Guid id);
        List< HangGiay> GetAll();

    }
}
