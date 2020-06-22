﻿namespace QuanLyDiem
{
    partial class FrmSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinhVien));
            this.clmMaQue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaHDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.clmMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaDanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMaQue = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaKhoa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaChuyenNganh = new System.Windows.Forms.ComboBox();
            this.cmbMaHDT = new System.Windows.Forms.ComboBox();
            this.cmbMaChucVu = new System.Windows.Forms.ComboBox();
            this.cmbMaDanToc = new System.Windows.Forms.ComboBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSinhVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // clmMaQue
            // 
            this.clmMaQue.DataPropertyName = "MaQue";
            this.clmMaQue.HeaderText = "Mã quê";
            this.clmMaQue.MinimumWidth = 8;
            this.clmMaQue.Name = "clmMaQue";
            this.clmMaQue.Width = 150;
            // 
            // clmMaChuyenNganh
            // 
            this.clmMaChuyenNganh.DataPropertyName = "MaChuyenNganh";
            this.clmMaChuyenNganh.HeaderText = "Mã chuyên ngành";
            this.clmMaChuyenNganh.MinimumWidth = 8;
            this.clmMaChuyenNganh.Name = "clmMaChuyenNganh";
            this.clmMaChuyenNganh.Width = 150;
            // 
            // clmMaHDT
            // 
            this.clmMaHDT.DataPropertyName = "MaHDT";
            this.clmMaHDT.HeaderText = "Mã hệ đào tạo";
            this.clmMaHDT.MinimumWidth = 8;
            this.clmMaHDT.Name = "clmMaHDT";
            this.clmMaHDT.Width = 150;
            // 
            // clmMaChucVu
            // 
            this.clmMaChucVu.DataPropertyName = "MaChucVu";
            this.clmMaChucVu.HeaderText = "Mã chức vụ";
            this.clmMaChucVu.MinimumWidth = 8;
            this.clmMaChucVu.Name = "clmMaChucVu";
            this.clmMaChucVu.Width = 150;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1348, 629);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 69);
            this.btnThoat.TabIndex = 88;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridViewSinhVien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(537, 250);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1064, 337);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // GridViewSinhVien
            // 
            this.GridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaSV,
            this.clmTenSV,
            this.clmMaKhoa,
            this.clmMaLop,
            this.clmNgaySinh,
            this.clmGioiTinh,
            this.clmMaQue,
            this.clmMaDanToc,
            this.clmMaChuyenNganh,
            this.clmMaHDT,
            this.clmMaChucVu});
            this.GridViewSinhVien.Location = new System.Drawing.Point(9, 35);
            this.GridViewSinhVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridViewSinhVien.Name = "GridViewSinhVien";
            this.GridViewSinhVien.RowHeadersWidth = 62;
            this.GridViewSinhVien.Size = new System.Drawing.Size(1023, 266);
            this.GridViewSinhVien.TabIndex = 0;
            this.GridViewSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewSinhVien_CellClick);
            // 
            // clmMaSV
            // 
            this.clmMaSV.DataPropertyName = "MaSV";
            this.clmMaSV.HeaderText = "Mã sinh viên";
            this.clmMaSV.MinimumWidth = 8;
            this.clmMaSV.Name = "clmMaSV";
            this.clmMaSV.Width = 150;
            // 
            // clmTenSV
            // 
            this.clmTenSV.DataPropertyName = "TenSV";
            this.clmTenSV.HeaderText = "Tên sinh viên";
            this.clmTenSV.MinimumWidth = 8;
            this.clmTenSV.Name = "clmTenSV";
            this.clmTenSV.Width = 150;
            // 
            // clmMaKhoa
            // 
            this.clmMaKhoa.DataPropertyName = "MaKhoa";
            this.clmMaKhoa.HeaderText = "Mã khoa";
            this.clmMaKhoa.MinimumWidth = 8;
            this.clmMaKhoa.Name = "clmMaKhoa";
            this.clmMaKhoa.Width = 150;
            // 
            // clmMaLop
            // 
            this.clmMaLop.DataPropertyName = "MaLop";
            this.clmMaLop.HeaderText = "Mã lớp";
            this.clmMaLop.MinimumWidth = 8;
            this.clmMaLop.Name = "clmMaLop";
            this.clmMaLop.Width = 150;
            // 
            // clmNgaySinh
            // 
            this.clmNgaySinh.DataPropertyName = "NgaySinh";
            this.clmNgaySinh.HeaderText = "Ngày sinh";
            this.clmNgaySinh.MinimumWidth = 8;
            this.clmNgaySinh.Name = "clmNgaySinh";
            this.clmNgaySinh.Width = 150;
            // 
            // clmGioiTinh
            // 
            this.clmGioiTinh.DataPropertyName = "GioiTinh";
            this.clmGioiTinh.HeaderText = "Giới tính";
            this.clmGioiTinh.MinimumWidth = 8;
            this.clmGioiTinh.Name = "clmGioiTinh";
            this.clmGioiTinh.Width = 150;
            // 
            // clmMaDanToc
            // 
            this.clmMaDanToc.DataPropertyName = "MaDanToc";
            this.clmMaDanToc.HeaderText = "Mã dân tộc";
            this.clmMaDanToc.MinimumWidth = 8;
            this.clmMaDanToc.Name = "clmMaDanToc";
            this.clmMaDanToc.Width = 150;
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(1222, 629);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 69);
            this.btnHuy.TabIndex = 89;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1098, 629);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 69);
            this.btnLuu.TabIndex = 90;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(47, 582);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 30);
            this.label12.TabIndex = 86;
            this.label12.Text = "Mã chức vụ";
            //this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(974, 629);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 69);
            this.btnXoa.TabIndex = 91;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(851, 629);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 69);
            this.btnSua.TabIndex = 92;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(730, 629);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 69);
            this.btnThem.TabIndex = 93;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(48, 528);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 30);
            this.label11.TabIndex = 85;
            this.label11.Text = "Mã hệ đào tạo";
            //this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(48, 474);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 30);
            this.label10.TabIndex = 84;
            this.label10.Text = "Mã chuyên ngành";
            //this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(49, 418);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 30);
            this.label9.TabIndex = 83;
            this.label9.Text = "Mã dân tộc";
            //this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cmbMaQue
            // 
            this.cmbMaQue.FormattingEnabled = true;
            this.cmbMaQue.Location = new System.Drawing.Point(242, 365);
            this.cmbMaQue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMaQue.Name = "cmbMaQue";
            this.cmbMaQue.Size = new System.Drawing.Size(180, 28);
            this.cmbMaQue.TabIndex = 82;
           // this.cmbMaQue.SelectedIndexChanged += new System.EventHandler(this.cmbMaQue_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(49, 365);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 30);
            this.label8.TabIndex = 81;
            this.label8.Text = "Mã quê";
            //this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(49, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 30);
            this.label7.TabIndex = 80;
            this.label7.Text = "Giới tính";
            //this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // mtbNgaySinh
            // 
            this.mtbNgaySinh.Location = new System.Drawing.Point(240, 269);
            this.mtbNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbNgaySinh.Mask = "00/00/0000";
            this.mtbNgaySinh.Name = "mtbNgaySinh";
            this.mtbNgaySinh.Size = new System.Drawing.Size(180, 26);
            this.mtbNgaySinh.TabIndex = 79;
            //this.mtbNgaySinh.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbNgaySinh_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(49, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 30);
            this.label6.TabIndex = 78;
            this.label6.Text = "Ngày sinh";
            //this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(241, 221);
            this.cmbMaLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(180, 28);
            this.cmbMaLop.TabIndex = 77;
            //this.cmbMaLop.SelectedIndexChanged += new System.EventHandler(this.cmbMaLop_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(49, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 30);
            this.label5.TabIndex = 76;
            this.label5.Text = "Mã lớp";
            //this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbMaKhoa
            // 
            this.cmbMaKhoa.FormattingEnabled = true;
            this.cmbMaKhoa.Location = new System.Drawing.Point(241, 171);
            this.cmbMaKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMaKhoa.Name = "cmbMaKhoa";
            this.cmbMaKhoa.Size = new System.Drawing.Size(180, 28);
            this.cmbMaKhoa.TabIndex = 75;
            this.cmbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbMaKhoa_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(49, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 30);
            this.label4.TabIndex = 74;
            this.label4.Text = "Mã khoa";
            //this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(48, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 73;
            this.label3.Text = "Tên sinh viên";
            //this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(240, 69);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(180, 26);
            this.txtMaSV.TabIndex = 72;
           // this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(49, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 30);
            this.label2.TabIndex = 71;
            this.label2.Text = "Mã sinh viên";
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbMaChuyenNganh
            // 
            this.cmbMaChuyenNganh.FormattingEnabled = true;
            this.cmbMaChuyenNganh.Location = new System.Drawing.Point(241, 479);
            this.cmbMaChuyenNganh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMaChuyenNganh.Name = "cmbMaChuyenNganh";
            this.cmbMaChuyenNganh.Size = new System.Drawing.Size(180, 28);
            this.cmbMaChuyenNganh.TabIndex = 18;
            // 
            // cmbMaHDT
            // 
            this.cmbMaHDT.FormattingEnabled = true;
            this.cmbMaHDT.Location = new System.Drawing.Point(241, 533);
            this.cmbMaHDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMaHDT.Name = "cmbMaHDT";
            this.cmbMaHDT.Size = new System.Drawing.Size(180, 28);
            this.cmbMaHDT.TabIndex = 20;
            //this.cmbMaHDT.SelectedIndexChanged += new System.EventHandler(this.cmbMaHDT_SelectedIndexChanged);
            // 
            // cmbMaChucVu
            // 
            this.cmbMaChucVu.FormattingEnabled = true;
            this.cmbMaChucVu.Location = new System.Drawing.Point(241, 587);
            this.cmbMaChucVu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMaChucVu.Name = "cmbMaChucVu";
            this.cmbMaChucVu.Size = new System.Drawing.Size(180, 28);
            this.cmbMaChucVu.TabIndex = 22;
            //this.cmbMaChucVu.SelectedIndexChanged += new System.EventHandler(this.cmbMaChucVu_SelectedIndexChanged);
            // 
            // cmbMaDanToc
            // 
            this.cmbMaDanToc.FormattingEnabled = true;
            this.cmbMaDanToc.Location = new System.Drawing.Point(241, 423);
            this.cmbMaDanToc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMaDanToc.Name = "cmbMaDanToc";
            this.cmbMaDanToc.Size = new System.Drawing.Size(180, 28);
            this.cmbMaDanToc.TabIndex = 16;
            //this.cmbMaDanToc.SelectedIndexChanged += new System.EventHandler(this.cmbMaDanToc_SelectedIndexChanged);
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(240, 119);
            this.txtTenSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(180, 26);
            this.txtTenSV.TabIndex = 4;
            //this.txtTenSV.TextChanged += new System.EventHandler(this.txtTenSV_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(684, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 45);
            this.label1.TabIndex = 70;
            this.label1.Text = "Quản lý sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdNu);
            this.groupBox2.Controls.Add(this.rdNam);
            this.groupBox2.Controls.Add(this.cmbMaChuyenNganh);
            this.groupBox2.Controls.Add(this.cmbMaHDT);
            this.groupBox2.Controls.Add(this.cmbMaChucVu);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmbMaDanToc);
            this.groupBox2.Controls.Add(this.txtTenSV);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbMaQue);
            this.groupBox2.Controls.Add(this.cmbMaKhoa);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbMaLop);
            this.groupBox2.Controls.Add(this.mtbNgaySinh);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(26, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(458, 657);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin sinh viên";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdNu.Location = new System.Drawing.Point(332, 316);
            this.rdNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(67, 34);
            this.rdNu.TabIndex = 24;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            //this.rdNu.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdNam.Location = new System.Drawing.Point(240, 316);
            this.rdNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(84, 34);
            this.rdNam.TabIndex = 23;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            //this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTaiLai);
            this.groupBox3.Controls.Add(this.btnHienThi);
            this.groupBox3.Controls.Add(this.cbMaLop);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(546, 77);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(670, 126);
            this.groupBox3.TabIndex = 96;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiển thị danh sách sinh viên theo mã lớp";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(513, 44);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(112, 50);
            this.btnTaiLai.TabIndex = 8;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(375, 44);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(111, 50);
            this.btnHienThi.TabIndex = 6;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // cbMaLop
            // 
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(136, 56);
            this.cbMaLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(180, 28);
            this.cbMaLop.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(47, 51);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 30);
            this.label13.TabIndex = 2;
            this.label13.Text = "Mã lớp";
            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 790);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSinhVien";
            this.Text = "FrmSinhVien";
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSinhVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaQue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaHDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaChucVu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridViewSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaDanToc;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMaQue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaChuyenNganh;
        private System.Windows.Forms.ComboBox cmbMaHDT;
        private System.Windows.Forms.ComboBox cmbMaChucVu;
        private System.Windows.Forms.ComboBox cmbMaDanToc;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnHienThi;
    }
}