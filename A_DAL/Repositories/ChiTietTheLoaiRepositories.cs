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
    public class ChiTietTheLoaiRepositories :IChiTietTheLoai
    {
        private NahidaShoesDbContext _dbContext;

        public ChiTietTheLoaiRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(ChiTietTheLoai obj)
        {
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.ChiTietTheLoai.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(ChiTietTheLoai obj)
        {
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.ChiTietTheLoai.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.IdTheLoai = obj.IdTheLoai;
            tempobj.IdChiTietGiay = obj.IdChiTietGiay;
            tempobj.TrangThai = obj.TrangThai;

            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietTheLoai obj)
        {
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.ChiTietTheLoai.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public ChiTietTheLoai GetByiD(Guid id)
        {
            if (id == null) return null;

            return _dbContext.ChiTietTheLoai.FirstOrDefault(x => x.Id == id);
        }

        public List<ChiTietTheLoai> GetAll()
        {
            return _dbContext.ChiTietTheLoai.ToList();
        }
    }
}
