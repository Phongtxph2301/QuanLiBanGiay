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
            this._pnlmenu = new System.Windows.Forms.Panel();
            this._btnBanhang = new System.Windows.Forms.Button();
            this._btnThongKe = new System.Windows.Forms.Button();
            this._btn_GiaoCa = new System.Windows.Forms.Button();
            this._btnSanPham = new System.Windows.Forms.Button();
            this._pnllogo = new System.Windows.Forms.Panel();
            this.pnl = new System.Windows.Forms.Label();
            this._pnltitleBar = new System.Windows.Forms.Panel();
            this._rjbtndong = new C_GUI.RJControls.RJButton();
            this._lbltitle = new System.Windows.Forms.Label();
            this._pnlDesktoppanel = new System.Windows.Forms.Panel();
            this._pnlmenu.SuspendLayout();
            this._pnllogo.SuspendLayout();
            this._pnltitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnlmenu
            // 
            this._pnlmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this._pnlmenu.Controls.Add(this._btnBanhang);
            this._pnlmenu.Controls.Add(this._btnThongKe);
            this._pnlmenu.Controls.Add(this._btn_GiaoCa);
            this._pnlmenu.Controls.Add(this._btnSanPham);
            this._pnlmenu.Controls.Add(this._pnllogo);
            this._pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlmenu.Location = new System.Drawing.Point(0, 0);
            this._pnlmenu.Name = "_pnlmenu";
            this._pnlmenu.Size = new System.Drawing.Size(250, 770);
            this._pnlmenu.TabIndex = 0;
            // 
            // _btnBanhang
            // 
            this._btnBanhang.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnBanhang.FlatAppearance.BorderSize = 0;
            this._btnBanhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBanhang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnBanhang.Location = new System.Drawing.Point(0, 434);
            this._btnBanhang.Name = "_btnBanhang";
            this._btnBanhang.Size = new System.Drawing.Size(250, 103);
            this._btnBanhang.TabIndex = 5;
            this._btnBanhang.Text = "Bán Hàng";
            this._btnBanhang.UseVisualStyleBackColor = true;
            this._btnBanhang.Click += new System.EventHandler(this._btnBanhang_Click_1);
            // 
            // _btnThongKe
            // 
            this._btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnThongKe.FlatAppearance.BorderSize = 0;
            this._btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnThongKe.Location = new System.Drawing.Point(0, 331);
            this._btnThongKe.Name = "_btnThongKe";
            this._btnThongKe.Size = new System.Drawing.Size(250, 103);
            this._btnThongKe.TabIndex = 4;
            this._btnThongKe.Text = "Thống Kê";
            this._btnThongKe.UseVisualStyleBackColor = true;
            this._btnThongKe.Click += new System.EventHandler(this._btnThongKe_Click_1);
            // 
            // _btn_GiaoCa
            // 
            this._btn_GiaoCa.Dock = System.Windows.Forms.DockStyle.Top;
            this._btn_GiaoCa.FlatAppearance.BorderSize = 0;
            this._btn_GiaoCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_GiaoCa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btn_GiaoCa.Location = new System.Drawing.Point(0, 228);
            this._btn_GiaoCa.Name = "_btn_GiaoCa";
            this._btn_GiaoCa.Size = new System.Drawing.Size(250, 103);
            this._btn_GiaoCa.TabIndex = 3;
            this._btn_GiaoCa.Text = "Giao Ca";
            this._btn_GiaoCa.UseVisualStyleBackColor = true;
            this._btn_GiaoCa.Click += new System.EventHandler(this._btn_GiaoCa_Click);
            // 
            // _btnSanPham
            // 
            this._btnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnSanPham.FlatAppearance.BorderSize = 0;
            this._btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSanPham.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnSanPham.Location = new System.Drawing.Point(0, 125);
            this._btnSanPham.Name = "_btnSanPham";
            this._btnSanPham.Size = new System.Drawing.Size(250, 103);
            this._btnSanPham.TabIndex = 1;
            this._btnSanPham.Text = "Sản Phẩm";
            this._btnSanPham.UseVisualStyleBackColor = true;
            this._btnSanPham.Click += new System.EventHandler(this._btnSanPham_Click_1);
            // 
            // _pnllogo
            // 
            this._pnllogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this._pnllogo.Controls.Add(this.pnl);
            this._pnllogo.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnllogo.Location = new System.Drawing.Point(0, 0);
            this._pnllogo.Name = "_pnllogo";
            this._pnllogo.Size = new System.Drawing.Size(250, 125);
            this._pnllogo.TabIndex = 0;
            // 
            // pnl
            // 
            this.pnl.AutoSize = true;
            this.pnl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl.Location = new System.Drawing.Point(43, 40);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(157, 35);
            this.pnl.TabIndex = 0;
            this.pnl.Text = "NaHiDaShoe";
            // 
            // _pnltitleBar
            // 
            this._pnltitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this._pnltitleBar.Controls.Add(this._rjbtndong);
            this._pnltitleBar.Controls.Add(this._lbltitle);
            this._pnltitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnltitleBar.Location = new System.Drawing.Point(250, 0);
            this._pnltitleBar.Name = "_pnltitleBar";
            this._pnltitleBar.Size = new System.Drawing.Size(1210, 125);
            this._pnltitleBar.TabIndex = 1;
            // 
            // _rjbtndong
            // 
            this._rjbtndong.BackColor = System.Drawing.Color.Turquoise;
            this._rjbtndong.BackgroundColor = System.Drawing.Color.Turquoise;
            this._rjbtndong.BorderColor = System.Drawing.Color.Black;
            this._rjbtndong.BorderRadius = 15;
            this._rjbtndong.BorderSize = 2;
            this._rjbtndong.FlatAppearance.BorderSize = 0;
            this._rjbtndong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._rjbtndong.ForeColor = System.Drawing.Color.Black;
            this._rjbtndong.Location = new System.Drawing.Point(6, 80);
            this._rjbtndong.Name = "_rjbtndong";
            this._rjbtndong.Size = new System.Drawing.Size(188, 39);
            this._rjbtndong.SizeImage = new System.Drawing.Size(20, 20);
            this._rjbtndong.TabIndex = 1;
            this._rjbtndong.Text = "Đóng";
            this._rjbtndong.TextColor = System.Drawing.Color.Black;
            this._rjbtndong.UseVisualStyleBackColor = false;
            this._rjbtndong.Click += new System.EventHandler(this._rjbtndong_Click_1);
            // 
            // _lbltitle
            // 
            this._lbltitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._lbltitle.AutoSize = true;
            this._lbltitle.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lbltitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._lbltitle.Location = new System.Drawing.Point(481, 53);
            this._lbltitle.Name = "_lbltitle";
            this._lbltitle.Size = new System.Drawing.Size(90, 35);
            this._lbltitle.TabIndex = 0;
            this._lbltitle.Text = "Home";
            // 
            // _pnlDesktoppanel
            // 
            this._pnlDesktoppanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlDesktoppanel.Location = new System.Drawing.Point(250, 125);
            this._pnlDesktoppanel.Name = "_pnlDesktoppanel";
            this._pnlDesktoppanel.Size = new System.Drawing.Size(1210, 645);
            this._pnlDesktoppanel.TabIndex = 2;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 770);
            this.Controls.Add(this._pnlDesktoppanel);
            this.Controls.Add(this._pnltitleBar);
            this.Controls.Add(this._pnlmenu);
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this._pnlmenu.ResumeLayout(false);
            this._pnllogo.ResumeLayout(false);
            this._pnllogo.PerformLayout();
            this._pnltitleBar.ResumeLayout(false);
            this._pnltitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel _pnlmenu;
        private Button _btnThongKe;
        private Button _btn_GiaoCa;
        private Button _btnSanPham;
        private Panel _pnllogo;
        private Panel _pnltitleBar;
        private Label _lbltitle;
        private Label pnl;
        private Panel _pnlDesktoppanel;
        private RJControls.RJButton _rjbtndong;
        private Button _btnBanhang;
    }
}