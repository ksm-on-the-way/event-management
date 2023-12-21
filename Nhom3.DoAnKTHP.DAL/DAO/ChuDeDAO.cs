using Nhom3.DoAnKTHP.DAL.DBConnection;
using Nhom3.DoAnKTHP.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom3.DoAnKTHP.DAL.DAO
{
    public class ChuDeDAO : IEventMgtDAO<ChuDe>
    {
        EventMgtContext db = new EventMgtContext();
        public void Add(ChuDe t)
        {
            throw new NotImplementedException();
        }

        public int Delete(ChuDe t)
        {
            throw new NotImplementedException();
        }

        public ChuDe? GetByName(string str)
        {
            throw new NotImplementedException();
        }

        public List<ChuDe> GetAll()
        {
            return db.ChuDes.ToList();
        }

        public int Update(ChuDe t)
        {
            throw new NotImplementedException();
        }

        public ChuDe? GetById(int id)
        {
            return db.ChuDes.FirstOrDefault(xxx => xxx.MaChuDe == id);
        }
    }
}
