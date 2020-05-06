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
    public partial class TinhTong_BT1 : Form
    {
        public TinhTong_BT1()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lamlai_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Tong_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ban chua nhap a");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Ban chua nhap b");
                textBox2.Focus();
                return;
            }

            int Sum = 0;
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            soa.Text = a.ToString();
            sob.Text = b.ToString();

            for(int i = a; i <= b; i++)
            {
                Sum = Sum + i;
            }
            TinhSum.Text = Sum.ToString();

            for (int i = b; i <= a; i++)
            {
                Sum = Sum + i;
            }
            TinhSum.Text = Sum.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-')||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                    e.Handled = false;
                else e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') ||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
