namespace bt3
{
    partial class bt1
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
            this.so_thu_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tinh_tong = new System.Windows.Forms.Button();
            this.so1 = new System.Windows.Forms.TextBox();
            this.so2 = new System.Windows.Forms.TextBox();
            this.xuat_tong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // so_thu_1
            // 
            this.so_thu_1.AutoSize = true;
            this.so_thu_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.so_thu_1.Location = new System.Drawing.Point(161, 112);
            this.so_thu_1.Name = "so_thu_1";
            this.so_thu_1.Size = new System.Drawing.Size(123, 25);
            this.so_thu_1.TabIndex = 0;
            this.so_thu_1.Text = "Số thứ nhất :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số thứ hai :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tinh_tong
            // 
            this.tinh_tong.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tinh_tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinh_tong.Location = new System.Drawing.Point(580, 356);
            this.tinh_tong.Name = "tinh_tong";
            this.tinh_tong.Size = new System.Drawing.Size(144, 41);
            this.tinh_tong.TabIndex = 3;
            this.tinh_tong.Text = "Tính tổng !";
            this.tinh_tong.UseVisualStyleBackColor = false;
            this.tinh_tong.Click += new System.EventHandler(this.tinh_tong_Click);
            // 
            // so1
            // 
            this.so1.Location = new System.Drawing.Point(301, 113);
            this.so1.Name = "so1";
            this.so1.Size = new System.Drawing.Size(236, 26);
            this.so1.TabIndex = 4;
            // 
            // so2
            // 
            this.so2.Location = new System.Drawing.Point(301, 195);
            this.so2.Name = "so2";
            this.so2.Size = new System.Drawing.Size(236, 26);
            this.so2.TabIndex = 5;
            // 
            // xuat_tong
            // 
            this.xuat_tong.Location = new System.Drawing.Point(301, 279);
            this.xuat_tong.Name = "xuat_tong";
            this.xuat_tong.ReadOnly = true;
            this.xuat_tong.Size = new System.Drawing.Size(236, 26);
            this.xuat_tong.TabIndex = 6;
            this.xuat_tong.TextChanged += new System.EventHandler(this.xuat_tong_TextChanged);
            // 
            // bt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xuat_tong);
            this.Controls.Add(this.so2);
            this.Controls.Add(this.so1);
            this.Controls.Add(this.tinh_tong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.so_thu_1);
            this.Name = "bt1";
            this.Text = "Bài 1 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label so_thu_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tinh_tong;
        private System.Windows.Forms.TextBox so1;
        private System.Windows.Forms.TextBox so2;
        private System.Windows.Forms.TextBox xuat_tong;
    }
}