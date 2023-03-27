namespace bt3
{
    partial class bt3
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
            this.so = new System.Windows.Forms.Label();
            this.chu = new System.Windows.Forms.Label();
            this.nhap = new System.Windows.Forms.TextBox();
            this.xuat = new System.Windows.Forms.TextBox();
            this.doc = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // so
            // 
            this.so.AutoSize = true;
            this.so.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.so.Location = new System.Drawing.Point(39, 102);
            this.so.Name = "so";
            this.so.Size = new System.Drawing.Size(249, 25);
            this.so.TabIndex = 0;
            this.so.Text = "Nhập số nguyên từ 0 tới 9 : ";
            // 
            // chu
            // 
            this.chu.AutoSize = true;
            this.chu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chu.Location = new System.Drawing.Point(39, 301);
            this.chu.Name = "chu";
            this.chu.Size = new System.Drawing.Size(91, 25);
            this.chu.TabIndex = 1;
            this.chu.Text = "Kết quả :";
            // 
            // nhap
            // 
            this.nhap.Location = new System.Drawing.Point(303, 102);
            this.nhap.Name = "nhap";
            this.nhap.Size = new System.Drawing.Size(100, 26);
            this.nhap.TabIndex = 2;
            this.nhap.TextChanged += new System.EventHandler(this.nhap_TextChanged);
            // 
            // xuat
            // 
            this.xuat.Location = new System.Drawing.Point(44, 351);
            this.xuat.Name = "xuat";
            this.xuat.ReadOnly = true;
            this.xuat.Size = new System.Drawing.Size(215, 26);
            this.xuat.TabIndex = 3;
            // 
            // doc
            // 
            this.doc.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc.Location = new System.Drawing.Point(601, 102);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(125, 47);
            this.doc.TabIndex = 4;
            this.doc.Text = "Đọc ";
            this.doc.UseVisualStyleBackColor = false;
            this.doc.Click += new System.EventHandler(this.doc_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(601, 195);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(125, 47);
            this.xoa.TabIndex = 5;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(601, 290);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(125, 47);
            this.thoat.TabIndex = 6;
            this.thoat.Text = "Thoát ";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // bt3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.doc);
            this.Controls.Add(this.xuat);
            this.Controls.Add(this.nhap);
            this.Controls.Add(this.chu);
            this.Controls.Add(this.so);
            this.Name = "bt3";
            this.Text = "Bài 3 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label so;
        private System.Windows.Forms.Label chu;
        private System.Windows.Forms.TextBox nhap;
        private System.Windows.Forms.TextBox xuat;
        private System.Windows.Forms.Button doc;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
    }
}