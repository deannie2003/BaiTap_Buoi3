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
    public partial class bt5 : Form
    {
        public bt5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void tinhgtri_Click(object sender, EventArgs e)
        {
            int m, n, kq_s1 = 0 , kq_s2 = 0 ;
            long kq_agt = 1, kq_bgt = 1;
            double kq_s3 = 0;
            m = Int32.Parse(a.Text.Trim());
            n = Int32.Parse(b.Text.Trim());
            for ( int i = 1; i <= m; i++ )
            {
                kq_agt = kq_agt * i ;
                kq_s1 = kq_s1 + i ;
            }
            for (int j = 1; j <= n; j++)
            {
                kq_bgt = kq_bgt * j;
                kq_s2 = kq_s2 + j;
            }
            for (double k = 1 ; k <= n; k++)
            {
                kq_s3 = kq_s3 + Math.Pow(m,k) ;
            }
            xuat_agt.Text = kq_agt.ToString("#,###");
            xuat_s1.Text = kq_s1.ToString("#,###");
            xuat_bgt.Text = kq_bgt.ToString("#,###");
            xuat_s2.Text = kq_s2.ToString("#,###");
            xuat_s3.Text = kq_s3.ToString("#,###");
        }

        private void s2_Click(object sender, EventArgs e)
        {

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            a.Clear();
            b.Clear();
            xuat_s1.Text = "...";
            xuat_bgt.Text = "...";
            xuat_agt.Text= "...";
            xuat_s2.Text= "...";
            xuat_s3.Text= "...";
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
