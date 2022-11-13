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
    public class QLGiayViewServices:IQLGiayViewServices
    {
        private IGiayRepositories _giayrp;

        public QLGiayViewServices()
        {
            _giayrp = new GiayRepositories();
        }
        public string Add(QLGiayView khv)
        {
            //ADD
            Giay kh = new Giay()
            {
                Id = khv.Id,
                MaGiay = khv.MaGiay,
                TenGiay = khv.TenGiay,
                TrangThai = khv.TrangThai,


            };
            if (_giayrp.Add(kh))
            {
                return "thêm thành công";
            }

            return "thêm thất bại";
        }

        public string Update(QLGiayView khv)
        {
            //Update
            var x = _giayrp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaGiay = khv.MaGiay;
            x.TenGiay = khv.TenGiay;
            x.TrangThai = khv.TrangThai;

            if (_giayrp.Update(x))
            {
                return "sửa thành công";
            }
            return "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            var x = _giayrp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            if (_giayrp.Delete(x))
            {
                return "Xóa Thành Công";
            }

            return "Xóa thất Bại";
        }

        public List<QLGiayView> Getall()
        {
            //Getall
            return (from a in _giayrp.GetAll()
                select new QLGiayView()
                {
                    Id = a.Id,
                    MaGiay = a.MaGiay,
                    TenGiay = a.TenGiay,
                    TrangThai = a.TrangThai,

                }).ToList();
        }
    }
}
