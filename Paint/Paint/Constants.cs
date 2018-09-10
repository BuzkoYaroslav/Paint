using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    static class Constants
    {
        internal static class DrawingPanel
        {
            internal const int initialWidth = 200;
            internal const int initialHeight = 200;

            internal const string pictureFileDialogFilter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp|Picture|*.png";
            internal const string projectFileDialogFilter = "Paint project|*.paint";

            internal const string openFileDialogTitle = "Открыть проект или рисунок...";
            internal const string saveFileDialogTitle = "Сохранить текущий рисунок как...";

            internal const string chooseInstrumentForDrawingInformationMessage = "Выберите инструмент для рисования!";

            internal const string informationMessageTitle = "Info";
            internal const string saveFileMessageBoxText = "Хотите ли сохранить проект?";
            internal const string saveFileMessageBoxTitle = "Сохранение";
        }
    }
}
