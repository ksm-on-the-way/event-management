namespace Nhom3.DoAnKTHP.EventMgt
{
    partial class SuKienSapDienRa
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
            dgvDanhSachSuKien = new DataGridView();
            lblDangKySuKien = new Label();
            txtTuKhoa = new TextBox();
            lblTuKhoa = new Label();
            btnTimKiem = new Button();
            cbChuDe = new ComboBox();
            lblChuDe = new Label();
            grbTimKiem = new GroupBox();
            grbLoc = new GroupBox();
            btnXemChiTiet = new Button();
            linkLblQuayVeTrangChu = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSuKien).BeginInit();
            grbTimKiem.SuspendLayout();
            grbLoc.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDanhSachSuKien
            // 
            dgvDanhSachSuKien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachSuKien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSuKien.Location = new Point(12, 129);
            dgvDanhSachSuKien.Name = "dgvDanhSachSuKien";
            dgvDanhSachSuKien.RowHeadersWidth = 51;
            dgvDanhSachSuKien.Size = new Size(641, 261);
            dgvDanhSachSuKien.TabIndex = 0;
            // 
            // lblDangKySuKien
            // 
            lblDangKySuKien.AutoSize = true;
            lblDangKySuKien.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDangKySuKien.ForeColor = Color.FromArgb(4, 102, 200);
            lblDangKySuKien.Location = new Point(192, 9);
            lblDangKySuKien.Name = "lblDangKySuKien";
            lblDangKySuKien.Size = new Size(312, 32);
            lblDangKySuKien.TabIndex = 5;
            lblDangKySuKien.Text = "SỰ KIỆN SẮP DIỄN RA";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new Point(76, 19);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(117, 21);
            txtTuKhoa.TabIndex = 1;
            // 
            // lblTuKhoa
            // 
            lblTuKhoa.AutoSize = true;
            lblTuKhoa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblTuKhoa.Location = new Point(6, 23);
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Size = new Size(62, 15);
            lblTuKhoa.TabIndex = 2;
            lblTuKhoa.Text = "Từ khóa:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(199, 19);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(88, 23);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cbChuDe
            // 
            cbChuDe.FormattingEnabled = true;
            cbChuDe.Location = new Point(60, 19);
            cbChuDe.Name = "cbChuDe";
            cbChuDe.Size = new Size(121, 23);
            cbChuDe.TabIndex = 3;
            cbChuDe.SelectedIndexChanged += cbChuDe_SelectedIndexChanged;
            // 
            // lblChuDe
            // 
            lblChuDe.AutoSize = true;
            lblChuDe.Location = new Point(6, 22);
            lblChuDe.Name = "lblChuDe";
            lblChuDe.Size = new Size(56, 15);
            lblChuDe.TabIndex = 8;
            lblChuDe.Text = "Chủ đề:";
            // 
            // grbTimKiem
            // 
            grbTimKiem.Controls.Add(lblTuKhoa);
            grbTimKiem.Controls.Add(btnTimKiem);
            grbTimKiem.Controls.Add(txtTuKhoa);
            grbTimKiem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            grbTimKiem.ForeColor = Color.FromArgb(4, 102, 200);
            grbTimKiem.Location = new Point(12, 63);
            grbTimKiem.Name = "grbTimKiem";
            grbTimKiem.Size = new Size(297, 52);
            grbTimKiem.TabIndex = 9;
            grbTimKiem.TabStop = false;
            grbTimKiem.Text = "Tìm kiếm";
            // 
            // grbLoc
            // 
            grbLoc.Controls.Add(lblChuDe);
            grbLoc.Controls.Add(cbChuDe);
            grbLoc.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            grbLoc.ForeColor = Color.FromArgb(4, 102, 200);
            grbLoc.Location = new Point(344, 63);
            grbLoc.Name = "grbLoc";
            grbLoc.Size = new Size(191, 52);
            grbLoc.TabIndex = 10;
            grbLoc.TabStop = false;
            grbLoc.Text = "Lọc";
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnXemChiTiet.Location = new Point(557, 82);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.Size = new Size(96, 23);
            btnXemChiTiet.TabIndex = 4;
            btnXemChiTiet.Text = "Xem chi tiết";
            btnXemChiTiet.UseVisualStyleBackColor = true;
            btnXemChiTiet.Click += btnXemChiTiet_Click;
            // 
            // linkLblQuayVeTrangChu
            // 
            linkLblQuayVeTrangChu.AutoSize = true;
            linkLblQuayVeTrangChu.Location = new Point(12, 22);
            linkLblQuayVeTrangChu.Name = "linkLblQuayVeTrangChu";
            linkLblQuayVeTrangChu.Size = new Size(104, 15);
            linkLblQuayVeTrangChu.TabIndex = 5;
            linkLblQuayVeTrangChu.TabStop = true;
            linkLblQuayVeTrangChu.Text = "Quay về trang chủ";
            linkLblQuayVeTrangChu.LinkClicked += linkLblQuayVeTrangChu_LinkClicked;
            // 
            // SuKienSapDienRa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 202, 249);
            ClientSize = new Size(669, 398);
            Controls.Add(linkLblQuayVeTrangChu);
            Controls.Add(btnXemChiTiet);
            Controls.Add(grbLoc);
            Controls.Add(grbTimKiem);
            Controls.Add(lblDangKySuKien);
            Controls.Add(dgvDanhSachSuKien);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SuKienSapDienRa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TimKiemSuKien";
            FormClosing += SuKienSapDienRa_FormClosing;
            Load += SuKienSapDienRa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSuKien).EndInit();
            grbTimKiem.ResumeLayout(false);
            grbTimKiem.PerformLayout();
            grbLoc.ResumeLayout(false);
            grbLoc.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDanhSachSuKien;
        private Label lblDangKySuKien;
        private TextBox txtTuKhoa;
        private Label lblTuKhoa;
        private Button btnTimKiem;
        private ComboBox cbChuDe;
        private Label lblChuDe;
        private GroupBox grbTimKiem;
        private GroupBox grbLoc;
        private Button btnXemChiTiet;
        private LinkLabel linkLblQuayVeTrangChu;
    }
}
