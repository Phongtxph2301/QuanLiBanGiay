using System.ComponentModel;

namespace C_GUI.RJControls
{
    public enum TextPosition
    {
        Left,
        Right,
        Center,
        Sliding,
        None
    }

    internal class RJProgressBar : ProgressBar
    {
        //Fields
        //-> Appearance
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private Color foreBackColor = Color.RoyalBlue;
        private int channelHeight = 6;
        private int sliderHeight = 6;
        private TextPosition showValue = TextPosition.Right;
        private string symbolBefore = "";
        private string symbolAfter = "";
        private bool showMaximun = false;

        //-> Others
        private bool paintedBack = false;
        private bool stopPainting = false;

        //Constructor
        public RJProgressBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
            ForeColor = Color.White;
        }

        //Propertiesfff
        [Category("RJ Code Advance")]
        public Color ChannelColor
        {
            get => channelColor;
            set
            {
                channelColor = value;
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color SliderColor
        {
            get => sliderColor;
            set
            {
                sliderColor = value;
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color ForeBackColor
        {
            get => foreBackColor;
            set
            {
                foreBackColor = value;
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public int ChannelHeight
        {
            get => channelHeight;
            set
            {
                channelHeight = value;
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public int SliderHeight
        {
            get => sliderHeight;
            set
            {
                sliderHeight = value;
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public TextPosition ShowValue
        {
            get => showValue;
            set
            {
                showValue = value;
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public string SymbolBefore
        {
            get => symbolBefore;
            set
            {
                symbolBefore = value;
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public string SymbolAfter
        {
            get => symbolAfter;
            set
            {
                symbolAfter = value;
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public bool ShowMaximun
        {
            get => showMaximun;
            set
            {
                showMaximun = value;
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Font Font
        {
            get => base.Font;
            set => base.Font = value;
        }

        [Category("RJ Code Advance")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set => base.ForeColor = value;
        }

        //-> Paint the background & channel
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (stopPainting == false)
            {
                if (paintedBack == false)
                {
                    //Fields
                    Graphics graph = pevent.Graphics;
                    Rectangle rectChannel = new(0, 0, Width, ChannelHeight);
                    using SolidBrush brushChannel = new(channelColor);
                    rectChannel.Y = channelHeight >= sliderHeight ? Height - channelHeight : Height - ((channelHeight + sliderHeight) / 2);

                    //Painting
                    graph.Clear(Parent.BackColor);//Surface
                    graph.FillRectangle(brushChannel, rectChannel);//Channel

                    //Stop painting the back & Channel
                    if (DesignMode == false)
                    {
                        paintedBack = true;
                    }
                }
                //Reset painting the back & channel
                if (Value == Maximum || Value == Minimum)
                {
                    paintedBack = false;
                }
            }
        }
        //-> Paint slider
        protected override void OnPaint(PaintEventArgs e)
        {
            if (stopPainting == false)
            {
                //Fields
                Graphics graph = e.Graphics;
                double scaleFactor = ((double)Value - Minimum) / ((double)Maximum - Minimum);
                int sliderWidth = (int)(Width * scaleFactor);
                Rectangle rectSlider = new(0, 0, sliderWidth, sliderHeight);
                using SolidBrush brushSlider = new(sliderColor);
                rectSlider.Y = sliderHeight >= channelHeight ? Height - sliderHeight : Height - ((sliderHeight + channelHeight) / 2);

                //Painting
                if (sliderWidth > 1) //Slider
                {
                    graph.FillRectangle(brushSlider, rectSlider);
                }

                if (showValue != TextPosition.None) //Text
                {
                    DrawValueText(graph, sliderWidth, rectSlider);
                }
            }
            if (Value == Maximum)
            {
                stopPainting = true;//Stop painting
            }
            else
            {
                stopPainting = false; //Keep painting
            }
        }

        //-> Paint value text
        private void DrawValueText(Graphics graph, int sliderWidth, Rectangle rectSlider)
        {
            //Fields
            string text = symbolBefore + Value.ToString() + symbolAfter;
            if (showMaximun)
            {
                text = text + "/" + symbolBefore + Maximum.ToString() + symbolAfter;
            }

            Size textSize = TextRenderer.MeasureText(text, Font);
            Rectangle rectText = new(0, 0, textSize.Width, textSize.Height + 2);
            using SolidBrush brushText = new(ForeColor);
            using SolidBrush brushTextBack = new(foreBackColor);
            using StringFormat textFormat = new();
            switch (showValue)
            {
                case TextPosition.Left:
                    rectText.X = 0;
                    textFormat.Alignment = StringAlignment.Near;
                    break;

                case TextPosition.Right:
                    rectText.X = Width - textSize.Width;
                    textFormat.Alignment = StringAlignment.Far;
                    break;

                case TextPosition.Center:
                    rectText.X = (Width - textSize.Width) / 2;
                    textFormat.Alignment = StringAlignment.Center;
                    break;

                case TextPosition.Sliding:
                    rectText.X = sliderWidth - textSize.Width;
                    textFormat.Alignment = StringAlignment.Center;
                    //Clean previous text surface
                    using (SolidBrush brushClear = new(Parent.BackColor))
                    {
                        Rectangle rect = rectSlider;
                        rect.Y = rectText.Y;
                        rect.Height = rectText.Height;
                        graph.FillRectangle(brushClear, rect);
                    }
                    break;
            }
            //Painting
            graph.FillRectangle(brushTextBack, rectText);
            graph.DrawString(text, Font, brushText, rectText, textFormat);
        }


    }
}
