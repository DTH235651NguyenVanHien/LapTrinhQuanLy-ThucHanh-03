namespace QuanLyBanHang.Forms
{
    partial class frmNhanVien
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
            groupBox1 = new GroupBox();
            dataGridView = new DataGridView();
            groupBox2 = new GroupBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboQuyenHan = new ComboBox();
            txtDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            txtHoTen = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Location = new Point(12, 269);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1533, 308);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sach nhan vien";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(6, 38);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(1521, 264);
            dataGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXuat);
            groupBox2.Controls.Add(btnNhap);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnHuyBo);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(cboQuyenHan);
            groupBox2.Controls.Add(txtDienThoai);
            groupBox2.Controls.Add(txtDiaChi);
            groupBox2.Controls.Add(txtTenDangNhap);
            groupBox2.Controls.Add(txtMatKhau);
            groupBox2.Controls.Add(txtHoTen);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1533, 251);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thong tin nhan vien";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1377, 172);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 46);
            btnXuat.TabIndex = 20;
            btnXuat.Text = "Xuat";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1377, 102);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 46);
            btnNhap.TabIndex = 19;
            btnNhap.Text = "Nhap";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1377, 38);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 46);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Text = "Tim kiem";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1148, 172);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(1148, 105);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(150, 46);
            btnHuyBo.TabIndex = 16;
            btnHuyBo.Text = "Huy bo";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(1148, 38);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 46);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(899, 172);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(899, 105);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(899, 41);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 12;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Location = new Point(612, 183);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(242, 40);
            cboQuyenHan.TabIndex = 11;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(161, 106);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(234, 39);
            txtDienThoai.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(161, 179);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(234, 39);
            txtDiaChi.TabIndex = 9;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(612, 45);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(242, 39);
            txtTenDangNhap.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(612, 109);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(242, 39);
            txtMatKhau.TabIndex = 7;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(161, 45);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(234, 39);
            txtHoTen.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 109);
            label6.Name = "label6";
            label6.Size = new Size(130, 32);
            label6.TabIndex = 5;
            label6.Text = "Dien thoai:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 186);
            label5.Name = "label5";
            label5.Size = new Size(92, 32);
            label5.TabIndex = 4;
            label5.Text = "Dia chi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 45);
            label4.Name = "label4";
            label4.Size = new Size(210, 32);
            label4.TabIndex = 3;
            label4.Text = "Ten dang nhap (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 109);
            label3.Name = "label3";
            label3.Size = new Size(151, 32);
            label3.TabIndex = 2;
            label3.Text = "Mat khau (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 186);
            label2.Name = "label2";
            label2.Size = new Size(168, 32);
            label2.TabIndex = 1;
            label2.Text = "Quyen han (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 0;
            label1.Text = "Ho va ten (*):";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 589);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboQuyenHan;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private TextBox txtHoTen;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
    }
}