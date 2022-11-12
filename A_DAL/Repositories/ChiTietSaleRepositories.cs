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
    public class ChiTietSaleRepositories :IChiTietSaleRepositories
    {
        private NahidaShoesDbContext _dbContext;

        public ChiTietSaleRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(ChiTietSale obj)
        {
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.ChiTietSale.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(ChiTietSale obj)
        {
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.ChiTietSale.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.IdSale = obj.IdSale;
            tempobj.IdChiTietGiay = obj.IdChiTietGiay;
            tempobj.TrangThai = obj.TrangThai;

            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietSale obj)
        {
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.ChiTietSale.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public ChiTietSale GetByiD(Guid id)
        {
            if (id == null) return null;

            return _dbContext.ChiTietSale.FirstOrDefault(x => x.Id == id);
        }

        public List<ChiTietSale> GetAll()
        {
            return _dbContext.ChiTietSale.ToList();
        }
    }
}
