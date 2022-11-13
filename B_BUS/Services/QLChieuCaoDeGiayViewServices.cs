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
    public class QLChieuCaoDeGiayViewServices:IQLChieuCaoDeGiayViewServices
    {
        private IChieuCaoDeGiayRepositories _ccdgrp;

        public QLChieuCaoDeGiayViewServices()
        {
            _ccdgrp = new ChieuCaoDeGiayRepositories();
        }
        public string Add(QLChieuCaoDeGiayView khv)
        {
            //ADD
            ChieuCaoDeGiay kh = new ChieuCaoDeGiay()
            {
                Id = khv.Id,
                MaKichCo = khv.MaKichCo,
                KichCo = khv.KichCo,
                TrangThai = khv.TrangThai,


            };
            if (_ccdgrp.Add(kh))
            {
                return "thêm thành công";
            }

            return "thêm thất bại";
        }

        public string Update(QLChieuCaoDeGiayView khv)
        {
            //Update
            var x = _ccdgrp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaKichCo = khv.MaKichCo;
            x.KichCo = khv.KichCo;
            x.TrangThai = khv.TrangThai;

            if (_ccdgrp.Update(x))
            {
                return "sửa thành công";
            }
            return "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            var x = _ccdgrp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            if (_ccdgrp.Delete(x))
            {
                return "Xóa Thành Công";
            }

            return "Xóa thất Bại";
        }

        public List<QLChieuCaoDeGiayView> Getall()
        {
            //Getall
            return (from a in _ccdgrp.GetAll()
                select new QLChieuCaoDeGiayView()
                {
                    Id = a.Id,
                    MaKichCo = a.MaKichCo,
                    KichCo = a.KichCo,
                    TrangThai = a.TrangThai,

                }).ToList();
        }
    }
}
