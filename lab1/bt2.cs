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
    public partial class bt2 : Form
    {
        public bt2()
        {
            InitializeComponent();
        }

        
        public int timMAX(int a,int b,int c)
        {
            if (a >= b && a>=c)
            {
                return a;
            }
            else if (b>=a && b>=c)
                return b;
            else 
                return c;
        }
        public int timMIN(int a, int b, int c)
        {
            if (a <= b && a<=c)
            {
                return a;
            }
            else if (b<=a && b<=c)
                return b;
            else
                return c;
        }
        private void tim_Click(object sender, EventArgs e)
        {
            int s1, s2, s3;
            s1 = Int32.Parse(so1.Text.Trim());
            s2 = Int32.Parse(so2.Text.Trim());
            s3 = Int32.Parse(so3.Text.Trim());
            max.Text = timMAX(s1,s2,s3).ToString();
            min.Text = timMIN(s1,s2,s3).ToString();

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            so1.Clear();
            so2.Clear();
            so3.Clear();
            min.Clear();
            max.Clear();
        }

       
    }
}
