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
    public class DiemTieuDungRepositories :IDiemTieuDungRepositories
    {
        private NahidaShoesDbContext _dbContext;

        public DiemTieuDungRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(DiemTieuDung obj)
        {
            //add
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.DiemTieuDung.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(DiemTieuDung obj)
        {
            //Update
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.DiemTieuDung.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaDiemTieuDung = obj.MaDiemTieuDung;
            tempobj.IdKhachHang = obj.IdKhachHang;
            tempobj.SoDiem = obj.SoDiem;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(DiemTieuDung obj)
        {
            //Delete
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.DiemTieuDung.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public DiemTieuDung GetById(Guid id)
        {
            if (id == null) return null;

            return _dbContext.DiemTieuDung.FirstOrDefault(x => x.Id == id);
        }

        public List<DiemTieuDung> GetAll()
        {
            return _dbContext.DiemTieuDung.ToList();
        }
    }
}
