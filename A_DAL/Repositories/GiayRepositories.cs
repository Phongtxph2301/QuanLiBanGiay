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
    public class GiayRepositories :IGiayRepositories
    {
        private NahidaShoesDbContext _dbContext;

        public GiayRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(Giay obj)
        {
            //add
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.Giay.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(Giay obj)
        {
            //Update
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.Giay.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaGiay= obj.MaGiay;
            tempobj.TenGiay = obj.TenGiay;
  
            tempobj.TrangThai = obj.TrangThai;
          
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Giay obj)
        {
            //Delete
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.Giay.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public Giay GetByiD(Guid id)
        {
            if (id == null) return null;

            return _dbContext.Giay.FirstOrDefault(x => x.Id == id);
        }

        public List<Giay> GetAll()
        {
            return _dbContext.Giay.ToList();
        }
    }
}
