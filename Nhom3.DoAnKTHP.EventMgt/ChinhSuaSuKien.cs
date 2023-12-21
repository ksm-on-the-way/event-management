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
    public partial class ChinhSuaSuKien : Form
    {
        SuKien suKien;
        ThanhVien thanhVien;
        ChuDeBLL chuDeBLL = new ChuDeBLL();
        SuKienBLL suKienBLL = new SuKienBLL();

        public ChinhSuaSuKien(ThanhVien thanhVien, SuKien suKien)
        {
            InitializeComponent();
            this.thanhVien = thanhVien;
            this.suKien = suKien;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {


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

            suKienBLL.UpdateSuKiens(suKien);
            MessageBox.Show("Chỉnh sửa sự kiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChinhSuaSuKien_Load(object sender, EventArgs e)
        {


            var chude = chuDeBLL.GetChuDeById(suKien.MaChuDe);
            cbChuDe.DataSource = chuDeBLL.GetAllChuDes();
            cbChuDe.DisplayMember = "TenChuDe";
            cbChuDe.ValueMember = "MaChuDe";
            txtTenSuKien.Text = suKien.TenSuKien;
            dateTimeThoiGianBatDau.Value = suKien.ThoiGianBatDau;
            txtSoLuongChoPhep.Text = suKien.SoLuongChoPhep.ToString();
            cbChuDe.SelectedItem = chude.ToString();
            if (suKien.ChoPhepSinhVien == true)
            {
                radioBtnChoPhepSinhVien.Checked = true;
            }
            else
            {
                radioBtnKhongChoPhepSinhVien.Checked = true;
            }
            txtDiaDiem.Text = suKien.DiaDiem;
            txtMoTa.Text = suKien.MoTa;

        }

        private void lblChuDe_Click(object sender, EventArgs e)
        {

        }
    }
}
