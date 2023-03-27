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
    public partial class bt3 : Form
    {
        public bt3()
        {
            InitializeComponent();
        }

        private void doc_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(nhap.Text.Trim());
            xuat.Text = a switch
            {
                0 => "Không",
                _ => "Nhập không hợp lệ !"
            };
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            nhap.Clear();
            xuat.Clear();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void nhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
