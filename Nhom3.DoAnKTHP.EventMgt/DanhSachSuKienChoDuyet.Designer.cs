namespace Nhom3.DoAnKTHP.EventMgt
{
    partial class DanhSachSuKienChoDuyet
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
            btnDuyet = new Button();
            grbLoc = new GroupBox();
            lblChuDe = new Label();
            cbChuDe = new ComboBox();
            grbTimKiem = new GroupBox();
            lblTuKhoa = new Label();
            btnTimKiem = new Button();
            txtTuKhoa = new TextBox();
            lblDanhSachSuKienChoDuyet = new Label();
            dgvDanhSachSuKien = new DataGridView();
            grbLoc.SuspendLayout();
            grbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSuKien).BeginInit();
            SuspendLayout();
            // 
            // linkLblQuayVeTrangChu
            // 
            linkLblQuayVeTrangChu.AutoSize = true;
            linkLblQuayVeTrangChu.Location = new Point(16, 29);
            linkLblQuayVeTrangChu.Name = "linkLblQuayVeTrangChu";
            linkLblQuayVeTrangChu.Size = new Size(121, 15);
            linkLblQuayVeTrangChu.TabIndex = 5;
            linkLblQuayVeTrangChu.TabStop = true;
            linkLblQuayVeTrangChu.Text = "Quay về trang chủ";
            linkLblQuayVeTrangChu.LinkClicked += linkLblQuayVeTrangChu_LinkClicked;
            // 
            // btnDuyet
            // 
            btnDuyet.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnDuyet.ForeColor = Color.Black;
            btnDuyet.Location = new Point(727, 101);
            btnDuyet.Margin = new Padding(3, 4, 3, 4);
            btnDuyet.Name = "btnDuyet";
            btnDuyet.Size = new Size(114, 28);
            btnDuyet.TabIndex = 4;
            btnDuyet.Text = "Duyệt";
            btnDuyet.UseVisualStyleBackColor = true;
            btnDuyet.Click += btnDuyet_Click;
            // 
            // grbLoc
            // 
            grbLoc.Controls.Add(lblChuDe);
            grbLoc.Controls.Add(cbChuDe);
            grbLoc.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            grbLoc.ForeColor = Color.FromArgb(4, 102, 200);
            grbLoc.Location = new Point(442, 78);
            grbLoc.Margin = new Padding(3, 4, 3, 4);
            grbLoc.Name = "grbLoc";
            grbLoc.Padding = new Padding(3, 4, 3, 4);
            grbLoc.Size = new Size(245, 62);
            grbLoc.TabIndex = 16;
            grbLoc.TabStop = false;
            grbLoc.Text = "Lọc";
            // 
            // lblChuDe
            // 
            lblChuDe.AutoSize = true;
            lblChuDe.Location = new Point(8, 26);
            lblChuDe.Name = "lblChuDe";
            lblChuDe.Size = new Size(56, 15);
            lblChuDe.TabIndex = 8;
            lblChuDe.Text = "Chủ đề:";
            // 
            // cbChuDe
            // 
            cbChuDe.FormattingEnabled = true;
            cbChuDe.Location = new Point(78, 22);
            cbChuDe.Margin = new Padding(3, 4, 3, 4);
            cbChuDe.Name = "cbChuDe";
            cbChuDe.Size = new Size(155, 23);
            cbChuDe.TabIndex = 3;
            cbChuDe.SelectedIndexChanged += cbChuDe_SelectedIndexChanged;
            // 
            // grbTimKiem
            // 
            grbTimKiem.Controls.Add(lblTuKhoa);
            grbTimKiem.Controls.Add(btnTimKiem);
            grbTimKiem.Controls.Add(txtTuKhoa);
            grbTimKiem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbTimKiem.ForeColor = Color.FromArgb(4, 102, 200);
            grbTimKiem.Location = new Point(16, 78);
            grbTimKiem.Margin = new Padding(3, 4, 3, 4);
            grbTimKiem.Name = "grbTimKiem";
            grbTimKiem.Padding = new Padding(3, 4, 3, 4);
            grbTimKiem.Size = new Size(381, 62);
            grbTimKiem.TabIndex = 15;
            grbTimKiem.TabStop = false;
            grbTimKiem.Text = "Tìm kiếm";
            // 
            // lblTuKhoa
            // 
            lblTuKhoa.AutoSize = true;
            lblTuKhoa.Location = new Point(8, 28);
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Size = new Size(62, 15);
            lblTuKhoa.TabIndex = 2;
            lblTuKhoa.Text = "Từ khóa:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(255, 22);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(114, 28);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new Point(98, 22);
            txtTuKhoa.Margin = new Padding(3, 4, 3, 4);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(149, 21);
            txtTuKhoa.TabIndex = 1;
            // 
            // lblDanhSachSuKienChoDuyet
            // 
            lblDanhSachSuKienChoDuyet.AutoSize = true;
            lblDanhSachSuKienChoDuyet.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachSuKienChoDuyet.ForeColor = Color.FromArgb(4, 102, 200);
            lblDanhSachSuKienChoDuyet.Location = new Point(188, 14);
            lblDanhSachSuKienChoDuyet.Name = "lblDanhSachSuKienChoDuyet";
            lblDanhSachSuKienChoDuyet.Size = new Size(399, 31);
            lblDanhSachSuKienChoDuyet.TabIndex = 14;
            lblDanhSachSuKienChoDuyet.Text = "SỰ KIỆN ĐANG CHỜ DUYỆT";
            // 
            // dgvDanhSachSuKien
            // 
            dgvDanhSachSuKien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachSuKien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSuKien.Location = new Point(16, 158);
            dgvDanhSachSuKien.Margin = new Padding(3, 4, 3, 4);
            dgvDanhSachSuKien.Name = "dgvDanhSachSuKien";
            dgvDanhSachSuKien.RowHeadersWidth = 51;
            dgvDanhSachSuKien.Size = new Size(825, 313);
            dgvDanhSachSuKien.TabIndex = 13;
            // 
            // DanhSachSuKienChoDuyet
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 202, 249);
            ClientSize = new Size(855, 482);
            Controls.Add(linkLblQuayVeTrangChu);
            Controls.Add(btnDuyet);
            Controls.Add(grbLoc);
            Controls.Add(grbTimKiem);
            Controls.Add(lblDanhSachSuKienChoDuyet);
            Controls.Add(dgvDanhSachSuKien);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            ForeColor = Color.FromArgb(4, 102, 200);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DanhSachSuKienChoDuyet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DanhSachSuKienChoDuyet";
            FormClosing += DanhSachSuKienChoDuyet_FormClosing;
            Load += DanhSachSuKienChoDuyet_Load;
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
        private Button btnDuyet;
        private GroupBox grbLoc;
        private Label lblChuDe;
        private ComboBox cbChuDe;
        private GroupBox grbTimKiem;
        private Label lblTuKhoa;
        private Button btnTimKiem;
        private TextBox txtTuKhoa;
        private Label lblDanhSachSuKienChoDuyet;
        private DataGridView dgvDanhSachSuKien;
    }
}