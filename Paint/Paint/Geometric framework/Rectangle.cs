using System;
using System.Drawing;

namespace Paint.Geometric_framework
{
    [Serializable]
    class Rectangle : Shape
    {
        public Rectangle(System.Drawing.Rectangle frame, 
            Color border, float borderWidth, bool hasBorder, Color background, bool hasBackground) :
            base(frame, border, borderWidth, hasBorder, background, hasBackground)
        {
        }
        public Rectangle(Point begin, Point end,
            Color border, float borderWidth, bool hasBorder, Color background, bool hasBackground) :
            base(begin, end, border, borderWidth, hasBorder, background, hasBackground)
        {
        }

        public override void Draw(Graphics g)
        {
            if (g == null)
                throw new ArgumentNullException();

            if (HasBackground)
                g.FillRectangle(new SolidBrush(BackgroundColor), Frame);

            if (HasBorder)
                g.DrawRectangle(new Pen(BorderColor, BorderWidth), Frame);
        }

        public override object Clone()
        {
            return new Rectangle(Frame, BorderColor, BorderWidth, HasBorder, BackgroundColor, HasBackground);
        }
    }

    static class DrawRectangleExtension
    {
        public static void DrawRectangle(this Graphics g, Pen pen, RectangleF rectangle)
        {
            g.DrawRectangle(pen, rectangle.Location.X, rectangle.Location.Y, 
                rectangle.Size.Width, rectangle.Size.Height);
        }
    }
}
