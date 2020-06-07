using QuanLyBenhNhan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FrmDiem : Form
    {
        DataTable tblDiem;
        public FrmDiem()
        {
            InitializeComponent();
        }

        private void FrmDiem_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql = "select * from Lop";
            DAO.FillDataToCombo(sql, cmbMaLop, "MaLop", "MaLop");
            sql = "select MaMon, TenMon from MonHoc";
            DAO.FillDataToCombo(sql, cmbMonHoc, "MaMon", "TenMon");
            cmbMaLop.SelectedIndex = -1;
            cmbMonHoc.SelectedIndex = -1;
            //cmbMaLop.Enabled = false;
            //cmbMonHoc.Enabled = false;
            txtMaSV.Enabled = false;
            txtMaMon.Enabled = false;
            txtTenSV.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            Load_DataGridView();
            DAO.CloseConnection();
        }

        private void Load_DataGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql;
                sql = "SELECT * FROM Diem";
                tblDiem = DAO.GetDataToTable(sql);
                GridViewDiem.DataSource = tblDiem;
                GridViewDiem.Enabled = true;
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
        private void ResetValues()
        {
            txtMaSV.Text = "";
            txtDiem.Text = "";
            txtLanThi.Text = "";
            txtMaMon.Text = "";
            cmbMaLop.SelectedIndex = -1;
            cmbMonHoc.SelectedIndex = -1;
            cmbHocKy.SelectedIndex = -1;
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonHoc.Text == "")
            {
                txtMaMon.Text = "";
            }
            //Khi kich chon Ten mon hoc thi Ma mon se tu dong hien ra
            string str = "SELECT MaMon FROM MonHoc WHERE MaMon = N'" + cmbMonHoc.SelectedValue + "'";
            txtMaMon.Text = DAO.GetFieldValues(str);

        }
        private void txtMaSV_TextChanged(object sender, EventArgs e)
                {
                    string str;
                    if (txtMaSV.Text == "")
                    {
                        txtTenSV.Text = "";
                    }
                    //Khi kich chon Ma khach thi ten khach, dia chi, dien thoai se tu dong hien ra
                    str = "Select TenSV from SinhVien where MaSV = '" + txtMaSV.Text.Trim() + "'";
                    txtTenSV.Text = DAO.GetFieldValues(str);
                }
        private void GridViewDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DAO.OpenConnection();
            txtLanThi.Text = GridViewDiem.CurrentRow.Cells["clmLanThi"].Value.ToString();
            txtMaSV.Text = GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString();
            txtDiem.Text=GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString();
            string ma = GridViewDiem.CurrentRow.Cells["clmMaLop"].Value.ToString();
            cmbMaLop.Text = ma ;
            ma = GridViewDiem.CurrentRow.Cells["clmMaMon"].Value.ToString();
            cmbMonHoc.Text = DAO.GetFieldValues("select TenMon from MonHoc where MaMon = N'" + ma + "'");
            ma = GridViewDiem.CurrentRow.Cells["clmHocKy"].Value.ToString();
            cmbHocKy.Text = ma;
            txtMaSV.Enabled = false;
            cmbMaLop.Enabled = false;
            cmbMonHoc.Enabled = false;
            DAO.CloseConnection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            GridViewDiem.Enabled = false;
            cmbMaLop.Enabled = true;
            cmbMonHoc.Enabled = true;
            txtMaSV.Enabled = true;
            cmbMaLop.Focus();
            return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (tblDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbMaLop.SelectedIndex == -1 || txtMaMon.Text == "" || txtMaSV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtLanThi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lần thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLanThi.Focus();
                return;
            }
            if (txtDiem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem.Focus();
                return;
            }

            sql = "UPDATE Diem SET HocKy = " + cmbHocKy.Text + ", LanThi = " + txtLanThi.Text + ", Diem = " + txtDiem.Text
                        + " WHERE MaSV=N'" + txtMaSV.Text.Trim() + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon=N'" + txtMaMon.Text.Trim() + "'";
            DAO.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnHuy.Enabled = false;
            DAO.CloseConnection();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (tblDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbMaLop.SelectedIndex == -1 || txtMaMon.Text == "" || txtMaSV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Diem WHERE MaSV=N'" + txtMaSV.Text.Trim() + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon=N'" + txtMaMon.Text.Trim() + "'";
                DAO.RunSql(sql);
                Load_DataGridView();
                ResetValues();
            }
            DAO.CloseConnection();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (txtMaSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return;
            }
            if (cmbMaLop.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaLop.Focus();
                return;
            }
            if (cmbMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn mã môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMonHoc.Focus();
                return;
            }
            if (txtLanThi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lần thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLanThi.Focus();
                return;
            }
            if (txtDiem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem.Focus();
                return;
            }
            if (cmbHocKy.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn học kỳ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            sql = "SELECT MaSV FROM SinhVien WHERE MaSV=N'" + txtMaSV.Text.Trim() + "'";
            if (DAO.CheckKeyExist(sql)==false)
            {
                MessageBox.Show("Mã sinh viên không tồn tại , bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return;
            }
            sql = "SELECT MaSV, MaLop, MaMon FROM Diem WHERE MaSV=N'" + txtMaSV.Text.Trim() + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon=N'" + txtMaMon.Text.Trim() + "'";
            if (DAO.CheckKeyExist(sql) == true)
            {
                MessageBox.Show("Đã nhập điểm cho sinh viên học lớp và môn này , bạn hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return;
            }
            sql = "INSERT INTO Diem VALUES(N'" + txtMaSV.Text.Trim() + "',N'" + cmbMaLop.Text + "',N'" + txtMaMon.Text + "'," 
                        + cmbHocKy.Text + "," + txtLanThi.Text.Trim() + "," + txtDiem.Text.Trim() + ")";
            DAO.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = false;
            txtMaSV.Enabled = false;
            cmbMaLop.SelectedIndex = -1;
            cmbMonHoc.SelectedIndex = -1;
            DAO.CloseConnection();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            GridViewDiem.Enabled = true;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaSV.Enabled = false;
            cmbMaLop.SelectedIndex = -1;
            cmbMonHoc.SelectedIndex = -1;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
