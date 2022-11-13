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
    public class NsxRepositories:INsxRepositories
    {
        private NahidaShoesDbContext _dbContext;
        public NsxRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(Nsx obj)
        {
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _dbContext.Nsx.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(Nsx obj)
        {
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.Nsx.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.DiaChi = obj.DiaChi;
            tempobj.MaNsx = obj.MaNsx;
            tempobj.TenNsx = obj.TenNsx;
         
            
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Nsx obj)
        {
            if (obj == null) return false;
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            var tempobj = _dbContext.Nsx.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public Nsx GetByiD(Guid id)
        {
            if (id == null) return null;

            return _dbContext.Nsx.FirstOrDefault(x => x.Id == id);
        }

        public List<Nsx> GetAll()
        {
            return _dbContext.Nsx.ToList();
        }
    }
}
