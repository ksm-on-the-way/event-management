﻿using Nhom3.DoAnKTHP.BLL;
using Nhom3.DoAnKTHP.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom3.DoAnKTHP.EventMgt
{
    public partial class SuKienSapDienRa : Form
    {
        SuKienBLL suKienBLL = new SuKienBLL();
        ThanhVienBLL thanhVienBLL = new ThanhVienBLL();
        ChuDeBLL chuDeBLL = new ChuDeBLL();
        ThanhVien thanhVien;
        DangSuKienBLL dangSuKienBLL = new DangSuKienBLL();
        public SuKienSapDienRa(ThanhVien thanhVien)
        {
            InitializeComponent();
            this.thanhVien = thanhVien;
        }
        private void cbChuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sukiens = from sukien in suKienBLL.GetAllSuKiens()
                          join benToChuc in thanhVienBLL.GetAllThanhVien()
                          on sukien.MaBenToChuc equals benToChuc.MaThanhVien
                          join chude in chuDeBLL.GetAllChuDes()
                          on sukien.MaChuDe equals chude.MaChuDe
                          join dangSuKien in dangSuKienBLL.GetAllDangSuKiens()
                          on sukien.MaSuKien equals dangSuKien.MaSuKien
                          where sukien.ThoiGianBatDau > DateTime.Now
                          select new
                          {
                              MaSuKien = sukien.MaSuKien,
                              TenSuKien = sukien.TenSuKien,
                              ChuDe = chude.TenChuDe,
                              DiaDiem = sukien.DiaDiem,
                              ThoiGianBatDau = sukien.ThoiGianBatDau,
                              MaTrangThaiDuyet = dangSuKien.MaTrangThaiDuyet
                          };
            if (cbChuDe.Text == "Tất cả")
            {
                dgvDanhSachSuKien.DataSource = sukiens.Where(xxx => xxx.MaTrangThaiDuyet == 3).ToList();
            }
            else
            {
                dgvDanhSachSuKien.DataSource = sukiens.Where(xxx => xxx.MaTrangThaiDuyet == 3).Where(xxx => xxx.ChuDe == cbChuDe.Text).ToList();
            }
            dgvDanhSachSuKien.Columns["masukien"].Visible = false;
            dgvDanhSachSuKien.Columns["MaTrangThaiDuyet"].Visible = false;
        }
        private void SuKienSapDienRa_Load(object sender, EventArgs e)
        {
            //Load data cho datagridview
            var sukiens = from sukien in suKienBLL.GetAllSuKiens()
                          join benToChuc in thanhVienBLL.GetAllThanhVien()
                          on sukien.MaBenToChuc equals benToChuc.MaThanhVien
                          join chude in chuDeBLL.GetAllChuDes()
                          on sukien.MaChuDe equals chude.MaChuDe
                          join dangSuKien in dangSuKienBLL.GetAllDangSuKiens()
                          on sukien.MaSuKien equals dangSuKien.MaSuKien
                          where sukien.ThoiGianBatDau > DateTime.Now
                          select new
                          {
                              MaSuKien = sukien.MaSuKien,
                              TenSuKien = sukien.TenSuKien,
                              ChuDe = chude.TenChuDe,
                              DiaDiem = sukien.DiaDiem,
                              ThoiGianBatDau = sukien.ThoiGianBatDau,
                              MaTrangThaiDuyet = dangSuKien.MaTrangThaiDuyet
                          };


            dgvDanhSachSuKien.DataSource = sukiens.Where(xxx => xxx.MaTrangThaiDuyet == 3).ToList();
            dgvDanhSachSuKien.Columns["MaSuKien"].Visible = false;
            dgvDanhSachSuKien.Columns["MaTrangThaiDuyet"].Visible = false;

            // Load data cho combobox
            cbChuDe.DataSource = chuDeBLL.GetAllChuDes();
            cbChuDe.DisplayMember = "TenChuDe";
            cbChuDe.ValueMember = "MaChuDe";

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var sukiens = from sukien in suKienBLL.GetAllSuKiens()
                          join benToChuc in thanhVienBLL.GetAllThanhVien()
                          on sukien.MaBenToChuc equals benToChuc.MaThanhVien
                          join chude in chuDeBLL.GetAllChuDes()
                          on sukien.MaChuDe equals chude.MaChuDe
                          join dangSuKien in dangSuKienBLL.GetAllDangSuKiens()
                          on sukien.MaSuKien equals dangSuKien.MaSuKien
                          where sukien.ThoiGianBatDau > DateTime.Now
                          select new
                          {
                              MaSuKien = sukien.MaSuKien,
                              TenSuKien = sukien.TenSuKien,
                              ChuDe = chude.TenChuDe,
                              DiaDiem = sukien.DiaDiem,
                              ThoiGianBatDau = sukien.ThoiGianBatDau,
                              MaTrangThaiDuyet = dangSuKien.MaTrangThaiDuyet
                          };
            dgvDanhSachSuKien.DataSource = null;
            dgvDanhSachSuKien.DataSource = sukiens.Where(xxx => xxx.MaTrangThaiDuyet == 3).Where(xxx => xxx.TenSuKien.Trim().ToLower().Contains(txtTuKhoa.Text.Trim().ToLower())).ToList();
            dgvDanhSachSuKien.Columns["MaSuKien"].Visible = false;
            dgvDanhSachSuKien.Columns["MaTrangThaiDuyet"].Visible = false;
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSuKien.CurrentCell == null)
            {
                return;
            }
            else
            {
                var tenSuKien = dgvDanhSachSuKien.Rows[dgvDanhSachSuKien.CurrentCell.RowIndex].Cells[1].Value.ToString();
                var suKien = suKienBLL.GetSuKienByName(tenSuKien);
                ChiTietSuKien chiTietSuKien = new ChiTietSuKien(thanhVien, suKien);
                chiTietSuKien.Show();
            }

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

        private void SuKienSapDienRa_FormClosing(object sender, FormClosingEventArgs e)
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
