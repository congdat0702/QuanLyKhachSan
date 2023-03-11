
namespace QLKhachSan
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaPhongHD = new System.Windows.Forms.TextBox();
            this.txtNgayTT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qlksDataSet = new QLKhachSan.qlksDataSet();
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachhangTableAdapter = new QLKhachSan.qlksDataSetTableAdapters.khachhangTableAdapter();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(334, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khách Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Hóa Đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Thanh Toán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng Tiền:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(191, 86);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(143, 22);
            this.txtMaHD.TabIndex = 6;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(326, 179);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(150, 22);
            this.txtTongTien.TabIndex = 7;
            // 
            // txtMaPhongHD
            // 
            this.txtMaPhongHD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhongHD.Location = new System.Drawing.Point(528, 130);
            this.txtMaPhongHD.Name = "txtMaPhongHD";
            this.txtMaPhongHD.Size = new System.Drawing.Size(143, 22);
            this.txtMaPhongHD.TabIndex = 8;
            // 
            // txtNgayTT
            // 
            this.txtNgayTT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayTT.Location = new System.Drawing.Point(528, 86);
            this.txtNgayTT.Name = "txtNgayTT";
            this.txtNgayTT.Size = new System.Drawing.Size(143, 22);
            this.txtNgayTT.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 251);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn Chi Tiết:";
            // 
            // listHoaDon
            // 
            this.listHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listHoaDon.HideSelection = false;
            this.listHoaDon.Location = new System.Drawing.Point(6, 33);
            this.listHoaDon.Name = "listHoaDon";
            this.listHoaDon.Size = new System.Drawing.Size(763, 218);
            this.listHoaDon.TabIndex = 0;
            this.listHoaDon.UseCompatibleStateImageBehavior = false;
            this.listHoaDon.View = System.Windows.Forms.View.Details;
            this.listHoaDon.Click += new System.EventHandler(this.listHoaDon_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Hóa Đơn";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày Thanh Toán";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 173;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tổng Tiền";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 207;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã Phòng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 141;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã Khách Hàng";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 128;
            // 
            // qlksDataSet
            // 
            this.qlksDataSet.DataSetName = "qlksDataSet";
            this.qlksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachhangBindingSource
            // 
            this.khachhangBindingSource.DataMember = "khachhang";
            this.khachhangBindingSource.DataSource = this.qlksDataSet;
            // 
            // khachhangTableAdapter
            // 
            this.khachhangTableAdapter.ClearBeforeFill = true;
            // 
            // btnThemHD
            // 
            this.btnThemHD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHD.Location = new System.Drawing.Point(346, 221);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(98, 23);
            this.btnThemHD.TabIndex = 12;
            this.btnThemHD.Text = "Thêm Hóa Đơn";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(191, 134);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(143, 22);
            this.txtMaKH.TabIndex = 13;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(480, 221);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(610, 221);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 518);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNgayTT);
            this.Controls.Add(this.txtMaPhongHD);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qlksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaPhongHD;
        private System.Windows.Forms.TextBox txtNgayTT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listHoaDon;
        private qlksDataSet qlksDataSet;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
        private qlksDataSetTableAdapters.khachhangTableAdapter khachhangTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}