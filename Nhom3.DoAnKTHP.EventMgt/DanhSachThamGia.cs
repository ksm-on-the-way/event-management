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
    public partial class DanhSachThamGia : Form
    {
        SuKienBLL suKienBLL = new SuKienBLL();
        ThanhVienBLL thanhVienBLL = new ThanhVienBLL();
        DangKyThamGiaBLL dangKyThamGiaBLL = new DangKyThamGiaBLL();
        ChuDeBLL chuDeBLL = new ChuDeBLL();
        ThanhVien thanhVien;
        SuKien suKien;
        public DanhSachThamGia(ThanhVien thanhVien, SuKien suKien)
        {
            InitializeComponent();
            this.thanhVien = thanhVien;
            this.suKien = suKien;
        }

        private void DanhSachThamGia_Load(object sender, EventArgs e)
        {
            lblTenSuKien.Text = "Sự kiện: " + suKien.TenSuKien;

            var nguoiThamGias = from dangkythamgia in dangKyThamGiaBLL.GetAllDangKyThamGias()
                                join nguoithamgia in thanhVienBLL.GetAllThanhVien()
                                on dangkythamgia.MaThanhVien equals nguoithamgia.MaThanhVien
                                select new
                                {
                                    MaSuKien = dangkythamgia.MaSuKien,
                                    MaNguoiThamGia = dangkythamgia.MaThanhVien,
                                    TenNguoiThamGia = nguoithamgia.TenThanhVien,
                                    GioiTinh = nguoithamgia.GioiTinh == true ? "Nam" : "Nữ",
                                    SoDienThoai = nguoithamgia.SoDienThoai,
                                    Mssv = nguoithamgia.Mssv,
                                    Email = nguoithamgia.Email
                                };
            dgvDanhSachNguoiThamGia.DataSource = nguoiThamGias.Where(xxx => xxx.MaSuKien == suKien.MaSuKien).ToList();
            dgvDanhSachNguoiThamGia.Columns["MaSuKien"].Visible = false;
            dgvDanhSachNguoiThamGia.Columns["MaNguoiThamGia"].Visible = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (suKien.ThoiGianBatDau < DateTime.Now)
            {
                MessageBox.Show("Sự kiện này đã kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnXoa.Enabled = false;
                return;
            }
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa người tham gia này?", "Xóa người tham gia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Xóa một dòng đăng ký tham gia
                var maSuKien = dgvDanhSachNguoiThamGia.Rows[dgvDanhSachNguoiThamGia.CurrentCell.RowIndex].Cells[0].Value.ToString();
                var maNguoiThamGia = dgvDanhSachNguoiThamGia.Rows[dgvDanhSachNguoiThamGia.CurrentCell.RowIndex].Cells[1].Value.ToString();
                var dangKyThamGia = dangKyThamGiaBLL.GetAllDangKyThamGias().Where(xxx => xxx.MaSuKien.ToString() == maSuKien && xxx.MaThanhVien.ToString() == maNguoiThamGia).ToList()[0];
                dangKyThamGiaBLL.DeleteDangKyThamGias(dangKyThamGia);

                //Load lại datagridview
                var nguoiThamGias = from dangkythamgia in dangKyThamGiaBLL.GetAllDangKyThamGias()
                                    join nguoithamgia in thanhVienBLL.GetAllThanhVien()
                                    on dangkythamgia.MaThanhVien equals nguoithamgia.MaThanhVien
                                    select new
                                    {
                                        MaSuKien = dangkythamgia.MaSuKien,
                                        MaNguoiThamGia = dangkythamgia.MaThanhVien,
                                        TenNguoiThamGia = nguoithamgia.TenThanhVien,
                                        GioiTinh = nguoithamgia.GioiTinh == true ? "Nam" : "Nữ",
                                        SoDienThoai = nguoithamgia.SoDienThoai,
                                        Mssv = nguoithamgia.Mssv,
                                        Email = nguoithamgia.Email
                                    };
                dgvDanhSachNguoiThamGia.DataSource = null;
                dgvDanhSachNguoiThamGia.DataSource = nguoiThamGias.Where(xxx => xxx.MaSuKien == suKien.MaSuKien).ToList();
                dgvDanhSachNguoiThamGia.Columns["MaSuKien"].Visible = false;
                dgvDanhSachNguoiThamGia.Columns["MaNguoiThamGia"].Visible = false;
            }
            else
            {
                return;
            }

        }

        private void linkLblQuayLaiTrangChu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SuKienDaToChuc suKienDaToChuc = new SuKienDaToChuc(thanhVien);
            suKienDaToChuc.Show();
            this.Hide();
        }
    }
}
