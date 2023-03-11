namespace QLKhachSan
{
    partial class FormDatPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatPhong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listDSLoaiPhong = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbkh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSonguoi = new System.Windows.Forms.TextBox();
            this.txtTienphong = new System.Windows.Forms.TextBox();
            this.txtmapd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNgayDi = new System.Windows.Forms.TextBox();
            this.txtNgayDen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDatphong = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listDanhSachDP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listDSLoaiPhong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(8, 379);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(680, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các Loại Phòng:";
            // 
            // listDSLoaiPhong
            // 
            this.listDSLoaiPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listDSLoaiPhong.HideSelection = false;
            this.listDSLoaiPhong.Location = new System.Drawing.Point(0, 31);
            this.listDSLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.listDSLoaiPhong.Name = "listDSLoaiPhong";
            this.listDSLoaiPhong.Size = new System.Drawing.Size(679, 230);
            this.listDSLoaiPhong.TabIndex = 1;
            this.listDSLoaiPhong.UseCompatibleStateImageBehavior = false;
            this.listDSLoaiPhong.View = System.Windows.Forms.View.Details;
            this.listDSLoaiPhong.Click += new System.EventHandler(this.listDSLoaiPhong_Click);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Loại Phòng:";
            this.columnHeader6.Width = 152;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số Người Tối Đa:";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 168;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giá Phòng";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 185;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(24, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(24, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khách hàng";
            // 
            // cbkh
            // 
            this.cbkh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbkh.FormattingEnabled = true;
            this.cbkh.Location = new System.Drawing.Point(156, 219);
            this.cbkh.Margin = new System.Windows.Forms.Padding(4);
            this.cbkh.Name = "cbkh";
            this.cbkh.Size = new System.Drawing.Size(231, 30);
            this.cbkh.TabIndex = 5;
            this.cbkh.SelectedIndexChanged += new System.EventHandler(this.cbkh_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(24, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số người";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(24, 331);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(24, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(24, 426);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày đi";
            // 
            // txtSonguoi
            // 
            this.txtSonguoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSonguoi.Location = new System.Drawing.Point(156, 276);
            this.txtSonguoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSonguoi.Name = "txtSonguoi";
            this.txtSonguoi.Size = new System.Drawing.Size(231, 30);
            this.txtSonguoi.TabIndex = 14;
            // 
            // txtTienphong
            // 
            this.txtTienphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTienphong.Location = new System.Drawing.Point(156, 327);
            this.txtTienphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienphong.Name = "txtTienphong";
            this.txtTienphong.Size = new System.Drawing.Size(231, 30);
            this.txtTienphong.TabIndex = 15;
            // 
            // txtmapd
            // 
            this.txtmapd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmapd.Location = new System.Drawing.Point(156, 169);
            this.txtmapd.Margin = new System.Windows.Forms.Padding(4);
            this.txtmapd.Name = "txtmapd";
            this.txtmapd.Size = new System.Drawing.Size(231, 30);
            this.txtmapd.TabIndex = 16;
            this.txtmapd.Text = "PD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNgayDi);
            this.groupBox2.Controls.Add(this.txtNgayDen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtmapd);
            this.groupBox2.Controls.Add(this.txtTienphong);
            this.groupBox2.Controls.Add(this.txtSonguoi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbkh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(16, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(412, 540);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu đặt phòng";
            // 
            // txtNgayDi
            // 
            this.txtNgayDi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgayDi.Location = new System.Drawing.Point(156, 422);
            this.txtNgayDi.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayDi.Name = "txtNgayDi";
            this.txtNgayDi.Size = new System.Drawing.Size(231, 30);
            this.txtNgayDi.TabIndex = 19;
            // 
            // txtNgayDen
            // 
            this.txtNgayDen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgayDen.Location = new System.Drawing.Point(156, 380);
            this.txtNgayDen.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayDen.Name = "txtNgayDen";
            this.txtNgayDen.Size = new System.Drawing.Size(231, 30);
            this.txtNgayDen.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(123, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "ĐẶT PHÒNG";
            // 
            // btnDatphong
            // 
            this.btnDatphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDatphong.Location = new System.Drawing.Point(131, 594);
            this.btnDatphong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatphong.Name = "btnDatphong";
            this.btnDatphong.Size = new System.Drawing.Size(153, 50);
            this.btnDatphong.TabIndex = 5;
            this.btnDatphong.Text = "Đặt phòng";
            this.btnDatphong.UseVisualStyleBackColor = true;
            this.btnDatphong.Click += new System.EventHandler(this.btnDatphong_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listDanhSachDP);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(467, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(696, 654);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Đặt Phòng:";
            // 
            // listDanhSachDP
            // 
            this.listDanhSachDP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listDanhSachDP.HideSelection = false;
            this.listDanhSachDP.Location = new System.Drawing.Point(8, 41);
            this.listDanhSachDP.Margin = new System.Windows.Forms.Padding(4);
            this.listDanhSachDP.Name = "listDanhSachDP";
            this.listDanhSachDP.Size = new System.Drawing.Size(679, 330);
            this.listDanhSachDP.TabIndex = 0;
            this.listDanhSachDP.UseCompatibleStateImageBehavior = false;
            this.listDanhSachDP.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Phòng:";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Khách Hàng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Đến";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá Phòng:";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số Người";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 105;
            // 
            // FormDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDatphong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Phòng";
            this.Load += new System.EventHandler(this.FormDatPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbkh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSonguoi;
        private System.Windows.Forms.TextBox txtTienphong;
        private System.Windows.Forms.TextBox txtmapd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDatphong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listDanhSachDP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtNgayDi;
        private System.Windows.Forms.TextBox txtNgayDen;
        private System.Windows.Forms.ListView listDSLoaiPhong;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}