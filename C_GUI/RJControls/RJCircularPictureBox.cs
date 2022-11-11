using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace C_GUI.RJControls
{
    internal class RJCircularPictureBox : PictureBox
    {
        //Fields
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;

        //Constructor
        public RJCircularPictureBox()
        {
            Size = new Size(100, 100);
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Properties
        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                Invalidate();
            }
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
        public Color BorderColor2
        {
            get => borderColor2;
            set
            {
                borderColor2 = value;
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public DashStyle BorderLineStyle
        {
            get => borderLineStyle;
            set
            {
                borderLineStyle = value;
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public DashCap BorderCapStyle
        {
            get => borderCapStyle;
            set
            {
                borderCapStyle = value;
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public float GradientAngle
        {
            get => gradientAngle;
            set
            {
                gradientAngle = value;
                Invalidate();
            }
        }

        //Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(Width, Width);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            //Fields
            Graphics graph = pe.Graphics;
            Rectangle rectContourSmooth = Rectangle.Inflate(ClientRectangle, -1, -1);
            Rectangle rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            int smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using LinearGradientBrush borderGColor = new(rectBorder, borderColor, borderColor2, gradientAngle);
            using GraphicsPath pathRegion = new();
            using Pen penSmooth = new(Parent.BackColor, smoothSize);
            using Pen penBorder = new(borderGColor, borderSize);
            graph.SmoothingMode = SmoothingMode.AntiAlias;
            penBorder.DashStyle = borderLineStyle;
            penBorder.DashCap = borderCapStyle;
            pathRegion.AddEllipse(rectContourSmooth);
            //Set rounded region 
            Region = new Region(pathRegion);

            //Drawing
            graph.DrawEllipse(penSmooth, rectContourSmooth);//Draw contour smoothing
            if (borderSize > 0) //Draw border
            {
                graph.DrawEllipse(penBorder, rectBorder);
            }
        }
    }
}
