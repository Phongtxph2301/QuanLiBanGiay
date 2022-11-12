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
     public class QuyDoiRepositories :IQuyDoiRepositories
     {
         private NahidaShoesDbContext _dbContext;

         public QuyDoiRepositories()
         {
             _dbContext = new NahidaShoesDbContext();
         }
        public bool Add(QuyDoi obj)
        {
            //add
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.QuyDoi.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(QuyDoi obj)
        {
            //Update
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.QuyDoi.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaQuyDoi = obj.MaQuyDoi;
            tempobj.GiaTriQuyDoi = obj.GiaTriQuyDoi;
            tempobj.GiaTriSauQuyDoi = obj.GiaTriSauQuyDoi;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(QuyDoi obj)
        {
            //Delete
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.QuyDoi.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public QuyDoi GetById(Guid id)
        {
            if (id == null) return null;

            return _dbContext.QuyDoi.FirstOrDefault(x => x.Id == id);
        }

        public List<QuyDoi> GetAll()
        {
            return _dbContext.QuyDoi.ToList();
        }
    }
}
