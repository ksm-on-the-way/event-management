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
    public partial class DanhGiaSuKien : Form
    {
        ThanhVien thanhVien;
        SuKien suKien;
        DangKyThamGiaBLL dangKyThamGiaBLL = new DangKyThamGiaBLL();
        public DanhGiaSuKien(ThanhVien thanhVien, SuKien suKien)
        {
            InitializeComponent();
            this.thanhVien = thanhVien;
            this.suKien = suKien;
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            var selected = dangKyThamGiaBLL.GetAllDangKyThamGias().FirstOrDefault(xxx => xxx.MaThanhVien == this.thanhVien.MaThanhVien && xxx.MaSuKien == this.suKien.MaSuKien);
            if (suKien.ThoiGianBatDau > DateTime.Now)
            {
                MessageBox.Show("Sự kiện chưa diễn ra!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int result;
            if (radioBtnRatKhongHaiLong.Checked)
            {
                result = 1;
            }
            else if (radioBtnKhongHaiLong.Checked)
            {
                result = 2;
            }
            else if (radioBtnKhongYKien.Checked)
            {
                result = 3;
            }
            else if (radioBtnHaiLong.Checked)
            {
                result = 4;
            }
            else
            {
                result = 5;
            }
            selected.MaDanhGia = result;
            dangKyThamGiaBLL.UpdateDangKyThamGias(selected);
            MessageBox.Show("Cảm ơn bạn đã đánh giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
