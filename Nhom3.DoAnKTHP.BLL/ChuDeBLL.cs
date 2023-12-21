using Nhom3.DoAnKTHP.DAL.DAO;
using Nhom3.DoAnKTHP.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom3.DoAnKTHP.BLL
{
    public class ChuDeBLL
    {
        public IEventMgtDAO<ChuDe> chuDeDAO;
        public ChuDeBLL()
        {
            chuDeDAO = new ChuDeDAO();
        }
        public List<ChuDe> GetAllChuDes()
        {
            return chuDeDAO.GetAll();
        }

        public ChuDe GetChuDeById(int id)
        {
            return chuDeDAO.GetById(id);
        }
    }
}
