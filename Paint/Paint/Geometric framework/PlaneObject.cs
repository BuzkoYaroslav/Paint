using System;
using System.Drawing;

namespace Paint.Geometric_framework
{
    [Serializable]
    abstract class PlaneObject : GeometricObject
    {
        public Color BorderColor { get; set; }
        public float BorderWidth { get; set; }

        protected PlaneObject(Color color, float width)
        {
            BorderColor = color;
            BorderWidth = Math.Max(width, 1);
        }

        public override void InverseColor()
        {
            BorderColor = Color.FromArgb(255, 255 - BorderColor.R, 255 - BorderColor.G, 255 - BorderColor.B);
        }

        protected Func<Point, Point> RotateFlipFunc(RotateFlipType type, Size outerFrame)
        {
            switch (type)
            {
                case RotateFlipType.Rotate90FlipNone:
                    return (point) => new Point(outerFrame.Height - point.Y, point.X);
                case RotateFlipType.Rotate270FlipNone:
                    return (point) => new Point(point.Y, outerFrame.Width - point.X);
                case RotateFlipType.RotateNoneFlipX:
                    return (point) => new Point(point.X, outerFrame.Height - point.Y);
                case RotateFlipType.RotateNoneFlipY:
                    return (point) => new Point(outerFrame.Width - point.X, point.Y);

                default:
                    return null;
            }
        }

    }
}
