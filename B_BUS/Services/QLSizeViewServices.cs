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
    public class QLSizeViewServices:IQLSizeViewServices
    {
        private ISizeRepositories _sizerp;

        public QLSizeViewServices()
        {
            _sizerp = new SizeRepositories();
        }
        public string Add(QLSizeView khv)
        {
            //ADD
            Size kh = new Size()
            {
                Id = khv.Id,
                MaSize = khv.MaSize,
                TenSize = khv.TenSize,
                SoSize = khv.SoSize,
                TrangThai = khv.TrangThai,


            };
            if (_sizerp.Add(kh))
            {
                return "thêm thành công";
            }

            return "thêm thất bại";
        }

        public string Update(QLSizeView khv)
        {
            //Update
            var x = _sizerp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaSize = khv.MaSize;
            x.TenSize = khv.TenSize;
            x.SoSize = khv.SoSize;
            x.TrangThai = khv.TrangThai;

            if (_sizerp.Update(x))
            {
                return "sửa thành công";
            }
            return "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            var x = _sizerp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            if (_sizerp.Delete(x))
            {
                return "Xóa Thành Công";
            }

            return "Xóa thất Bại";
        }

        public List<QLSizeView> Getall()
        {
            //Getall
            return (from a in _sizerp.GetAll()
                select new QLSizeView()
                {
                    Id = a.Id,
                    MaSize = a.MaSize,
                    TenSize = a.TenSize,
                    TrangThai = a.TrangThai,

                }).ToList();
        }
    }
}
