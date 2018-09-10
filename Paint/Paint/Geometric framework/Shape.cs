using System;
using System.Drawing;

namespace Paint.Geometric_framework
{
    [Serializable]
    abstract class Shape : GeometricObject
    {
        public System.Drawing.Rectangle Frame { get; set; }

        public Color BorderColor { get; set; }
        public float BorderWidth { get; set; }
        public bool HasBorder { get; set; }

        public Color BackgroundColor { get; set; }
        public bool HasBackground { get; set; }

        protected Shape(System.Drawing.Rectangle frame, 
            Color border, float borderWidth, bool hasBorder,
            Color background, bool hasBackground)
        {
            Frame = frame;

            BorderColor = border;
            BorderWidth = Math.Max(borderWidth, 1);
            HasBorder = hasBorder;

            BackgroundColor = background;
            HasBackground = hasBackground;
        }
        protected Shape(Point begin, Point end, Color border, 
            float borderWidth, bool hasBorder, 
            Color background, bool hasBackground) :
            this(DetermineFrame(begin, end), 
                border, borderWidth, hasBorder, 
                background, hasBackground)
        {

        }

        public override void Update(Point begin, Point end)
        {
            Frame = DetermineFrame(begin, end);
        }

        public static System.Drawing.Rectangle DetermineFrame(Point begin, Point end)
        {
            Point location = new Point(Math.Min(begin.X, end.X), Math.Min(begin.Y, end.Y));
            Size size = new Size(Math.Max(begin.X, end.X) - location.X,
                Math.Max(begin.Y, end.Y) - location.Y);

            return new System.Drawing.Rectangle(location, size);
        }

        public override void InverseColor()
        {
            BorderColor = Color.FromArgb(255, 
                255 - BorderColor.R, 255 - BorderColor.G, 255 - BorderColor.B);
            BackgroundColor = Color.FromArgb(255, 
                255 - BackgroundColor.R, 255 - BackgroundColor.G, 255 - BackgroundColor.B);
        }

        public override void Scale(float x, float y)
        {
            Frame = new System.Drawing.Rectangle((int)(x * Frame.X), (int)(y * Frame.Y), 
                (int)(x * Frame.Width), (int)(y * Frame.Height));
        }

        public override void RotateFlip(RotateFlipType type, Size outerFrame)
        {
            switch (type)
            {
                case RotateFlipType.Rotate270FlipNone:
                    Frame = new System.Drawing.Rectangle(Frame.Y, 
                        outerFrame.Width - Frame.Size.Width - Frame.X, 
                        Frame.Size.Height, Frame.Size.Width);
                    break;
                case RotateFlipType.Rotate90FlipNone:
                    Frame = new System.Drawing.Rectangle(outerFrame.Height - Frame.Size.Height - Frame.Y, 
                        Frame.X, 
                        Frame.Size.Height, Frame.Size.Width);
                    break;
                case RotateFlipType.RotateNoneFlipX:
                    Frame = new System.Drawing.Rectangle(Frame.X, 
                        outerFrame.Height - Frame.Size.Height - Frame.Y, 
                        Frame.Size.Width, Frame.Size.Height);
                    break;
                case RotateFlipType.RotateNoneFlipY:
                    Frame = new System.Drawing.Rectangle(outerFrame.Width - Frame.Size.Width - Frame.X,
                        Frame.Y, 
                        Frame.Size.Width, Frame.Size.Height);
                    break;

                default:
                    break;
                
            }
        }
    }
}
