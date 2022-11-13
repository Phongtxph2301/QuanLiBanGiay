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
    public class QLMauSacViewServices :IQLMauSacViewServices
    {
        private IMauSacRepositories _MauSacRp;
        private List<QLMauSacview> _ListMauView;

        public QLMauSacViewServices()
        {
            _MauSacRp = new MauSacrepositories();
            _ListMauView = new List<QLMauSacview>();
        }

        public string Add(QLMauSacview khv)
        {
            //ADD
            MauSac kh = new MauSac()
            {
                Id = khv.Id,
                MaMauSac = khv.MaMauSac,
                TenMauSac = khv.TenMauSac,
                TrangThai = khv.TrangThai,


            };
            if (_MauSacRp.Add(kh))
            {
                return "thêm thành công";
            }

            return "thêm thất bại";
        }

        public string Update(QLMauSacview khv)
        {
            //Update
            var x = _MauSacRp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaMauSac = khv.MaMauSac;
            x.TenMauSac = khv.TenMauSac;
            x.TrangThai = khv.TrangThai;

            if (_MauSacRp.Update(x))
            {
                return "sửa thành công";
            }
            return "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            var x = _MauSacRp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            if (_MauSacRp.Delete(x))
            {
                return "Xóa Thành Công";
            }

            return "Xóa thất Bại";
        }

        public List<QLMauSacview> Getall()
        {
            //Getall
            return (from a in _MauSacRp.GetAll()
                select new QLMauSacview()
                {
                    Id = a.Id,
                    MaMauSac = a.MaMauSac,
                    TenMauSac = a.TenMauSac,
                    TrangThai = a.TrangThai,

                }).ToList();
        }
    }
}
