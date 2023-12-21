using Nhom3.DoAnKTHP.DAL.DBConnection;
using Nhom3.DoAnKTHP.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom3.DoAnKTHP.DAL.DAO
{
    public class ThongBaoDAO : IEventMgtDAO<ThongBao>
    {
        EventMgtContext db = new EventMgtContext();
        public void Add(ThongBao t)
        {
            db.Add(t);
            db.SaveChanges();
        }

        public int Delete(ThongBao t)
        {
            db.Remove(t);
            db.SaveChanges();
            return 1;
        }

        public ThongBao? GetByName(string str)
        {
            return db.ThongBaos.FirstOrDefault(xxx => xxx.NoiDung.ToLower().Contains(str.ToLower()));
        }

        public List<ThongBao> GetAll()
        {
            return db.ThongBaos.ToList();
        }

        public int Update(ThongBao t)
        {
            db.Update(t);
            return db.SaveChanges();
        }

        public ThongBao? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
