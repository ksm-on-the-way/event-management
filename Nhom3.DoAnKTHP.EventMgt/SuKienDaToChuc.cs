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
    public partial class SuKienDaToChuc : Form
    {
        SuKienBLL suKienBLL = new SuKienBLL();
        ThanhVienBLL thanhVienBLL = new ThanhVienBLL();
        ChuDeBLL chuDeBLL = new ChuDeBLL();
        ThanhVien thanhVien;
        DangKyThamGiaBLL dangKyThamGiaBLL = new DangKyThamGiaBLL();
        DangSuKienBLL dangSuKienBLL = new DangSuKienBLL();
        public SuKienDaToChuc(ThanhVien thanhVien)
        {
            InitializeComponent();
            this.thanhVien = thanhVien;
        }

        private void SuKienDaToChuc_Load(object sender, EventArgs e)
        {
            //Load data cho datagridview
            var suKiens = from sukien in suKienBLL.GetAllSuKiens()
                          join benToChuc in thanhVienBLL.GetAllThanhVien()
                          on sukien.MaBenToChuc equals benToChuc.MaThanhVien
                          join chude in chuDeBLL.GetAllChuDes()
                          on sukien.MaChuDe equals chude.MaChuDe
                          join dangSuKien in dangSuKienBLL.GetAllDangSuKiens()
                          on sukien.MaSuKien equals dangSuKien.MaSuKien
                          select new
                          {
                              MaSuKien = sukien.MaSuKien,
                              MaBenToChuc = sukien.MaBenToChuc,
                              TenSuKien = sukien.TenSuKien,
                              DiaDiem = sukien.DiaDiem,
                              ThoiGianBatDau = sukien.ThoiGianBatDau,
                          };

            dgvDanhSachSuKien.DataSource = suKiens.Where(xxx => xxx.MaBenToChuc == thanhVien.MaThanhVien).ToList();
            dgvDanhSachSuKien.Columns["MaSuKien"].Visible = false;
            dgvDanhSachSuKien.Columns["MaBenToChuc"].Visible = false;

            // Load data cho combobox
            cbChuDe.DataSource = chuDeBLL.GetAllChuDes();
            cbChuDe.DisplayMember = "TenChuDe";
            cbChuDe.ValueMember = "MaChuDe";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var suKiens = from sukien in suKienBLL.GetAllSuKiens()
                          join benToChuc in thanhVienBLL.GetAllThanhVien()
                          on sukien.MaBenToChuc equals benToChuc.MaThanhVien
                          join chude in chuDeBLL.GetAllChuDes()
                          on sukien.MaChuDe equals chude.MaChuDe
                          join dangSuKien in dangSuKienBLL.GetAllDangSuKiens()
                          on sukien.MaSuKien equals dangSuKien.MaSuKien
                          select new
                          {
                              MaSuKien = sukien.MaSuKien,
                              MaBenToChuc = sukien.MaBenToChuc,
                              TenSuKien = sukien.TenSuKien,
                              DiaDiem = sukien.DiaDiem,
                              ThoiGianBatDau = sukien.ThoiGianBatDau,
                          };
            dgvDanhSachSuKien.DataSource = suKiens.Where(xxx => xxx.MaBenToChuc == thanhVien.MaThanhVien).Where(xxx => xxx.TenSuKien.Trim().ToLower().Contains(txtTuKhoa.Text.Trim().ToLower())).ToList();
            dgvDanhSachSuKien.Columns["MaSuKien"].Visible = false;
            dgvDanhSachSuKien.Columns["MaBenToChuc"].Visible = false;
        }

        private void cbChuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            var suKiens = from sukien in suKienBLL.GetAllSuKiens()
                          join benToChuc in thanhVienBLL.GetAllThanhVien()
                          on sukien.MaBenToChuc equals benToChuc.MaThanhVien
                          join chude in chuDeBLL.GetAllChuDes()
                          on sukien.MaChuDe equals chude.MaChuDe
                          join dangSuKien in dangSuKienBLL.GetAllDangSuKiens()
                          on sukien.MaSuKien equals dangSuKien.MaSuKien
                          select new
                          {
                              MaSuKien = sukien.MaSuKien,
                              MaBenToChuc = sukien.MaBenToChuc,
                              TenSuKien = sukien.TenSuKien,
                              ChuDe = chude.TenChuDe,
                              DiaDiem = sukien.DiaDiem,
                              ThoiGianBatDau = sukien.ThoiGianBatDau,
                          };
            if (cbChuDe.Text == "Tất cả")
            {
                dgvDanhSachSuKien.DataSource = suKiens.Where(xxx => xxx.MaBenToChuc == thanhVien.MaThanhVien).ToList();
            }
            else
            {
                dgvDanhSachSuKien.DataSource = suKiens.Where(xxx => xxx.MaBenToChuc == thanhVien.MaThanhVien).Where(xxx => xxx.ChuDe == cbChuDe.Text).ToList();
            }
            dgvDanhSachSuKien.Columns["masukien"].Visible = false;
            dgvDanhSachSuKien.Columns["MaBenToChuc"].Visible = false;
            dgvDanhSachSuKien.Columns["ChuDe"].Visible = false;
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSuKien.CurrentCell == null)
            {
                return;
            }
            else
            {
                var tenSuKien = dgvDanhSachSuKien.Rows[dgvDanhSachSuKien.CurrentCell.RowIndex].Cells[2].Value.ToString();
                var suKien = suKienBLL.GetSuKienByName(tenSuKien);
                ChiTietSuKien chiTietSuKien = new ChiTietSuKien(thanhVien, suKien);
                chiTietSuKien.Show();
            }

        }

        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {

            if (dgvDanhSachSuKien.CurrentCell == null)
            {
                return;
            }
            else
            {
                var tenSuKien = dgvDanhSachSuKien.Rows[dgvDanhSachSuKien.CurrentCell.RowIndex].Cells[2].Value.ToString();
                var suKien = suKienBLL.GetSuKienByName(tenSuKien);
                DanhSachThamGia danhSachThamGia = new DanhSachThamGia(thanhVien, suKien);
                danhSachThamGia.Show();
                this.Hide();
            }

        }

        private void btnChinhSuaSuKien_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSuKien.CurrentCell == null)
            {
                return;
            }
            else
            {
                var tenSuKien = dgvDanhSachSuKien.Rows[dgvDanhSachSuKien.CurrentCell.RowIndex].Cells[2].Value.ToString();
                var suKien = suKienBLL.GetSuKienByName(tenSuKien);
                if (suKien.ThoiGianBatDau < DateTime.Now)
                {
                    MessageBox.Show("Sự kiện này đã kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    ChinhSuaSuKien chinhSuaSuKien = new ChinhSuaSuKien(thanhVien, suKien);
                    chinhSuaSuKien.Show();
                }

            }

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
            }
            this.Hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSuKien.CurrentCell == null)
            {
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa sự kiện này?", "Xóa sự kiện", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    var tenSuKien = dgvDanhSachSuKien.Rows[dgvDanhSachSuKien.CurrentCell.RowIndex].Cells[2].Value.ToString();
                    var suKien = suKienBLL.GetSuKienByName(tenSuKien);
                    suKienBLL.DeleteSuKiens(suKien);
                    var danhsachdangky = dangKyThamGiaBLL.GetAllDangKyThamGias().Where(xxx => xxx.MaSuKien == suKien.MaSuKien);
                    foreach (var dangkythamgia in danhsachdangky)
                    {
                        dangKyThamGiaBLL.DeleteDangKyThamGias(dangkythamgia);
                    }
                    MessageBox.Show("Xóa sự kiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }

                //Load lại data
                var suKiens = from sukien in suKienBLL.GetAllSuKiens()
                              join benToChuc in thanhVienBLL.GetAllThanhVien()
                              on sukien.MaBenToChuc equals benToChuc.MaThanhVien
                              join chude in chuDeBLL.GetAllChuDes()
                              on sukien.MaChuDe equals chude.MaChuDe
                              join dangSuKien in dangSuKienBLL.GetAllDangSuKiens()
                              on sukien.MaSuKien equals dangSuKien.MaSuKien
                              select new
                              {
                                  MaSuKien = sukien.MaSuKien,
                                  MaBenToChuc = sukien.MaBenToChuc,
                                  TenSuKien = sukien.TenSuKien,
                                  DiaDiem = sukien.DiaDiem,
                                  ThoiGianBatDau = sukien.ThoiGianBatDau,
                              };

                dgvDanhSachSuKien.DataSource = suKiens.Where(xxx => xxx.MaBenToChuc == thanhVien.MaThanhVien).ToList();
                dgvDanhSachSuKien.Columns["MaSuKien"].Visible = false;
                dgvDanhSachSuKien.Columns["MaBenToChuc"].Visible = false;
            }


        }

        private void SuKienDaToChuc_FormClosing(object sender, FormClosingEventArgs e)
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

        private void grbTimKiem_Enter(object sender, EventArgs e)
        {

        }
    }
}
