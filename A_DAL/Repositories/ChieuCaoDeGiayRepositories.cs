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
    public class ChieuCaoDeGiayRepositories :IChieuCaoDeGiayRepositories
    {
        private NahidaShoesDbContext _dbContext;

        public ChieuCaoDeGiayRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }

        public bool Add(ChieuCaoDeGiay obj)
        {
            //add
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.ChieuCaoDeGiay.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(ChieuCaoDeGiay obj)
        {
            //Update
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.ChieuCaoDeGiay.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaKichCo = obj.MaKichCo;
            tempobj.KichCo = obj.KichCo;
  
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChieuCaoDeGiay obj)
        {
            //Delete
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.ChiTietGiay.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public ChieuCaoDeGiay GetByiD(Guid id)
        {
            if (id == null) return null;

            return _dbContext.ChieuCaoDeGiay.FirstOrDefault(x => x.Id == id);
        }

        public List<ChieuCaoDeGiay> GetAll()
        {
            return _dbContext.ChieuCaoDeGiay.ToList();
        }
    }
}
