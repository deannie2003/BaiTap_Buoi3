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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bai_1_Click(object sender, EventArgs e)
        {
            this.Hide();
            bt1 b1 = new bt1();
            b1.ShowDialog();
        }

        private void bai_2_Click(object sender, EventArgs e)
        {
            this.Hide();
            bt2 b2 = new bt2();
            b2.ShowDialog();
        }

        private void bai_3_Click(object sender, EventArgs e)
        {
            this.Hide();
            bt3 b3 = new bt3();
            b3.ShowDialog();
        }

        private void bai_4_Click(object sender, EventArgs e)
        {
            this.Hide();
            bt4 b4 = new bt4();
            b4.ShowDialog();
        }

        private void bai_5_Click(object sender, EventArgs e)
        {
            this.Hide();
            bt5 b5 = new bt5();
            b5.ShowDialog();
        }
    }
}
