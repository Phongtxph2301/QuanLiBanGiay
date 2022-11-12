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
    public class CuaHangrepositories:ICuaHangRepositories
    {
        private NahidaShoesDbContext _dbContext;

        public CuaHangrepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(CuaHang obj)
        {
            //add
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.CuaHang.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(CuaHang obj)
        {
            //Update
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.CuaHang.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.DiaChi = obj.DiaChi;
            tempobj.MaCuaHang = obj.MaCuaHang;
            tempobj.TenCuaHang = obj.TenCuaHang;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(CuaHang obj)
        {
            //Delete
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.CuaHang.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public CuaHang GetById(Guid id)
        {
            if (id == null) return null;

            return _dbContext.CuaHang.FirstOrDefault(x => x.Id == id);
        }

        public List<CuaHang> GetAll()
        {
            return _dbContext.CuaHang.ToList();
        }
    }
}
