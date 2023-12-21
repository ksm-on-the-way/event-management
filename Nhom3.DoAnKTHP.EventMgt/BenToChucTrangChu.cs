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
    public partial class BenToChucTrangChu : Form
    {
        ThanhVien thanhVien;
        public BenToChucTrangChu(ThanhVien thanhVien)
        {
            InitializeComponent();
            this.thanhVien = thanhVien;
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

        private void sựKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuKienSapDienRa suKienSapDienRa = new SuKienSapDienRa(thanhVien);
            suKienSapDienRa.Show();
            this.Hide();
        }

        private void sựKiệnĐãThamGIaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuKienDaToChuc suKienDaToChuc = new SuKienDaToChuc(thanhVien);
            suKienDaToChuc.Show();
            this.Hide();
        }

        private void BenToChucTrangChu_Load(object sender, EventArgs e)
        {
            pictureAnhDaiDien.Image = byteArrayToImage(thanhVien.AnhDaiDien);
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void sựKiệnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TaoMoiSuKien taoMoiSuKien = new TaoMoiSuKien(thanhVien);
            taoMoiSuKien.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void BenToChucTrangChu_FormClosing(object sender, FormClosingEventArgs e)
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
