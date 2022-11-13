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
    public class MauSacrepositories:IMauSacRepositories
    {
        private NahidaShoesDbContext _dbContext;

        public MauSacrepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(MauSac obj)
        {
            //add
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.MauSac.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(MauSac obj)
        {
            //Update
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.MauSac.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaMauSac = obj.MaMauSac;
            tempobj.TenMauSac = obj.TenMauSac;
         
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(MauSac obj)
        {
            //Delete
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.MauSac.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public MauSac GetByiD(Guid id)
        {
            if (id == null) return null;

            return _dbContext.MauSac.FirstOrDefault(x => x.Id == id);
        }

        public List<MauSac> GetAll()
        {
            return _dbContext.MauSac.ToList();
        }
    }
}
