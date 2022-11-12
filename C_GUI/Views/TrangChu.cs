using A_DAL.Entities;

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
               _rjbtndong.Visible = false;
        }

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
                    _pnltitleBar.BackColor = color;
                    _rjbtndong.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in _pnlmenu.Controls)
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
            _pnlDesktoppanel.Controls.Add(childForm);
            _pnlDesktoppanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            _lbltitle.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            _lbltitle.Text = "HOME";
            _pnltitleBar.BackColor = Color.FromArgb(0, 150, 136);
            _pnllogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            _rjbtndong.Visible = false;
        }

       

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void _btnSanPham_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormSanPham(), sender);
        }



        private void _btn_GiaoCa_Click(object sender, EventArgs e)
        {
           OpenChildForm(new FormGiaoCa(), sender);
        }

        private void _btnThongKe_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKe(), sender);
        }

        private void _rjbtndong_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            Reset();
        }

        private void _btnBanhang_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang(), sender);
        }
    }
}
