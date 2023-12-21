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

    public partial class ChiTietSuKien : Form
    {
        SuKienBLL SuKienBLL = new SuKienBLL();
        ThanhVienBLL thanhVienBLL = new ThanhVienBLL();
        ChuDeBLL chuDeBLL = new ChuDeBLL();
        DangKyThamGiaBLL dangKyThamGiaBLL = new DangKyThamGiaBLL();
        DangKyThamGia dangKyThamGia = new DangKyThamGia();
        ThanhVien thanhVien;
        SuKien suKien;


        public ChiTietSuKien(ThanhVien thanhVien, SuKien suKien)
        {
            InitializeComponent();
            this.suKien = suKien;
            this.thanhVien = thanhVien;
        }

        private void ChiTietSuKien_Load(object sender, EventArgs e)
        {
            txtTenSuKien.Text = suKien.TenSuKien;
            txtDiaDiem.Text = suKien.DiaDiem;
            if (suKien.ChoPhepSinhVien == true)
            {
                radioBtnChoPhepSinhVien.Checked = true;
            }
            else
            {
                radioBtnKhongChoPhepSinhVien.Checked = true;
            }
            dateTimeNgayBatDau.Value = suKien.ThoiGianBatDau;
            dateTimeNgayBatDau.Format = DateTimePickerFormat.Short;
            dateTimeGioBatDau.Value = suKien.ThoiGianBatDau;
            dateTimeGioBatDau.Format = DateTimePickerFormat.Time;
            txtSoLuongChoPhep.Text = suKien.SoLuongChoPhep.ToString();
            txtSoLuongHienTai.Text = suKien.SoLuongHienTai.ToString();
            txtBenToChuc.Text = thanhVienBLL.GetThanhVienById(suKien.MaBenToChuc).TenThanhVien;
            txtChuDe.Text = chuDeBLL.GetChuDeById(suKien.MaChuDe).TenChuDe;
            txtMoTa.Text = suKien.MoTa;
            if (thanhVien.MaVaiTro != 3)
            {
                btnDangKyThamGia.Visible = false;
            }

        }


        private void btnDangKyThamGia_Click(object sender, EventArgs e)
        {
            if (suKien.SoLuongHienTai == suKien.SoLuongChoPhep)
            {
                btnDangKyThamGia.Enabled = false;
                MessageBox.Show("Sự kiện này đã đủ số lượng người tham gia. Vui lòng chọn sự kiện khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dangKyThamGiaBLL.GetAllDangKyThamGias().Where(xxx => (xxx.MaThanhVien == thanhVien.MaThanhVien) && (xxx.MaSuKien == suKien.MaSuKien)).ToList().Count > 0)
            {
                btnDangKyThamGia.Enabled = false;
                MessageBox.Show("Bạn đã đăng ký sự kiện này trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dangKyThamGia.MaSuKien = suKien.MaSuKien;
                dangKyThamGia.MaThanhVien = thanhVien.MaThanhVien;
                dangKyThamGia.ThoiGianDangKy = DateTime.Now;
                dangKyThamGia.MaTrangThaiDuyet = 1;
                dangKyThamGiaBLL.AddDangKyThamGia(dangKyThamGia);
                suKien.SoLuongHienTai = suKien.SoLuongHienTai + 1;
                SuKienBLL.UpdateSuKiens(suKien);
                MessageBox.Show("Đăng ký tham gia thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblSoLuongHienTai_Click(object sender, EventArgs e)
        {

        }

        private void lblMoTa_Click(object sender, EventArgs e)
        {

        }

        private void lblDiaDiem_Click(object sender, EventArgs e)
        {

        }

        private void lblBenToChuc_Click(object sender, EventArgs e)
        {

        }
    }
}
