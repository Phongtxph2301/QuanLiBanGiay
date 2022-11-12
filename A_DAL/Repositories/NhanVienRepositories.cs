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
    public class NhanVienRepositories :INhanVienRepositories
    {
        private NahidaShoesDbContext _dbContext;

        public NhanVienRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(NhanVien obj)
        {
            //add
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.NhanVien.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(NhanVien obj)
        {
            //Update
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.NhanVien.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.IdCuaHang = obj.IdCuaHang;
            tempobj.IdChucVu = obj.IdChucVu;
            tempobj.MaNhanVien = obj.MaNhanVien;
            tempobj.TenNhanVien = obj.TenNhanVien;
            tempobj.MatKhau = obj.MatKhau;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Email =obj.Email;
            tempobj.Sdt = obj.Sdt;
            tempobj.GioiTinh =obj.GioiTinh;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            //Delete
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.NhanVien.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public NhanVien GetById(Guid id)
        {
            if (id == null) return null;

            return _dbContext.NhanVien.FirstOrDefault(x => x.Id == id);
        }

        public List<NhanVien> GetAll()
        {
            return _dbContext.NhanVien.ToList();
        }
    }
}
