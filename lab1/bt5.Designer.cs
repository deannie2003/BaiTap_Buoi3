namespace bt3
{
    partial class bt5
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
            this.nhap_a = new System.Windows.Forms.Label();
            this.nhap_b = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.tinhgtri = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tinh_agt = new System.Windows.Forms.Label();
            this.tinh_s1 = new System.Windows.Forms.Label();
            this.tinh_s2 = new System.Windows.Forms.Label();
            this.tinh_s3 = new System.Windows.Forms.Label();
            this.tinh_bgt = new System.Windows.Forms.Label();
            this.xuat_agt = new System.Windows.Forms.Label();
            this.xuat_bgt = new System.Windows.Forms.Label();
            this.xuat_s3 = new System.Windows.Forms.Label();
            this.xuat_s2 = new System.Windows.Forms.Label();
            this.xuat_s1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nhap_a
            // 
            this.nhap_a.AutoSize = true;
            this.nhap_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhap_a.Location = new System.Drawing.Point(113, 41);
            this.nhap_a.Name = "nhap_a";
            this.nhap_a.Size = new System.Drawing.Size(89, 25);
            this.nhap_a.TabIndex = 0;
            this.nhap_a.Text = "Nhập A :";
            // 
            // nhap_b
            // 
            this.nhap_b.AutoSize = true;
            this.nhap_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhap_b.Location = new System.Drawing.Point(499, 41);
            this.nhap_b.Name = "nhap_b";
            this.nhap_b.Size = new System.Drawing.Size(88, 25);
            this.nhap_b.TabIndex = 1;
            this.nhap_b.Text = "Nhập B :";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(208, 41);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(204, 26);
            this.a.TabIndex = 2;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(593, 38);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(204, 26);
            this.b.TabIndex = 3;
            // 
            // tinhgtri
            // 
            this.tinhgtri.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tinhgtri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhgtri.Location = new System.Drawing.Point(124, 153);
            this.tinhgtri.Name = "tinhgtri";
            this.tinhgtri.Size = new System.Drawing.Size(313, 48);
            this.tinhgtri.TabIndex = 4;
            this.tinhgtri.Text = "Tính các giá trị ";
            this.tinhgtri.UseVisualStyleBackColor = false;
            this.tinhgtri.Click += new System.EventHandler(this.tinhgtri_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(490, 154);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(127, 48);
            this.xoa.TabIndex = 5;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(657, 153);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(127, 48);
            this.thoat.TabIndex = 6;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xuat_s1);
            this.groupBox1.Controls.Add(this.xuat_s2);
            this.groupBox1.Controls.Add(this.xuat_s3);
            this.groupBox1.Controls.Add(this.xuat_bgt);
            this.groupBox1.Controls.Add(this.xuat_agt);
            this.groupBox1.Controls.Add(this.tinh_bgt);
            this.groupBox1.Controls.Add(this.tinh_s3);
            this.groupBox1.Controls.Add(this.tinh_s2);
            this.groupBox1.Controls.Add(this.tinh_s1);
            this.groupBox1.Controls.Add(this.tinh_agt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 197);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KẾT QUẢ ";
            // 
            // tinh_agt
            // 
            this.tinh_agt.AutoSize = true;
            this.tinh_agt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinh_agt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tinh_agt.Location = new System.Drawing.Point(22, 44);
            this.tinh_agt.Name = "tinh_agt";
            this.tinh_agt.Size = new System.Drawing.Size(47, 22);
            this.tinh_agt.TabIndex = 0;
            this.tinh_agt.Text = "A! =";
            this.tinh_agt.Click += new System.EventHandler(this.label1_Click);
            // 
            // tinh_s1
            // 
            this.tinh_s1.AutoSize = true;
            this.tinh_s1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinh_s1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tinh_s1.Location = new System.Drawing.Point(22, 95);
            this.tinh_s1.Name = "tinh_s1";
            this.tinh_s1.Size = new System.Drawing.Size(271, 22);
            this.tinh_s1.TabIndex = 1;
            this.tinh_s1.Text = "S1 = 1 + 2 + 3 + 4 + ... + A =";
            // 
            // tinh_s2
            // 
            this.tinh_s2.AutoSize = true;
            this.tinh_s2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinh_s2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tinh_s2.Location = new System.Drawing.Point(22, 146);
            this.tinh_s2.Name = "tinh_s2";
            this.tinh_s2.Size = new System.Drawing.Size(271, 22);
            this.tinh_s2.TabIndex = 2;
            this.tinh_s2.Text = "S2 = 1 + 2 + 3 + 4 + ... + B =";
            this.tinh_s2.Click += new System.EventHandler(this.s2_Click);
            // 
            // tinh_s3
            // 
            this.tinh_s3.AutoSize = true;
            this.tinh_s3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinh_s3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tinh_s3.Location = new System.Drawing.Point(404, 44);
            this.tinh_s3.Name = "tinh_s3";
            this.tinh_s3.Size = new System.Drawing.Size(381, 22);
            this.tinh_s3.TabIndex = 3;
            this.tinh_s3.Text = "S3 = A^1 + A^2 + A^3 + A^4 + ... + A^B =";
            // 
            // tinh_bgt
            // 
            this.tinh_bgt.AutoSize = true;
            this.tinh_bgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinh_bgt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tinh_bgt.Location = new System.Drawing.Point(404, 95);
            this.tinh_bgt.Name = "tinh_bgt";
            this.tinh_bgt.Size = new System.Drawing.Size(47, 22);
            this.tinh_bgt.TabIndex = 5;
            this.tinh_bgt.Text = "B! =";
            // 
            // xuat_agt
            // 
            this.xuat_agt.AutoSize = true;
            this.xuat_agt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuat_agt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.xuat_agt.Location = new System.Drawing.Point(65, 44);
            this.xuat_agt.Name = "xuat_agt";
            this.xuat_agt.Size = new System.Drawing.Size(34, 22);
            this.xuat_agt.TabIndex = 6;
            this.xuat_agt.Text = "... ";
            // 
            // xuat_bgt
            // 
            this.xuat_bgt.AutoSize = true;
            this.xuat_bgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuat_bgt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.xuat_bgt.Location = new System.Drawing.Point(457, 95);
            this.xuat_bgt.Name = "xuat_bgt";
            this.xuat_bgt.Size = new System.Drawing.Size(28, 22);
            this.xuat_bgt.TabIndex = 8;
            this.xuat_bgt.Text = "...";
            // 
            // xuat_s3
            // 
            this.xuat_s3.AutoSize = true;
            this.xuat_s3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuat_s3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.xuat_s3.Location = new System.Drawing.Point(791, 44);
            this.xuat_s3.Name = "xuat_s3";
            this.xuat_s3.Size = new System.Drawing.Size(28, 22);
            this.xuat_s3.TabIndex = 9;
            this.xuat_s3.Text = "...";
            // 
            // xuat_s2
            // 
            this.xuat_s2.AutoSize = true;
            this.xuat_s2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuat_s2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.xuat_s2.Location = new System.Drawing.Point(290, 146);
            this.xuat_s2.Name = "xuat_s2";
            this.xuat_s2.Size = new System.Drawing.Size(28, 22);
            this.xuat_s2.TabIndex = 10;
            this.xuat_s2.Text = "...";
            // 
            // xuat_s1
            // 
            this.xuat_s1.AutoSize = true;
            this.xuat_s1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuat_s1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.xuat_s1.Location = new System.Drawing.Point(290, 95);
            this.xuat_s1.Name = "xuat_s1";
            this.xuat_s1.Size = new System.Drawing.Size(28, 22);
            this.xuat_s1.TabIndex = 11;
            this.xuat_s1.Text = "...";
            // 
            // bt5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.tinhgtri);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.nhap_b);
            this.Controls.Add(this.nhap_a);
            this.Name = "bt5";
            this.Text = "Bài 5 ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nhap_a;
        private System.Windows.Forms.Label nhap_b;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Button tinhgtri;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tinh_agt;
        private System.Windows.Forms.Label tinh_bgt;
        private System.Windows.Forms.Label tinh_s3;
        private System.Windows.Forms.Label tinh_s2;
        private System.Windows.Forms.Label tinh_s1;
        private System.Windows.Forms.Label xuat_s1;
        private System.Windows.Forms.Label xuat_s2;
        private System.Windows.Forms.Label xuat_s3;
        private System.Windows.Forms.Label xuat_bgt;
        private System.Windows.Forms.Label xuat_agt;
    }
}