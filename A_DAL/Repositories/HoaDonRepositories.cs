using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class HoaDonRepositories:IHoaDonRepositories
    {
        public NahidaShoesDbContext _dbContext;

        public HoaDonRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }


        public bool Add(HoaDon obj)
        {
            //add
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.HoaDon.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(HoaDon obj)
        {
            //Update
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.HoaDon.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaHoaDon = obj.MaHoaDon;
            tempobj.ThoiGianTao = obj.ThoiGianThanhToan;
            tempobj.IdKhachHang = obj.IdKhachHang;
            tempobj.IdNhanVien = obj.IdNhanVien;
            tempobj.GiamGia = obj.GiamGia;
            tempobj.GhiChu = obj.GhiChu;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            //Delete
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.HoaDon.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public HoaDon GetById(Guid id)
        {
            if (id == null) return null;

            return _dbContext.HoaDon.FirstOrDefault(x => x.Id == id);
        }

        public List<HoaDon> GetAll()
        {
            return _dbContext.HoaDon.ToList();
        }
    }
}
