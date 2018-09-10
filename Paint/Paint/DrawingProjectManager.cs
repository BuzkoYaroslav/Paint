using System;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Paint.Geometric_framework;

namespace Paint
{
    static class DrawingProjectManager
    {
        public static void SaveCanvasProject(Canvas canvas, string fileName)
        {
            var bf = new BinaryFormatter();

            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, canvas);
            }
        }

        public static Canvas LoadCanvasProject(string fileName)
        {
            var bf = new BinaryFormatter();

            using (var fs = new FileStream(fileName, FileMode.Open))
            {
                return bf.Deserialize(fs) as Canvas;
            }
        }

        public static void SaveCanvasPicture(Canvas canvas, string fileName)
        {
            canvas.CurrentState.Save(fileName);
        }

        public static Canvas OpenCanvasPicture(string fileName)
        {
            return new Canvas(Image.FromFile(fileName));
        }
    }
}
