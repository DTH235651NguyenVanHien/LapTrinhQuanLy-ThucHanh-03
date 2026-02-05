namespace QuanLyBanHang.Forms
{
    partial class frmSanPham
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
            btnXuat = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnNhap = new Button();
            btnTImKiem = new Button();
            btnThem = new Button();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            txtMoTa = new TextBox();
            txtTenSanPham = new TextBox();
            label6 = new Label();
            cboHangSanXuat = new ComboBox();
            cboPhanLoai = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTImKiem);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(cboPhanLoai);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1777, 406);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1619, 343);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 46);
            btnXuat.TabIndex = 22;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1091, 343);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(387, 343);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 20;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(563, 343);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(739, 343);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 46);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(915, 343);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(150, 46);
            btnHuyBo.TabIndex = 17;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1443, 343);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 46);
            btnNhap.TabIndex = 16;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTImKiem
            // 
            btnTImKiem.Location = new Point(1267, 343);
            btnTImKiem.Name = "btnTImKiem";
            btnTImKiem.Size = new Size(150, 46);
            btnTImKiem.TabIndex = 15;
            btnTImKiem.Text = "Tìm kiếm";
            btnTImKiem.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(211, 343);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(1164, 50);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(150, 46);
            btnDoiAnh.TabIndex = 13;
            btnDoiAnh.Text = "Đổi ảnh sản phẩm";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(929, 47);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(200, 271);
            picHinhAnh.TabIndex = 12;
            picHinhAnh.TabStop = false;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(658, 124);
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(240, 39);
            numDonGia.TabIndex = 11;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(658, 50);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(240, 39);
            numSoLuong.TabIndex = 10;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(211, 282);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(687, 39);
            txtMoTa.TabIndex = 9;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(211, 200);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(687, 39);
            txtTenSanPham.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 282);
            label6.Name = "label6";
            label6.Size = new Size(188, 32);
            label6.TabIndex = 7;
            label6.Text = "Mô tả sản phẩm";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(211, 118);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(242, 40);
            cboHangSanXuat.TabIndex = 6;
            // 
            // cboPhanLoai
            // 
            cboPhanLoai.FormattingEnabled = true;
            cboPhanLoai.Location = new Point(211, 47);
            cboPhanLoai.Name = "cboPhanLoai";
            cboPhanLoai.Size = new Size(242, 40);
            cboPhanLoai.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(489, 126);
            label5.Name = "label5";
            label5.Size = new Size(129, 32);
            label5.TabIndex = 4;
            label5.Text = "Đơn giá (*)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 50);
            label4.Name = "label4";
            label4.Size = new Size(141, 32);
            label4.TabIndex = 3;
            label4.Text = "Số lượng (*)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 203);
            label3.Name = "label3";
            label3.Size = new Size(199, 32);
            label3.TabIndex = 2;
            label3.Text = "Tên sản phẩm (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 126);
            label2.Name = "label2";
            label2.Size = new Size(197, 32);
            label2.TabIndex = 1;
            label2.Text = "Hãng sản xuất (*)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 50);
            label1.Name = "label1";
            label1.Size = new Size(143, 32);
            label1.TabIndex = 0;
            label1.Text = "Phân loại (*)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 437);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1777, 375);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(0, 38);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(1769, 337);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1801, 824);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            Text = "frmSanPham";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMoTa;
        private TextBox txtTenSanPham;
        private Label label6;
        private ComboBox cboHangSanXuat;
        private ComboBox cboPhanLoai;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnNhap;
        private Button btnTImKiem;
        private Button btnThem;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private Button btnXuat;
        private DataGridView dataGridView;
    }
}