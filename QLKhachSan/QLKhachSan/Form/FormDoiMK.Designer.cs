namespace QLKhachSan
{
    partial class FormDoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiMK));
            this.btnHuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMkc = new System.Windows.Forms.TextBox();
            this.txtMkm = new System.Windows.Forms.TextBox();
            this.txtMkm2 = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTenDN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(87, 258);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(78, 23);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(104, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(30, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(30, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(28, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nhập lại mật khẩu mới";
            // 
            // txtMkc
            // 
            this.txtMkc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMkc.Location = new System.Drawing.Point(189, 113);
            this.txtMkc.Name = "txtMkc";
            this.txtMkc.Size = new System.Drawing.Size(185, 22);
            this.txtMkc.TabIndex = 8;
            this.txtMkc.UseSystemPasswordChar = true;
            // 
            // txtMkm
            // 
            this.txtMkm.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMkm.Location = new System.Drawing.Point(189, 150);
            this.txtMkm.Name = "txtMkm";
            this.txtMkm.Size = new System.Drawing.Size(185, 22);
            this.txtMkm.TabIndex = 9;
            this.txtMkm.UseSystemPasswordChar = true;
            // 
            // txtMkm2
            // 
            this.txtMkm2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMkm2.Location = new System.Drawing.Point(189, 189);
            this.txtMkm2.Name = "txtMkm2";
            this.txtMkm2.Size = new System.Drawing.Size(185, 22);
            this.txtMkm2.TabIndex = 10;
            this.txtMkm2.UseSystemPasswordChar = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhan.Location = new System.Drawing.Point(234, 258);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(78, 23);
            this.btnXacNhan.TabIndex = 11;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(189, 72);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(185, 22);
            this.txtTenDN.TabIndex = 7;
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 338);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtMkm2);
            this.Controls.Add(this.txtMkm);
            this.Controls.Add(this.txtMkc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.FormDoiMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMkc;
        private System.Windows.Forms.TextBox txtMkm;
        private System.Windows.Forms.TextBox txtMkm2;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtTenDN;
    }
}