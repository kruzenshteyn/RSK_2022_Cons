using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RSK_2022_Drawing
{
    public class Canvas
    {
        #region Fields
        Size sourceSize = new Size(100, 100);
        Size size = new Size(100, 100);
        Point location = new Point(10, 10);
        double borderPercent = 0.1;
        Point max = new Point(10, 10);
        Point min = new Point(0, 0);
        int stepPxl = 10;
        float lineGridWidth = 1;
        float axisWidth = 5;

        #endregion
        #region Constructors
        public Canvas() { }
        public Canvas(Size sourceSize)
        {
            this.sourceSize = sourceSize;
            this.size = new Size((int)(sourceSize.Width * (1 - borderPercent)),
            (int)(sourceSize.Height * (1 - borderPercent)));
            location.X = (sourceSize.Width - size.Width) / 2;
            location.Y = (sourceSize.Height - size.Height) / 2;
            stepPxl = size.Width / max.X;
            if ((size.Height / max.Y) < stepPxl) stepPxl = size.Height / max.Y;
        }
        #endregion
        #region Methods
        public void DrawGrid(Graphics gr)
        {
            gr.Clear(Color.White);
            int wLines = size.Width / stepPxl;
            int hLines = size.Height / stepPxl;
            var pen = new Pen(Color.Black, lineGridWidth);
            int shift = 0;
            //Вертикальные линии
            for (int w = 1; w < wLines; w++)
            {
                shift = w * stepPxl;
                gr.DrawLine(pen, shift + location.X, location.Y, shift + location.X, size.Height
                + location.Y);
            }
            //Горизонтальные линии
            for (int h = 1; h < hLines; h++)
            {
                shift = h * stepPxl;
                gr.DrawLine(pen, location.X, sourceSize.Height - (shift + location.Y),
                size.Width + location.X, sourceSize.Height - (shift + location.Y));
            }
            //Рисование осей
            pen.Width = axisWidth;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
        
            gr.DrawLine(pen, location.X, size.Height + location.Y, location.X, location.Y);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
            gr.DrawLine(pen, location.X, sourceSize.Height - (location.Y),
            size.Width + location.X, sourceSize.Height - (location.Y));
        }

        public void DrawContour(Graphics gr, List<PointF> source, PointF shift)
        {
            var pen = new Pen(Color.Red, 3);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            PointF lastPoint = new PointF(shift.X * stepPxl + location.X,
            sourceSize.Height - (shift.Y * stepPxl) - location.Y);
            PointF currentPoint = new PointF(lastPoint.X + source.First().X * stepPxl,
            lastPoint.Y - (source.First().Y * stepPxl));
            // Первый вектор с точкой в начале
            pen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            gr.DrawLine(pen, lastPoint, currentPoint);
            lastPoint = currentPoint;
            // Остальные — только стрелка
            pen.StartCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
            for (int i = 1; i < source.Count; i++)
            {
                currentPoint.X = lastPoint.X + source[i].X * stepPxl;
                currentPoint.Y = lastPoint.Y - (source[i].Y * stepPxl);
                gr.DrawLine(pen, lastPoint, currentPoint);
                lastPoint = currentPoint;
            }
        }
        #endregion
    }
}
