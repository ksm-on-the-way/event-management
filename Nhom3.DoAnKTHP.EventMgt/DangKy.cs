using Nhom3.DoAnKTHP.BLL;
using Nhom3.DoAnKTHP.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom3.DoAnKTHP.EventMgt
{
    public partial class DangKy : Form
    {
        ThanhVienBLL thanhVienBLL = new ThanhVienBLL();
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtEmail.Focus();
            }
            else if (txtTenDangNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Text = "";
                txtMatKhau.Focus();
            }
            else if (thanhVienBLL.GetThanhVienByName(txtTenDangNhap.Text.Trim()) != null)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Text = "";
                txtMatKhau.Focus();
            }
            else if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!\nVui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNhapLaiMatKhau.Text = "";
                txtMatKhau.Focus();
            }
            else if (pictureAnhDaiDien.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh đại diện!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ThanhVien thanhVien = new ThanhVien();
                thanhVien.TenThanhVien = txtHoVaTen.Text;
                thanhVien.NgaySinh = DateOnly.Parse(dateTimeNgaySinh.Text);
                thanhVien.SoDienThoai = txtSoDienThoai.Text;
                thanhVien.Mssv = txtMssv.Text;
                if (radioBtnNam.Checked)
                {
                    thanhVien.GioiTinh = true;
                }
                else
                {
                    thanhVien.GioiTinh = false;
                }
                thanhVien.Email = txtEmail.Text;
                thanhVien.TenDangNhap = txtTenDangNhap.Text;
                thanhVien.MatKhau = txtMatKhau.Text;
                thanhVien.MaVaiTro = 3;
                thanhVien.AnhDaiDien = imageToByteArray(pictureAnhDaiDien);
                ThanhVienBLL thanhVienBLL = new ThanhVienBLL();
                thanhVienBLL.AddThanhVien(thanhVien);
                MessageBox.Show("Đăng ký thành công. Vui lòng đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DangNhap dangNhap = new DangNhap();
                dangNhap.Show();
                this.Hide();
            }
        }
        public byte[] imageToByteArray(PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
            return ms.ToArray();
        }

        private void DangKy_FormClosing(object sender, FormClosingEventArgs e)
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

        private void linkLblDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void btnChonAnhDaiDien_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgOpenFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureAnhDaiDien.Image = new Bitmap(dlgOpenFile.FileName);
            }
        }

        private void lblMssv_Click(object sender, EventArgs e)
        {

        }

        private void lblNhapLaiMatKhau_Click(object sender, EventArgs e)
        {

        }
    }
}
