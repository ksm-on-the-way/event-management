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
    public partial class DoiMatKhau : Form
    {
        ThanhVien thanhVien;
        public DoiMatKhau(ThanhVien thanhVien)
        {
            InitializeComponent();
            this.thanhVien = thanhVien;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (thanhVien.MatKhau != txtMatKhauHienTai.Text)
            {
                MessageBox.Show("Vui lòng nhập đúng mật khẩu hiện tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtMatKhauMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauMoi.Text = "";
                txtMatKhauMoi.Focus();
            }
            else if (txtMatKhauMoi.Text != txtNhapLaiMatKhauMoi.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!\nVui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNhapLaiMatKhauMoi.Text = "";
                txtMatKhauMoi.Focus();
            }
            else
            {
                thanhVien.MatKhau = txtMatKhauMoi.Text;
                ThanhVienBLL thanhVienBLL = new ThanhVienBLL();
                thanhVienBLL.UpdateThanhVien(thanhVien);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                quanTriVienTrangChu.Show();
                
            }

            this.Hide();
        }

        private void DoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
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

        private void lblMatKhauHienTai_Click(object sender, EventArgs e)
        {

        }
    }
}
