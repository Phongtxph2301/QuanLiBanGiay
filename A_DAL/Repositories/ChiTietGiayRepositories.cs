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
    public class ChiTietGiayRepositories :IChiTietGiayRepositories
    {
        private NahidaShoesDbContext _dbContext;

        public ChiTietGiayRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(ChiTietGiay obj)
        {
            //add
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.ChiTietGiay.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(ChiTietGiay obj)
        {
            //Update
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.ChiTietGiay.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.IdMauSac = obj.IdMauSac;
            tempobj.IdNsx = obj.IdNsx;
            tempobj.IdSize = obj.IdSize;
            tempobj.IdHangGiay = obj.IdHangGiay;
            tempobj.IdChieuCaoDeGiay = obj.IdChieuCaoDeGiay;
            tempobj.IdGiay = obj.IdGiay;
            tempobj.MoTa = obj.MoTa;
            tempobj.GiaBan = obj.GiaBan;
            tempobj.GiaNhap =obj.GiaNhap;
            tempobj.SoLuongTon =obj.SoLuongTon;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietGiay obj)
        {
            throw new NotImplementedException();
        }

        public ChiTietGiay GetByiD(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ChiTietGiay> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
