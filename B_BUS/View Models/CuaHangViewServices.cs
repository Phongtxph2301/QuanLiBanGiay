using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;

namespace B_BUS.View_Models
{
    public class CuaHangViewServices:IQLCuaHangViewservices
    {
        private ICuaHangRepositories _chrp;

        public CuaHangViewServices()
        {
            _chrp = new CuaHangrepositories();
        }

        public string Add(QLCuaHangView khv)
        {
            //ADD
            CuaHang kh = new CuaHang()
            {
                Id = khv.Id,
                MaCuaHang = khv.MaCuaHang,
                TenCuaHang = khv.TenCuaHang,
                DiaChi = khv.DiaChi,
                TrangThai = khv.TrangThai,


            };
            if (_chrp.Add(kh))
            {
                return "thêm thành công";
            }

            return "thêm thất bại";
        }

        public string Update(QLCuaHangView khv)
        {
            //Update
            var x = _chrp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaCuaHang = khv.MaCuaHang;
            x.TenCuaHang = khv.TenCuaHang;
            x.TrangThai = khv.TrangThai;

            if (_chrp.Update(x))
            {
                return "sửa thành công";
            }
            return "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            var x = _chrp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            if (_chrp.Delete(x))
            {
                return "Xóa Thành Công";
            }

            return "Xóa thất Bại";
        }

        public List<QLCuaHangView> Getall()
        {
            //Getall
            return (from a in _chrp.GetAll()
                select new QLCuaHangView()
                {
                    Id = a.Id,
                    MaCuaHang = a.MaCuaHang,
                    TenCuaHang = a.TenCuaHang,
                    DiaChi = a.DiaChi,
                    TrangThai = a.TrangThai,

                }).ToList();
        }
    }
}
