using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace QuanLyDiem
{
    public partial class FrmDiem : Form
    {
        DataTable tblDiem;
        public FrmDiem()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            sql = "SELECT MaSV, MaLop, MaMon,HocKy,LanThi FROM Diem WHERE MaSV=N'" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and LanThi='" + txtLanThi.Text.Trim() + "'";
            if (DAO.CheckKeyExist(sql) == false)
            {
                MessageBox.Show("Bản ghi này chưa được lưu nên bạn chưa sửa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tblDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "SELECT MaSV, MaLop, MaMon,HocKy,LanThi, Diem FROM Diem WHERE MaSV=N'" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and LanThi='" + txtLanThi.Text.Trim() + "'";
            if (DAO.CheckKeyExist(sql) == true)
            {
                string ss = DAO.GetFieldValues("Select LanThi from Diem where MaSV = '" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'and MaLop='" + cmbMaLop.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and MaMon='" + cmbMonHoc.SelectedValue + "' and LanThi='" + GridViewDiem.CurrentRow.Cells["clmLanThi"].Value.ToString() + "'");
                if (Convert.ToInt32(txtLanThi.Text.Trim()) != Convert.ToInt32(ss))
                {
                    MessageBox.Show("Không được phép sửa lần thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLanThi.Text = ss;
                    return;
                }
            }

            if ((Convert.ToDouble(GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString().Trim()) > 10))
            {
                MessageBox.Show("Bạn nhập sai điểm. Nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem.Focus();
                return;
            }

            if (Convert.ToDouble(GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString().Trim()) >= 5)
            {
                MessageBox.Show("Sinh viên này không phải thi lại lần sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string s0 = DAO.GetFieldValues("select count(MaSV) from Diem WHERE MaSV=N'" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "'");
                for (int i = (Convert.ToInt32(txtLanThi.Text.Trim()) + 1); i <= Convert.ToInt32(s0); i++)
                {
                    sql = "DELETE Diem WHERE MaSV=N'" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and LanThi='" + i + "'";
                    DAO.RunSql(sql);
                }

            }
            string s4 = "SELECT MaSV, MaLop, MaMon,HocKy,LanThi FROM Diem WHERE MaSV=N'" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and LanThi='" + (Convert.ToInt32(txtLanThi.Text.Trim()) + 1) + "'";
            if (Convert.ToDouble(GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString().Trim()) < 5 && DAO.CheckKeyExist(s4) == false)
            {
                sql = "INSERT INTO Diem VALUES(N'" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "',N'" + cmbMaLop.Text + "','" + cmbMonHoc.SelectedValue + "',"
                     + cmbHocKy.Text + "," + (Convert.ToInt32(txtLanThi.Text.Trim()) + 1) + ",null)";
                DAO.RunSql(sql);
                MessageBox.Show("Sinh viên này phải thi lại lần " + (Convert.ToInt32(txtLanThi.Text.Trim()) + 1), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sql = "UPDATE Diem SET Diem = ROUND(" + GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString() + ",1) WHERE MaSV=N'" + txtMaSV.Text.Trim() + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and LanThi='" + txtLanThi.Text.Trim() + "'";
            DAO.RunSql(sql);
            DAO.CloseConnection();
            if (btnQuayLai.Enabled == false)
            {
                Load_DataGridView();
            }
            else
            {
                Load_DataGridView1();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();

            string sql;
            sql = "SELECT MaSV, MaLop, MaMon,HocKy,LanThi, Diem FROM Diem WHERE MaSV=N'" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and LanThi='" + txtLanThi.Text.Trim() + "'";
            if (DAO.CheckKeyExist(sql) == false)
            {
                MessageBox.Show("Bản ghi này chưa được lưu nên bạn không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tblDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string str = DAO.GetFieldValues("Select Diem from Diem where MaSV = '" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'and MaLop='" + cmbMaLop.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and MaMon='" + cmbMonHoc.SelectedValue + "' and LanThi='" + (Convert.ToInt32(txtLanThi.Text.Trim()) + 1) + "'");
            if (Convert.ToDouble(GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString().Trim()) < 5 && str != "")
            {
                MessageBox.Show("Bạn không thể xóa vì sinh viên này đã thi lại lần 2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Convert.ToDouble(GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString().Trim()) < 5 && str == "")
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    sql = "DELETE Diem WHERE MaSV=N'" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and LanThi='" + 1 + "'";
                    DAO.RunSql(sql);
                    if (btnQuayLai.Enabled == false)
                    {
                        Load_DataGridView();
                    }
                    else
                    {
                        Load_DataGridView1();
                    }
                    txtMaSV.Text = "";
                    txtDiem.Text = "";
                    string s1 = DAO.GetFieldValues("select MaSV from Diem WHERE MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and LanThi='" + 2 + "' and Diem is null");
                    string s2 = "select MaSV from Diem WHERE MaSV=N'" + s1 + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and LanThi='" + 1 + "'";
                    if ((DAO.CheckKeyExist(s2) == false))
                    {
                        sql = "DELETE Diem WHERE MaSV=N'" + s1 + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and LanThi='" + 2 + "'";
                        DAO.RunSql(sql);
                    }
                }
            }
            if (Convert.ToDouble(GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString().Trim()) >= 5 && Convert.ToInt32(txtLanThi.Text.Trim()) == 1)
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    sql = "DELETE Diem WHERE MaSV=N'" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and LanThi='" + 1 + "'";
                    DAO.RunSql(sql);
                    if (btnQuayLai.Enabled == false)
                    {
                        Load_DataGridView();
                    }
                    else
                    {
                        Load_DataGridView1();
                    }
                    txtMaSV.Text = "";
                    txtDiem.Text = "";
                }
            }
            DAO.CloseConnection();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (tblDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbMaLop.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbHocKy.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn học kỳ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtLanThi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lần thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLanThi.Focus();
                return;
            }
            if (GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString().Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string s0 = DAO.GetFieldValues("select count(*) from Diem WHERE MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and LanThi='" + txtLanThi.Text.Trim() + "'");
            if (Convert.ToInt32(s0) == tblDiem.Rows.Count && Convert.ToInt32(txtLanThi.Text.Trim()) == 1)
            {
                MessageBox.Show("Bạn phải nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnLuu.Enabled = false;
                return;
            }
            if (Convert.ToInt32(txtLanThi.Text.Trim()) == 1)
            {
                sql = "SELECT MaSV, MaLop, MaMon,HocKy,LanThi FROM Diem WHERE MaSV=N'" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and LanThi='" + txtLanThi.Text.Trim() + "'";
                if (DAO.CheckKeyExist(sql) == true)
                {
                    MessageBox.Show("Bạn đã nhập điểm cho sinh viên học lớp và môn này , bạn hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSV.Focus();
                    return;
                }
            }

            sql = "SELECT MaSV FROM SinhVien WHERE MaSV=N'" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'";
            if (DAO.CheckKeyExist(sql) == false)
            {
                MessageBox.Show("Mã sinh viên không tồn tại , bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString().Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((Convert.ToDouble(GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString().Trim()) > 10))
            {
                MessageBox.Show("Bạn nhập sai điểm.Nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem.Focus();
                return;

            }
            if (Convert.ToDouble(GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString().Trim()) < 5)
            {
                sql = "INSERT INTO Diem VALUES(N'" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "',N'" + cmbMaLop.Text + "','" + cmbMonHoc.SelectedValue + "',"
                         + cmbHocKy.Text + "," + (Convert.ToInt32(txtLanThi.Text.Trim()) + 1) + ",null)";
                DAO.RunSql(sql);
                MessageBox.Show("Sinh viên này phải thi lại lần " + (Convert.ToInt32(txtLanThi.Text.Trim()) + 1), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string str = DAO.GetFieldValues("Select Diem from Diem where MaSV = '" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'and MaLop='" + cmbMaLop.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and MaMon='" + cmbMonHoc.SelectedValue + "' and LanThi='" + (Convert.ToInt32(txtLanThi.Text.Trim()) - 1) + "'");
            if (Convert.ToInt32(txtLanThi.Text.Trim()) > 1 && Convert.ToDouble(str) < 5)
            {
                sql = "UPDATE Diem SET Diem = ROUND(" + GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString() + ",1) WHERE MaSV=N'" + txtMaSV.Text.Trim() + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and LanThi='" + txtLanThi.Text.Trim() + "'";
                DAO.RunSql(sql);
                if (btnQuayLai.Enabled == false)
                {
                    Load_DataGridView();
                }
                else
                {
                    Load_DataGridView1();
                }
                txtMaSV.Text = "";
                txtDiem.Text = "";
            }
            else
            {
                sql = "INSERT INTO Diem VALUES(N'" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "',N'" + cmbMaLop.Text + "','" + cmbMonHoc.SelectedValue + "',"
                          + cmbHocKy.Text + "," + txtLanThi.Text.Trim() + ",ROUND(" + GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString() + ",1))";
                DAO.RunSql(sql);
                Load_DataGridView1();
                txtMaSV.Text = "";
                txtDiem.Text = "";
            }
            DAO.CloseConnection();
            btnLuu.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            if (btnQuayLai.Enabled == true)
            {
                txtMaSV.Text = "";
                txtDiem.Text = "";
                Load_DataGridView1();
            }
            else
            {
                ResetValues();
                Load_DataGridView();
                btnXoa.Enabled = false;
            }
            btnHuy.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDiem_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql = "select MaLop from Lop";
            DAO.FillDataToCombo(sql, cmbMaLop, "MaLop", "MaLop");
            sql = "select MaMon, TenMon from MonHoc";
            DAO.FillDataToCombo(sql, cmbMonHoc, "MaMon", "TenMon");
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnXoa.Enabled = false;
            btnQuayLai.Enabled = false;
            txtMaSV.Enabled = false;
            txtTenSV.Enabled = false;
            txtDiem.Enabled = false;
            Load_DataGridView();
            ResetValues();
            cmbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        private void Load_DataGridView()
        {
            try
            {
                DAO.OpenConnection();
                string str;
                str = "select * from Diem";
                tblDiem = DAO.GetDataToTable(str);
                GridViewDiem.DataSource = tblDiem;
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
            txtTenSV.Text = ""; 
            cmbMaLop.SelectedIndex = -1;
            cmbMonHoc.SelectedIndex = -1;
            cmbHocKy.SelectedIndex = -1;
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select Thoi_Khoa_Bieu.MaMon,TenMon from Thoi_Khoa_Bieu inner join MonHoc on Thoi_Khoa_Bieu.MaMon = MonHoc.MaMon where MaLop = '" + cmbMaLop.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' group by Thoi_Khoa_Bieu.MaMon,TenMon";
            DAO.FillDataToCombo(str, cmbMonHoc, "MaMon", "TenMon");
        }
        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select HocKy from Thoi_Khoa_Bieu where MaLop = '" + cmbMaLop.SelectedValue + "'";
            DAO.FillDataToCombo(str, cmbHocKy, "HocKy", "HocKy");
            cmbHocKy.SelectedIndex = -1;
        }
        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            if (cmbMaLop.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbHocKy.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn học kỳ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtLanThi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lần thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLanThi.Focus();
                return;
            }
            string str;
            str = " select * from Diem where MaLop='" + cmbMaLop.SelectedValue + "' and HocKy = " + cmbHocKy.Text + " and MaMon='" + cmbMonHoc.SelectedValue + "' and LanThi=" + txtLanThi.Text.Trim() + "";
            tblDiem = DAO.GetDataToTable(str);
            GridViewDiem.DataSource = tblDiem;
            btnLuu.Enabled = false;
            if (Convert.ToInt32(txtLanThi.Text.Trim()) > 1)
            {
                btnXoa.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
            }
            btnSua.Enabled = true;
            btnQuayLai.Enabled = true;
            txtMaSV.Text = "";
            txtDiem.Text = "";
        }
        public void cell1()
        {
            txtMaSV.Text = GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString();
            txtDiem.Text = GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString();
            GridViewDiem.CurrentRow.Cells["clmMaLop"].ReadOnly = true;
            GridViewDiem.CurrentRow.Cells["clmHocKy"].ReadOnly = true;
            GridViewDiem.CurrentRow.Cells["clmMaMon"].ReadOnly = true;
            GridViewDiem.CurrentRow.Cells["clmLanThi"].ReadOnly = true;
            btnHuy.Enabled = true;
            string s0 = DAO.GetFieldValues("select count(*) from Diem WHERE MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and LanThi='" + txtLanThi.Text.Trim() + "'");
            string str = DAO.GetFieldValues("Select Diem from Diem where MaSV = '" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'and MaLop='" + cmbMaLop.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and MaMon='" + cmbMonHoc.SelectedValue + "' and LanThi='" + txtLanThi.Text.Trim() + "'");
            string sql = "SELECT MaSV, MaLop, MaMon,HocKy,LanThi,Diem FROM Diem WHERE MaSV=N'" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'AND MaLop=N'" + cmbMaLop.SelectedValue + "'AND MaMon='" + cmbMonHoc.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and LanThi='" + txtLanThi.Text.Trim() + "'";

            if (Convert.ToInt32(txtLanThi.Text.Trim()) == 1)
            {
                if (GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() != "" && str != "" && DAO.CheckKeyExist(sql) == true)
                {
                    btnLuu.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
                else
                {
                    btnLuu.Enabled = true;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
            }
            else if (Convert.ToInt32(txtLanThi.Text.Trim()) > 1)
            {
                if (GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() != "" && str == "")
                {
                    btnLuu.Enabled = true;
                    btnSua.Enabled = false;
                }
                else
                {
                    btnLuu.Enabled = false;
                    btnSua.Enabled = true;
                }
            }

            if (Convert.ToInt32(txtLanThi.Text.Trim()) == 1)
            {
                for (int i = 0; i < Convert.ToInt32(s0); i++)
                {
                    GridViewDiem.Rows[i].Cells["clmMaSV"].ReadOnly = true;
                }
            }
            if (Convert.ToInt32(txtLanThi.Text.Trim()) > 1)
            {
                GridViewDiem.CurrentRow.Cells["clmMaSV"].ReadOnly = true;
                GridViewDiem.Rows[tblDiem.Rows.Count].ReadOnly = true;
            }
        }
        public void cell2()
        {

            GridViewDiem.CurrentRow.Cells["clmMaLop"].ReadOnly = true;
            GridViewDiem.CurrentRow.Cells["clmHocKy"].ReadOnly = true;
            GridViewDiem.CurrentRow.Cells["clmMaMon"].ReadOnly = true;
            GridViewDiem.CurrentRow.Cells["clmLanThi"].ReadOnly = true;
            txtLanThi.Text = GridViewDiem.CurrentRow.Cells["clmLanThi"].Value.ToString();
            txtMaSV.Text = GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString();
            txtDiem.Text = GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString();
            string ma = GridViewDiem.CurrentRow.Cells["clmMaLop"].Value.ToString();
            cmbMaLop.Text = ma;
            ma = GridViewDiem.CurrentRow.Cells["clmMaMon"].Value.ToString();
            cmbMonHoc.Text = DAO.GetFieldValues("select TenMon from MonHoc where MaMon = N'" + ma + "'");
            ma = GridViewDiem.CurrentRow.Cells["clmHocKy"].Value.ToString();
            cmbHocKy.Text = ma;
            GridViewDiem.CurrentRow.Cells["clmMaSV"].ReadOnly = true;
            GridViewDiem.Rows[tblDiem.Rows.Count].ReadOnly = true;
            btnHuy.Enabled = true;
            string str = DAO.GetFieldValues("Select Diem from Diem where MaSV = '" + GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() + "'and MaLop='" + cmbMaLop.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and MaMon='" + cmbMonHoc.SelectedValue + "' and LanThi='" + txtLanThi.Text.Trim() + "'");
            if (GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() != "" && str == "")
            {
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
            }
            if (GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() == "" && GridViewDiem.CurrentRow.Cells["clmDiem"].Value.ToString() == "")
            {
                ResetValues();
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else if (GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() != "" && Convert.ToInt32(GridViewDiem.CurrentRow.Cells["clmLanThi"].Value.ToString()) > 1)
            {
                btnXoa.Enabled = false;
            }
            else if ((GridViewDiem.CurrentRow.Cells["clmMaSV"].Value.ToString() != "" && Convert.ToInt32(GridViewDiem.CurrentRow.Cells["clmLanThi"].Value.ToString()) == 1))
            {
                btnXoa.Enabled = true;
            }
        }
        private void GridViewDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnQuayLai.Enabled == false)
            {
                cell2();
            }
            else
            {
                cell1();
            }
        }
        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (txtMaSV.Text == "")
            {
                txtTenSV.Text = "";
            }
            str = "Select TenSV from SinhVien where MaSV = '" + txtMaSV.Text.Trim() + "'";
            txtTenSV.Text = DAO.GetFieldValues(str);
        }
        private void Load_DataGridView1()
        {
            try
            {
                DAO.OpenConnection();
                string str;
                str = " select * from Diem where MaLop='" + cmbMaLop.SelectedValue + "' and HocKy = '" + cmbHocKy.Text + "' and MaMon='" + cmbMonHoc.SelectedValue + "' and LanThi='" + txtLanThi.Text.Trim() + "'";
                tblDiem = DAO.GetDataToTable(str);
                GridViewDiem.DataSource = tblDiem;
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

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            Load_DataGridView();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnQuayLai.Enabled = false;
        }
    }
}
