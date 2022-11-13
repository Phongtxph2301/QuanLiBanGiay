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
    public class QLHangGiayViewServices:IQLHangGiayViewServices
    {
        private IHangGiayRepositories _hanggiayrp;

        public QLHangGiayViewServices()
        {
            _hanggiayrp = new HangGiayrepositories();
        }
        public string Add(QLHangGiayView khv)
        {
            //ADD
            HangGiay kh = new HangGiay()
            {
                Id = khv.Id,
                MaHangGiay = khv.MaHangGiay,
                TenHangGiay = khv.TenHangGiay,
                TrangThai = khv.TrangThai,


            };
            if (_hanggiayrp.Add(kh))
            {
                return "thêm thành công";
            }

            return "thêm thất bại";
        }

        public string Update(QLHangGiayView khv)
        {
            //Update
            var x = _hanggiayrp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaHangGiay = khv.MaHangGiay;
            x.TenHangGiay = khv.TenHangGiay;
            x.TrangThai = khv.TrangThai;

            if (_hanggiayrp.Update(x))
            {
                return "sửa thành công";
            }
            return "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            var x = _hanggiayrp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            if (_hanggiayrp.Delete(x))
            {
                return "Xóa Thành Công";
            }

            return "Xóa thất Bại";
        }

        public List<QLHangGiayView> Getall()
        {
            //Getall
            return (from a in _hanggiayrp.GetAll()
                select new QLHangGiayView()
                {
                    Id = a.Id,
                    MaHangGiay = a.MaHangGiay,
                    TenHangGiay = a.TenHangGiay,
                    TrangThai = a.TrangThai,

                }).ToList();
        }
    }
}
