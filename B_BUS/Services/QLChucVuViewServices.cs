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
    public class QLChucVuViewServices:IQLChucVuViewServices
    {
        private IChucVureposiries _cvrp;

        public QLChucVuViewServices()
        {
            _cvrp = new ChucVuRepositories();
        }
        public string Add(QLChucVuView khv)
        {
            //ADD
            ChucVu kh = new ChucVu()
            {
                Id = khv.Id,
                MaChucVu = khv.MaChucVu,
                TenChucVu = khv.TenChucVu,
                TrangThai = khv.TrangThai,


            };
            if (_cvrp.Add(kh))
            {
                return "thêm thành công";
            }

            return "thêm thất bại";
        }

        public string Update(QLChucVuView khv)
        {
            //Update
            var x = _cvrp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaChucVu = khv.MaChucVu;
            x.TenChucVu = khv.TenChucVu;
            x.TrangThai = khv.TrangThai;

            if (_cvrp.Update(x))
            {
                return "sửa thành công";
            }
            return "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            var x = _cvrp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            if (_cvrp.Delete(x))
            {
                return "Xóa Thành Công";
            }

            return "Xóa thất Bại";
        }

        public List<QLChucVuView> Getall()
        {
            //Getall
            return (from a in _cvrp.GetAll()
                select new QLChucVuView()
                {
                    Id = a.Id,
                    MaChucVu = a.MaChucVu,
                    TenChucVu = a.TenChucVu,
                    TrangThai = a.TrangThai,

                }).ToList();
        }
    }
}
