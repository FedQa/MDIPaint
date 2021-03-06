using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIPaint
{
    public partial class DocumentForm : Form
    {
        int X, Y, X1, Y1;
        Point shapeStartPoint = new Point();
        private bool LineSelected = false;
        private Bitmap bmp;
        private Bitmap bmp1;
        PointF[] points = new PointF[5];
        public Bitmap Bitmap
        {
            get => bmp;
            set
            {
                bmp = value;
                pictureBox1.Image = bmp;
            }

        }
        public Bitmap Bitmap1
        {
            get => bmp1;
            set
            {
                bmp1 = value;
                pictureBox1.Image = bmp1;
            }
        }
        public void Scale(float height, float width)
        {
            if (width < 100)
                width = 100;
            if (height < 100)
                height = 100;

            Size newSize = new Size((int)height, (int)width);

            Bitmap bitmap = new Bitmap(bmp, newSize);
            Bitmap = bitmap;

            Bitmap bitmap1 = new Bitmap(bmp1, newSize);
            Bitmap1 = bitmap1;
        }
        public int CanvasHeight
        {
            get
            {
                return pictureBox1.Height;
            }
            set
            {
                pictureBox1.Height = value;
                Bitmap tempBit = new Bitmap(value, pictureBox1.Height);
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.Clear(Color.White);
                graphics.DrawImage(tempBit, new Point(0, 0));
                Bitmap = tempBit;
                pictureBox1.Image = Bitmap;
            }
        }
        public int CanvasHeight1
        {
            get
            {
                return pictureBox1.Height;
            }
            set
            {
                pictureBox1.Height = value;
                Bitmap tempBit = new Bitmap(value, pictureBox1.Height);
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.Clear(Color.White);
                graphics.DrawImage(tempBit, new Point(0, 0));
                Bitmap1 = tempBit;
                pictureBox1.Image = Bitmap1;
            }
        }
        public int CanvasWidth
        {
            get
            {
                return pictureBox1.Width;
            }
            set
            {
                pictureBox1.Width = value;
                Bitmap tempBit = new Bitmap(value, pictureBox1.Width);
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.Clear(Color.White);
                graphics.DrawImage(tempBit, new Point(0, 0));
                Bitmap = tempBit;
                pictureBox1.Image = Bitmap;
            }
        }
        public int CanvasWidth1
        {
            get
            {
                return pictureBox1.Width;
            }
            set
            {
                pictureBox1.Width = value;
                Bitmap tempBit = new Bitmap(value, pictureBox1.Width);
                Graphics graphics = Graphics.FromImage(tempBit);
                graphics.Clear(Color.White);
                graphics.DrawImage(tempBit, new Point(0, 0));
                bmp1 = tempBit;
                pictureBox1.Image = bmp1;
            }
        }
        public void SaveAs()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.AddExtension = true;
            saveFile.Filter = "Windows Bitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpg)|*.jpg";
            ImageFormat[] images = { ImageFormat.Bmp, ImageFormat.Jpeg };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(saveFile.FileName, images[saveFile.FilterIndex - 1]);
            }
        }
        public DocumentForm(String FileName)
        {
            InitializeComponent();
            Bitmap = new Bitmap(FileName);
            pictureBox1.Image = Bitmap;

            Bitmap1 = new Bitmap(FileName);
            pictureBox1.Image = Bitmap1;
        }

        public DocumentForm()
        {
            InitializeComponent();
            Bitmap = new Bitmap(Width, Height);
            pictureBox1.Image = Bitmap;

            Bitmap1 = new Bitmap(Width, Height);
            pictureBox1.Image = Bitmap1;
        }

        private void DocumentForm_Resize(object sender, EventArgs e)
        {
            Scale(this.CanvasWidth, this.CanvasHeight);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(MainForm.CurrentColor, MainForm.CurrentWidth);
            pen.StartCap = pen.EndCap = LineCap.Round;
            Graphics g = Graphics.FromImage(Bitmap);
            if (MainForm.TheFigureNumber == 1)
            {
                g.DrawLine(pen, X, Y, e.X, e.Y);
                X = e.X;
                Y = e.Y;
            }
            if (MainForm.TheFigureNumber==2)
            {
                g.DrawLine(pen, X, Y, X1, Y1);
            }
            if (MainForm.TheFigureNumber == 3)
            {
                g.DrawEllipse(pen, X, Y, e.X - X, e.Y - Y);
            }
            if (MainForm.TheFigureNumber == 4)
            {
                g.DrawPolygon(pen, points);
            }
            if (e.Button == MouseButtons.Right)
            {
                X = e.X;
                Y = e.Y;
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
        }
        private PointF[] StarPoints(int num_points)
        {
            // Make room for the points.
            PointF[] pts = new PointF[num_points];

            double rx = X;
            double ry = Y;
            double cx = X + X1;
            double cy = Y + Y1;

            // Start at the top.
            double theta = -Math.PI / 2;
            double dtheta = 4 * Math.PI / num_points;
            for (int i = 0; i < num_points; i++)
            {
                pts[i] = new PointF(
                    (float)(cx + rx * Math.Cos(theta)),
                    (float)(cy + ry * Math.Sin(theta)));
                theta += dtheta;
            }

            return pts;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(Bitmap);
            Graphics g1 = Graphics.FromImage(Bitmap1);
            Pen pen = new Pen(MainForm.CurrentColor, MainForm.CurrentWidth);
            pen.StartCap = pen.EndCap = LineCap.Round;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g1.SmoothingMode = SmoothingMode.HighQuality;
            if (MainForm.CurrentColor.IsEmpty)
                MainForm.CurrentColor = Color.Black;
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (MainForm.TheFigureNumber == 1)
                    {
                        g.DrawLine(pen, X, Y, e.X, e.Y);
                        pictureBox1.Image = bmp;
                        X = e.X;
                        Y = e.Y;
                        pictureBox1.Invalidate();
                    }
                    if (MainForm.TheFigureNumber == 2)
                    {
                        bmp1 = new Bitmap(Bitmap);
                        pictureBox1.Image = bmp1;
                        g1 = Graphics.FromImage(bmp1);
                        g1.SmoothingMode = SmoothingMode.HighQuality;
                        pen.StartCap = pen.EndCap = LineCap.Round;
                        g1.DrawLine(pen, new Point(X,Y), e.Location);
                        pictureBox1.Invalidate();
                    }
                    if (MainForm.TheFigureNumber == 3)
                    {
                        bmp1 = new Bitmap(Bitmap);
                        pictureBox1.Image = bmp1;
                        g1 = Graphics.FromImage(bmp1);
                        g1.SmoothingMode = SmoothingMode.HighQuality;
                        pen.StartCap = pen.EndCap = LineCap.Round;
                        g1.DrawEllipse(pen, X, Y, e.X - X, e.Y - Y);
                        pictureBox1.Invalidate();
                    }
                    if(MainForm.TheFigureNumber == 4)
                    {
                        bmp1 = new Bitmap(Bitmap);
                        pictureBox1.Image = bmp1;
                        g1 = Graphics.FromImage(bmp1);
                        g1.SmoothingMode = SmoothingMode.HighQuality;
                        pen.StartCap = pen.EndCap = LineCap.Round;
                        g1.DrawPolygon(pen, points);
                        pictureBox1.Invalidate();
                    }
                    X1 = e.X;
                    Y1 = e.Y;
                }
                if (e.Button == MouseButtons.Right)
                {
                    Pen razer = new Pen(Color.White, MainForm.CurrentWidth * 2);
                    pictureBox1.Image = bmp;
                    razer.StartCap = razer.EndCap = LineCap.Round;
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.DrawLine(razer, X,Y, e.X,e.Y);
                    X = e.X;
                    Y = e.Y;
                }
                Refresh();
            }
        }
    }
}
