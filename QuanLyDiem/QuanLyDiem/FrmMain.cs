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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void hệĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHeDaoTao f1 = new FrmHeDaoTao();
            f1.Show();
        }

        private void dânTộcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanToc f2 = new FrmDanToc();
            f2.Show();
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiem f3 = new FrmDiem();
            f3.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
