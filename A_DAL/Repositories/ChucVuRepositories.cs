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
    public class ChucVuRepositories :IChucVureposiries
    {
        private NahidaShoesDbContext _dbContext;

        public ChucVuRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(ChucVu obj)
        {
            //add
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.ChucVu.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(ChucVu obj)
        {
            //Update
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.ChucVu.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaChucVu = obj.MaChucVu;
            tempobj.TenChucVu = obj.TenChucVu;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            //Delete
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.ChucVu.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public ChucVu GetById(Guid id)
        {
            if (id == null) return null;

            return _dbContext.ChucVu.FirstOrDefault(x => x.Id == id);
        }

        public List<ChucVu> GetAll()
        {
            return _dbContext.ChucVu.ToList();
        }
    }
}
