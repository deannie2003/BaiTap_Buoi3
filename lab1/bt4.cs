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
    public partial class bt4 : Form
    {
        public bt4()
        {
            InitializeComponent();
            /*cbbox.DataSource = TienTe.All;
            cbbox.DisplayMember = "Name";
            cbbox.ValueMember = "Id";*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chuyendoi_Click(object sender, EventArgs e)
        {
            /*var tiente = TienTe.All[cbbox.SelectedIndex > 0 ? cbbox.SelectedIndex : 0];
            tygia.Text = $"1 {tiente.Id} = {tiente.Price} VND";
            var isDouble = double.TryParse(nhap.Text.Trim(), out double tien);
            if (isDouble)
            {
                xuat.Text = $"{tiente.Price * tien}";
            }
            else
            {
                xuat.Text = "Số tiền không hợp lệ!";
            }*/
            double tien,xuat_tien;
            tien = double.Parse(nhap.Text.Trim());
            if(cbbox.SelectedIndex == 0)
            {
                xuat_tien = tien*22772;
                xuat.Text = xuat_tien.ToString("#,###");
                tygia.Text = "1 USD = 22,772 VND";
            }
            if (cbbox.SelectedIndex == 1)
            {
                xuat_tien = tien*28132 ;
                xuat.Text = xuat_tien.ToString("#,###");
                tygia.Text = "1 EUR = 28,132 VND";
            }
            if (cbbox.SelectedIndex == 2)
            {
                xuat_tien = tien*31538 ;
                xuat.Text = xuat_tien.ToString("#,###");
                tygia.Text = "1 GBP = 31,538 VND";
            }
            if (cbbox.SelectedIndex == 3)
            {
                xuat_tien = tien*17286 ;
                xuat.Text = xuat_tien.ToString("#,###");
                tygia.Text = "1 SGD = 17,286 VND";
            }
            if (cbbox.SelectedIndex == 4)
            {
                xuat_tien = tien*214 ;
                xuat.Text = xuat_tien.ToString("#,###");
                tygia.Text = "1 JPY = 214 VND";
            }
        }

        private void cbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tygia_Click(object sender, EventArgs e)
        {

        }
    }

    /*public class TienTe
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public static TienTe[] All = new TienTe[]
        { 
            new TienTe() {Id = "USD", Name = "Đô-la Mỹ", Price = 22_772 },
            new TienTe() {Id = "EUR", Name = "Đồng Euro", Price = 22_772 },
            new TienTe() {Id = "GBP", Name = "Bảng Anh", Price = 22_772 },
            new TienTe() {Id = "SGD", Name = "Đô-la Singapo", Price = 22_772 },
            new TienTe() {Id = "JPY", Name = "Yên", Price = 22_772 },
        };
    }*/
}
