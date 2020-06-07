namespace QuanLyDiem
{
    partial class FrmDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiem));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridViewDiem = new System.Windows.Forms.DataGridView();
            this.clmMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLanThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLanThi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDiem)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(654, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 45);
            this.label3.TabIndex = 14;
            this.label3.Text = "Điểm sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridViewDiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(653, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(933, 357);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // GridViewDiem
            // 
            this.GridViewDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaSV,
            this.clmMaLop,
            this.clmMaMon,
            this.clmHocKy,
            this.clmLanThi,
            this.clmDiem});
            this.GridViewDiem.Location = new System.Drawing.Point(32, 50);
            this.GridViewDiem.Name = "GridViewDiem";
            this.GridViewDiem.RowHeadersWidth = 62;
            this.GridViewDiem.RowTemplate.Height = 28;
            this.GridViewDiem.Size = new System.Drawing.Size(866, 266);
            this.GridViewDiem.TabIndex = 19;
            this.GridViewDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDiem_CellClick);
            // 
            // clmMaSV
            // 
            this.clmMaSV.DataPropertyName = "MaSV";
            this.clmMaSV.HeaderText = "Mã sinh viên";
            this.clmMaSV.MinimumWidth = 8;
            this.clmMaSV.Name = "clmMaSV";
            this.clmMaSV.Width = 150;
            // 
            // clmMaLop
            // 
            this.clmMaLop.DataPropertyName = "MaLop";
            this.clmMaLop.HeaderText = "Mã lớp";
            this.clmMaLop.MinimumWidth = 8;
            this.clmMaLop.Name = "clmMaLop";
            this.clmMaLop.Width = 150;
            // 
            // clmMaMon
            // 
            this.clmMaMon.DataPropertyName = "MaMon";
            this.clmMaMon.HeaderText = "Mã môn";
            this.clmMaMon.MinimumWidth = 8;
            this.clmMaMon.Name = "clmMaMon";
            this.clmMaMon.Width = 150;
            // 
            // clmHocKy
            // 
            this.clmHocKy.DataPropertyName = "HocKy";
            this.clmHocKy.HeaderText = "Học kỳ";
            this.clmHocKy.MinimumWidth = 8;
            this.clmHocKy.Name = "clmHocKy";
            this.clmHocKy.Width = 150;
            // 
            // clmLanThi
            // 
            this.clmLanThi.DataPropertyName = "LanThi";
            this.clmLanThi.HeaderText = "Lần Thi";
            this.clmLanThi.MinimumWidth = 8;
            this.clmLanThi.Name = "clmLanThi";
            this.clmLanThi.Width = 150;
            // 
            // clmDiem
            // 
            this.clmDiem.DataPropertyName = "Diem";
            this.clmDiem.HeaderText = "Điểm";
            this.clmDiem.MinimumWidth = 8;
            this.clmDiem.Name = "clmDiem";
            this.clmDiem.Width = 150;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1394, 517);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 63);
            this.btnThoat.TabIndex = 56;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(1272, 517);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 63);
            this.btnHuy.TabIndex = 57;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1150, 517);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 63);
            this.btnLuu.TabIndex = 58;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1025, 517);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 63);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(902, 517);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 63);
            this.btnSua.TabIndex = 60;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(779, 517);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 63);
            this.btnThem.TabIndex = 61;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtTenSV);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtDiem);
            this.groupBox5.Controls.Add(this.txtMaSV);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(42, 486);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(649, 144);
            this.groupBox5.TabIndex = 84;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin chi tiết";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 30);
            this.label8.TabIndex = 83;
            this.label8.Text = "Tên sinh viên";
            // 
            // txtTenSV
            // 
            this.txtTenSV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTenSV.Location = new System.Drawing.Point(172, 92);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(169, 29);
            this.txtTenSV.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 30);
            this.label7.TabIndex = 78;
            this.label7.Text = "Mã sinh viên";
            // 
            // txtDiem
            // 
            this.txtDiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiem.Location = new System.Drawing.Point(466, 48);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(153, 29);
            this.txtDiem.TabIndex = 81;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(172, 45);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(170, 29);
            this.txtMaSV.TabIndex = 79;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 30);
            this.label6.TabIndex = 80;
            this.label6.Text = "Điểm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cmbHocKy);
            this.groupBox4.Controls.Add(this.txtMaMon);
            this.groupBox4.Controls.Add(this.btnDanhSach);
            this.groupBox4.Controls.Add(this.cmbMaLop);
            this.groupBox4.Controls.Add(this.cmbMonHoc);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtLanThi);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(42, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(554, 357);
            this.groupBox4.TabIndex = 83;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lựa chọn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 30);
            this.label9.TabIndex = 74;
            this.label9.Text = "Học kỳ";
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbHocKy.Location = new System.Drawing.Point(150, 109);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(206, 28);
            this.cmbHocKy.TabIndex = 73;
            // 
            // txtMaMon
            // 
            this.txtMaMon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMaMon.Location = new System.Drawing.Point(415, 168);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(111, 26);
            this.txtMaMon.TabIndex = 72;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.Location = new System.Drawing.Point(219, 275);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(135, 59);
            this.btnDanhSach.TabIndex = 71;
            this.btnDanhSach.Text = "Danh sách";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(150, 48);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(206, 28);
            this.cmbMaLop.TabIndex = 70;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(150, 165);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(144, 28);
            this.cmbMonHoc.TabIndex = 69;
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 30);
            this.label2.TabIndex = 66;
            this.label2.Text = "Mã môn";
            // 
            // txtLanThi
            // 
            this.txtLanThi.Location = new System.Drawing.Point(150, 219);
            this.txtLanThi.Name = "txtLanThi";
            this.txtLanThi.Size = new System.Drawing.Size(144, 26);
            this.txtLanThi.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 30);
            this.label5.TabIndex = 66;
            this.label5.Text = "Môn học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 30);
            this.label4.TabIndex = 65;
            this.label4.Text = "Lần thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 64;
            this.label1.Text = "Mã lớp";
            // 
            // FrmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 661);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Name = "FrmDiem";
            this.Text = "FrmDiem";
            this.Load += new System.EventHandler(this.FrmDiem_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDiem)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridViewDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLanThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLanThi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.Label label9;

    }
}
