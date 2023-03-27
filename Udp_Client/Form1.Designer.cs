namespace Udp_Client
{
    partial class Client
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
            this.Input_Client = new System.Windows.Forms.TextBox();
            this.Output_Client = new System.Windows.Forms.ListBox();
            this.gui = new System.Windows.Forms.Button();
            this.dong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input_Client
            // 
            this.Input_Client.Location = new System.Drawing.Point(12, 103);
            this.Input_Client.Name = "Input_Client";
            this.Input_Client.Size = new System.Drawing.Size(547, 26);
            this.Input_Client.TabIndex = 1;
            // 
            // Output_Client
            // 
            this.Output_Client.FormattingEnabled = true;
            this.Output_Client.ItemHeight = 20;
            this.Output_Client.Location = new System.Drawing.Point(12, 154);
            this.Output_Client.Name = "Output_Client";
            this.Output_Client.Size = new System.Drawing.Size(776, 284);
            this.Output_Client.TabIndex = 2;
            this.Output_Client.SelectedIndexChanged += new System.EventHandler(this.Output_SelectedIndexChanged);
            // 
            // gui
            // 
            this.gui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gui.Location = new System.Drawing.Point(603, 26);
            this.gui.Name = "gui";
            this.gui.Size = new System.Drawing.Size(165, 42);
            this.gui.TabIndex = 3;
            this.gui.Text = "Send";
            this.gui.UseVisualStyleBackColor = true;
            this.gui.Click += new System.EventHandler(this.gui_Click);
            // 
            // dong
            // 
            this.dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dong.Location = new System.Drawing.Point(603, 92);
            this.dong.Name = "dong";
            this.dong.Size = new System.Drawing.Size(165, 42);
            this.dong.TabIndex = 4;
            this.dong.Text = "Close";
            this.dong.UseVisualStyleBackColor = true;
            this.dong.Click += new System.EventHandler(this.dong_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dong);
            this.Controls.Add(this.gui);
            this.Controls.Add(this.Output_Client);
            this.Controls.Add(this.Input_Client);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Input_Client;
        private System.Windows.Forms.ListBox Output_Client;
        private System.Windows.Forms.Button gui;
        private System.Windows.Forms.Button dong;
    }
}

