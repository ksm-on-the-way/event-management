using Nhom3.DoAnKTHP.DAL.DBConnection;
using Nhom3.DoAnKTHP.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom3.DoAnKTHP.DAL.DAO
{
    public class ThanhVienDAO : IEventMgtDAO<ThanhVien>
    {
        EventMgtContext db = new EventMgtContext();

        public void Add(ThanhVien t)
        {
            db.Add(t);
            db.SaveChanges();
        }

        public ThanhVien? GetByName(string name)
        {
            return db.ThanhViens.FirstOrDefault(xxx => xxx.TenDangNhap == name);
        }

        public List<ThanhVien> GetAll()
        {
            return db.ThanhViens.ToList();
        }


        public int Delete(ThanhVien t)
        {
            db.ThanhViens.Remove(t);
            return db.SaveChanges();
        }

        public int Update(ThanhVien t)
        {
            db.Update(t);
            return db.SaveChanges();
        }

        public ThanhVien? GetById(int id)
        {
            return db.ThanhViens.FirstOrDefault(xxx=>xxx.MaThanhVien == id);
        }
    }
}
