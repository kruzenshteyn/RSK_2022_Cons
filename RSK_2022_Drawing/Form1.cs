using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSK_2022_Complex;

namespace RSK_2022_Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawEllipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создание временного изображения
            var bmp = new Bitmap(pbCanvas.Width, pbCanvas.Height);
            var canvas = Graphics.FromImage(bmp);
            canvas.Clear(Color.White);
            SizeF size = new SizeF(200, 100);
            PointF location = new PointF((float)bmp.Width / 2, (float)bmp.Height / 2);
            location.X -= size.Width / 2;
            location.Y -= size.Height / 2;
            canvas.DrawEllipse(Pens.Red, new RectangleF(location, size));
            pbCanvas.Image = bmp;
            pbCanvas.Refresh();
        }

        List<MyComplexSignal> signals = new List<MyComplexSignal>();

        private void CreateTestSignal()
        {
            MyComplexSignal signal = new MyComplexSignal();
            signal.location = new MyComplex(1, 1);
            signal.data.Add(new MyComplex(1, 0));
            signal.data.Add(new MyComplex(1, 1));
            signal.data.Add(new MyComplex(-2, 0));
            signal.data.Add(new MyComplex(0, -1));
            signals.Add(signal);
        }

        private (List<PointF> dat, PointF loc) ConvertCS2PointList(MyComplexSignal src)
        {
            var loc = new PointF((float)(src.location.x), (float)(src.location.y));

            var contour = new List<PointF>();
            foreach(var c in src.data)
            {
                var f = new PointF();
                f.X = (float)c.x;
                f.Y = (float)c.y;
                contour.Add(f);
            }

            return (contour, loc);
        }

        private void drawGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawCountours();
        }

        private void DrawCountours()
        {
            pbCanvas.Image = new Bitmap(pbCanvas.Width, pbCanvas.Height);
            var cnv = new Canvas(pbCanvas.Image.Size);
            var gr = Graphics.FromImage(pbCanvas.Image);
            cnv.DrawGrid(gr);

            foreach(var c in signals)
            {
                var tmp = ConvertCS2PointList(c);
                cnv.DrawContour(gr, tmp.dat, tmp.loc);
            }

            //cnv.DrawContour(gr, contour, loc);
        }

        private void createTestSignalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTestSignal();
        }

        private void moveSignalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nS = MyComplexSignal.Move(signals.Last(), new MyComplex(5, 0));
            signals.Add(nS);
        }

        private void rotateSignalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nS = MyComplexSignal.Rotate(signals.Last(), Math.PI / 2);
            nS.location = new MyComplex(4, 4);
            signals.Remove(signals.Last());
            signals.Add(nS);
        }
    }
}
