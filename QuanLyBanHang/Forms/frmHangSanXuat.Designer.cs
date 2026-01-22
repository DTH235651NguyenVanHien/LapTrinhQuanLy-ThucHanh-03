namespace QuanLyBanHang.Forms
{
    partial class frmHangSanXuat
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTenHangSanXuat = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 38);
            label1.Name = "label1";
            label1.Size = new Size(274, 32);
            label1.TabIndex = 0;
            label1.Text = "Thong tin hang san xuat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 134);
            label2.Name = "label2";
            label2.Size = new Size(208, 32);
            label2.TabIndex = 1;
            label2.Text = "Ten hang san xuat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 334);
            label3.Name = "label3";
            label3.Size = new Size(281, 32);
            label3.TabIndex = 2;
            label3.Text = "Danh sach hang san xuat";
            // 
            // txtTenHangSanXuat
            // 
            txtTenHangSanXuat.Location = new Point(605, 131);
            txtTenHangSanXuat.Name = "txtTenHangSanXuat";
            txtTenHangSanXuat.Size = new Size(1401, 39);
            txtTenHangSanXuat.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(605, 219);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 4;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(852, 219);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1099, 219);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(1346, 219);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 46);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(1593, 219);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(150, 46);
            btnHuyBo.TabIndex = 8;
            btnHuyBo.Text = "Huy bo";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1856, 219);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(77, 394);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(1929, 412);
            dataGridView.TabIndex = 10;
            // 
            // frmHangSanXuat
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2101, 834);
            Controls.Add(dataGridView);
            Controls.Add(btnThoat);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTenHangSanXuat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmHangSanXuat";
            Text = "frmHangSanXuat";
            Load += frmHangSanXuat_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTenHangSanXuat;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnThoat;
        private DataGridView dataGridView;
    }
}