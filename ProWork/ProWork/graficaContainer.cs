using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ProWork
{
    public partial class graficaContainer : UserControl
    {
        private string yAxis = "y";
        private string xAxis = "x";
        public Point[] Points
        {
            get { return grf.Points; }
            set { grf.Points = value; graficaContainer_FontChanged(this, EventArgs.Empty); }
        }
        public string XAxis
        {
            get { return xAxis; }
            set { xAxis = value; Refresh(); }
        }
        public string YAxis
        {
            get { return yAxis; }
            set { yAxis = value; graficaContainer_FontChanged(this, null); }
        }
        public graficaContainer()
        {
            InitializeComponent();
            grf.realCoordsOfPointsChanged += invokePaint;
            grf.Size = new Size(Width - TextRenderer.MeasureText(yAxis, Font).Width - Estilo.anchoLinea, Height - Font.Height - Estilo.anchoLinea);
            grf.Location = new(Width - grf.Width, 0);
            grf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void invokePaint(object sender, EventArgs e)
        {
            Refresh();
        }

        private void graficaContainer_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        private void graficaContainer_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush contraste = new(Estilo.Contraste);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new(Estilo.Contraste, Estilo.anchoLinea);
            pen.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawString(yAxis, Font, contraste, new Point(grf.Location.X - Estilo.anchoLinea - TextRenderer.MeasureText(yAxis.ToString(), Font).Width, 0));
            e.Graphics.DrawString(xAxis, Font, contraste, new Point(Width - TextRenderer.MeasureText(xAxis, Font).Width,  Height - Font.Height));

            pen.Alignment = PenAlignment.Right;
            e.Graphics.DrawLine(pen, new(grf.Location.X - Estilo.anchoLinea, grf.Height), new(Width, grf.Height));
            pen.Alignment = PenAlignment.Left;
            e.Graphics.DrawLine(pen, new(grf.Location.X - Estilo.medioAnchoLinea, grf.Height), new(grf.Location.X - Estilo.medioAnchoLinea, 0));

            for(int i = 0; i < grf.Points.Length; i++)
            {
                if (grf.realCoordsOfPoints[i].X >= 0 && grf.realCoordsOfPoints[i].X < grf.Width - TextRenderer.MeasureText(xAxis, Font).Width)
                {
                    e.Graphics.DrawString(grf.Points[i].X.ToString(), Font, contraste, new Point(grf.realCoordsOfPoints[i].X + grf.Location.X - TextRenderer.MeasureText(grf.Points[i].X.ToString(), Font).Width / 2, grf.Height + Estilo.anchoLinea));
                }
                if (grf.Points[i].Y > grf.YOffset && grf.realCoordsOfPoints[i].Y > TextRenderer.MeasureText(yAxis, Font).Height) 
                {
                    e.Graphics.DrawString(grf.Points[i].Y.ToString(), Font, contraste, new Point(grf.Location.X - Estilo.anchoLinea - TextRenderer.MeasureText(grf.Points[i].Y.ToString(), Font).Width, grf.realCoordsOfPoints[i].Y - Font.Height / 2));
                }
            }
        }

        private void graficaContainer_FontChanged(object sender, EventArgs e)
        {
            grf.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            string longstring = yAxis;

            foreach (Point point in grf.Points)
            {
                if (TextRenderer.MeasureText(point.Y.ToString(), Font).Width > TextRenderer.MeasureText(longstring, Font).Width)
                {
                    longstring = point.Y.ToString();
                }
            }

            grf.Size = new Size(Width - TextRenderer.MeasureText(longstring, Font).Width - Estilo.anchoLinea, Height - Font.Height - Estilo.anchoLinea);
            grf.Location = new(Width - grf.Width, 0);
            grf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Refresh();
        }

        private void grf_Paint(object sender, PaintEventArgs e)
        {
        }
        private void graficaContainer_Click(object sender, EventArgs e)
        {
        }

        private void graficaContainer_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X > Width / 2 && e.Y > grf.Height)
            {
                grf.XOffset += 1;
            }
            else if (e.X < Width / 2 && e.Y > grf.Height)
            {
                grf.XOffset -= 1;
            }
            if(e.Y < Height / 2 && e.X < grf.Location.X)
            {
                grf.Scale = new(grf.Scale.Width - 1, grf.Scale.Height - 1);
            }
            else if (e.X < Width / 2 && e.Y < grf.Height)
            {
                grf.Scale = new(grf.Scale.Width + 1, grf.Scale.Height + 1);
            }
        }

        private void grf_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int i = random.Next(13);

            Point[] buffer = new Point[i];

            for (int j = 0; j < i; j++)
            {
                int x = random.Next(grf.Scale.Width);
                int y = random.Next(grf.Scale.Height);
                buffer[j] = new(x - grf.XOffset, y - grf.YOffset);
            }

            Points = buffer;
        }
    }
}
