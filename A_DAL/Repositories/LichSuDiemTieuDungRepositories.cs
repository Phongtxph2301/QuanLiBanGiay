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
    public class LichSuDiemTieuDungRepositories:ILichSuDiemTieuDungRepositories
    {
        private NahidaShoesDbContext _dbContext;

        public LichSuDiemTieuDungRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(LichSuDiemTieuDung obj)
        {
            //add
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.LichSuDiemTieuDung.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(LichSuDiemTieuDung obj)
        {
            //Update
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.LichSuDiemTieuDung.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.IdHoaDon = obj.IdHoaDon;
            tempobj.IdDiemTieuDung = obj.IdDiemTieuDung;
            tempobj.IdQuyDoi = obj.IdQuyDoi;
            tempobj.GiaTriQuyDoi = obj.GiaTriQuyDoi;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(LichSuDiemTieuDung obj)
        {
            //Delete
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.LichSuDiemTieuDung.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public LichSuDiemTieuDung GetById(Guid id)
        {
            if (id == null) return null;

            return _dbContext.LichSuDiemTieuDung.FirstOrDefault(x => x.Id == id);
        }

        public List<LichSuDiemTieuDung> GetAll()
        {
            return _dbContext.LichSuDiemTieuDung.ToList();
        }
    }
}
