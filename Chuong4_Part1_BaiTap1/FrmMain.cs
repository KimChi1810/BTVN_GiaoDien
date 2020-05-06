using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chuong4_Part1_BaiTap1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void tinhTongBT1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhTong_BT1 c1 = new TinhTong_BT1();
            c1.Show();
        }
    }
}
