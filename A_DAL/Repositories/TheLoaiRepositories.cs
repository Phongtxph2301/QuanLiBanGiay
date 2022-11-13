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
    public class TheLoaiRepositories :ITheLoaiRepositories
    {
        private NahidaShoesDbContext _dbContext;
        public TheLoaiRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(TheLoai obj)
        {
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.TheLoai.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(TheLoai obj)
        {
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.TheLoai.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaTheLoai = obj.MaTheLoai;
            tempobj.TenTheLoai = obj.TenTheLoai;
            tempobj.IdPhanCap = obj.IdPhanCap;
            tempobj.TrangThai = obj.TrangThai;
          
          
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(TheLoai obj)
        {
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.TheLoai.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public TheLoai GetByiD(Guid id)
        {
            if (id == null) return null;

            return _dbContext.TheLoai.FirstOrDefault(x => x.Id == id);
        }

        public List<TheLoai> GetAll()
        {
            return _dbContext.TheLoai.ToList();
        }
    }
}
