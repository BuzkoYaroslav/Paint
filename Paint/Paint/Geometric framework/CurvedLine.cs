using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Paint.Geometric_framework
{
    [Serializable]
    class CurvedLine : PlaneObject
    {
        private List<Point> points;

        public CurvedLine(Point[] points, Color color, float width) : base(color, width)
        {
            this.points = new List<Point>();

            foreach (var point in points)
                this.points.Add(point);
        }

        public void AddPoint(Point point)
        {
            if (points == null)
                throw new ArgumentNullException();

            points.Add(point);
        }

        public override void Draw(Graphics g)
        {
            if (points == null ||
                g == null)
                throw new ArgumentNullException();

            g.DrawLines(new Pen(BorderColor, BorderWidth), points.ToArray());
        }

        public override void Update(Point begin, Point end)
        {
            points.Add(end);
        }

        public override object Clone()
        {
            return new CurvedLine(points.ToArray(), BorderColor, BorderWidth);
        }

        public override void Scale(float x, float y)
        {
            for (int i = 0; i < points.Count; i++)
                points[i] = new Point((int)(x * points[i].X), (int)(y * points[i].Y));
        }

        public override void RotateFlip(RotateFlipType type, Size outerFrame)
        {
            points = points.Select(RotateFlipFunc(type, outerFrame)).ToList();
        }
    }
}
