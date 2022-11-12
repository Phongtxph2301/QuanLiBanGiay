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
    public class HoaDonChiTietRepositories:IHoaDonChiTietrepositories
    {
        private NahidaShoesDbContext _dbContext;

        public HoaDonChiTietRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(HoaDonChiTiet obj)
        {
            //add
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.HoaDonChiTiet.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(HoaDonChiTiet obj)
        {
            //Update
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.HoaDonChiTiet.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.IdChiTietGiay = obj.IdChiTietGiay;
            tempobj.IdHoaDon= obj.IdHoaDon;
            tempobj.DonGia = obj.DonGia;

            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            //Delete
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.HoaDonChiTiet.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public HoaDonChiTiet GetByiD(Guid id)
        {
            if (id == null) return null;

            return _dbContext.HoaDonChiTiet.FirstOrDefault(x => x.Id == id);
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _dbContext.HoaDonChiTiet.ToList();
        }
    }
}
