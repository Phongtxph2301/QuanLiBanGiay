namespace C_GUI.Views
{
    partial class TrangChu
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
            this._pnlMenu = new System.Windows.Forms.Panel();
            this._btnTHongKe = new System.Windows.Forms.Button();
            this._btnBanHang = new System.Windows.Forms.Button();
            this._btnSanPham = new System.Windows.Forms.Button();
            this._btnHoaDon = new System.Windows.Forms.Button();
            this._btnTrangChu = new System.Windows.Forms.Button();
            this._pnlLogo = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this._pnltitlebar = new System.Windows.Forms.Panel();
            this._rjbtnDong = new C_GUI.RJControls.RJButton();
            this.lbltitle = new System.Windows.Forms.Label();
            this._pnlDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this._pnlMenu.SuspendLayout();
            this._pnlLogo.SuspendLayout();
            this._pnltitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnlMenu
            // 
            this._pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this._pnlMenu.Controls.Add(this.pictureBox5);
            this._pnlMenu.Controls.Add(this.pictureBox4);
            this._pnlMenu.Controls.Add(this.pictureBox3);
            this._pnlMenu.Controls.Add(this.pictureBox2);
            this._pnlMenu.Controls.Add(this.pictureBox1);
            this._pnlMenu.Controls.Add(this._btnTHongKe);
            this._pnlMenu.Controls.Add(this._btnBanHang);
            this._pnlMenu.Controls.Add(this._btnSanPham);
            this._pnlMenu.Controls.Add(this._btnHoaDon);
            this._pnlMenu.Controls.Add(this._btnTrangChu);
            this._pnlMenu.Controls.Add(this._pnlLogo);
            this._pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlMenu.Location = new System.Drawing.Point(0, 0);
            this._pnlMenu.Name = "_pnlMenu";
            this._pnlMenu.Size = new System.Drawing.Size(229, 597);
            this._pnlMenu.TabIndex = 0;
            // 
            // _btnTHongKe
            // 
            this._btnTHongKe.FlatAppearance.BorderSize = 0;
            this._btnTHongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnTHongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnTHongKe.Location = new System.Drawing.Point(54, 461);
            this._btnTHongKe.Name = "_btnTHongKe";
            this._btnTHongKe.Size = new System.Drawing.Size(175, 80);
            this._btnTHongKe.TabIndex = 5;
            this._btnTHongKe.Text = "Thống Kê";
            this._btnTHongKe.UseVisualStyleBackColor = true;
            this._btnTHongKe.Click += new System.EventHandler(this._btnTHongKe_Click);
            // 
            // _btnBanHang
            // 
            this._btnBanHang.FlatAppearance.BorderSize = 0;
            this._btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBanHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnBanHang.Location = new System.Drawing.Point(54, 375);
            this._btnBanHang.Name = "_btnBanHang";
            this._btnBanHang.Size = new System.Drawing.Size(175, 80);
            this._btnBanHang.TabIndex = 4;
            this._btnBanHang.Text = "Bán Hàng";
            this._btnBanHang.UseVisualStyleBackColor = true;
            this._btnBanHang.Click += new System.EventHandler(this._btnBanHang_Click);
            // 
            // _btnSanPham
            // 
            this._btnSanPham.FlatAppearance.BorderSize = 0;
            this._btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSanPham.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnSanPham.Location = new System.Drawing.Point(54, 289);
            this._btnSanPham.Name = "_btnSanPham";
            this._btnSanPham.Size = new System.Drawing.Size(172, 80);
            this._btnSanPham.TabIndex = 3;
            this._btnSanPham.Text = "Sản Phẩm";
            this._btnSanPham.UseVisualStyleBackColor = true;
            this._btnSanPham.Click += new System.EventHandler(this._btnSanPham_Click);
            // 
            // _btnHoaDon
            // 
            this._btnHoaDon.FlatAppearance.BorderSize = 0;
            this._btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnHoaDon.Location = new System.Drawing.Point(54, 203);
            this._btnHoaDon.Name = "_btnHoaDon";
            this._btnHoaDon.Size = new System.Drawing.Size(172, 80);
            this._btnHoaDon.TabIndex = 2;
            this._btnHoaDon.Text = "Hóa Đơn";
            this._btnHoaDon.UseVisualStyleBackColor = true;
            this._btnHoaDon.Click += new System.EventHandler(this._btnHoaDon_Click);
            // 
            // _btnTrangChu
            // 
            this._btnTrangChu.FlatAppearance.BorderSize = 0;
            this._btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnTrangChu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnTrangChu.Location = new System.Drawing.Point(54, 117);
            this._btnTrangChu.Name = "_btnTrangChu";
            this._btnTrangChu.Size = new System.Drawing.Size(175, 80);
            this._btnTrangChu.TabIndex = 1;
            this._btnTrangChu.Text = "Trang Chủ";
            this._btnTrangChu.UseVisualStyleBackColor = true;
            this._btnTrangChu.Click += new System.EventHandler(this._btnTrangChu_Click);
            // 
            // _pnlLogo
            // 
            this._pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this._pnlLogo.Controls.Add(this.lbl);
            this._pnlLogo.Location = new System.Drawing.Point(0, 3);
            this._pnlLogo.Name = "_pnlLogo";
            this._pnlLogo.Size = new System.Drawing.Size(226, 108);
            this._pnlLogo.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.ForeColor = System.Drawing.Color.Transparent;
            this.lbl.Location = new System.Drawing.Point(27, 33);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(164, 37);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "NahidaShop";
            // 
            // _pnltitlebar
            // 
            this._pnltitlebar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._pnltitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this._pnltitlebar.Controls.Add(this._rjbtnDong);
            this._pnltitlebar.Controls.Add(this.lbltitle);
            this._pnltitlebar.Location = new System.Drawing.Point(233, 3);
            this._pnltitlebar.Name = "_pnltitlebar";
            this._pnltitlebar.Size = new System.Drawing.Size(800, 108);
            this._pnltitlebar.TabIndex = 1;
            // 
            // _rjbtnDong
            // 
            this._rjbtnDong.BackColor = System.Drawing.Color.Turquoise;
            this._rjbtnDong.BackgroundColor = System.Drawing.Color.Turquoise;
            this._rjbtnDong.BorderColor = System.Drawing.Color.Black;
            this._rjbtnDong.BorderRadius = 15;
            this._rjbtnDong.BorderSize = 2;
            this._rjbtnDong.FlatAppearance.BorderSize = 0;
            this._rjbtnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._rjbtnDong.ForeColor = System.Drawing.Color.Black;
            this._rjbtnDong.Location = new System.Drawing.Point(3, 9);
            this._rjbtnDong.Name = "_rjbtnDong";
            this._rjbtnDong.Size = new System.Drawing.Size(118, 39);
            this._rjbtnDong.SizeImage = new System.Drawing.Size(20, 20);
            this._rjbtnDong.TabIndex = 1;
            this._rjbtnDong.Text = "Đóng";
            this._rjbtnDong.TextColor = System.Drawing.Color.Black;
            this._rjbtnDong.UseVisualStyleBackColor = false;
            this._rjbtnDong.Click += new System.EventHandler(this._rjbtnDong_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft JhengHei", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(305, 35);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(154, 36);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Trang Chủ";
            // 
            // _pnlDesktop
            // 
            this._pnlDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._pnlDesktop.Location = new System.Drawing.Point(235, 117);
            this._pnlDesktop.Name = "_pnlDesktop";
            this._pnlDesktop.Size = new System.Drawing.Size(789, 469);
            this._pnlDesktop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_GUI.Properties.Resources.Picsart_22_11_11_01_37_22_243;
            this.pictureBox1.Location = new System.Drawing.Point(0, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::C_GUI.Properties.Resources.Picsart_22_11_11_01_55_18_321;
            this.pictureBox2.Location = new System.Drawing.Point(0, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::C_GUI.Properties.Resources.Picsart_22_11_11_01_55_52_111;
            this.pictureBox3.Location = new System.Drawing.Point(0, 375);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::C_GUI.Properties.Resources.Picsart_22_11_11_01_56_27_676;
            this.pictureBox4.Location = new System.Drawing.Point(0, 461);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(102, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::C_GUI.Properties.Resources.Picsart_22_11_11_01_54_23_965;
            this.pictureBox5.Location = new System.Drawing.Point(0, 289);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(102, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 597);
            this.Controls.Add(this._pnlDesktop);
            this.Controls.Add(this._pnltitlebar);
            this.Controls.Add(this._pnlMenu);
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this._pnlMenu.ResumeLayout(false);
            this._pnlLogo.ResumeLayout(false);
            this._pnlLogo.PerformLayout();
            this._pnltitlebar.ResumeLayout(false);
            this._pnltitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel _pnlMenu;
        private Button _btnTHongKe;
        private Button _btnBanHang;
        private Button _btnSanPham;
        private Button _btnHoaDon;
        private Button _btnTrangChu;
        private Panel _pnlLogo;
        private Panel _pnltitlebar;
        private Label lbltitle;
        private Label lbl;
        private Panel _pnlDesktop;
        private RJControls.RJButton _rjbtnDong;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}