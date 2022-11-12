using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface ICuaHangRepositories
    {
        bool Add(CuaHang obj);
        bool Update(CuaHang obj);
        bool Delete(CuaHang obj);
        CuaHang GetById(Guid id);//Phương thức này lấy theo id
        List<CuaHang> GetAll();
    }
}
  