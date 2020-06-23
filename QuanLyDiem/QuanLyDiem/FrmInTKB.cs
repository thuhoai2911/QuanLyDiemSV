﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyDiem
{
    public partial class FrmInTKB : Form
    {
        DataTable tblInTKB;
        public FrmInTKB()
        {
            InitializeComponent();
        }
        private void FrmInTKB_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();

            DAO.FillDataToCombo("SELECT MaLop FROM Thoi_Khoa_Bieu group by(MaLop)", cmbLop,"MaLop", "MaLop");
            cmbLop.SelectedIndex = -1;

            LoadDataToGridView();
            DAO.FillDataToCombo("SELECT HocKy  FROM Thoi_Khoa_Bieu  group by(HocKy) ",cmbHocKy, "HocKy", "HocKy");
            cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbHocKy.SelectedIndex = -1;
            cmbLop.SelectedIndexChanged += cmbLop_SelectedIndexChanged;
            cmbHocKy.SelectedIndexChanged += cmbHocKy_SelectedIndexChanged;
            DAO.CloseConnection();


        }
        private void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql;
                sql = " select * from Thoi_Khoa_Bieu";
                tblInTKB = DAO.GetDataToTable(sql);
                dataGridView1.DataSource = tblInTKB;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
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
       private void LoadDataTKB()
        {
            string str;
            str = "SELECT HocKy FROM Thoi_Khoa_Bieu WHERE MaLop = '" + cmbLop.SelectedValue + "'";
            cmbHocKy.Text = DAO.GetFieldValues(str);
        }

        private void cmbHocKy_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
                this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable Thoi_Khoa_Bieu;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
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

            exRange.Range["F4:I5"].Font.Size = 24;
            exRange.Range["F4:I5"].Font.Name = "Times new roman";
            exRange.Range["F4:I5"].Font.Bold = true;
            exRange.Range["F4:I5"].Font.ColorIndex = 9; //Màu đỏ
            exRange.Range["F4:I5"].MergeCells = true;
            exRange.Range["A1:J30"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["F4:I5"].Value = "THỜI KHÓA BIỂU";
            sql = "SELECT a.MaLop, a.MaMon, a.HocKy, a.ThuHoc, a.CaHoc,b.TenPhong " +
                  "FROM Thoi_Khoa_Bieu as a join PhongHoc as b on a.MaPhong=b.MaPhong  WHERE MaLop = '" +
                  cmbLop.Text + "' and  HocKy= " + cmbHocKy.Text + "  ";
            Thoi_Khoa_Bieu = DAO.GetDataToTable(sql);

            // Biểu diễn thông tin TKB
            //Tạo dòng tiêu đề bảng

            exRange.Range["D7:J7"].Font.Bold = true;
            exRange.Range["D7:J7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D7:J7"].Interior.Color = System.Drawing.Color.Bisque;
            exRange.Range["D7:J7"].ColumnWidth = 12;
            exRange.Range["D7:D7"].Value = "STT";
            exRange.Range["D7:D7"].Font.Size = 13;
            exRange.Range["E7:E7"].Value = "Mã lớp";
            exRange.Range["E7:E7"].Font.Size = 13;

            exRange.Range["F7:F7"].Value = "Mã môn";
            exRange.Range["F7:F7"].Font.Size = 13;
            exRange.Range["G7:G7"].Value = "Học kỳ";
            exRange.Range["G7:G7"].Font.Size = 13;
            exRange.Range["H7:H7"].Value = "Thứ học";
            exRange.Range["H7:H7"].Font.Size = 13;
            exRange.Range["I7:I7"].Value = "Ca học";
            exRange.Range["I7:I7"].Font.Size = 13;
            exRange.Range["J7:J7"].Value = "Tên phòng";
            exRange.Range["J7:J7"].Font.Size = 13;
            for (hang = 0; hang <= Thoi_Khoa_Bieu.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 4 từ dòng 8
                exSheet.Cells[4][hang + 8] = hang + 1;
                for (cot = 0; cot <= Thoi_Khoa_Bieu.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 5, dòng 8
                    exSheet.Cells[cot + 5][hang + 8] = Thoi_Khoa_Bieu.Rows[hang][cot].ToString();
            }

            exApp.Visible = true;
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLop.SelectedIndex != -1)
            {
                string str;
                str = "select distinct HocKy from Thoi_Khoa_Bieu where MaLop = '" + cmbLop.SelectedValue + "' ";
                // MessageBox.Show(str);
                DAO.FillDataToCombo(str, cmbHocKy, "HocKy", "HocKy");
            }
        }
        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cmbLop.Text == "") && (cmbHocKy.Text == "") )
            {
                MessageBox.Show("Hãy chọn một điều kiện tìm kiếm!!!", "Yêu cầu nhập Lớp,Học kỳ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = " select * from Thoi_Khoa_Bieu where 1=1 ";
            if (cmbLop.Text != "")
            {
                sql = sql + " AND MaLop Like '%" + cmbLop.SelectedValue + "%'";
            }
            if (cmbHocKy.Text != "")
            {
                sql = sql + " AND HocKy Like '%" + cmbHocKy.SelectedValue + "%'";
            }
            tblInTKB = DAO.GetDataToTable(sql); 
            dataGridView1.DataSource = tblInTKB;
        }
    }
}
