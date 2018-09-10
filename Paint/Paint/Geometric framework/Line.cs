using System;
using System.Drawing;

namespace Paint.Geometric_framework
{
    [Serializable]
    class Line : PlaneObject
    {
        public Point Begin { get; private set; }
        public Point End { get; private set; }

        public Line(Point begin, Point end, Color color, float width) : base(color, width)
        {
            Begin = begin;
            End = end;
        }

        public override void Draw(Graphics g)
        {
            if (Begin == null || End == null ||
                g == null)
                throw new ArgumentNullException();

            g.DrawLine(new Pen(BorderColor, BorderWidth), Begin, End);
        }

        public override void Update(Point begin, Point end)
        {
            Begin = begin;
            End = end;
        }

        public override object Clone()
        {
            return new Line(Begin, End, BorderColor, BorderWidth);
        }

        public override void Scale(float x, float y)
        {
            Begin = new Point((int)(x * Begin.X), (int)(y * Begin.Y));
            End = new Point((int)(x * End.X), (int)(y * End.Y));
        }

        public override void RotateFlip(RotateFlipType type, Size outerFrame)
        {
            var func = RotateFlipFunc(type, outerFrame);

            Begin = func(Begin);
            End = func(End);
        }
    }
}
