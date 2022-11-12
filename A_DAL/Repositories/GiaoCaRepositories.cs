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
    public class GiaoCaRepositories :IGiaoCaRepositories
    {
        private NahidaShoesDbContext _dbContext;

        public GiaoCaRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(GiaoCa obj)
        {
            //add
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.GiaoCa.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(GiaoCa obj)
        {
            //Update
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.GiaoCa.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.IdNhanVien = obj.IdNhanVien;
            tempobj.ThoiGianBatDau = obj.ThoiGianBatDau;
            tempobj.ThoiGianBatDau = obj.ThoiGianBatDau;
            tempobj.ThoiGianKetThuc = obj.ThoiGianKetThuc;
            tempobj.TienLai = obj.TienLai;
            tempobj.TienDuTru = obj.TienDuTru;
            tempobj.TienPhatSinh = obj.TienPhatSinh;
            tempobj.ChuThich =obj.ChuThich;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(GiaoCa obj)
        {
            //Delete
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.GiaoCa.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public GiaoCa GetByiD(Guid id)
        {
            if (id == null) return null;

            return _dbContext.GiaoCa.FirstOrDefault(x => x.Id == id);
        }

        public List<GiaoCa> GetAll()
        {
            return _dbContext.GiaoCa.ToList();
        }
    }
}
