﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows;
namespace QuanLyDiem
{
    public partial class FrmSinhVien : Form
    {
        DataTable tblSinhVien;
        string GioiTinh;
        public FrmSinhVien()
        {
            InitializeComponent();
        }
        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            cmbMaKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaQue.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaDanToc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaChuyenNganh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaHDT.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaLop.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadDatatogriview();
            btnLuu.Enabled = false;
            string sql = "select MaLop, TenLop from Lop";
            DAO.FillDataToCombo(sql, cmbMaLop, "MaLop", "TenLop");//lớp
            sql = "select MaKhoa, TenKhoa from Khoa";
            DAO.FillDataToCombo(sql, cmbMaKhoa, "MaKhoa", "TenKhoa");//khoa            
            sql = "select MaQue, TenQue from Que";
            DAO.FillDataToCombo(sql, cmbMaQue, "MaQue", "TenQue");//quê
            sql = "select MaDanToc, TenDanToc from DanToc";
            DAO.FillDataToCombo(sql, cmbMaDanToc, "MaDanToc", "TenDanToc");//dân tộc
            sql = "select MaChuyenNganh, TenChuyenNganh from ChuyenNganh";
            DAO.FillDataToCombo(sql, cmbMaChuyenNganh, "MaChuyenNganh", "TenChuyenNganh");//chuyên ngành
            sql = "select MaChucVu, TenChucVu from ChucVu";
            DAO.FillDataToCombo(sql, cmbMaChucVu, "MaChucVu", "TenChucVu");//chức vụ 
            sql = "select MaHDT, TenHDT from HeDaoTao";
            DAO.FillDataToCombo(sql, cmbMaHDT, "MaHDT", "TenHDT");
            string s1 = "select MaLop, TenLop from Lop";
            DAO.FillDataToCombo(s1, cbMaLop, "MaLop", "TenLop");
            cbMaLop.SelectedIndex = -1;
            ResetValues();
            cmbMaChuyenNganh.SelectedIndex = -1;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            GridViewSinhVien.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            GridViewSinhVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadDatatogriview()// LẤY DỮ LIỆU ĐỔ VÀO DATAGRIDVIEW
        {
            try
            {
                DAO.OpenConnection();
                string sql = " select * from SinhVien";
                tblSinhVien = DAO.GetDataToTable(sql);
                GridViewSinhVien.DataSource = tblSinhVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnection();
            }
        }
        private void GridViewSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = GridViewSinhVien.CurrentRow.Cells["clmMaSV"].Value.ToString();
            txtTenSV.Text = GridViewSinhVien.CurrentRow.Cells["clmTenSV"].Value.ToString();
            string sql = "SELECT TenKhoa FROM Khoa WHERE MaKhoa='" + GridViewSinhVien.CurrentRow.Cells["clmMaKhoa"].Value.ToString() + "'";
            string s1 = "SELECT TenLop FROM Lop WHERE MaLop='" + GridViewSinhVien.CurrentRow.Cells["clmMaLop"].Value.ToString() + "'";
            string s2 = "SELECT TenQue FROM Que WHERE MaQue='" + GridViewSinhVien.CurrentRow.Cells["clmMaQue"].Value.ToString() + "'";
            string s3 = "SELECT TenDanToc FROM DanToc WHERE MaDanToc='" + GridViewSinhVien.CurrentRow.Cells["clmMaDanToc"].Value.ToString() + "'";
            string s4 = "SELECT TenChuyenNganh FROM ChuyenNganh WHERE MaChuyenNganh='" + GridViewSinhVien.CurrentRow.Cells["clmMaChuyenNganh"].Value.ToString() + "'";
            string s5 = "SELECT TenHDT FROM HeDaoTao WHERE MaHDT='" + GridViewSinhVien.CurrentRow.Cells["clmMaHDT"].Value.ToString() + "'";
            string s6 = "SELECT TenChucVu FROM ChucVu WHERE MaChucVu='" + GridViewSinhVien.CurrentRow.Cells["clmMaChucVu"].Value.ToString() + "'";
            cmbMaKhoa.Text = DAO.GetFieldValues(sql);
            cmbMaLop.Text = DAO.GetFieldValues(s1);
            mtbNgaySinh.Text = GridViewSinhVien.CurrentRow.Cells["clmNgaySinh"].Value.ToString();
            cmbMaQue.Text = DAO.GetFieldValues(s2);
            cmbMaDanToc.Text = DAO.GetFieldValues(s3);
            cmbMaChuyenNganh.Text = DAO.GetFieldValues(s4);
            cmbMaHDT.Text = DAO.GetFieldValues(s5);
            cmbMaChucVu.Text = DAO.GetFieldValues(s6);

            if (GridViewSinhVien.CurrentRow.Cells["clmGioitinh"].Value.ToString() == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            txtMaSV.Enabled = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        private void ResetValues()
        {
            txtMaSV.Enabled = true;
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            cmbMaKhoa.SelectedIndex = -1;
            cmbMaLop.SelectedIndex = -1;
            cmbMaQue.SelectedIndex = -1;
            cmbMaDanToc.SelectedIndex = -1;
            cmbMaHDT.SelectedIndex = -1;
            cmbMaChuyenNganh.SelectedIndex = -1;
            cmbMaChucVu.SelectedIndex = -1;
            rdNam.Checked = false;
            rdNu.Checked = false;
            mtbNgaySinh.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaSV.Focus();
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;        
            GridViewSinhVien.Enabled = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            string sql;
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Bạn không được để trống mã sinh viên");
                txtMaSV.Focus();
                return;
            }
            if (txtTenSV.Text == "")

            {
                MessageBox.Show("Bạn không được để trống tên sinh viên");
                txtTenSV.Focus();
                return;
            }
            if (cmbMaKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn khoa");
                cmbMaKhoa.Focus();
                return;
            }
            if (cmbMaLop.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn  lớp");
                cmbMaLop.Focus();
                return;
            }
            if (cmbMaQue.SelectedIndex == -1)

            {
                MessageBox.Show("Bạn chưa chọn quê");
                cmbMaQue.Focus();
                return;
            }
            if (cmbMaDanToc.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn  dân tộc");
                cmbMaDanToc.Focus();
                return;
            }
            if (cmbMaHDT.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn hệ đào tạo");
                cmbMaHDT.Focus();
                return;
            }
            if (cmbMaChuyenNganh.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn chuyên ngành");
                cmbMaChuyenNganh.Focus();
                return;
            }
            if (cmbMaChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn chức vụ");
                cmbMaChucVu.Focus();
                return;
            }

            if (mtbNgaySinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn không để trống ngày sinh");
                mtbNgaySinh.Focus();
                return;
            }
            if (rdNam.Checked == false && rdNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DAO.IsDate(mtbNgaySinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbNgaySinh.Text = "";
                mtbNgaySinh.Focus();
                return;
            }

            if (rdNam.Checked == true)
            {
                GioiTinh = "Nam";
            }
            if (rdNu.Checked == true)
            {
                GioiTinh = "Nữ";
            }

            string s1 = " select MaSV from SinhVien where MaSV =N'" + txtMaSV.Text.Trim() + "'";
            DAO.OpenConnection();
            if (DAO.CheckKeyExist(s1))
            {
                MessageBox.Show(" Mã sinh viên đã tồn tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DAO.CloseConnection();
                txtMaSV.Focus();
                return;
            }
            else
            {
                sql = " insert into SinhVien  values('" + txtMaSV.Text.Trim() + "',N'" + txtTenSV.Text.Trim() + "','" + cmbMaKhoa.SelectedValue.ToString() + "','" + cmbMaLop.SelectedValue.ToString() + "','"
                   + DAO.ConvertDateTime(mtbNgaySinh.Text) + "',N'" + GioiTinh + "','" + cmbMaQue.SelectedValue.ToString() + "','" + cmbMaDanToc.SelectedValue.ToString() + "','" + cmbMaChuyenNganh.SelectedValue.ToString()
                   + "','" + cmbMaHDT.SelectedValue.ToString() + "','" + cmbMaChucVu.SelectedValue.ToString() + "')";
                //MessageBox.Show(sql);
                //cập nhật  sĩ số
                string sql1 = " update Lop set SiSo = SiSo +1 WHERE MaLop = '" + cmbMaLop.SelectedValue + "'";
                DAO.RunSql(sql1);
                int sl = Convert.ToInt32(DAO.GetFieldValues(" select SiSo from Lop where MaLop = '" + cmbMaLop.SelectedValue + "'"));
                //MessageBox.Show(" Bạn đã thêm mới thành công, sĩ số sau khi cập nhật của phòng '" + cmbMaLop.Text + "' là " + sl, " thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlCommand cmd = new SqlCommand(sql, DAO.con);// khai báo đổi tượng command
                cmd.CommandText = sql; // gán câu truy vấn
                cmd.Connection = DAO.con;
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();

                LoadDatatogriview();

                DAO.CloseConnection();
                btnLuu.Enabled = false;
                txtMaSV.Enabled = false;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            //string GioiTinh;

            if (tblSinhVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql;
            if (txtTenSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSV.Focus();
                return;
            }
            if (cmbMaKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaKhoa.Focus();
                return;
            }
            if (cmbMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaLop.Focus();
                return;
            }
            if (cmbMaQue.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập quê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaQue.Focus();
                return;
            }
            if (cmbMaDanToc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập dân tôc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaDanToc.Focus();
                return;
            }
            if (cmbMaChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaChucVu.Focus();
                return;
            }
            if (cmbMaChuyenNganh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chuyên ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaChuyenNganh.Focus();
                return;
            }
            if (mtbNgaySinh.Text == "  /  /")

            {
                MessageBox.Show("Bạn không để trống ngày sinh");
                mtbNgaySinh.Focus();
                return;
            }
            if (!DAO.IsDate(mtbNgaySinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbNgaySinh.Text = "";
                mtbNgaySinh.Focus();
                return;
            }
            if (rdNam.Checked == true)
                GioiTinh = "Nam";
            if (rdNu.Checked == true)
                GioiTinh = "Nữ";

            sql = "UPDATE SinhVien SET  TenSV=N'" + txtTenSV.Text.ToString() +
                  "',MaKhoa='" + cmbMaKhoa.SelectedValue.ToString() + "',MaLop='" + cmbMaLop.SelectedValue.ToString() +
                    "',NgaySinh='" + DAO.ConvertDateTime(mtbNgaySinh.Text) + "',GioiTinh=N'" + GioiTinh
                   + "',MaQue='" + cmbMaQue.SelectedValue.ToString() +
                   "',MaDanToc='" + cmbMaDanToc.SelectedValue.ToString() + "',MaChuyenNganh='" + cmbMaChuyenNganh.SelectedValue.ToString() + "',MaHDT='" + cmbMaHDT.SelectedValue.ToString() + "',MaChucVu='" + cmbMaChucVu.SelectedValue.ToString() +
                   "' WHERE MaSV='" + txtMaSV.Text + "'";
            //MessageBox.Show(sql);
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.con;
            cmd.ExecuteNonQuery();//thực thi câu lệnh
            DAO.CloseConnection();
            LoadDatatogriview();

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (tblSinhVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "select MaSV from Diem where MaSV='" + txtMaSV.Text.Trim() + "'";
            if (DAO.CheckKeyExist(sql) == true)
                MessageBox.Show("Bạn không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    sql = " delete from SinhVien where MaSV='" + txtMaSV.Text + "'";
                    //cập nhật sĩ số khi xóa sinh viên
                    String sql1 = " update Lop set SiSo = SiSo -1 WHERE MaLop = '" + cmbMaLop.SelectedValue + "'";
                    DAO.RunSql(sql1);
                    int s2 = Convert.ToInt32(DAO.GetFieldValues(" select SiSo from Lop where MaLop = '" + cmbMaLop.SelectedValue + "'"));
                    MessageBox.Show(" Sĩ số sau khi cập nhật của lớp '" + cmbMaLop.Text + "' là " + s2, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DAO.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = sql;
                    cmd.Connection = DAO.con;
                    cmd.ExecuteNonQuery();
                    DAO.CloseConnection();
                    ResetValues();
                    LoadDatatogriview();
                    //LoadDatatogriview();
                    // update sinh viên giảm xuống
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaSV.Enabled = false;
            GridViewSinhVien.Enabled = true;

        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (cbMaLop.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn lớp");
                cbMaLop.Focus();
                return;
            }
            try
            {
                DAO.OpenConnection();
                string Sql = "select * from SinhVien where MaLop='" + cbMaLop.SelectedValue.ToString() + "'";
                tblSinhVien = DAO.GetDataToTable(Sql);
                GridViewSinhVien.DataSource = tblSinhVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnection();
            }
            cbMaLop.SelectedIndex = -1;
            cbMaLop.Focus();
            return;
        }
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            cbMaLop.SelectedIndex = -1;
            btnTaiLai.Enabled = false;
            btnTaiLai.Enabled = true;
        }
        private void cmbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select MaLop,TenLop from Lop where MaKhoa=N'" + cmbMaKhoa.SelectedValue + "'";
            DAO.FillDataToCombo(str, cmbMaLop, "MaLop", "TenLop");
            str = "select MaChuyenNganh,TenChuyenNganh from ChuyenNganh where MaKhoa=N'" + cmbMaKhoa.SelectedValue + "'";
            DAO.FillDataToCombo(str, cmbMaChuyenNganh, "MaChuyenNganh", "TenChuyenNganh");
        }
    }
}
