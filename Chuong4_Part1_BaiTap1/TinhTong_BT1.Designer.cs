namespace Chuong4_Part1_BaiTap1
{
    partial class TinhTong_BT1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.soa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sob = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TinhSum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Tong = new System.Windows.Forms.Button();
            this.Lamlai = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng các số từ ";
            // 
            // soa
            // 
            this.soa.AutoSize = true;
            this.soa.Location = new System.Drawing.Point(301, 126);
            this.soa.Name = "soa";
            this.soa.Size = new System.Drawing.Size(0, 13);
            this.soa.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "đến";
            // 
            // sob
            // 
            this.sob.AutoSize = true;
            this.sob.Location = new System.Drawing.Point(374, 126);
            this.sob.Name = "sob";
            this.sob.Size = new System.Drawing.Size(0, 13);
            this.sob.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "=";
            // 
            // TinhSum
            // 
            this.TinhSum.AutoSize = true;
            this.TinhSum.Location = new System.Drawing.Point(435, 126);
            this.TinhSum.Name = "TinhSum";
            this.TinhSum.Size = new System.Drawing.Size(0, 13);
            this.TinhSum.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(306, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Tong
            // 
            this.Tong.Location = new System.Drawing.Point(164, 205);
            this.Tong.Name = "Tong";
            this.Tong.Size = new System.Drawing.Size(75, 23);
            this.Tong.TabIndex = 10;
            this.Tong.Text = "Tổng";
            this.Tong.UseVisualStyleBackColor = true;
            this.Tong.Click += new System.EventHandler(this.Tong_Click);
            // 
            // Lamlai
            // 
            this.Lamlai.Location = new System.Drawing.Point(345, 205);
            this.Lamlai.Name = "Lamlai";
            this.Lamlai.Size = new System.Drawing.Size(75, 23);
            this.Lamlai.TabIndex = 11;
            this.Lamlai.Text = "Làm lại";
            this.Lamlai.UseVisualStyleBackColor = true;
            this.Lamlai.Click += new System.EventHandler(this.Lamlai_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(508, 205);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(75, 23);
            this.Thoat.TabIndex = 12;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // TinhTong_BT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 265);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Lamlai);
            this.Controls.Add(this.Tong);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TinhSum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.soa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TinhTong_BT1";
            this.Text = "TinhTong_BT1";
            this.toolTip2.SetToolTip(this, "Nhập số nguyên");
            this.toolTip1.SetToolTip(this, "Nhập số nguyên");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label soa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TinhSum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Tong;
        private System.Windows.Forms.Button Lamlai;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}