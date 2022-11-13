using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLTheLoaiViewSerices:IQLTheLoaiViewServices
    {
        private ITheLoaiRepositories _tlrp;

        public QLTheLoaiViewSerices()
        {
            _tlrp = new TheLoaiRepositories();
        }

        public string Add(QLTheLoaiView khv)
        {
            //ADD
            TheLoai kh = new TheLoai()
            {
                Id = khv.Id,
                MaTheLoai = khv.MaTheLoai,
                TenTheLoai = khv.TenTheLoai,
                IdPhanCap = khv.IdPhanCap,
                TrangThai = khv.TrangThai,


            };
            if (_tlrp.Add(kh))
            {
                return "thêm thành công";
            }

            return "thêm thất bại";
        }

        public string Update(QLTheLoaiView khv)
        {
            //Update
            var x = _tlrp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaTheLoai = khv.MaTheLoai;
            x.TenTheLoai = khv.TenTheLoai;
            x.IdPhanCap = khv.IdPhanCap;
            x.TrangThai = khv.TrangThai;

            if (_tlrp.Update(x))
            {
                return "sửa thành công";
            }
            return "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            var x = _tlrp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            if (_tlrp.Delete(x))
            {
                return "Xóa Thành Công";
            }

            return "Xóa thất Bại";
        }

        public List<QLTheLoaiView> Getall()
        {
            //Getall
            return (from a in _tlrp.GetAll()
                select new QLTheLoaiView()
                {
                    Id = a.Id,
                    MaTheLoai = a.MaTheLoai,
                    TenTheLoai = a.TenTheLoai,
                    IdPhanCap = a.IdPhanCap,
                    TrangThai = a.TrangThai,

                }).ToList();
        }
    }
}
