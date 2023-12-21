using Nhom3.DoAnKTHP.DAL.DTO;
using Nhom3.DoAnKTHP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom3.DoAnKTHP.DAL.DAO;

namespace Nhom3.DoAnKTHP.BLL
{
    public class ThanhVienBLL
    {
        public IEventMgtDAO<ThanhVien> thanhVienDAO;
        public ThanhVienBLL()
        {
            thanhVienDAO = new ThanhVienDAO();
        }

        public ThanhVien CheckLogin(string TenDangNhap, string MatKhau)
        {

            ThanhVien thanhVien = thanhVienDAO.GetByName(TenDangNhap);

            if (thanhVien == null)
            {
                return null;
            }
            if (thanhVien.MatKhau == MatKhau)
            {
                return thanhVien;
            }
            return null;
        }


        public void AddThanhVien(ThanhVien thanhVien)
        {
            thanhVienDAO.Add(thanhVien);
        }

        public ThanhVien GetThanhVienByName(string name)
        {
            return thanhVienDAO.GetByName(name);
        }

        public ThanhVien GetThanhVienById(int id)
        {
            return thanhVienDAO.GetById(id);
        }

        public int UpdateThanhVien(ThanhVien thanhVien)
        {
            return thanhVienDAO.Update(thanhVien);
        }

        public List<ThanhVien> GetAllThanhVien()
        {
            return thanhVienDAO.GetAll();
        }
        
        public int DeleteThanhVien(ThanhVien thanhVien)
        {
            return thanhVienDAO.Delete(thanhVien);
        }
    }
}
