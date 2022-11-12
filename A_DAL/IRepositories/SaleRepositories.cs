using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    internal interface SaleRepositories
    {
        bool Add(Sale obj);
        bool Update(Sale obj);
        bool Delete(Sale obj);
        Sale GetByiD(Guid id);
        List<Sale> GetAll();
    }
}
