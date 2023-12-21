using Nhom3.DoAnKTHP.DAL.DBConnection;
using Nhom3.DoAnKTHP.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom3.DoAnKTHP.DAL.DAO
{
    public class DangSuKienDAO : IEventMgtDAO<DangSuKien>
    {
        EventMgtContext db = new EventMgtContext();
        public void Add(DangSuKien t)
        {
            db.Add(t);
            db.SaveChanges();
        }

        public int Delete(DangSuKien t)
        {
            throw new NotImplementedException();
        }

        public DangSuKien? GetByName(string str)
        {
            throw new NotImplementedException();
        }

        public List<DangSuKien> GetAll()
        {
            return db.DangSuKiens.ToList();
        }

        public int Update(DangSuKien t)
        {
            db.Update(t);
            return db.SaveChanges();
        }

        public DangSuKien? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
