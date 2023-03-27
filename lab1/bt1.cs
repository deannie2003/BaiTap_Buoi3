using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt3
{
    public partial class bt1 : Form
    {
        public bt1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void tinh_tong_Click(object sender, EventArgs e)
        {
            
            int s1, s2;
            long tong = 0;
            s1 = Int32.Parse(so1.Text.Trim());
            s2 = Int32.Parse(so2.Text.Trim());
            if (IsNumber(so1.Text) && IsNumber(so2.Text))
            {
                tong = s1+s2;
                xuat_tong.Text = tong.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên !");
            }

        }

        private void xuat_tong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
