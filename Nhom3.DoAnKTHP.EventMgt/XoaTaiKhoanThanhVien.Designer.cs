namespace Nhom3.DoAnKTHP.EventMgt
{
    partial class XoaTaiKhoanThanhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTenThanhVien = new Label();
            btnXoa = new Button();
            lblDanhSachThanhVien = new Label();
            dgvDanhSachNguoiThamGia = new DataGridView();
            linkLblQuayVeTrangChu = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNguoiThamGia).BeginInit();
            SuspendLayout();
            // 
            // lblTenThanhVien
            // 
            lblTenThanhVien.AutoSize = true;
            lblTenThanhVien.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblTenThanhVien.ForeColor = Color.FromArgb(4, 102, 200);
            lblTenThanhVien.Location = new Point(15, 87);
            lblTenThanhVien.Name = "lblTenThanhVien";
            lblTenThanhVien.Size = new Size(85, 15);
            lblTenThanhVien.TabIndex = 35;
            lblTenThanhVien.Text = "Thành viên :";
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnXoa.Location = new Point(539, 74);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(133, 40);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa thành viên";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lblDanhSachThanhVien
            // 
            lblDanhSachThanhVien.AutoSize = true;
            lblDanhSachThanhVien.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachThanhVien.ForeColor = Color.FromArgb(4, 102, 200);
            lblDanhSachThanhVien.Location = new Point(193, 9);
            lblDanhSachThanhVien.Name = "lblDanhSachThanhVien";
            lblDanhSachThanhVien.Size = new Size(368, 31);
            lblDanhSachThanhVien.TabIndex = 33;
            lblDanhSachThanhVien.Text = "DANH SÁCH THÀNH VIÊN";
            // 
            // dgvDanhSachNguoiThamGia
            // 
            dgvDanhSachNguoiThamGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachNguoiThamGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNguoiThamGia.Location = new Point(15, 132);
            dgvDanhSachNguoiThamGia.Name = "dgvDanhSachNguoiThamGia";
            dgvDanhSachNguoiThamGia.RowHeadersWidth = 51;
            dgvDanhSachNguoiThamGia.Size = new Size(657, 261);
            dgvDanhSachNguoiThamGia.TabIndex = 32;
            dgvDanhSachNguoiThamGia.CellClick += dgvDanhSachNguoiThamGia_CellClick;
            // 
            // linkLblQuayVeTrangChu
            // 
            linkLblQuayVeTrangChu.AutoSize = true;
            linkLblQuayVeTrangChu.Location = new Point(15, 22);
            linkLblQuayVeTrangChu.Name = "linkLblQuayVeTrangChu";
            linkLblQuayVeTrangChu.Size = new Size(104, 15);
            linkLblQuayVeTrangChu.TabIndex = 2;
            linkLblQuayVeTrangChu.TabStop = true;
            linkLblQuayVeTrangChu.Text = "Quay về trang chủ";
            linkLblQuayVeTrangChu.LinkClicked += linkLblQuayVeTrangChu_LinkClicked;
            // 
            // XoaTaiKhoanThanhVien
            // 
            AcceptButton = btnXoa;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 202, 249);
            ClientSize = new Size(686, 402);
            Controls.Add(linkLblQuayVeTrangChu);
            Controls.Add(lblTenThanhVien);
            Controls.Add(btnXoa);
            Controls.Add(lblDanhSachThanhVien);
            Controls.Add(dgvDanhSachNguoiThamGia);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "XoaTaiKhoanThanhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XoaTaiKhoanThanhVien";
            FormClosing += XoaTaiKhoanThanhVien_FormClosing;
            Load += XoaTaiKhoanThanhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNguoiThamGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenThanhVien;
        private Button btnXoa;
        private Label lblDanhSachThanhVien;
        private DataGridView dgvDanhSachNguoiThamGia;
        private LinkLabel linkLblQuayVeTrangChu;
    }
}