namespace Nhom3.DoAnKTHP.EventMgt
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            lblDangKy = new Label();
            lblMatKhauHienTai = new Label();
            txtMatKhauHienTai = new TextBox();
            txtMatKhauMoi = new TextBox();
            lblMatKhauMoi = new Label();
            txtNhapLaiMatKhauMoi = new TextBox();
            lblNhapLaiMatKhauMoi = new Label();
            btnDoiMatKhau = new Button();
            linkLblQuayVeTrangChu = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblDangKy
            // 
            lblDangKy.AutoSize = true;
            lblDangKy.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDangKy.ForeColor = Color.FromArgb(4, 102, 200);
            lblDangKy.Location = new Point(107, 11);
            lblDangKy.Name = "lblDangKy";
            lblDangKy.Size = new Size(216, 32);
            lblDangKy.TabIndex = 30;
            lblDangKy.Text = "ĐỔI MẬT KHẨU";
            // 
            // lblMatKhauHienTai
            // 
            lblMatKhauHienTai.AutoSize = true;
            lblMatKhauHienTai.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblMatKhauHienTai.ForeColor = Color.FromArgb(4, 102, 200);
            lblMatKhauHienTai.Location = new Point(46, 72);
            lblMatKhauHienTai.Name = "lblMatKhauHienTai";
            lblMatKhauHienTai.Size = new Size(122, 15);
            lblMatKhauHienTai.TabIndex = 31;
            lblMatKhauHienTai.Text = "Mật khẩu hiện tại:";
            lblMatKhauHienTai.Click += lblMatKhauHienTai_Click;
            // 
            // txtMatKhauHienTai
            // 
            txtMatKhauHienTai.Location = new Point(237, 69);
            txtMatKhauHienTai.Margin = new Padding(3, 4, 3, 4);
            txtMatKhauHienTai.Name = "txtMatKhauHienTai";
            txtMatKhauHienTai.PasswordChar = '*';
            txtMatKhauHienTai.Size = new Size(220, 21);
            txtMatKhauHienTai.TabIndex = 1;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(237, 118);
            txtMatKhauMoi.Margin = new Padding(3, 4, 3, 4);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '*';
            txtMatKhauMoi.Size = new Size(220, 21);
            txtMatKhauMoi.TabIndex = 2;
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblMatKhauMoi.ForeColor = Color.FromArgb(4, 102, 200);
            lblMatKhauMoi.Location = new Point(46, 121);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(98, 15);
            lblMatKhauMoi.TabIndex = 33;
            lblMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // txtNhapLaiMatKhauMoi
            // 
            txtNhapLaiMatKhauMoi.Location = new Point(237, 166);
            txtNhapLaiMatKhauMoi.Margin = new Padding(3, 4, 3, 4);
            txtNhapLaiMatKhauMoi.Name = "txtNhapLaiMatKhauMoi";
            txtNhapLaiMatKhauMoi.PasswordChar = '*';
            txtNhapLaiMatKhauMoi.Size = new Size(220, 21);
            txtNhapLaiMatKhauMoi.TabIndex = 3;
            // 
            // lblNhapLaiMatKhauMoi
            // 
            lblNhapLaiMatKhauMoi.AutoSize = true;
            lblNhapLaiMatKhauMoi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblNhapLaiMatKhauMoi.ForeColor = Color.FromArgb(4, 102, 200);
            lblNhapLaiMatKhauMoi.Location = new Point(46, 169);
            lblNhapLaiMatKhauMoi.Name = "lblNhapLaiMatKhauMoi";
            lblNhapLaiMatKhauMoi.Size = new Size(156, 15);
            lblNhapLaiMatKhauMoi.TabIndex = 35;
            lblNhapLaiMatKhauMoi.Text = "Nhập lại mật khẩu mới:";
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoiMatKhau.ForeColor = Color.Black;
            btnDoiMatKhau.Location = new Point(317, 219);
            btnDoiMatKhau.Margin = new Padding(3, 4, 3, 4);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(142, 42);
            btnDoiMatKhau.TabIndex = 4;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // linkLblQuayVeTrangChu
            // 
            linkLblQuayVeTrangChu.AutoSize = true;
            linkLblQuayVeTrangChu.Location = new Point(25, 242);
            linkLblQuayVeTrangChu.Name = "linkLblQuayVeTrangChu";
            linkLblQuayVeTrangChu.Size = new Size(121, 15);
            linkLblQuayVeTrangChu.TabIndex = 5;
            linkLblQuayVeTrangChu.TabStop = true;
            linkLblQuayVeTrangChu.Text = "Quay về trang chủ";
            linkLblQuayVeTrangChu.LinkClicked += linkLblQuayVeTrangChu_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 166);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 51;
            pictureBox3.TabStop = false;
            // 
            // DoiMatKhau
            // 
            AcceptButton = btnDoiMatKhau;
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 202, 249);
            ClientSize = new Size(496, 277);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(linkLblQuayVeTrangChu);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(txtNhapLaiMatKhauMoi);
            Controls.Add(lblNhapLaiMatKhauMoi);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(lblMatKhauMoi);
            Controls.Add(txtMatKhauHienTai);
            Controls.Add(lblMatKhauHienTai);
            Controls.Add(lblDangKy);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            ForeColor = Color.FromArgb(4, 102, 200);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoiMatKhau";
            FormClosing += DoiMatKhau_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDangKy;
        private Label lblMatKhauHienTai;
        private TextBox txtMatKhauHienTai;
        private TextBox txtMatKhauMoi;
        private Label lblMatKhauMoi;
        private TextBox txtNhapLaiMatKhauMoi;
        private Label lblNhapLaiMatKhauMoi;
        private Button btnDoiMatKhau;
        private LinkLabel linkLblQuayVeTrangChu;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}