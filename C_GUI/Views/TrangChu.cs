namespace C_GUI.Views
{
    public partial class TrangChu : Form
    {
        private Button? currentButton;
        private readonly Random random;
        private int tempIndex;
        private Form activeForm;
        public TrangChu()
        {
            InitializeComponent();
            random = new Random();
            _rjbtnDong.Visible = false;
            //   this.Text = string.Empty;
            //  this.ControlBox = false;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        // [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        // private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        // private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                    _pnltitlebar.BackColor = color;
                    _pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    _rjbtnDong.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in _pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            _pnlDesktop.Controls.Add(childForm);
            _pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbltitle.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            lbltitle.Text = "HOME";
            _pnltitlebar.BackColor = Color.FromArgb(0, 150, 136);
            _pnlLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            _rjbtnDong.Visible = false;
        }

        private void _btnTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTrangChu(), sender);
        }

        private void _btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHoaDon(), sender);
        }

        private void _btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSanPham(), sender);
        }

        private void _btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang(), sender);
        }

        private void _btnTHongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKe(), sender);
        }

        private void _rjbtnDong_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            Reset();
        }
    }
}
