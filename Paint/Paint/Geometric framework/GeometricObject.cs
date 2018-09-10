using System;
using System.Drawing;

namespace Paint.Geometric_framework
{
    [Serializable]
    abstract class GeometricObject : ICloneable
    {
        public abstract void Draw(Graphics g);
        public abstract void Update(Point begin, Point end);

        public abstract void Scale(float x, float y);
        public abstract void RotateFlip(RotateFlipType type, Size outerFrame);
        public abstract void InverseColor();

        public abstract object Clone();
    }
}
