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
    public partial class TaoMoiSuKien : Form
    {
        ThanhVien thanhVien;

        SuKienBLL suKienBLL = new SuKienBLL();
        DangSuKien dangSuKien = new DangSuKien();
        DangSuKienBLL dangSuKienBLL = new DangSuKienBLL();
        ChuDeBLL chuDeBLL = new ChuDeBLL();

        public TaoMoiSuKien(ThanhVien thanhVien)
        {
            InitializeComponent();
            this.thanhVien = thanhVien;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            SuKien suKien = new SuKien();
            //Tạo ra sự kiện
            suKien.TenSuKien = txtTenSuKien.Text;
            suKien.ThoiGianBatDau = dateTimeThoiGianBatDau.Value;
            suKien.SoLuongChoPhep = Int32.Parse(txtSoLuongChoPhep.Text);
            suKien.MaChuDe = (int)cbChuDe.SelectedValue;
            suKien.SoLuongChoPhep = Int32.Parse(txtSoLuongChoPhep.Text);
            suKien.SoLuongHienTai = 0;
            suKien.MaBenToChuc = thanhVien.MaThanhVien;
            if (radioBtnChoPhepSinhVien.Checked)
            {
                suKien.ChoPhepSinhVien = true;
            }
            else
            {
                suKien.ChoPhepSinhVien = false;
            }
            suKien.DiaDiem = txtDiaDiem.Text;
            suKien.MoTa = txtMoTa.Text;
            suKienBLL.AddSuKien(suKien);

            //Chờ QTV duyệt
            dangSuKien.MaThanhVien = thanhVien.MaThanhVien;
            dangSuKien.MaSuKien = suKien.MaSuKien;
            dangSuKien.ThoiGianDangBai = DateTime.Now;
            dangSuKien.MaTrangThaiDuyet = 1;
            dangSuKienBLL.AddDangSuKien(dangSuKien);
            MessageBox.Show("Tạo mới sự kiện thành công! Chờ quản trị viên duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TaoMoiSuKien_Load(object sender, EventArgs e)
        {
            cbChuDe.DataSource = chuDeBLL.GetAllChuDes().Where(xxx => xxx.TenChuDe != "Tất cả").ToList();
            cbChuDe.DisplayMember = "TenChuDe";
            cbChuDe.ValueMember = "MaChuDe";
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

        private void TaoMoiSuKien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void lblChuDe_Click(object sender, EventArgs e)
        {

        }
    }
}
