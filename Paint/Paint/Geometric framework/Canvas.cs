using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace Paint.Geometric_framework
{ 
    public interface IImageDisplayable
    {
        void DisplayImage(Image image);
        void ResizeDisplay(Size size);
    }

    public interface IProgress
    {
        void SetTaskNumber(int number);
        void TaskCompleted(int count);
        void CompletionIsStarted();
        void CompletionIsFinished();
    }

    enum CanvasTool
    {
        Pencil = 0, Line = 1, Ellipse = 2, Rectangle = 3
    }

    class DrawingObject
    {
        internal GeometricObject Object { get; set; }
                
        internal Point StartingPoint { get; set; }

        internal Color BorderColor { get; set; }
        internal Color BackgroundColor { get; set; }

        internal float BorderWidth { get; set; }

        internal bool HasBackground { get; set; }
        internal bool HasBorder { get; set; }
    }

    [Serializable]
    class Canvas
    {
        public Size Size
        {
            get { return size; }
            private set
            {
                size = value;
                if (Display != null)
                    Display.ResizeDisplay(Size);
            }
        }
        public IImageDisplayable Display
        {
            get { return display; }
            set
            {
                display = value;

                if (display != null)
                {
                    display.ResizeDisplay(Size);
                    display.DisplayImage(currentBitmap);
                }
            }
        }
        public Bitmap CurrentState { get { return currentBitmap; } }
        public Image BackgroundImage { get; private set; }

        private Size size;

        [NonSerialized]
        private IImageDisplayable display;
        
        private List<GeometricObject> objects;

        [NonSerialized]
        private bool figureIsStarted = false;
        [NonSerialized]
        private CanvasTool currentTool;
        [NonSerialized]
        private DrawingObject currentObject;

        [NonSerialized]
        private Bitmap previousImageState;
        private Bitmap currentBitmap;
        [NonSerialized]
        private Graphics graphicsContext;

        public Canvas(Size size, bool isTransparent = false)
        {
            Size = size;

            InitializeGraphics();
            
            graphicsContext.FillRectangle(new SolidBrush(Color.White), 0, 0, Size.Width, Size.Height);

            if (!isTransparent)
                BackgroundImage = currentBitmap.Clone() as Bitmap;

            objects = new List<GeometricObject>();
        }
        public Canvas(Image image) : this(image.Size)
        {
            BackgroundImage = image;

            graphicsContext.DrawImage(image, 0, 0);
        }

        private void InitializeGraphics(Bitmap image = null)
        {
            if (image == null)
                currentBitmap = new Bitmap(Size.Width, Size.Height);
            else
                currentBitmap = image.Clone() as Bitmap;

            graphicsContext = Graphics.FromImage(currentBitmap);
            graphicsContext.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void DrawCurrentContext()
        {
            InitializeGraphics(previousImageState);

            currentObject.Object.Draw(graphicsContext);

            if (Display != null)
                Display.DisplayImage(currentBitmap);
        }

        private void DrawContext()
        {
            InitializeGraphics();

            if (BackgroundImage != null)
                graphicsContext.DrawImage(BackgroundImage, 0, 0);
            else
                graphicsContext.FillRectangle(new SolidBrush(Color.White), 0, 0, 
                    Size.Width, Size.Height);

            foreach (var obj in objects)
                obj.Draw(graphicsContext);

            if (Display != null)
                Display.DisplayImage(currentBitmap);
        }

        public void StartFigure(CanvasTool tool, Color border, float borderWidth, 
            Color background, bool hasBackground, Point start)
        {
            if (figureIsStarted)
                return;

            figureIsStarted = true;
            currentTool = tool;
            currentObject = new DrawingObject();          
            currentObject.StartingPoint = start;
            currentObject.BorderColor = border;
            currentObject.BackgroundColor = background;
            currentObject.BorderWidth = borderWidth;
            currentObject.HasBackground = hasBackground;
            currentObject.HasBorder = true;

            previousImageState = currentBitmap.Clone() as Bitmap;
        }

        public void ContinueFigure(Point point)
        {
            if (!figureIsStarted)
                return;
            
            if (currentObject.Object == null)
                currentObject.Object = CreateNewGraphicObject(currentObject.StartingPoint, point,
                    currentObject.BorderColor, currentObject.BorderWidth, currentObject.HasBorder,
                    currentObject.BackgroundColor, currentObject.HasBackground);
            else
                currentObject.Object.Update(currentObject.StartingPoint, point);

            DrawCurrentContext();
        }

        public void FinishFigure()
        {
            if (!figureIsStarted)
                return;

            previousImageState = null;
            figureIsStarted = false;

            objects.Add(currentObject.Object);

            currentObject = null;
        }

        private GeometricObject CreateNewGraphicObject(Point start, Point end, 
            Color border, float borderWidth, bool hasBorder,
            Color background, bool hasBackground)
        {
            switch (currentTool)
            {
                case CanvasTool.Pencil:
                    return new CurvedLine(new Point[] { start, end }, border, borderWidth);
                case CanvasTool.Line:
                    return new Line(start, end, border, borderWidth);
                case CanvasTool.Ellipse:
                    return new Ellipse(start, end, border, borderWidth, hasBorder, 
                        background, hasBackground);
                case CanvasTool.Rectangle:
                    return new Rectangle(start, end, border, borderWidth, hasBorder,
                        background, hasBackground);
                default:
                    return null;
            }
        }

        public void InverseColor(IProgress indicator)
        {
            if (indicator == null)
                throw new ArgumentNullException();

            StartActionOnBackgroundThread(() =>
            {
                indicator.CompletionIsStarted();

                indicator.SetTaskNumber(objects.Count + 
                    (BackgroundImage != null ? BackgroundImage.Size.Width * BackgroundImage.Size.Height : 0));

                Bitmap inversedBitmap = null;
                if (BackgroundImage != null)
                {
                    inversedBitmap = BackgroundImage.Clone() as Bitmap;

                    for (int i = 0; i < inversedBitmap.Size.Width; i++)
                    {
                        for (int j = 0; j < inversedBitmap.Size.Height; j++)
                        {
                            var color = inversedBitmap.GetPixel(i, j);

                            inversedBitmap.SetPixel(i, j, 
                                Color.FromArgb(255, 255 - color.R, 255 - color.G, 255 - color.B));

                            indicator.TaskCompleted(1);
                        }
                    }
                }

                var inversedObjects = new List<GeometricObject>();

                foreach (var shape in objects)
                {
                    var copy = shape.Clone() as GeometricObject;
                    copy.InverseColor();

                    inversedObjects.Add(copy);

                    indicator.TaskCompleted(1);
                }
                
                BackgroundImage = inversedBitmap;
                objects = inversedObjects;

                DrawContext();

                indicator.CompletionIsFinished();
            });
        }

        public void RotateFlip(RotateFlipType type, IProgress indicator)
        {
            if (indicator == null)
                throw new ArgumentNullException();

            StartActionOnBackgroundThread(() =>
            {
                indicator.CompletionIsStarted();

                indicator.SetTaskNumber(objects.Count + 1);

                Bitmap rotatedImage = null;
                if (BackgroundImage != null) {
                    rotatedImage = BackgroundImage.Clone() as Bitmap;
                    rotatedImage.RotateFlip(type);
                }

                indicator.TaskCompleted(1);

                var newSize = new Size(Size.Height, Size.Width);
                var rotatedObjects = new List<GeometricObject>();

                foreach (var shape in objects)
                {
                    var copy = shape.Clone() as GeometricObject;
                    copy.RotateFlip(type, Size);

                    rotatedObjects.Add(copy);

                    indicator.TaskCompleted(1);
                }

                Size = newSize;
                BackgroundImage = rotatedImage;
                objects = rotatedObjects;

                DrawContext();

                indicator.CompletionIsFinished();
            });
        }

        public void Scale(float x, float y, IProgress indicator)
        {
            if (indicator == null)
                throw new ArgumentNullException();

            StartActionOnBackgroundThread(() =>
            {
                indicator.CompletionIsStarted();

                indicator.SetTaskNumber(objects.Count + 1);

                var newSize = new Size((int)(Size.Width * x), (int)(Size.Height * y));

                Bitmap scaledImage = null;
                if (BackgroundImage != null)
                {
                    scaledImage = new Bitmap(BackgroundImage.Clone() as Bitmap, newSize);
                }

                indicator.TaskCompleted(1);

                
                var scaledObjects = new List<GeometricObject>();

                foreach (var shape in objects)
                {
                    var copy = shape.Clone() as GeometricObject;
                    copy.Scale(x, y);
                    scaledObjects.Add(copy);

                    indicator.TaskCompleted(1);
                }

                Size = newSize;
                BackgroundImage = scaledImage;
                objects = scaledObjects;

                DrawContext();

                indicator.CompletionIsFinished();
            });
        }
        
        private void StartActionOnBackgroundThread(Action action)
        {
            var thrd = new Thread(() => action());

            thrd.IsBackground = true;

            thrd.Start();
        }
    }
}
