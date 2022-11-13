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
    public class HangGiayrepositories:IHangGiayRepositories
    {
        private NahidaShoesDbContext _dbContext;

        public HangGiayrepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(HangGiay obj)
        {
            //add
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.HangGiay.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(HangGiay obj)
        {
            //Update
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.HangGiay.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaHangGiay = obj.MaHangGiay;
            tempobj.TenHangGiay = obj.TenHangGiay;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HangGiay obj)
        {
            //Delete
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.HangGiay.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public HangGiay GetByiD(Guid id)
        {
            if (id == null) return null;

            return _dbContext.HangGiay.FirstOrDefault(x => x.Id == id);
        }

        public List<HangGiay> GetAll()
        {
            return _dbContext.HangGiay.ToList();
        }
    }
}
