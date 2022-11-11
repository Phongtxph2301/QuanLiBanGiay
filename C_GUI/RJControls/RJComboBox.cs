using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing.Drawing2D;

namespace C_GUI.RJControls
{
    [DefaultEvent("OnSelectedIndexChanged")]
    internal class RJComboBox : UserControl
    {
        #region -> Fields
        //Fields
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;

        //Items
        private readonly ComboBox cmbList;
        private readonly Label lblText;
        private readonly Button btnIcon;

        //Events
        public event EventHandler OnSelectedIndexChanged;//Default event
        #endregion

        #region -> Constructor
        public RJComboBox()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            SuspendLayout();

            //ComboBox: Dropdown list
            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(Font.Name, 10F);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);//Default event
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);//Refresh text

            //Button: Icon
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);//Open dropdown list
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);//Draw icon

            //Label: Text
            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(Font.Name, 10F);
            //->Attach label events to user control event
            lblText.Click += new EventHandler(Surface_Click);//Select combo box
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);

            //User Control
            Controls.Add(lblText);//2
            Controls.Add(btnIcon);//1
            Controls.Add(cmbList);//0
            MinimumSize = new Size(200, 30);
            Size = new Size(200, 30);
            ForeColor = Color.DimGray;
            Padding = new Padding(borderSize);//Border Size
            Font = new Font(Font.Name, 10F);
            base.BackColor = borderColor; //Border Color
            Load += new System.EventHandler(RJComboBox_Load);
            ResumeLayout();
            AdjustComboBoxDimensions();
        }
        #endregion

        //Properties
        #region -> Appearance properties
        [Category("RJ Code - Appearance")]
        public new Color BackColor
        {
            get => backColor;
            set
            {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }

        [Category("RJ Code - Appearance")]
        public Color IconColor
        {
            get => iconColor;
            set
            {
                iconColor = value;
                btnIcon.Invalidate();//Redraw icon
            }
        }

        [Category("RJ Code - Appearance")]
        public Color ListBackColor
        {
            get => listBackColor;
            set
            {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }

        [Category("RJ Code - Appearance")]
        public Color ListTextColor
        {
            get => listTextColor;
            set
            {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            }
        }

        [Category("RJ Code - Appearance")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                base.BackColor = borderColor; //Border Color
            }
        }

        [Category("RJ Code - Appearance")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                Padding = new Padding(borderSize);//Border Size
                AdjustComboBoxDimensions();
            }
        }

        [Category("RJ Code - Appearance")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }

        [Category("RJ Code - Appearance")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value;//Optional
                AdjustComboBoxDimensions();
            }
        }

        [Category("RJ Code - Appearance")]
        public string Texts
        {
            get => lblText.Text;
            set => lblText.Text = value;
        }

        [Category("RJ Code - Appearance")]
        public ComboBoxStyle DropDownStyle
        {
            get => cmbList.DropDownStyle;
            set
            {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                {
                    cmbList.DropDownStyle = value;
                }
            }
        }
        #endregion

        #region -> Data properties

        [Category("RJ Code - Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items => cmbList.Items;

        [Category("RJ Code - Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get => cmbList.DataSource;
            set => cmbList.DataSource = value;
        }

        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get => cmbList.AutoCompleteCustomSource;
            set => cmbList.AutoCompleteCustomSource = value;
        }

        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get => cmbList.AutoCompleteSource;
            set => cmbList.AutoCompleteSource = value;
        }

        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get => cmbList.AutoCompleteMode;
            set => cmbList.AutoCompleteMode = value;
        }

        [Category("RJ Code - Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get => cmbList.SelectedItem;
            set => cmbList.SelectedItem = value;
        }

        [Category("RJ Code - Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get => cmbList.SelectedIndex;
            set => cmbList.SelectedIndex = value;
        }

        [Category("RJ Code - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get => cmbList.DisplayMember;
            set => cmbList.DisplayMember = value;
        }

        [Category("RJ Code - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get => cmbList.ValueMember;
            set => cmbList.ValueMember = value;
        }
        #endregion

        #region -> Private methods
        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point()
            {
                X = Width - Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
            if (cmbList.Height >= Height)
            {
                Height = cmbList.Height + (borderSize * 2);
            }
        }
        #endregion

        #region -> Event methods

        //-> Default event
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
            {
                OnSelectedIndexChanged.Invoke(sender, e);
            }
            //Refresh text
            lblText.Text = cmbList.Text;
        }

        //-> Draw icon
        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //Fields
            int iconWidht = 14;
            int iconHeight = 6;
            Rectangle rectIcon = new((btnIcon.Width - iconWidht) / 2, (btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;

            //Draw arrow down icon
            using GraphicsPath path = new();
            using Pen pen = new(iconColor, 2);
            graph.SmoothingMode = SmoothingMode.AntiAlias;
            path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
            path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
            graph.DrawPath(pen, path);
        }

        //-> Items actions
        private void Icon_Click(object sender, EventArgs e)
        {
            //Open dropdown list
            cmbList.Select();
            cmbList.DroppedDown = true;
        }
        private void Surface_Click(object sender, EventArgs e)
        {
            //Attach label click to user control click
            OnClick(e);
            //Select combo box
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                cmbList.DroppedDown = true;//Open dropdown list
            }
        }
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            //Refresh text
            lblText.Text = cmbList.Text;
        }

        //->Attach label events to user control event
        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }
        //::::+
        #endregion

        #region -> Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (DesignMode)
            {
                AdjustComboBoxDimensions();
            }
        }
        #endregion

        private void RJComboBox_Load(object sender, EventArgs e)
        {
            AdjustComboBoxDimensions();
        }
    }
}
