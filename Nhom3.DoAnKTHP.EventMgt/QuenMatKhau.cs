using Nhom3.DoAnKTHP.BLL;
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
    public partial class QuenMatKhau : Form
    {

        ThanhVienBLL thanhVienBLL = new ThanhVienBLL();
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var thanhVien = thanhVienBLL.GetThanhVienByName(txtTenDangNhap.Text);
            if (txtTenDangNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (thanhVien == null)
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (thanhVien.Email != txtEmail.Text)
            {
                MessageBox.Show("Email bạn nhập chưa đúng. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (thanhVien.SoDienThoai != txtSoDienThoai.Text)
            {
                MessageBox.Show("Số điện thoại bạn nhập chưa đúng. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtMatKhauMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                thanhVien.MatKhau = txtMatKhauMoi.Text;
                thanhVienBLL.UpdateThanhVien(thanhVien);
                MessageBox.Show("Đổi mật khẩu thành công. Vui lòng đăng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DangNhap dangNhap = new DangNhap();
                dangNhap.Show();
                this.Hide();
            }
        }

        private void linkLblDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void QuenMatKhau_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void txtNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
