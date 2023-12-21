namespace Nhom3.DoAnKTHP.EventMgt
{
    partial class DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTenDangNhap = new TextBox();
            txtMatkhau = new TextBox();
            btnDangNhap = new Button();
            lblDangNhap = new Label();
            lblTenDangNhap = new Label();
            lblMatKhau = new Label();
            groupBoxDangNhap = new GroupBox();
            linkLblDangKy = new LinkLabel();
            linkLblQuenMatKhau = new LinkLabel();
            groupBoxDangNhap.SuspendLayout();
            SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(7, 59);
            txtTenDangNhap.Margin = new Padding(3, 4, 3, 4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Nhập tên đăng nhập";
            txtTenDangNhap.Size = new Size(324, 26);
            txtTenDangNhap.TabIndex = 0;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(7, 131);
            txtMatkhau.Margin = new Padding(3, 4, 3, 4);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = '*';
            txtMatkhau.PlaceholderText = "Nhập mật khẩu";
            txtMatkhau.Size = new Size(324, 26);
            txtMatkhau.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.ActiveBorder;
            btnDangNhap.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.Black;
            btnDangNhap.Location = new Point(232, 291);
            btnDangNhap.Margin = new Padding(3, 4, 3, 4);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(126, 47);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDangNhap.ForeColor = Color.FromArgb(4, 102, 200);
            lblDangNhap.Location = new Point(99, 12);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(221, 40);
            lblDangNhap.TabIndex = 3;
            lblDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.ForeColor = Color.FromArgb(4, 102, 200);
            lblTenDangNhap.Location = new Point(7, 35);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(118, 18);
            lblTenDangNhap.TabIndex = 4;
            lblTenDangNhap.Text = "Tên đăng nhập";
            lblTenDangNhap.Click += lblTenDangNhap_Click;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.ForeColor = Color.FromArgb(4, 102, 200);
            lblMatKhau.Location = new Point(7, 107);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(78, 18);
            lblMatKhau.TabIndex = 5;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // groupBoxDangNhap
            // 
            groupBoxDangNhap.BackColor = Color.FromArgb(144, 202, 249);
            groupBoxDangNhap.Controls.Add(lblMatKhau);
            groupBoxDangNhap.Controls.Add(lblTenDangNhap);
            groupBoxDangNhap.Controls.Add(txtMatkhau);
            groupBoxDangNhap.Controls.Add(txtTenDangNhap);
            groupBoxDangNhap.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDangNhap.ForeColor = Color.FromArgb(4, 102, 200);
            groupBoxDangNhap.Location = new Point(26, 72);
            groupBoxDangNhap.Margin = new Padding(3, 4, 3, 4);
            groupBoxDangNhap.Name = "groupBoxDangNhap";
            groupBoxDangNhap.Padding = new Padding(3, 4, 3, 4);
            groupBoxDangNhap.Size = new Size(338, 189);
            groupBoxDangNhap.TabIndex = 6;
            groupBoxDangNhap.TabStop = false;
            groupBoxDangNhap.Text = "Thông tin đăng nhập :";
            groupBoxDangNhap.Enter += groupBoxDangNhap_Enter;
            // 
            // linkLblDangKy
            // 
            linkLblDangKy.AutoSize = true;
            linkLblDangKy.Location = new Point(33, 291);
            linkLblDangKy.Name = "linkLblDangKy";
            linkLblDangKy.Size = new Size(63, 20);
            linkLblDangKy.TabIndex = 3;
            linkLblDangKy.TabStop = true;
            linkLblDangKy.Text = "Đăng ký";
            linkLblDangKy.LinkClicked += linkLblDangKy_LinkClicked;
            // 
            // linkLblQuenMatKhau
            // 
            linkLblQuenMatKhau.AutoSize = true;
            linkLblQuenMatKhau.Location = new Point(33, 317);
            linkLblQuenMatKhau.Name = "linkLblQuenMatKhau";
            linkLblQuenMatKhau.Size = new Size(109, 20);
            linkLblQuenMatKhau.TabIndex = 4;
            linkLblQuenMatKhau.TabStop = true;
            linkLblQuenMatKhau.Text = "Quên mật khẩu";
            linkLblQuenMatKhau.LinkClicked += linkLblQuenMatKhau_LinkClicked;
            // 
            // DangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 202, 249);
            ClientSize = new Size(391, 355);
            Controls.Add(linkLblQuenMatKhau);
            Controls.Add(linkLblDangKy);
            Controls.Add(groupBoxDangNhap);
            Controls.Add(lblDangNhap);
            Controls.Add(btnDangNhap);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += DangNhap_FormClosing_1;
            Load += DangNhap_Load;
            groupBoxDangNhap.ResumeLayout(false);
            groupBoxDangNhap.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenDangNhap;
        private TextBox txtMatkhau;
        private Button btnDangNhap;
        private Label lblDangNhap;
        private Label lblTenDangNhap;
        private Label lblMatKhau;
        private GroupBox groupBoxDangNhap;
        private LinkLabel linkLblDangKy;
        private LinkLabel linkLblQuenMatKhau;
    }
}
