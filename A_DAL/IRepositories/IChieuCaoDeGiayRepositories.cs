using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;

namespace A_DAL.IRepositories
{
   public interface IChieuCaoDeGiayRepositories
    {
        bool Add(ChieuCaoDeGiay obj);
        bool Update(ChieuCaoDeGiay obj);
        bool Delete(ChieuCaoDeGiay obj);
        ChieuCaoDeGiay GetByiD(Guid id);
        List<ChieuCaoDeGiay> GetAll();
    }
}
