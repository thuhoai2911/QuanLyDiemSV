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
using QuanLyDiem.Class;
using QuanLyBenhNhan;

namespace QuanLyDiem
{
    public partial class InBangDiemSV : Form
    {
        public InBangDiemSV()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã sinh viên trước!");
            }
            else
            {
                COMExcel.Application exApp = new COMExcel.Application();
                COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
                COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
                COMExcel.Range exRange;
                string sql;
                int hang = 0, cot = 0;
                DataTable tblBangDiem;
                exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
                exSheet = exBook.Worksheets[1];

                exRange = exSheet.Cells[1, 1];
                exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
                exRange.Range["A1:B3"].Font.Size = 10;
                exRange.Range["A1:B3"].Font.Bold = true;
                exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
                exRange.Range["A1:A1"].ColumnWidth = 7;
                exRange.Range["B1:B1"].ColumnWidth = 15;
                exRange.Range["A1:B1"].MergeCells = true;
                exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A1:B1"].Value = "Banking Acedemy Vietnam";
                exRange.Range["A2:E2"].MergeCells = true;
                exRange.Range["A2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:E2"].Value = "12 Chua Boc Street, Quang Trung Ward, Dong Da District, Hanoi, Vietnam";

                exRange.Range["E5:G5"].Font.Size = 20;
                exRange.Range["E5:G5"].Font.Bold = true;
                exRange.Range["E5:G5"].Font.ColorIndex = 3; //Màu đỏ
                exRange.Range["E5:G5"].MergeCells = true;
                exRange.Range["E5:G5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["E5:G5"].Value = "ĐIỂM SINH VIÊN";

                exRange.Range["D6:H6"].MergeCells = true;
                exRange.Range["D6:H6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["D6:H6"].Value = "Mã sinh viên:";

                sql = "SELECT a.MaMon,b.TenMon,b.DVHT,a.HocKy,a.LanThi,a.Diem FROM Diem as a inner join MonHoc as b on a.MaMon=b.MaMon where MaSV=N'" + txtMaSV.Text.Trim() + "'";
                tblBangDiem = DAO.GetDataToTable(sql);
                exRange.Range["A11:K11"].Font.Bold = true;
                exRange.Range["A11:K11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C11:F11"].ColumnWidth = 12;
                exRange.Range["G11"].ColumnWidth = 16;
                exRange.Range["I11"].ColumnWidth = 13;
                exRange.Range["J11"].ColumnWidth = 12;
                exRange.Range["K11"].ColumnWidth = 12;
                exRange.Range["A11:A11"].Value = "STT";
                exRange.Range["B11:B11"].Value = "Mã môn";
                exRange.Range["C11:C11"].Value = "Tên môn";
                exRange.Range["D11:D11"].Value = "ĐVHT";
                exRange.Range["E11:E11"].Value = "Lần thi";
                exRange.Range["F11:F11"].Value = "ĐIểm";

                for (hang = 0; hang < tblBangDiem.Rows.Count; hang++)
                {
                    //Điền số thứ tự vào cột 1 từ dòng 12
                    exSheet.Cells[1][hang + 12] = hang + 1;
                    for (cot = 0; cot < tblBangDiem.Columns.Count; cot++) //Điền thông tin hàng từ cột thứ 2, dòng 12
                    {
                        exSheet.Cells[cot + 2][hang + 12] = tblBangDiem.Rows[hang][cot].ToString();
                        if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblBangDiem.Rows[hang][cot].ToString();
                    }
                }
                exRange = exSheet.Cells[cot][hang + 14];

                exRange = exSheet.Cells[1][hang + 15]; //Ô A1 

                exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
                exRange.Range["A1:C1"].MergeCells = true;
                exRange.Range["A1:C1"].Font.Italic = true;
                exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

                exSheet.Name = "ĐIỂM SINH VIÊN";
                exApp.Visible = true;
            }    
        }
    }
}
