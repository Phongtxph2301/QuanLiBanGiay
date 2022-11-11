using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace C_GUI.RJControls
{
    [DefaultEvent("_TextChanged")]
    public partial class RJTextBox : UserControl
    {
        #region -> Fields
        //Fields
        private Color borderColor = Color.Black;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private bool isFocused = false;

        private int borderRadius = 15;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;

        //Events
        public event EventHandler _TextChanged;

        #endregion

        //-> Constructor
        public RJTextBox()
        {
            //Created by designer
            InitializeComponent();
            textBox1.MaxLength = 20;
        }

        #region -> Properties
        public bool IsNumberDouble { get; private set; } = false;

        public bool IsNotUnicode { get; private set; } = true;

        public bool IsNumberInt { get; private set; } = false;

        public bool IsName { get; private set; } = true;

        [Category("RJ Code Advance")]
        public int MaxLength
        {
            get => textBox1.MaxLength;
            set => textBox1.MaxLength = value;
        }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color BorderFocusColor { get; set; } = Color.Red;

        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                if (value >= 1)
                {
                    borderSize = value;
                    Invalidate();
                }
            }
        }

        [Category("RJ Code Advance")]
        public bool UnderlinedStyle
        {
            get => underlinedStyle;
            set
            {
                underlinedStyle = value;
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public bool PasswordChar
        {
            get => isPasswordChar;
            set
            {
                isPasswordChar = value;
                if (!isPlaceholder)
                {
                    textBox1.UseSystemPasswordChar = value;
                }
            }
        }

        [Category("RJ Code Advance")]
        public bool Multiline
        {
            get => textBox1.Multiline;
            set => textBox1.Multiline = value;
        }

        [Category("RJ Code Advance")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }

        [Category("RJ Code Advance")]
        public string Texts
        {
            get => isPlaceholder ? "" : textBox1.Text;
            set
            {
                RemovePlaceholder();//If it is the case.
                textBox1.Text = value;
                SetPlaceholder();//If it is the case.
            }
        }

        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    Invalidate();//Redraw control
                }
            }
        }

        [Category("RJ Code Advance")]
        public Color PlaceholderColor
        {
            get => placeholderColor;
            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                {
                    textBox1.ForeColor = value;
                }
            }
        }

        [Category("RJ Code Advance")]
        public string PlaceholderText
        {
            get => placeholderText;
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            }
        }
        #endregion

        #region -> Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (DesignMode)
            {
                UpdateControlHeight();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                Rectangle rectBorderSmooth = ClientRectangle;
                Rectangle rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius);
                using GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize);
                using Pen penBorderSmooth = new(Parent.BackColor, smoothSize);
                using Pen penBorder = new(borderColor, borderSize);
                //-Drawing
                Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                if (borderRadius > 15)
                {
                    SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                }

                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                if (isFocused)
                {
                    penBorder.Color = BorderFocusColor;
                }

                if (underlinedStyle) //Line Style
                {
                    //Draw border smoothing
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    //Draw border
                    graph.SmoothingMode = SmoothingMode.None;
                    graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                }
                else //Normal Style
                {
                    //Draw border smoothing
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    //Draw border
                    graph.DrawPath(penBorder, pathBorder);
                }
            }
            else //Square/Normal TextBox
            {
                //Draw border
                using Pen penBorder = new(borderColor, borderSize);
                Region = new Region(ClientRectangle);
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (isFocused)
                {
                    penBorder.Color = BorderFocusColor;
                }

                if (underlinedStyle) //Line Style
                {
                    graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                }
                else //Normal Style
                {
                    graph.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
                }
            }
        }
        #endregion

        #region -> Private methods
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = false;
                }
            }
        }
        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = ForeColor;
                if (isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = true;
                }
            }
        }
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                Height = textBox1.Height + Padding.Top + Padding.Bottom;
            }
        }
        #endregion

        #region -> TextBox events
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
            try
            {
                int number = Convert.ToInt32(textBox1.Text);
                IsNumberInt = true;
            }
            catch (Exception)
            {
                IsNumberInt = false;
            }
            try
            {
                double number = Convert.ToDouble(textBox1.Text);
                IsNumberDouble = true;
            }
            catch (Exception)
            {
                IsNumberDouble = false;
            }
            IsNotUnicode = Regex.IsMatch(textBox1.Text, @"^[A-Za-z0-9\s]+$");
            IsName = Regex.IsMatch(textBox1.Text, @"^[^0-9]+$");
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            Invalidate();
            RemovePlaceholder();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            Invalidate();
            SetPlaceholder();
        }
        ///::::+
        #endregion
    }
}
