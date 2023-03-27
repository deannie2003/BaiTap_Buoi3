namespace bt3
{
    partial class bt4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tieude = new System.Windows.Forms.Label();
            this.tiendoi = new System.Windows.Forms.Label();
            this.nhap = new System.Windows.Forms.TextBox();
            this.cbbox = new System.Windows.Forms.ComboBox();
            this.chuyendoi = new System.Windows.Forms.Button();
            this.tiendadoi = new System.Windows.Forms.Label();
            this.xuat = new System.Windows.Forms.TextBox();
            this.tygiaquydoi = new System.Windows.Forms.Label();
            this.tygia = new System.Windows.Forms.Label();
            this.vnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tieude
            // 
            this.tieude.AutoSize = true;
            this.tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieude.Location = new System.Drawing.Point(33, 34);
            this.tieude.Name = "tieude";
            this.tieude.Size = new System.Drawing.Size(292, 37);
            this.tieude.TabIndex = 0;
            this.tieude.Text = "Chuyển đổi tiền tệ";
            // 
            // tiendoi
            // 
            this.tiendoi.AutoSize = true;
            this.tiendoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiendoi.Location = new System.Drawing.Point(35, 111);
            this.tiendoi.Name = "tiendoi";
            this.tiendoi.Size = new System.Drawing.Size(152, 25);
            this.tiendoi.TabIndex = 1;
            this.tiendoi.Text = "Số tiền cần đổi :";
            // 
            // nhap
            // 
            this.nhap.Location = new System.Drawing.Point(203, 111);
            this.nhap.Name = "nhap";
            this.nhap.Size = new System.Drawing.Size(297, 26);
            this.nhap.TabIndex = 2;
            // 
            // cbbox
            // 
            this.cbbox.FormattingEnabled = true;
            this.cbbox.Items.AddRange(new object[] {
            "USD ( Đô-la Mỹ )",
            "EUR ( Đồng Euro )",
            "GBP ( Bảng Anh )",
            "SGD ( Đô-la Singapo ) ",
            "JPY ( Yên )"});
            this.cbbox.Location = new System.Drawing.Point(506, 112);
            this.cbbox.Name = "cbbox";
            this.cbbox.Size = new System.Drawing.Size(249, 28);
            this.cbbox.TabIndex = 3;
            this.cbbox.SelectedIndexChanged += new System.EventHandler(this.cbbox_SelectedIndexChanged);
            // 
            // chuyendoi
            // 
            this.chuyendoi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chuyendoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuyendoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chuyendoi.Location = new System.Drawing.Point(40, 180);
            this.chuyendoi.Name = "chuyendoi";
            this.chuyendoi.Size = new System.Drawing.Size(348, 53);
            this.chuyendoi.TabIndex = 4;
            this.chuyendoi.Text = "Chuyển đổi";
            this.chuyendoi.UseVisualStyleBackColor = false;
            this.chuyendoi.Click += new System.EventHandler(this.chuyendoi_Click);
            // 
            // tiendadoi
            // 
            this.tiendadoi.AutoSize = true;
            this.tiendadoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiendadoi.Location = new System.Drawing.Point(45, 296);
            this.tiendadoi.Name = "tiendadoi";
            this.tiendadoi.Size = new System.Drawing.Size(142, 25);
            this.tiendadoi.TabIndex = 5;
            this.tiendadoi.Text = "Số tiền đã đổi :";
            this.tiendadoi.Click += new System.EventHandler(this.label1_Click);
            // 
            // xuat
            // 
            this.xuat.Location = new System.Drawing.Point(237, 295);
            this.xuat.Name = "xuat";
            this.xuat.ReadOnly = true;
            this.xuat.Size = new System.Drawing.Size(263, 26);
            this.xuat.TabIndex = 6;
            // 
            // tygiaquydoi
            // 
            this.tygiaquydoi.AutoSize = true;
            this.tygiaquydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tygiaquydoi.Location = new System.Drawing.Point(45, 384);
            this.tygiaquydoi.Name = "tygiaquydoi";
            this.tygiaquydoi.Size = new System.Drawing.Size(145, 25);
            this.tygiaquydoi.TabIndex = 7;
            this.tygiaquydoi.Text = "Tỷ giá quy đổi :";
            // 
            // tygia
            // 
            this.tygia.AutoSize = true;
            this.tygia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tygia.Location = new System.Drawing.Point(237, 384);
            this.tygia.Name = "tygia";
            this.tygia.Size = new System.Drawing.Size(268, 29);
            this.tygia.TabIndex = 8;
            this.tygia.Text = "Vui lòng nhập thông tin !";
            this.tygia.Click += new System.EventHandler(this.tygia_Click);
            // 
            // vnd
            // 
            this.vnd.AutoSize = true;
            this.vnd.Location = new System.Drawing.Point(519, 301);
            this.vnd.Name = "vnd";
            this.vnd.Size = new System.Drawing.Size(61, 20);
            this.vnd.TabIndex = 9;
            this.vnd.Text = "( VND )";
            // 
            // bt4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vnd);
            this.Controls.Add(this.tygia);
            this.Controls.Add(this.tygiaquydoi);
            this.Controls.Add(this.xuat);
            this.Controls.Add(this.tiendadoi);
            this.Controls.Add(this.chuyendoi);
            this.Controls.Add(this.cbbox);
            this.Controls.Add(this.nhap);
            this.Controls.Add(this.tiendoi);
            this.Controls.Add(this.tieude);
            this.Name = "bt4";
            this.Text = "Bài 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tieude;
        private System.Windows.Forms.Label tiendoi;
        private System.Windows.Forms.TextBox nhap;
        private System.Windows.Forms.ComboBox cbbox;
        private System.Windows.Forms.Button chuyendoi;
        private System.Windows.Forms.Label tiendadoi;
        private System.Windows.Forms.TextBox xuat;
        private System.Windows.Forms.Label tygiaquydoi;
        private System.Windows.Forms.Label tygia;
        private System.Windows.Forms.Label vnd;
    }
}