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
    public partial class NguoiDungTrangChu : Form
    {
        ThanhVien thanhVien;
        public NguoiDungTrangChu(ThanhVien thanhVien)
        {
            InitializeComponent();
            this.thanhVien = thanhVien;
        }

        private void NguoiDungTrangChu_Load(object sender, EventArgs e)
        {
            pictureAnhDaiDien.Image = byteArrayToImage(thanhVien.AnhDaiDien);
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void hồSơCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaHoSoCaNhan chinhSuaHoSoCaNhan = new ChinhSuaHoSoCaNhan(thanhVien);
            chinhSuaHoSoCaNhan.Show();
            this.Hide();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau(thanhVien);
            doiMatKhau.Show();
            this.Hide();
        }

        private void SuKienSapDienRaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuKienSapDienRa suKienSapDienRa = new SuKienSapDienRa(thanhVien);
            suKienSapDienRa.Show();
            this.Hide();
        }

        private void SuKienDaDangKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuKienDaDangKy suKienDaDangKy = new SuKienDaDangKy(thanhVien);
            suKienDaDangKy.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void NguoiDungTrangChu_FormClosing(object sender, FormClosingEventArgs e)
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

