using Nhom3.DoAnKTHP.DAL.DAO;
using Nhom3.DoAnKTHP.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom3.DoAnKTHP.BLL
{
    public class SuKienBLL
    {
        public IEventMgtDAO<SuKien> suKienDAO;     

        public SuKienBLL()
        {
            suKienDAO = new SuKienDAO();
        }

        public void AddSuKien(SuKien suKien)
        {
            suKienDAO.Add(suKien);
        }

        public List<SuKien> GetAllSuKiens()
        {
            return suKienDAO.GetAll();
        }

        public SuKien GetSuKienById(int maSuKien)
        {
            return suKienDAO.GetById(maSuKien);
        }

        public SuKien GetSuKienByName(string name)
        {
            return suKienDAO.GetByName(name);
        }

        public int UpdateSuKiens(SuKien suKien)
        {
            return suKienDAO.Update(suKien);
        }

        public int DeleteSuKiens(SuKien suKien)
        {
            return suKienDAO.Delete(suKien);
        }

    }
}
