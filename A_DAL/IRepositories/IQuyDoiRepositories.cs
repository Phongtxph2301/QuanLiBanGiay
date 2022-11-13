using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface IQuyDoiRepositories
    {
        bool Add(QuyDoi obj);
        bool Update(QuyDoi obj);
        bool Delete(QuyDoi obj);
        QuyDoi GetById(Guid id);//Phương thức này lấy theo id
        List<QuyDoi> GetAll();
    }
}
