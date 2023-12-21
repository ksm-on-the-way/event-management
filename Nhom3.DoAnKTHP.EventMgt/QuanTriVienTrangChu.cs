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
    public partial class QuanTriVienTrangChu : Form
    {
        ThanhVien thanhVien;
        public QuanTriVienTrangChu(ThanhVien thanhVien)
        {
            InitializeComponent();
            this.thanhVien = thanhVien;
        }

        private void QuanTriVienTrangChu_Load(object sender, EventArgs e)
        {
            pictureAnhDaiDien.Image = byteArrayToImage(thanhVien.AnhDaiDien);
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau(thanhVien);
            doiMatKhau.Show();
            this.Hide();
        }

        private void sựKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuKienSapDienRa suKienSapDienRa = new SuKienSapDienRa(thanhVien);
            suKienSapDienRa.Show();
            this.Hide();
        }

        private void tạoTàiKhoảnĐơnVịTổChứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoTaiKhoanDonVi taoTaiKhoanDonVi = new TaoTaiKhoanDonVi(thanhVien);
            taoTaiKhoanDonVi.Show();
            this.Hide();
        }

        private void xóaTàiKhoảnThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaTaiKhoanThanhVien xoaTaiKhoanThanhVien = new XoaTaiKhoanThanhVien(thanhVien);
            xoaTaiKhoanThanhVien.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void SuKienDangChoDuyetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachSuKienChoDuyet danhSachSuKienChoDuyet = new DanhSachSuKienChoDuyet(thanhVien);
            danhSachSuKienChoDuyet.Show();
            this.Hide();
        }

        private void QuanTriVienTrangChu_FormClosing(object sender, FormClosingEventArgs e)
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
