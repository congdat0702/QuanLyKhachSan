
namespace QLKhachSan
{
    partial class frmThongBao
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
            this.ptbThongbao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThongbao)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbThongbao
            // 
            this.ptbThongbao.Location = new System.Drawing.Point(0, -2);
            this.ptbThongbao.Name = "ptbThongbao";
            this.ptbThongbao.Size = new System.Drawing.Size(517, 298);
            this.ptbThongbao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbThongbao.TabIndex = 0;
            this.ptbThongbao.TabStop = false;
            // 
            // frmThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 296);
            this.Controls.Add(this.ptbThongbao);
            this.Name = "frmThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Báo Bảo Trì";
            this.Load += new System.EventHandler(this.frmThongBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbThongbao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbThongbao;
    }
}