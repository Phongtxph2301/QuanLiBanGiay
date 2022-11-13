using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface IChiTietSaleRepositories
    {
        bool Add(ChiTietSale obj);
        bool Update(ChiTietSale obj);
        bool Delete(ChiTietSale obj);
        ChiTietSale GetByiD(Guid id);
        List<ChiTietSale> GetAll();
    }
}
