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
    public class SizeRepositories :ISizeRepositories
    {
        private NahidaShoesDbContext _dbContext;

        public SizeRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(Size obj)
        {
            //add
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.Size.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(Size obj)
        {
            //Update
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.Size.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaSize = obj.MaSize;
            tempobj.TenSize = obj.TenSize;
            tempobj.SoSize = obj.SoSize;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Size obj)
        {
            //Delete
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.Size.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public Size GetByiD(Guid id)
        {
            if (id == null) return null;

            return _dbContext.Size.FirstOrDefault(x => x.Id == id);
        }

        public List<Size> GetAll()
        {
            return _dbContext.Size.ToList();
        }
    }
}
