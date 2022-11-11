using System.Drawing.Drawing2D;

namespace C_GUI.RJControls
{
    internal class RJRadioButton : RadioButton
    {
        //Fields
        private Color checkedColor = Color.MediumSlateBlue;
        private Color unCheckedColor = Color.Gray;

        //Properties
        public Color CheckedColor
        {
            get => checkedColor;

            set
            {
                checkedColor = value;
                Invalidate();
            }
        }

        public Color UnCheckedColor
        {
            get => unCheckedColor;

            set
            {
                unCheckedColor = value;
                Invalidate();
            }
        }

        //Constructor
        public RJRadioButton()
        {
            MinimumSize = new Size(0, 21);
            //Add a padding of 10 to the left to have a considerable distance between the text and the RadioButton.
            Padding = new Padding(10, 0, 0, 0);
        }

        //Overridden methods
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //Fields
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            float rbBorderSize = 18F;
            float rbCheckSize = 12F;
            RectangleF rectRbBorder = new()
            {
                X = 0.5F,
                Y = (Height - rbBorderSize) / 2, //Center
                Width = rbBorderSize,
                Height = rbBorderSize
            };
            RectangleF rectRbCheck = new()
            {
                X = rectRbBorder.X + ((rectRbBorder.Width - rbCheckSize) / 2), //Center
                Y = (Height - rbCheckSize) / 2, //Center
                Width = rbCheckSize,
                Height = rbCheckSize
            };

            //Drawing
            using Pen penBorder = new(checkedColor, 1.6F);
            using SolidBrush brushRbCheck = new(checkedColor);
            using SolidBrush brushText = new(ForeColor);
            //Draw surface
            graphics.Clear(BackColor);
            //Draw Radio Button
            if (Checked)
            {
                graphics.DrawEllipse(penBorder, rectRbBorder);//Circle border
                graphics.FillEllipse(brushRbCheck, rectRbCheck); //Circle Radio Check
            }
            else
            {
                penBorder.Color = unCheckedColor;
                graphics.DrawEllipse(penBorder, rectRbBorder); //Circle border
            }
            //Draw text
            graphics.DrawString(Text, Font, brushText,
                rbBorderSize + 8, (Height - TextRenderer.MeasureText(Text, Font).Height) / 2);//Y=Center
        }

        //X-> Obsolete code, this was replaced by the Padding property in the constructor
        //(this.Padding = new Padding(10,0,0,0);)
        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);
        //    this.Width = TextRenderer.MeasureText(this.Text, this.Font).Width + 30;
        //}
    }
}
