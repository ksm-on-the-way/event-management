using Nhom3.DoAnKTHP.BLL;
using Nhom3.DoAnKTHP.DAL.DTO;

namespace Nhom3.DoAnKTHP.EventMgt
{
    public partial class DangNhap : Form
    {
        ThanhVienBLL thanhVienBLL = new ThanhVienBLL();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtMatkhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var nguoiSuDung = thanhVienBLL.CheckLogin(txtTenDangNhap.Text, txtMatkhau.Text);
                if (nguoiSuDung == null)
                {
                    MessageBox.Show("Thông tin đăng nhập sai. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (nguoiSuDung.MaVaiTro == 3)
                {
                    NguoiDungTrangChu nguoiDungTrangChu = new NguoiDungTrangChu(thanhVienBLL.CheckLogin(txtTenDangNhap.Text, txtMatkhau.Text));
                    nguoiDungTrangChu.Show();
                    this.Hide();
                }
                else if (nguoiSuDung.MaVaiTro == 2)
                {
                    BenToChucTrangChu benToChucTrangChu = new BenToChucTrangChu(thanhVienBLL.CheckLogin(txtTenDangNhap.Text, txtMatkhau.Text));
                    benToChucTrangChu.Show();
                    this.Hide();
                }
                else if (nguoiSuDung.MaVaiTro == 1)
                {
                    QuanTriVienTrangChu quanTriVienTrangChu = new QuanTriVienTrangChu(thanhVienBLL.CheckLogin(txtTenDangNhap.Text, txtMatkhau.Text));
                    quanTriVienTrangChu.Show();
                    this.Hide();
                }
            }
        }

        private void linkLblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.Show();
            this.Hide();
        }

        private void linkLblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.Show();
            this.Hide();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
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

        private void DangNhap_FormClosing_1(object sender, FormClosingEventArgs e)
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

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void lblTenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxDangNhap_Enter(object sender, EventArgs e)
        {

        }
    }
}
