using Nhom3.DoAnKTHP.DAL.DAO;
using Nhom3.DoAnKTHP.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom3.DoAnKTHP.BLL
{
    
    public class DangSuKienBLL
    {
        public IEventMgtDAO<DangSuKien> dangSuKienDAO;

        public DangSuKienBLL()
        {
            dangSuKienDAO = new DangSuKienDAO();
        }

        public void AddDangSuKien(DangSuKien dangSuKien)
        {
            dangSuKienDAO.Add(dangSuKien);
        }
        
        public List<DangSuKien> GetAllDangSuKiens() {
            return dangSuKienDAO.GetAll();
        }

        public int UpdateDangSuKiens(DangSuKien dangSuKien)
        {
            return dangSuKienDAO.Update(dangSuKien);
        }
    }
}
