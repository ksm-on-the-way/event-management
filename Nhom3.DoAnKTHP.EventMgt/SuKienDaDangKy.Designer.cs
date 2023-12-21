namespace Nhom3.DoAnKTHP.EventMgt
{
    partial class SuKienDaDangKy
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
            btnDanhGia = new Button();
            grbLoc = new GroupBox();
            lblChuDe = new Label();
            cbChuDe = new ComboBox();
            grbTimKiem = new GroupBox();
            lblTuKhoa = new Label();
            btnTimKiem = new Button();
            txtTuKhoa = new TextBox();
            lblDanhSachSuKienDaDangKy = new Label();
            dgvDanhSachSuKien = new DataGridView();
            linkLblQuayVeTrangChu = new LinkLabel();
            grbLoc.SuspendLayout();
            grbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSuKien).BeginInit();
            SuspendLayout();
            // 
            // btnDanhGia
            // 
            btnDanhGia.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnDanhGia.ForeColor = Color.Black;
            btnDanhGia.Location = new Point(565, 84);
            btnDanhGia.Name = "btnDanhGia";
            btnDanhGia.Size = new Size(88, 23);
            btnDanhGia.TabIndex = 4;
            btnDanhGia.Text = "Đánh giá";
            btnDanhGia.UseVisualStyleBackColor = true;
            btnDanhGia.Click += btnDanhGia_Click;
            // 
            // grbLoc
            // 
            grbLoc.Controls.Add(lblChuDe);
            grbLoc.Controls.Add(cbChuDe);
            grbLoc.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            grbLoc.ForeColor = Color.FromArgb(4, 102, 200);
            grbLoc.Location = new Point(344, 65);
            grbLoc.Name = "grbLoc";
            grbLoc.Size = new Size(191, 52);
            grbLoc.TabIndex = 15;
            grbLoc.TabStop = false;
            grbLoc.Text = "Lọc";
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
            // cbChuDe
            // 
            cbChuDe.FormattingEnabled = true;
            cbChuDe.Location = new Point(60, 19);
            cbChuDe.Name = "cbChuDe";
            cbChuDe.Size = new Size(121, 23);
            cbChuDe.TabIndex = 3;
            cbChuDe.SelectedIndexChanged += cbChuDe_SelectedIndexChanged;
            // 
            // grbTimKiem
            // 
            grbTimKiem.Controls.Add(lblTuKhoa);
            grbTimKiem.Controls.Add(btnTimKiem);
            grbTimKiem.Controls.Add(txtTuKhoa);
            grbTimKiem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            grbTimKiem.ForeColor = Color.FromArgb(4, 102, 200);
            grbTimKiem.Location = new Point(12, 65);
            grbTimKiem.Name = "grbTimKiem";
            grbTimKiem.Size = new Size(297, 52);
            grbTimKiem.TabIndex = 14;
            grbTimKiem.TabStop = false;
            grbTimKiem.Text = "Tìm kiếm";
            // 
            // lblTuKhoa
            // 
            lblTuKhoa.AutoSize = true;
            lblTuKhoa.Location = new Point(6, 23);
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Size = new Size(62, 15);
            lblTuKhoa.TabIndex = 2;
            lblTuKhoa.Text = "Từ khóa:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(199, 19);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(88, 23);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new Point(76, 19);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(117, 21);
            txtTuKhoa.TabIndex = 1;
            // 
            // lblDanhSachSuKienDaDangKy
            // 
            lblDanhSachSuKienDaDangKy.AutoSize = true;
            lblDanhSachSuKienDaDangKy.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachSuKienDaDangKy.ForeColor = Color.FromArgb(4, 102, 200);
            lblDanhSachSuKienDaDangKy.Location = new Point(187, 9);
            lblDanhSachSuKienDaDangKy.Name = "lblDanhSachSuKienDaDangKy";
            lblDanhSachSuKienDaDangKy.Size = new Size(315, 31);
            lblDanhSachSuKienDaDangKy.TabIndex = 13;
            lblDanhSachSuKienDaDangKy.Text = "SỰ KIỆN ĐÃ ĐĂNG KÝ";
            // 
            // dgvDanhSachSuKien
            // 
            dgvDanhSachSuKien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachSuKien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSuKien.Location = new Point(12, 131);
            dgvDanhSachSuKien.Name = "dgvDanhSachSuKien";
            dgvDanhSachSuKien.RowHeadersWidth = 51;
            dgvDanhSachSuKien.Size = new Size(641, 261);
            dgvDanhSachSuKien.TabIndex = 12;
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
            // SuKienDaDangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 202, 249);
            ClientSize = new Size(665, 402);
            Controls.Add(linkLblQuayVeTrangChu);
            Controls.Add(btnDanhGia);
            Controls.Add(grbLoc);
            Controls.Add(grbTimKiem);
            Controls.Add(lblDanhSachSuKienDaDangKy);
            Controls.Add(dgvDanhSachSuKien);
            ForeColor = Color.FromArgb(4, 102, 200);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SuKienDaDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuKienDaDangKy";
            FormClosing += SuKienDaDangKy_FormClosing;
            Load += SuKienDaDangKy_Load;
            grbLoc.ResumeLayout(false);
            grbLoc.PerformLayout();
            grbTimKiem.ResumeLayout(false);
            grbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSuKien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDanhGia;
        private GroupBox grbLoc;
        private Label lblChuDe;
        private ComboBox cbChuDe;
        private GroupBox grbTimKiem;
        private Label lblTuKhoa;
        private Button btnTimKiem;
        private TextBox txtTuKhoa;
        private Label lblDanhSachSuKienDaDangKy;
        private DataGridView dgvDanhSachSuKien;
        private LinkLabel linkLblQuayVeTrangChu;
    }
}