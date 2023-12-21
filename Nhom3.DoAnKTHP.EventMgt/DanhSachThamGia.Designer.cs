namespace Nhom3.DoAnKTHP.EventMgt
{
    partial class DanhSachThamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachThamGia));
            btnXoa = new Button();
            lblDanhSachThamGia = new Label();
            dgvDanhSachNguoiThamGia = new DataGridView();
            lblTenSuKien = new Label();
            pictureBox1 = new PictureBox();
            linkLblQuayLaiDanhSachSuKien = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNguoiThamGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(524, 74);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 40);
            btnXoa.TabIndex = 30;
            btnXoa.Text = "Xóa người tham gia";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lblDanhSachThamGia
            // 
            lblDanhSachThamGia.AutoSize = true;
            lblDanhSachThamGia.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachThamGia.ForeColor = Color.FromArgb(4, 102, 200);
            lblDanhSachThamGia.Location = new Point(195, 9);
            lblDanhSachThamGia.Name = "lblDanhSachThamGia";
            lblDanhSachThamGia.Size = new Size(331, 31);
            lblDanhSachThamGia.TabIndex = 23;
            lblDanhSachThamGia.Text = "DANH SÁCH THAM GIA";
            // 
            // dgvDanhSachNguoiThamGia
            // 
            dgvDanhSachNguoiThamGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachNguoiThamGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNguoiThamGia.Location = new Point(17, 132);
            dgvDanhSachNguoiThamGia.Name = "dgvDanhSachNguoiThamGia";
            dgvDanhSachNguoiThamGia.RowHeadersWidth = 51;
            dgvDanhSachNguoiThamGia.Size = new Size(657, 261);
            dgvDanhSachNguoiThamGia.TabIndex = 22;
            // 
            // lblTenSuKien
            // 
            lblTenSuKien.AutoSize = true;
            lblTenSuKien.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenSuKien.ForeColor = Color.FromArgb(4, 102, 200);
            lblTenSuKien.Location = new Point(54, 87);
            lblTenSuKien.Name = "lblTenSuKien";
            lblTenSuKien.Size = new Size(67, 17);
            lblTenSuKien.TabIndex = 31;
            lblTenSuKien.Text = "Sự kiện:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 87);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // linkLblQuayLaiDanhSachSuKien
            // 
            linkLblQuayLaiDanhSachSuKien.AutoSize = true;
            linkLblQuayLaiDanhSachSuKien.Location = new Point(17, 22);
            linkLblQuayLaiDanhSachSuKien.Name = "linkLblQuayLaiDanhSachSuKien";
            linkLblQuayLaiDanhSachSuKien.Size = new Size(147, 15);
            linkLblQuayLaiDanhSachSuKien.TabIndex = 50;
            linkLblQuayLaiDanhSachSuKien.TabStop = true;
            linkLblQuayLaiDanhSachSuKien.Text = "Quay lại danh sách sự kiện";
            linkLblQuayLaiDanhSachSuKien.LinkClicked += linkLblQuayLaiTrangChu_LinkClicked;
            // 
            // DanhSachThamGia
            // 
            AcceptButton = btnXoa;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 202, 249);
            ClientSize = new Size(686, 402);
            Controls.Add(linkLblQuayLaiDanhSachSuKien);
            Controls.Add(pictureBox1);
            Controls.Add(lblTenSuKien);
            Controls.Add(btnXoa);
            Controls.Add(lblDanhSachThamGia);
            Controls.Add(dgvDanhSachNguoiThamGia);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DanhSachThamGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DanhSachThamGia";
            Load += DanhSachThamGia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNguoiThamGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXoa;
        private Label lblDanhSachThamGia;
        private DataGridView dgvDanhSachNguoiThamGia;
        private Label lblTenSuKien;
        private PictureBox pictureBox1;
        private LinkLabel linkLblQuayLaiDanhSachSuKien;
    }
}