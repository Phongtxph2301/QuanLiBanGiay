using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface IChiTietTheLoai
    {
        bool Add(ChiTietTheLoai obj);
        bool Update(ChiTietTheLoai obj);
        bool Delete(ChiTietTheLoai obj);
        ChiTietTheLoai GetByiD(Guid id);
        List<ChiTietTheLoai> GetAll();
    }
}
