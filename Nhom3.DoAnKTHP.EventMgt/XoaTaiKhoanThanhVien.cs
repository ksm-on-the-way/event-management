using Nhom3.DoAnKTHP.BLL;
using Nhom3.DoAnKTHP.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom3.DoAnKTHP.EventMgt
{
    public partial class XoaTaiKhoanThanhVien : Form
    {
        ThanhVien thanhVien;
        ThanhVienBLL thanhVienBLL = new ThanhVienBLL();
        DangKyThamGiaBLL dangKyThamGiaBLL = new DangKyThamGiaBLL();
        public XoaTaiKhoanThanhVien(ThanhVien thanhVien)
        {
            InitializeComponent();
            this.thanhVien = thanhVien;
        }

        private void XoaTaiKhoanThanhVien_Load(object sender, EventArgs e)
        {
            var thanhViens = from thanhVien in thanhVienBLL.GetAllThanhVien()
                             select new
                             {
                                 MaNguoiThamGia = thanhVien.MaThanhVien,
                                 TenNguoiThamGia = thanhVien.TenThanhVien,
                                 GioiTinh = thanhVien.GioiTinh == true ? "Nam" : (thanhVien.GioiTinh == false ? "Nữ" : null),
                                 SoDienThoai = thanhVien.SoDienThoai,
                                 Mssv = thanhVien.Mssv,
                                 Email = thanhVien.Email,
                                 MaVaiTro = thanhVien.MaVaiTro
                             };
            dgvDanhSachNguoiThamGia.DataSource = thanhViens.Where(xxx => xxx.MaVaiTro != 1).ToList();
            dgvDanhSachNguoiThamGia.Columns["MaNguoiThamGia"].Visible = false;
            dgvDanhSachNguoiThamGia.Columns["MaVaiTro"].Visible = false;
        }

        private void linkLblQuayVeTrangChu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (thanhVien.MaVaiTro == 3)
            {
                NguoiDungTrangChu nguoiDungTrangChu = new NguoiDungTrangChu(thanhVien);
                nguoiDungTrangChu.Show();
            }
            else if (thanhVien.MaVaiTro == 2)
            {
                BenToChucTrangChu benToChucTrangChu = new BenToChucTrangChu(thanhVien);
                benToChucTrangChu.Show();
            }
            else if (thanhVien.MaVaiTro == 1)
            {
                QuanTriVienTrangChu quanTriVienTrangChu = new QuanTriVienTrangChu(thanhVien);
                quanTriVienTrangChu.Show();
            }
            this.Hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa người tham gia này?", "Xóa người tham gia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Xóa tất cả đăng ký tham gia của người dùng này
                var maNguoiThamGia = dgvDanhSachNguoiThamGia.Rows[dgvDanhSachNguoiThamGia.CurrentCell.RowIndex].Cells[0].Value;
                var dangKyThamGias = dangKyThamGiaBLL.GetAllDangKyThamGias().Where(xxx => xxx.MaThanhVien.ToString() == maNguoiThamGia.ToString()).ToList();
                foreach (var dangKyThamGia in dangKyThamGias)
                {
                    dangKyThamGiaBLL.DeleteDangKyThamGias(dangKyThamGia);
                }


                //Xóa người dùng này
                thanhVienBLL.DeleteThanhVien(thanhVienBLL.GetThanhVienById(Int32.Parse(maNguoiThamGia.ToString())));

                //Load lại data
                var thanhViens = from thanhVien in thanhVienBLL.GetAllThanhVien()
                                 select new
                                 {
                                     MaNguoiThamGia = thanhVien.MaThanhVien,
                                     TenNguoiThamGia = thanhVien.TenThanhVien,
                                     GioiTinh = thanhVien.GioiTinh == true ? "Nam" : (thanhVien.GioiTinh == false ? "Nữ" : null),
                                     SoDienThoai = thanhVien.SoDienThoai,
                                     Mssv = thanhVien.Mssv,
                                     Email = thanhVien.Email,
                                     MaVaiTro = thanhVien.MaVaiTro
                                 };
                dgvDanhSachNguoiThamGia.DataSource = thanhViens.Where(xxx => xxx.MaVaiTro != 1).ToList();
                dgvDanhSachNguoiThamGia.Columns["MaNguoiThamGia"].Visible = false;
                dgvDanhSachNguoiThamGia.Columns["MaVaiTro"].Visible = false;
            }

        }


        private void dgvDanhSachNguoiThamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var maNguoiThamGia = dgvDanhSachNguoiThamGia.Rows[dgvDanhSachNguoiThamGia.CurrentCell.RowIndex].Cells[0].Value;
            lblTenThanhVien.Text = "Thành viên: " + thanhVienBLL.GetThanhVienById(Int32.Parse(maNguoiThamGia.ToString())).TenThanhVien;
        }

        private void XoaTaiKhoanThanhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn muốn thoát chương trình?", "Thoát chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

    }
}
