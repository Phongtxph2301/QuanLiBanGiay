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
    public class QLNsxViewServices: IQLNsxViewServices
    {
        private INsxRepositories _Nsxrp;
        private List<Nsx> _list;
        public QLNsxViewServices()
        {
            _Nsxrp = new NsxRepositories();
            _list = new List<Nsx>();
        }
        public string Add(QLNsxView khv)
        {
            //ADD
            Nsx kh = new Nsx()
            {
                Id = khv.Id,
                MaNsx = khv.MaNsx,
                TenNsx = khv.TenNsx,
                DiaChi = khv.DiaChi,

            };
            if (_Nsxrp.Add(kh))
            {
                return "thêm thành công";
            }

            return "thêm thất bại";
        }

        public string Update(QLNsxView khv)
        {
            //Update
            var x = _Nsxrp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaNsx = khv.MaNsx;
            x.TenNsx = khv.TenNsx;
            x.DiaChi = khv.DiaChi;

            if (_Nsxrp.Update(x))
            {
                return "sửa thành công";
            }
            return "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            var x = _Nsxrp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            if (_Nsxrp.Delete(x))
            {
                return "Xóa Thành Công";
            }

            return "Xóa thất Bại";
        }

        public List<QLNsxView> Getall()
        {
            //Getall
            return (from a in _Nsxrp.GetAll()
                select new QLNsxView()
                {
                    Id = a.Id,
                    MaNsx = a.MaNsx,
                    TenNsx = a.TenNsx,
                    DiaChi = a.DiaChi,

                }).ToList();
        }
    }
}
