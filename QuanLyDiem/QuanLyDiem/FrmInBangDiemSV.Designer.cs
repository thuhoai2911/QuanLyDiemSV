namespace QuanLyDiem
{
    partial class FrmInBangDiemSV
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.GridViewInBangDiemSV = new System.Windows.Forms.DataGridView();
            this.clmMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLanThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInBangDiemSV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtTenSV);
            this.groupBox3.Controls.Add(this.txtMaSV);
            this.groupBox3.Location = new System.Drawing.Point(150, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 156);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã sinh viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(248, 41);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(166, 26);
            this.txtMaSV.TabIndex = 15;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // GridViewInBangDiemSV
            // 
            this.GridViewInBangDiemSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewInBangDiemSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaSV,
            this.clmMaLop,
            this.clmMaMon,
            this.clmHocKy,
            this.clmLanThi,
            this.clmDiem});
            this.GridViewInBangDiemSV.Location = new System.Drawing.Point(52, 215);
            this.GridViewInBangDiemSV.Name = "GridViewInBangDiemSV";
            this.GridViewInBangDiemSV.RowHeadersWidth = 62;
            this.GridViewInBangDiemSV.RowTemplate.Height = 28;
            this.GridViewInBangDiemSV.Size = new System.Drawing.Size(749, 223);
            this.GridViewInBangDiemSV.TabIndex = 66;
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
            this.clmLanThi.HeaderText = "Lần thi";
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
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(366, 462);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(108, 64);
            this.btnIn.TabIndex = 67;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(228, 462);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 64);
            this.btnLamMoi.TabIndex = 68;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(501, 462);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 64);
            this.btnThoat.TabIndex = 67;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTenSV
            // 
            this.txtTenSV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTenSV.Location = new System.Drawing.Point(248, 99);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(166, 26);
            this.txtTenSV.TabIndex = 15;
            this.txtTenSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên sinh viên";
            // 
            // FrmInBangDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 549);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.GridViewInBangDiemSV);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmInBangDiemSV";
            this.Text = "InBangDiemSV";
            this.Load += new System.EventHandler(this.FrmInBangDiemSV_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInBangDiemSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.DataGridView GridViewInBangDiemSV;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLanThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSV;
    }
}