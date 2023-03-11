namespace QLKhachSan
{
    partial class FormPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhong));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gvp = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gvlp = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSonguoi = new System.Windows.Forms.TextBox();
            this.txtMaloai = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvp)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvlp)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbLoaiPhong);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.gvp);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMaphong);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(639, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(133, 115);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(161, 27);
            this.cbLoaiPhong.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(214, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Danh sách phòng";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 206);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // gvp
            // 
            this.gvp.AllowUserToAddRows = false;
            this.gvp.AllowUserToDeleteRows = false;
            this.gvp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvp.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvp.Location = new System.Drawing.Point(315, 63);
            this.gvp.MultiSelect = false;
            this.gvp.Name = "gvp";
            this.gvp.ReadOnly = true;
            this.gvp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvp.Size = new System.Drawing.Size(316, 297);
            this.gvp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phòng";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(133, 63);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(161, 26);
            this.txtMaphong.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtgia);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.gvlp);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtSonguoi);
            this.tabPage2.Controls.Add(this.txtMaloai);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(639, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý loại phòng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Giá";
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(124, 162);
            this.txtgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(161, 26);
            this.txtgia.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(247, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Loại phòng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 15;
            this.button4.Text = "Sửa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 14;
            this.button5.Text = "Thêm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // gvlp
            // 
            this.gvlp.AllowUserToAddRows = false;
            this.gvlp.AllowUserToDeleteRows = false;
            this.gvlp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvlp.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvlp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvlp.Location = new System.Drawing.Point(306, 59);
            this.gvlp.MultiSelect = false;
            this.gvlp.Name = "gvlp";
            this.gvlp.ReadOnly = true;
            this.gvlp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvlp.Size = new System.Drawing.Size(316, 297);
            this.gvlp.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số người";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã loại";
            // 
            // txtSonguoi
            // 
            this.txtSonguoi.Location = new System.Drawing.Point(124, 108);
            this.txtSonguoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSonguoi.Name = "txtSonguoi";
            this.txtSonguoi.Size = new System.Drawing.Size(161, 26);
            this.txtSonguoi.TabIndex = 10;
            // 
            // txtMaloai
            // 
            this.txtMaloai.Location = new System.Drawing.Point(124, 56);
            this.txtMaloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaloai.Name = "txtMaloai";
            this.txtMaloai.Size = new System.Drawing.Size(161, 26);
            this.txtMaloai.TabIndex = 9;
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 430);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng";
            this.Load += new System.EventHandler(this.FormPhong_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvp)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvlp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gvp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView gvlp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSonguoi;
        private System.Windows.Forms.TextBox txtMaloai;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
    }
}