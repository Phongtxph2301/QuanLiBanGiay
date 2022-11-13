namespace C_GUI.Views
{
    partial class FormBanHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._dgrvThongTinSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._dgrvHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._rjtbxMaHoaDon = new C_GUI.RJControls.RJTextBox();
            this._rjtbxTenKhachHang = new C_GUI.RJControls.RJTextBox();
            this._rjtbxSDT = new C_GUI.RJControls.RJTextBox();
            this._rjdtpkNgayThang = new C_GUI.RJControls.RJDatePicker();
            this._rjrdtnChuaThanhToan = new C_GUI.RJControls.RJRadioButton();
            this._rjrdtnThanhToan = new C_GUI.RJControls.RJRadioButton();
            this._rjbtnXacNhan = new C_GUI.RJControls.RJButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgrvThongTinSanPham)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgrvHoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._dgrvThongTinSanPham);
            this.groupBox1.Location = new System.Drawing.Point(440, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // _dgrvThongTinSanPham
            // 
            this._dgrvThongTinSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgrvThongTinSanPham.Location = new System.Drawing.Point(24, 36);
            this._dgrvThongTinSanPham.Name = "_dgrvThongTinSanPham";
            this._dgrvThongTinSanPham.RowHeadersWidth = 51;
            this._dgrvThongTinSanPham.RowTemplate.Height = 29;
            this._dgrvThongTinSanPham.Size = new System.Drawing.Size(578, 188);
            this._dgrvThongTinSanPham.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._dgrvHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(440, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 362);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa Đơn";
            // 
            // _dgrvHoaDon
            // 
            this._dgrvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgrvHoaDon.Location = new System.Drawing.Point(24, 87);
            this._dgrvHoaDon.Name = "_dgrvHoaDon";
            this._dgrvHoaDon.RowHeadersWidth = 51;
            this._dgrvHoaDon.RowTemplate.Height = 29;
            this._dgrvHoaDon.Size = new System.Drawing.Size(563, 188);
            this._dgrvHoaDon.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._rjbtnXacNhan);
            this.groupBox3.Controls.Add(this._rjrdtnThanhToan);
            this.groupBox3.Controls.Add(this._rjrdtnChuaThanhToan);
            this.groupBox3.Controls.Add(this._rjdtpkNgayThang);
            this.groupBox3.Controls.Add(this._rjtbxSDT);
            this.groupBox3.Controls.Add(this._rjtbxTenKhachHang);
            this.groupBox3.Controls.Add(this._rjtbxMaHoaDon);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 624);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(19, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Trạng Thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Tao Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // _rjtbxMaHoaDon
            // 
            this._rjtbxMaHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this._rjtbxMaHoaDon.BorderColor = System.Drawing.Color.Black;
            this._rjtbxMaHoaDon.BorderFocusColor = System.Drawing.Color.Red;
            this._rjtbxMaHoaDon.BorderRadius = 15;
            this._rjtbxMaHoaDon.BorderSize = 2;
            this._rjtbxMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._rjtbxMaHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._rjtbxMaHoaDon.Location = new System.Drawing.Point(198, 58);
            this._rjtbxMaHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this._rjtbxMaHoaDon.MaxLength = 20;
            this._rjtbxMaHoaDon.Multiline = false;
            this._rjtbxMaHoaDon.Name = "_rjtbxMaHoaDon";
            this._rjtbxMaHoaDon.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._rjtbxMaHoaDon.PasswordChar = false;
            this._rjtbxMaHoaDon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._rjtbxMaHoaDon.PlaceholderText = "";
            this._rjtbxMaHoaDon.Size = new System.Drawing.Size(197, 35);
            this._rjtbxMaHoaDon.TabIndex = 9;
            this._rjtbxMaHoaDon.Texts = "";
            this._rjtbxMaHoaDon.UnderlinedStyle = false;
            // 
            // _rjtbxTenKhachHang
            // 
            this._rjtbxTenKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this._rjtbxTenKhachHang.BorderColor = System.Drawing.Color.Black;
            this._rjtbxTenKhachHang.BorderFocusColor = System.Drawing.Color.Red;
            this._rjtbxTenKhachHang.BorderRadius = 15;
            this._rjtbxTenKhachHang.BorderSize = 2;
            this._rjtbxTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._rjtbxTenKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._rjtbxTenKhachHang.Location = new System.Drawing.Point(198, 137);
            this._rjtbxTenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this._rjtbxTenKhachHang.MaxLength = 20;
            this._rjtbxTenKhachHang.Multiline = false;
            this._rjtbxTenKhachHang.Name = "_rjtbxTenKhachHang";
            this._rjtbxTenKhachHang.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._rjtbxTenKhachHang.PasswordChar = false;
            this._rjtbxTenKhachHang.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._rjtbxTenKhachHang.PlaceholderText = "";
            this._rjtbxTenKhachHang.Size = new System.Drawing.Size(197, 35);
            this._rjtbxTenKhachHang.TabIndex = 10;
            this._rjtbxTenKhachHang.Texts = "";
            this._rjtbxTenKhachHang.UnderlinedStyle = false;
            // 
            // _rjtbxSDT
            // 
            this._rjtbxSDT.BackColor = System.Drawing.SystemColors.Window;
            this._rjtbxSDT.BorderColor = System.Drawing.Color.Black;
            this._rjtbxSDT.BorderFocusColor = System.Drawing.Color.Red;
            this._rjtbxSDT.BorderRadius = 15;
            this._rjtbxSDT.BorderSize = 2;
            this._rjtbxSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._rjtbxSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._rjtbxSDT.Location = new System.Drawing.Point(198, 216);
            this._rjtbxSDT.Margin = new System.Windows.Forms.Padding(4);
            this._rjtbxSDT.MaxLength = 20;
            this._rjtbxSDT.Multiline = false;
            this._rjtbxSDT.Name = "_rjtbxSDT";
            this._rjtbxSDT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._rjtbxSDT.PasswordChar = false;
            this._rjtbxSDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._rjtbxSDT.PlaceholderText = "";
            this._rjtbxSDT.Size = new System.Drawing.Size(197, 35);
            this._rjtbxSDT.TabIndex = 11;
            this._rjtbxSDT.Texts = "";
            this._rjtbxSDT.UnderlinedStyle = false;
            // 
            // _rjdtpkNgayThang
            // 
            this._rjdtpkNgayThang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this._rjdtpkNgayThang.BorderSize = 2;
            this._rjdtpkNgayThang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._rjdtpkNgayThang.Location = new System.Drawing.Point(198, 295);
            this._rjdtpkNgayThang.MinimumSize = new System.Drawing.Size(0, 35);
            this._rjdtpkNgayThang.Name = "_rjdtpkNgayThang";
            this._rjdtpkNgayThang.Size = new System.Drawing.Size(218, 35);
            this._rjdtpkNgayThang.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this._rjdtpkNgayThang.TabIndex = 12;
            this._rjdtpkNgayThang.TextColor = System.Drawing.Color.White;
            // 
            // _rjrdtnChuaThanhToan
            // 
            this._rjrdtnChuaThanhToan.AutoSize = true;
            this._rjrdtnChuaThanhToan.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this._rjrdtnChuaThanhToan.Location = new System.Drawing.Point(198, 358);
            this._rjrdtnChuaThanhToan.MinimumSize = new System.Drawing.Size(0, 21);
            this._rjrdtnChuaThanhToan.Name = "_rjrdtnChuaThanhToan";
            this._rjrdtnChuaThanhToan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._rjrdtnChuaThanhToan.Size = new System.Drawing.Size(154, 24);
            this._rjrdtnChuaThanhToan.TabIndex = 13;
            this._rjrdtnChuaThanhToan.TabStop = true;
            this._rjrdtnChuaThanhToan.Text = "Chưa Thanh Toán";
            this._rjrdtnChuaThanhToan.UnCheckedColor = System.Drawing.Color.Gray;
            this._rjrdtnChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // _rjrdtnThanhToan
            // 
            this._rjrdtnThanhToan.AutoSize = true;
            this._rjrdtnThanhToan.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this._rjrdtnThanhToan.Location = new System.Drawing.Point(198, 399);
            this._rjrdtnThanhToan.MinimumSize = new System.Drawing.Size(0, 21);
            this._rjrdtnThanhToan.Name = "_rjrdtnThanhToan";
            this._rjrdtnThanhToan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._rjrdtnThanhToan.Size = new System.Drawing.Size(139, 24);
            this._rjrdtnThanhToan.TabIndex = 14;
            this._rjrdtnThanhToan.TabStop = true;
            this._rjrdtnThanhToan.Text = "Đã Thanh Toán";
            this._rjrdtnThanhToan.UnCheckedColor = System.Drawing.Color.Gray;
            this._rjrdtnThanhToan.UseVisualStyleBackColor = true;
            // 
            // _rjbtnXacNhan
            // 
            this._rjbtnXacNhan.BackColor = System.Drawing.Color.Turquoise;
            this._rjbtnXacNhan.BackgroundColor = System.Drawing.Color.Turquoise;
            this._rjbtnXacNhan.BorderColor = System.Drawing.Color.Black;
            this._rjbtnXacNhan.BorderRadius = 15;
            this._rjbtnXacNhan.BorderSize = 2;
            this._rjbtnXacNhan.FlatAppearance.BorderSize = 0;
            this._rjbtnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._rjbtnXacNhan.ForeColor = System.Drawing.Color.Black;
            this._rjbtnXacNhan.Location = new System.Drawing.Point(149, 448);
            this._rjbtnXacNhan.Name = "_rjbtnXacNhan";
            this._rjbtnXacNhan.Size = new System.Drawing.Size(188, 39);
            this._rjbtnXacNhan.SizeImage = new System.Drawing.Size(20, 20);
            this._rjbtnXacNhan.TabIndex = 15;
            this._rjbtnXacNhan.Text = "Xác Nhận";
            this._rjbtnXacNhan.TextColor = System.Drawing.Color.Black;
            this._rjbtnXacNhan.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(1076, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 520);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hóa Đơn Chờ";
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 660);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgrvThongTinSanPham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgrvHoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView _dgrvThongTinSanPham;
        private GroupBox groupBox2;
        private DataGridView _dgrvHoaDon;
        private GroupBox groupBox3;
        private Label label9;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RJControls.RJButton _rjbtnXacNhan;
        private RJControls.RJRadioButton _rjrdtnThanhToan;
        private RJControls.RJRadioButton _rjrdtnChuaThanhToan;
        private RJControls.RJDatePicker _rjdtpkNgayThang;
        private RJControls.RJTextBox _rjtbxSDT;
        private RJControls.RJTextBox _rjtbxTenKhachHang;
        private RJControls.RJTextBox _rjtbxMaHoaDon;
        private GroupBox groupBox4;
    }
}