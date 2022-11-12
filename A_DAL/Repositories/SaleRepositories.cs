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
    public class SaleRepositories :ISaleRepositories
    {
        private NahidaShoesDbContext _dbContext;

        public SaleRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(Sale obj)
        {
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.Sale.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(Sale obj)
        {
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.Sale.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaGiamGia = obj.MaGiamGia;
            tempobj.TenChuongTrinh = obj.TenChuongTrinh;
            tempobj.LuaChonGiamGia = obj.LuaChonGiamGia;
            tempobj.NgayBatDau = obj.NgayBatDau;
            tempobj.NgayKetThuc = obj.NgayKetThuc;
            tempobj.TrangThai = obj.TrangThai;

            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Sale obj)
        {
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.Sale.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public Sale GetByiD(Guid id)
        {
            if (id == null) return null;

            return _dbContext.Sale.FirstOrDefault(x => x.Id == id);
        }

        public List<Sale> GetAll()
        {
            return _dbContext.Sale.ToList();
        }
    }
}
