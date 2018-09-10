using System;
using System.Drawing;

namespace Paint.Geometric_framework
{
    [Serializable]
    class Ellipse : Shape
    {
        public Ellipse(System.Drawing.Rectangle frame, 
            Color border, float borderWidth, bool hasBorder, Color background, bool hasBackground) : 
            base(frame, border, borderWidth, hasBorder, background, hasBackground)
        {

        }
        public Ellipse(Point begin, Point end,
            Color border, float borderWidth, bool hasBorder, Color background, bool hasBackground) :
            base(begin, end, border, borderWidth, hasBorder, background, hasBackground)
        {

        }

        public override void Draw(Graphics g)
        {
            if (g == null)
                throw new ArgumentNullException();

            if (HasBackground)
                g.FillEllipse(new SolidBrush(BackgroundColor), Frame);

            if (HasBorder)
                g.DrawEllipse(new Pen(BorderColor, BorderWidth), Frame);
        }

        public override object Clone()
        {
            return new Ellipse(Frame, BorderColor, BorderWidth, HasBorder, BackgroundColor, HasBackground);
        }
    }
}
