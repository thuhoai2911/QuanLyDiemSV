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
using Microsoft.Office.Interop.Excel;

namespace QuanLyDiem
{
    public partial class FrmInBangDiemSV : Form
    {
        System.Data.DataTable tblInBangDiemSV;
        public FrmInBangDiemSV()
        {
            InitializeComponent();
        }
        private void FrmInBangDiemSV_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            Load_DataGridView();
            txtTenSV.Enabled = false;
            DAO.CloseConnection();
        }
        private void Load_DataGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql;
                sql = "SELECT * FROM Diem";
                tblInBangDiemSV = DAO.GetDataToTable(sql);
                GridViewInBangDiemSV.DataSource = tblInBangDiemSV;
                GridViewInBangDiemSV.Enabled = true;
                // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
                GridViewInBangDiemSV.AllowUserToAddRows = false;
                // Không cho phép sửa dữ liệu trực tiếp trên lưới
                GridViewInBangDiemSV.EditMode = DataGridViewEditMode.EditProgrammatically;
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
            txtMaSV.Focus();
            return;
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            int kt = 0;
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã sinh viên trước!");
                ResetValues();
            }
            else
            {
                string sql = "select MaSV from SinhVien where MaSV='" + txtMaSV.Text.Trim() + "'";
                tblInBangDiemSV = DAO.GetDataToTable(sql);
                if (tblInBangDiemSV.Rows.Count == 0)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    kt = -1;
                    ResetValues();
                }
                if (kt == 0)
                {
                    sql = "select * from Diem where MaSV=N'" + txtMaSV.Text + "'";
                    if (DAO.CheckKeyExist(sql) == false)
                    {
                        MessageBox.Show("Mã sinh viên chưa có điểm , hãy nhập mã khác để in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ResetValues();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chờ... Đang cập nhật dữ liệu");
                        COMExcel.Application exApp = new COMExcel.Application();
                        COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
                        COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
                        COMExcel.Range exRange;
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
                        exRange.Range["A1:D1"].MergeCells = true;
                        exRange.Range["A1:D1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
                        exRange.Range["A1:D1"].Value = "Banking Acedemy Vietnam";
                        exRange.Range["A2:D2"].MergeCells = true;
                        exRange.Range["A2:D2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
                        exRange.Range["A2:D2"].Value = "12 Chua Boc, Quang Trung, Dong Da, Hanoi, Vietnam";

                        exRange.Range["B5:F5"].Font.Size = 20;
                        exRange.Range["B5:F5"].Font.Bold = true;
                        exRange.Range["B5:F5"].Font.ColorIndex = 9; //Màu nâu
                        exRange.Range["B5:F5"].MergeCells = true;
                        exRange.Range["B5:F5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                        exRange.Range["B5:F5"].Value = "ĐIỂM SINH VIÊN";

                        exRange.Range["B7:F9"].MergeCells = true;
                        exRange.Range["B7:F7"].Font.ColorIndex = 56;
                        //exRange.Range["B7:F7"].Font.Bold = true;
                        exRange.Range["B7:F7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                        exRange.Range["B7:B7"].Value = "Thông tin sinh viên \nMã sinh viên: " + txtMaSV.Text.Trim() + "\nTên sinh viên: " + txtTenSV.Text.Trim();

                        //exRange.Range["B8:F8"].MergeCells = true;
                        //exRange.Range["B8:B8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
                        //exRange.Range["B8:B8"].Value = "Tên sinh viên: " + txtTenSV.Text.Trim();

                        // exRange.Range["B9:F9"].MergeCells = true;
                        // exRange.Range["B9:F9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
                        // exRange.Range["B9:F9"].Value = ";

                        BorderAround(exRange.Range["B7:F9"], 25);


                        int hk = 1;
                        int row = 10;
                        sql = "select MAX(HocKy) from Diem where MaSV=N'" + txtMaSV.Text.Trim() + "'";
                        string SoLuongHK = DAO.GetFieldValues(sql);
                        for (hk = 1; hk <= Convert.ToInt32(SoLuongHK); hk++)
                        {
                            exRange = exSheet.Cells[1][hk + row];
                            sql = "SELECT a.MaMon,b.TenMon,b.DVHT,a.LanThi,a.Diem FROM Diem as a inner join MonHoc as b on a.MaMon=b.MaMon where MaSV = N'" + txtMaSV.Text.Trim() + "'and HocKy=" + hk;
                            tblInBangDiemSV = DAO.GetDataToTable(sql);
                            exRange.Range["A1:K1"].Font.Bold = true;
                            exRange.Range["A1:G1"].MergeCells = true;
                            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
                            exRange.Range["A1:A1"].Value = "Học kỳ " + hk;
                            exRange.Range["A1:A1"].Interior.Color = System.Drawing.Color.Bisque;
                            row++;
                            exRange = exSheet.Cells[2][hk + row];
                            exRange.Range["A1:K1"].Font.Bold = true;
                            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                            exRange.Range["A1:A1"].Value = "STT";
                            exRange.Range["A1:A1"].ColumnWidth = 5;
                            exRange.Range["B1:B1"].Value = "Mã môn";
                            exRange.Range["C1:C1"].Value = "Tên môn";
                            exRange.Range["C1:C1"].ColumnWidth = 40;
                            exRange.Range["D1:D1"].Value = "ĐVHT";
                            exRange.Range["E1:E1"].Value = "Lần thi";
                            exRange.Range["F1:F1"].Value = "Điểm";
                            row++;
                            for (hang = 0; hang < tblInBangDiemSV.Rows.Count; hang++)
                            {
                                //Điền số thứ tự vào cột 1 từ dòng 11
                                exSheet.Cells[2][hang + hk + row] = hang + 1;
                                for (cot = 0; cot < tblInBangDiemSV.Columns.Count; cot++) //Điền thông tin hàng từ cột thứ 2, dòng 12
                                {
                                    exSheet.Cells[cot + 3][hang + hk + row] = tblInBangDiemSV.Rows[hang][cot].ToString();
                                    //if (cot == 3) exSheet.Cells[cot + 3][hang + hk + row] = tblInBangDiemSV.Rows[hang][cot].ToString();
                                }
                            }
                            row += tblInBangDiemSV.Rows.Count;
                        }

                        void BorderAround(COMExcel.Range range, int colour)
                        {
                            COMExcel.Borders borders1 = range.Borders;
                            borders1[COMExcel.XlBordersIndex.xlEdgeLeft].LineStyle = COMExcel.XlLineStyle.xlContinuous;
                            borders1[COMExcel.XlBordersIndex.xlEdgeTop].LineStyle = COMExcel.XlLineStyle.xlContinuous;
                            borders1[COMExcel.XlBordersIndex.xlEdgeBottom].LineStyle = COMExcel.XlLineStyle.xlContinuous;
                            borders1[COMExcel.XlBordersIndex.xlEdgeRight].LineStyle = COMExcel.XlLineStyle.xlContinuous;
                            borders1.Color = colour;
                            borders1[COMExcel.XlBordersIndex.xlInsideVertical].LineStyle = COMExcel.XlLineStyle.xlLineStyleNone;
                            borders1[COMExcel.XlBordersIndex.xlInsideHorizontal].LineStyle = COMExcel.XlLineStyle.xlLineStyleNone;
                            borders1[COMExcel.XlBordersIndex.xlDiagonalUp].LineStyle = COMExcel.XlLineStyle.xlLineStyleNone;
                            borders1[COMExcel.XlBordersIndex.xlDiagonalDown].LineStyle = COMExcel.XlLineStyle.xlLineStyleNone;
                            borders1 = null;
                        }

                        exSheet.Name = "Điểm sinh viên";
                        exApp.Visible = true;
                    }
                }     
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
            txtMaSV.Text = "";
            txtMaSV.Focus();
            Load_DataGridView();
            return;
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Diem where MaSV='" + txtMaSV.Text.Trim() + "'";
            tblInBangDiemSV = DAO.GetDataToTable(sql);
            GridViewInBangDiemSV.DataSource = tblInBangDiemSV;
            sql = "select TenSV from SinhVien where MaSV='" + txtMaSV.Text.Trim() + "'";
            txtTenSV.Text = DAO.GetFieldValues(sql);
        }
    }
}
