using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;
using QuanLyDiem.Properties;
using QuanLyDiem;

namespace QuanLyDiem
{
    public partial class FrmInDSDiem : Form
    {
        DataTable tblDSSiem;
        public FrmInDSDiem()
        {
            InitializeComponent();
        }

        private void FrmInDSDiem_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql = "select MaLop from Lop";
            DAO.FillDataToCombo(sql, cmbMaLop, "MaLop", "MaLop");
            sql = "select MaMon from MonHoc";
            DAO.FillDataToCombo(sql, cmbMaMon, "MaMon", "MaMon");
            Load_DataGridView();
            cmbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbMaMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            btnLamMoi.Enabled = false;
            txtTenMon.Enabled = false;
            txtLanThi.TextChanged += txtLanThi_TextChanged;
            cmbMaMon.SelectedIndexChanged += cmbMon_SelectedIndexChanged;
            cmbMaLop.SelectedIndexChanged += cmbLop_SelectedIndexChanged;
            DAO.CloseConnection();
        }
        private void Load_DataGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql;
                sql = "SELECT * FROM Diem";
                tblDSSiem = DAO.GetDataToTable(sql);
                GridViewDSDiem.DataSource = tblDSSiem;
                GridViewDSDiem.Enabled = true;
                ResetValues();
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


        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaLop.SelectedIndex != -1)
            {
                btnLamMoi.Enabled = true;
                string str;
                str = "select distinct MaMon from Diem  where MaLop = '" + cmbMaLop.SelectedValue + "'";
                DAO.FillDataToCombo(str, cmbMaMon, "MaMon", "MaMon");

            }
        }

        private void cmbMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLamMoi.Enabled = true;
            string str;
            if (cmbMaMon.SelectedIndex == -1)
            {
                txtTenMon.Text = "";
            }
            //Khi kich chon Ma mon thi ten mon hien ra
            str = "Select TenMon from MonHoc where MaMon = '" + cmbMaMon.Text + "'";
            txtTenMon.Text = DAO.GetFieldValues(str);

            if (cmbMaLop.SelectedIndex != -1 && cmbMaMon.SelectedIndex != -1 && txtLanThi.Text.Trim() != "")
            {
                str = "select distinct * from Diem where MaLop = '" + cmbMaLop.SelectedValue + "' and MaMon='" + cmbMaMon.SelectedValue + "' and LanThi=" + txtLanThi.Text.Trim() + "";
                //str = "select MaMon, LanThi from Diem where MaMon='" + cmbMonHoc.SelectedValue + "' and LanThi=" + txtLanThi.Text.Trim() + " group by MaMon, LanThi";
                //MessageBox.Show(str);
                tblDSSiem = DAO.GetDataToTable(str);
                GridViewDSDiem.DataSource = tblDSSiem;
            }
        }

        private void txtLanThi_TextChanged(object sender, EventArgs e)
        {
            btnLamMoi.Enabled = true;
            if (cmbMaLop.SelectedIndex != -1 && cmbMaMon.SelectedIndex != -1 && txtLanThi.Text.Trim() != "")
            {
                string str;
                str = "select distinct * from Diem where MaLop = '" + cmbMaLop.SelectedValue + "' and MaMon='" + cmbMaMon.SelectedValue + "' and LanThi=" + txtLanThi.Text.Trim() + "";
                tblDSSiem = DAO.GetDataToTable(str);
                GridViewDSDiem.DataSource = tblDSSiem;
            }
        }

        private void ResetValues()
        {
            cmbMaMon.SelectedIndex = -1;
            txtTenMon.Text = "";
            cmbMaLop.SelectedIndex = -1;
            txtLanThi.Text = "";
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetValues();
            cmbMaLop.Focus();
            Load_DataGridView();
            return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (cmbMaLop.Text == "" || cmbMaMon.Text == "" || txtLanThi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn đủ điều kiện hiển thị trước!");
            }
            else
            {
                MessageBox.Show("Vui lòng chờ... Đang cập nhật dữ liệu");

                COMExcel.Application exApp = new COMExcel.Application();
                COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
                COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
                COMExcel.Range exRange;
                string sql;
                int hang = 0, cot = 0;
                exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
                exSheet = exBook.Worksheets[1];

                exRange = exSheet.Cells[1, 1];
                exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
                exRange.Range["A1:B3"].Font.Size = 10;
                exRange.Range["A1:B3"].Font.Bold = true;
                exRange.Range["A1:B3"].Font.ColorIndex = 25; //Màu navy
                exRange.Range["A1:A1"].ColumnWidth = 7;
                exRange.Range["B1:B1"].ColumnWidth = 15;
                exRange.Range["A1:B1"].MergeCells = true;
                exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A1:B1"].Value = "Banking Acedemy Vietnam";
                exRange.Range["A2:E2"].MergeCells = true;
                exRange.Range["A2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:E2"].Value = "12 Chua Boc Street, Quang Trung Ward, Dong Da District, Hanoi, Vietnam";

                exRange.Range["C5:F5"].Font.Size = 20;
                exRange.Range["C5:F5"].Font.Bold = true;
                exRange.Range["C5:F5"].Font.ColorIndex = 9; //Màu nâu
                exRange.Range["C5:F5"].MergeCells = true;
                exRange.Range["C5:F5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C5:F5"].Value = "DANH SÁCH ĐIỂM SINH VIÊN";

                sql = "SELECT * FROM Diem where MaMon=N'" + cmbMaMon.SelectedValue + "' and MaLop=N'" + cmbMaLop.SelectedValue + "'and LanThi=" + txtLanThi.Text.Trim();
                tblDSSiem = DAO.GetDataToTable(sql);
                exRange.Range["A7:K7"].Font.Bold = true;
                exRange.Range["A7:K7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C7:F7"].ColumnWidth = 12;
                exRange.Range["G7"].ColumnWidth = 16;
                exRange.Range["I7"].ColumnWidth = 13;
                exRange.Range["J7"].ColumnWidth = 12;
                exRange.Range["K7"].ColumnWidth = 12;

                exRange.Range["A7:G7"].Interior.Color = System.Drawing.Color.Bisque;
                exRange.Range["A7:A7"].Value = "STT";
                exRange.Range["A7:A7"].ColumnWidth = 5;
                exRange.Range["B7:B7"].Value = "Mã sinh viên";
                exRange.Range["C7:C7"].Value = "Mã lớp";
                exRange.Range["D7:D7"].Value = "Mã môn";
                exRange.Range["E7:E7"].Value = "Học kỳ";
                exRange.Range["F7:F7"].Value = "Lần thi";
                exRange.Range["G7:G7"].Value = "Điểm";

                for (hang = 0; hang < tblDSSiem.Rows.Count; hang++)
                {
                    //Điền số thứ tự vào cột 1 từ dòng 8
                    exSheet.Cells[1][hang + 8] = hang + 1;
                    for (cot = 0; cot < tblDSSiem.Columns.Count; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 8
                    {
                        exSheet.Cells[cot + 2][hang + 8] = tblDSSiem.Rows[hang][cot].ToString();
                        if (cot == 3) exSheet.Cells[cot + 2][hang + 8] = tblDSSiem.Rows[hang][cot].ToString();
                    }
                }
                exSheet.Name = "Danh Sách Điểm Sinh viên";
                exApp.Visible = true;
            }
        }

        private void txtLanThi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}