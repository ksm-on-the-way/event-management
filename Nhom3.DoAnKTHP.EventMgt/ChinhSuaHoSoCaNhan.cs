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
    public partial class ChinhSuaHoSoCaNhan : Form
    {
        ThanhVien thanhVien;
        public ChinhSuaHoSoCaNhan(ThanhVien thanhVien)
        {
            InitializeComponent();
            this.thanhVien = thanhVien;
        }

        private void ChinhSuaHoSoCaNhan_Load(object sender, EventArgs e)
        {
            if (thanhVien.MaVaiTro == 2)
            {
                txtMssv.Enabled = false;
            }
            txtHoVaTen.Text = thanhVien.TenThanhVien;
            DateTime a;
            DateTime.TryParse(thanhVien.NgaySinh.ToString(), out a);
            dateTimeNgaySinh.Value = a;
            pictureAnhDaiDien.Image = byteArrayToImage(thanhVien.AnhDaiDien);
            txtMssv.Text = thanhVien.Mssv;
            txtSoDienThoai.Text = thanhVien.SoDienThoai;
            txtEmail.Text = thanhVien.Email;
        }

        public byte[] imageToByteArray(PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
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

        private void btnChonAnhDaiDien_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgOpenFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureAnhDaiDien.Image = new Bitmap(dlgOpenFile.FileName);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtEmail.Focus();
            }
            else if (pictureAnhDaiDien.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh đại diện!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                thanhVien.TenThanhVien = txtHoVaTen.Text;
                thanhVien.NgaySinh = DateOnly.Parse(dateTimeNgaySinh.Text);
                thanhVien.SoDienThoai = txtSoDienThoai.Text;
                thanhVien.Email = txtEmail.Text;
                thanhVien.Mssv = txtMssv.Text;
                thanhVien.AnhDaiDien = imageToByteArray(pictureAnhDaiDien);
                ThanhVienBLL thanhVienBLL = new ThanhVienBLL();
                thanhVienBLL.UpdateThanhVien(thanhVien);
                MessageBox.Show("Chỉnh sửa thành công. Trở lại màn hình chính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NguoiDungTrangChu nguoiDungTrangChu = new NguoiDungTrangChu(thanhVien);
                nguoiDungTrangChu.Show();
                this.Hide();
            }
        }

        private void ChinhSuaHoSoCaNhan_FormClosing(object sender, FormClosingEventArgs e)
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
