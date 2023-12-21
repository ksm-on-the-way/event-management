namespace Nhom3.DoAnKTHP.EventMgt
{
    partial class ChinhSuaHoSoCaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChinhSuaHoSoCaNhan));
            btnLuu = new Button();
            pictureAnhDaiDien = new PictureBox();
            btnChonAnhDaiDien = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtMssv = new TextBox();
            lblMssv = new Label();
            txtSoDienThoai = new TextBox();
            lblSoDienThoai = new Label();
            dateTimeNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            lblHoVaTen = new Label();
            txtHoVaTen = new TextBox();
            lblDangKy = new Label();
            dlgOpenFile = new OpenFileDialog();
            linkLblQuayVeTrangChu = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureAnhDaiDien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(526, 380);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(110, 35);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // pictureAnhDaiDien
            // 
            pictureAnhDaiDien.BorderStyle = BorderStyle.Fixed3D;
            pictureAnhDaiDien.Location = new Point(428, 52);
            pictureAnhDaiDien.Name = "pictureAnhDaiDien";
            pictureAnhDaiDien.Size = new Size(227, 260);
            pictureAnhDaiDien.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureAnhDaiDien.TabIndex = 45;
            pictureAnhDaiDien.TabStop = false;
            // 
            // btnChonAnhDaiDien
            // 
            btnChonAnhDaiDien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChonAnhDaiDien.ForeColor = SystemColors.ControlText;
            btnChonAnhDaiDien.Location = new Point(472, 323);
            btnChonAnhDaiDien.Name = "btnChonAnhDaiDien";
            btnChonAnhDaiDien.Size = new Size(125, 23);
            btnChonAnhDaiDien.TabIndex = 6;
            btnChonAnhDaiDien.Text = "Chọn ảnh đại diện";
            btnChonAnhDaiDien.UseVisualStyleBackColor = true;
            btnChonAnhDaiDien.Click += btnChonAnhDaiDien_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(231, 255);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(4, 102, 200);
            lblEmail.Location = new Point(38, 255);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 15);
            lblEmail.TabIndex = 39;
            lblEmail.Text = "Email:";
            // 
            // txtMssv
            // 
            txtMssv.Location = new Point(231, 200);
            txtMssv.Name = "txtMssv";
            txtMssv.Size = new Size(168, 23);
            txtMssv.TabIndex = 4;
            // 
            // lblMssv
            // 
            lblMssv.AutoSize = true;
            lblMssv.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMssv.ForeColor = Color.FromArgb(4, 102, 200);
            lblMssv.Location = new Point(38, 207);
            lblMssv.Name = "lblMssv";
            lblMssv.Size = new Size(168, 15);
            lblMssv.TabIndex = 44;
            lblMssv.Text = "Mã số sinh viên (nếu có):";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(231, 152);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(168, 23);
            txtSoDienThoai.TabIndex = 3;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoDienThoai.ForeColor = Color.FromArgb(4, 102, 200);
            lblSoDienThoai.Location = new Point(38, 152);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(144, 15);
            lblSoDienThoai.TabIndex = 43;
            lblSoDienThoai.Text = "Số điện thoại liên hệ:";
            // 
            // dateTimeNgaySinh
            // 
            dateTimeNgaySinh.DropDownAlign = LeftRightAlignment.Right;
            dateTimeNgaySinh.Format = DateTimePickerFormat.Custom;
            dateTimeNgaySinh.Location = new Point(231, 97);
            dateTimeNgaySinh.Name = "dateTimeNgaySinh";
            dateTimeNgaySinh.Size = new Size(168, 23);
            dateTimeNgaySinh.TabIndex = 2;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNgaySinh.ForeColor = Color.FromArgb(4, 102, 200);
            lblNgaySinh.Location = new Point(38, 102);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(174, 15);
            lblNgaySinh.TabIndex = 37;
            lblNgaySinh.Text = "Ngày sinh/Ngày thành lập:";
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.AutoSize = true;
            lblHoVaTen.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoVaTen.ForeColor = Color.FromArgb(4, 102, 200);
            lblHoVaTen.Location = new Point(38, 56);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(71, 15);
            lblHoVaTen.TabIndex = 32;
            lblHoVaTen.Text = "Họ và tên:";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(231, 52);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(168, 23);
            txtHoVaTen.TabIndex = 1;
            // 
            // lblDangKy
            // 
            lblDangKy.AutoSize = true;
            lblDangKy.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDangKy.ForeColor = Color.FromArgb(4, 102, 200);
            lblDangKy.Location = new Point(161, 9);
            lblDangKy.Name = "lblDangKy";
            lblDangKy.Size = new Size(412, 31);
            lblDangKy.TabIndex = 29;
            lblDangKy.Text = "CHỈNH SỬA HỒ SƠ CÁ NHÂN";
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.Filter = "JPEG files| *.jpg; *.jpeg| PNG files|*.png";
            // 
            // linkLblQuayVeTrangChu
            // 
            linkLblQuayVeTrangChu.AutoSize = true;
            linkLblQuayVeTrangChu.Location = new Point(12, 400);
            linkLblQuayVeTrangChu.Name = "linkLblQuayVeTrangChu";
            linkLblQuayVeTrangChu.Size = new Size(104, 15);
            linkLblQuayVeTrangChu.TabIndex = 8;
            linkLblQuayVeTrangChu.TabStop = true;
            linkLblQuayVeTrangChu.Text = "Quay về trang chủ";
            linkLblQuayVeTrangChu.LinkClicked += linkLblQuayVeTrangChu_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 52);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 97);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 148);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 48;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 200);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 49;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 252);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 23);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 50;
            pictureBox5.TabStop = false;
            // 
            // ChinhSuaHoSoCaNhan
            // 
            AcceptButton = btnLuu;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 202, 249);
            ClientSize = new Size(665, 428);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(linkLblQuayVeTrangChu);
            Controls.Add(btnLuu);
            Controls.Add(pictureAnhDaiDien);
            Controls.Add(btnChonAnhDaiDien);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtMssv);
            Controls.Add(lblMssv);
            Controls.Add(txtSoDienThoai);
            Controls.Add(lblSoDienThoai);
            Controls.Add(dateTimeNgaySinh);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblHoVaTen);
            Controls.Add(txtHoVaTen);
            Controls.Add(lblDangKy);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChinhSuaHoSoCaNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChinhSuaHoSoCaNhan";
            FormClosing += ChinhSuaHoSoCaNhan_FormClosing;
            Load += ChinhSuaHoSoCaNhan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureAnhDaiDien).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLuu;
        private PictureBox pictureAnhDaiDien;
        private Button btnChonAnhDaiDien;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtMssv;
        private Label lblMssv;
        private TextBox txtSoDienThoai;
        private Label lblSoDienThoai;
        private DateTimePicker dateTimeNgaySinh;
        private Label lblNgaySinh;
        private Label lblHoVaTen;
        private TextBox txtHoVaTen;
        private Label lblDangKy;
        private OpenFileDialog dlgOpenFile;
        private LinkLabel linkLblQuayVeTrangChu;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}