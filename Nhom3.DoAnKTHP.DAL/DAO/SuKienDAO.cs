using Nhom3.DoAnKTHP.DAL.DBConnection;
using Nhom3.DoAnKTHP.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom3.DoAnKTHP.DAL.DAO
{
    public class SuKienDAO : IEventMgtDAO<SuKien>
    {

        EventMgtContext db = new EventMgtContext();
        public SuKienDAO()
        {

        }

        public void Add(SuKien t)
        {
            db.SuKiens.Add(t);
            db.SaveChanges();
        }

        public int Delete(SuKien t)
        {
            db.SuKiens.Remove(t);
            return db.SaveChanges();
        }

        public SuKien? GetByName(string str)
        {
            return db.SuKiens.FirstOrDefault(xxx => xxx.TenSuKien.ToLower()==str.ToLower());
        }

        public List<SuKien> GetAll()
        {
            return db.SuKiens.ToList();
        }

        public int Update(SuKien t)
        {
            db.Update(t);
            return db.SaveChanges();
        }

        public SuKien? GetById(int id)
        {
            return db.SuKiens.FirstOrDefault(xxx=>xxx.MaSuKien ==  id);
        }
    }
}
