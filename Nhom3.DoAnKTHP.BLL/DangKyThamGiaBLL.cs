using Nhom3.DoAnKTHP.DAL.DAO;
using Nhom3.DoAnKTHP.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom3.DoAnKTHP.BLL
{
    public class DangKyThamGiaBLL
    {
        public IEventMgtDAO<DangKyThamGia> dangKyThamGiaDAO;

        public DangKyThamGiaBLL() { 
            dangKyThamGiaDAO = new DangKyThamGiaDAO();
        }

        public void AddDangKyThamGia(DangKyThamGia dangKyThamGia)
        {
            dangKyThamGiaDAO.Add(dangKyThamGia);
        }

        public List<DangKyThamGia> GetAllDangKyThamGias()
        {
            return dangKyThamGiaDAO.GetAll();
        }

        public int UpdateDangKyThamGias(DangKyThamGia dangKyThamGia)
        {
            return dangKyThamGiaDAO.Update(dangKyThamGia);                        
        }

        public int DeleteDangKyThamGias(DangKyThamGia dangKyThamGia)
        {
            return dangKyThamGiaDAO.Delete(dangKyThamGia);
        }
    }
}
