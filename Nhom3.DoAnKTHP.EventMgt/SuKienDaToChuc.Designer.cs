namespace Nhom3.DoAnKTHP.EventMgt
{
    partial class SuKienDaToChuc
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
            linkLblQuayVeTrangChu = new LinkLabel();
            grbLoc = new GroupBox();
            lblChuDe = new Label();
            cbChuDe = new ComboBox();
            grbTimKiem = new GroupBox();
            lblTuKhoa = new Label();
            btnTimKiem = new Button();
            txtTuKhoa = new TextBox();
            lblDangKySuKien = new Label();
            dgvDanhSachSuKien = new DataGridView();
            btnXemDanhSach = new Button();
            btnChinhSuaSuKien = new Button();
            btnXoa = new Button();
            grbLoc.SuspendLayout();
            grbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSuKien).BeginInit();
            SuspendLayout();
            // 
            // linkLblQuayVeTrangChu
            // 
            linkLblQuayVeTrangChu.AutoSize = true;
            linkLblQuayVeTrangChu.Location = new Point(12, 24);
            linkLblQuayVeTrangChu.Name = "linkLblQuayVeTrangChu";
            linkLblQuayVeTrangChu.Size = new Size(104, 15);
            linkLblQuayVeTrangChu.TabIndex = 7;
            linkLblQuayVeTrangChu.TabStop = true;
            linkLblQuayVeTrangChu.Text = "Quay về trang chủ";
            linkLblQuayVeTrangChu.LinkClicked += linkLblQuayVeTrangChu_LinkClicked;
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
            grbLoc.TabIndex = 16;
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
            grbTimKiem.TabIndex = 15;
            grbTimKiem.TabStop = false;
            grbTimKiem.Text = "Tìm kiếm";
            grbTimKiem.Enter += grbTimKiem_Enter;
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
            // lblDangKySuKien
            // 
            lblDangKySuKien.AutoSize = true;
            lblDangKySuKien.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDangKySuKien.ForeColor = Color.FromArgb(4, 102, 200);
            lblDangKySuKien.Location = new Point(213, 9);
            lblDangKySuKien.Name = "lblDangKySuKien";
            lblDangKySuKien.Size = new Size(318, 31);
            lblDangKySuKien.TabIndex = 14;
            lblDangKySuKien.Text = "SỰ KIỆN ĐÃ TỔ CHỨC";
            // 
            // dgvDanhSachSuKien
            // 
            dgvDanhSachSuKien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachSuKien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSuKien.Location = new Point(12, 131);
            dgvDanhSachSuKien.Name = "dgvDanhSachSuKien";
            dgvDanhSachSuKien.RowHeadersWidth = 51;
            dgvDanhSachSuKien.Size = new Size(523, 261);
            dgvDanhSachSuKien.TabIndex = 13;
            // 
            // btnXemDanhSach
            // 
            btnXemDanhSach.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnXemDanhSach.Location = new Point(555, 131);
            btnXemDanhSach.Name = "btnXemDanhSach";
            btnXemDanhSach.Size = new Size(100, 41);
            btnXemDanhSach.TabIndex = 4;
            btnXemDanhSach.Text = "Xem danh sách";
            btnXemDanhSach.UseVisualStyleBackColor = true;
            btnXemDanhSach.Click += btnXemDanhSach_Click;
            // 
            // btnChinhSuaSuKien
            // 
            btnChinhSuaSuKien.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnChinhSuaSuKien.Location = new Point(555, 179);
            btnChinhSuaSuKien.Name = "btnChinhSuaSuKien";
            btnChinhSuaSuKien.Size = new Size(100, 41);
            btnChinhSuaSuKien.TabIndex = 5;
            btnChinhSuaSuKien.Text = "Chỉnh sửa";
            btnChinhSuaSuKien.UseVisualStyleBackColor = true;
            btnChinhSuaSuKien.Click += btnChinhSuaSuKien_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnXoa.Location = new Point(555, 226);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 41);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // SuKienDaToChuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 202, 249);
            ClientSize = new Size(666, 402);
            Controls.Add(btnXoa);
            Controls.Add(btnChinhSuaSuKien);
            Controls.Add(btnXemDanhSach);
            Controls.Add(linkLblQuayVeTrangChu);
            Controls.Add(grbLoc);
            Controls.Add(grbTimKiem);
            Controls.Add(lblDangKySuKien);
            Controls.Add(dgvDanhSachSuKien);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SuKienDaToChuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuKienDaToChuc";
            FormClosing += SuKienDaToChuc_FormClosing;
            Load += SuKienDaToChuc_Load;
            grbLoc.ResumeLayout(false);
            grbLoc.PerformLayout();
            grbTimKiem.ResumeLayout(false);
            grbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSuKien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLblQuayVeTrangChu;
        private GroupBox grbLoc;
        private Label lblChuDe;
        private ComboBox cbChuDe;
        private GroupBox grbTimKiem;
        private Label lblTuKhoa;
        private Button btnTimKiem;
        private TextBox txtTuKhoa;
        private Label lblDangKySuKien;
        private DataGridView dgvDanhSachSuKien;
        private Button btnXemDanhSach;
        private Button btnChinhSuaSuKien;
        private Button btnXoa;
    }
}