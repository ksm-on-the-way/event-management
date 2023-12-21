using Nhom3.DoAnKTHP.DAL.DBConnection;
using Nhom3.DoAnKTHP.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom3.DoAnKTHP.DAL.DAO
{
    public class DangKyThamGiaDAO : IEventMgtDAO<DangKyThamGia>
    {
        EventMgtContext db = new EventMgtContext();
        public void Add(DangKyThamGia t)
        {
            db.Add(t);
            db.SaveChanges();
        }

        public int Delete(DangKyThamGia t)
        {
            db.Remove(t);
            return db.SaveChanges();
        }

        public DangKyThamGia? GetByName(string str)
        {
            throw new NotImplementedException();
        }

        public List<DangKyThamGia> GetAll()
        {
            return db.DangKyThamGia.ToList();
        }

        public int Update(DangKyThamGia t)
        {
            db.Update(t);
            return db.SaveChanges();
        }

        public DangKyThamGia? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
