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
        public bool devMode { get; set; } = false;
        public bool HighlightDots
        {
            get { return grf.highlightDots;}
            set { grf.highlightDots = value;}
        }
        public bool onlyDots
        {
            get { return grf.onlyDots; }
            set { grf.onlyDots = value;}
        }
        public bool isBarGraph
        {
            get { return grf.isBarGraph; }
            set { grf.isBarGraph = value; }
        }
        public Size Scale
        {
            get { return grf.Scale; }
            set { grf.Scale = value; }
        }
        public Point[] Points
        {
            get { return grf.Points; }
            set { grf.Points = value; graficaContainer_FontChanged(this, EventArgs.Empty); }
        }
        public string XAxis
        {
            get { return xAxis; }
            set { xAxis = value; Invalidate(); }
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
            if (!grf.tmrBlend.Enabled)
            {
            }
            Region region = new(new Rectangle(new(0, 0), new(grf.Location.X, Height)));

            region.Union(new Rectangle(new(grf.Location.X, grf.Height), new(grf.Width, Height - grf.Height)));
            Invalidate(region);
        }

        private void graficaContainer_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        private void graficaContainer_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush contraste = new(Estilo.Contraste);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            Pen pen = new(Estilo.Contraste, Estilo.anchoLinea);
            pen.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawString(yAxis, Font, contraste, new Point(grf.Location.X - Estilo.anchoLinea - TextRenderer.MeasureText(yAxis.ToString(), Font).Width, 0));
            e.Graphics.DrawString(xAxis, Font, contraste, new Point(Width - TextRenderer.MeasureText(xAxis, Font).Width,  Height - Font.Height));

            //for(int i = 0; i < grf.Points.Length; i++)
            //{
            //    if (grf.realCoordsOfPoints[i].X >= 0 && grf.realCoordsOfPoints[i].X < grf.Width)
            //    {
            //        e.Graphics.DrawString(grf.Points[i].X.ToString(), Font, contraste, new PointF(grf.realCoordsOfPoints[i].X + grf.Location.X - TextRenderer.MeasureText(grf.Points[i].X.ToString(), Font).Width / 2, grf.Height + Estilo.anchoLinea));
            //    }
            //    if (grf.Points[i].Y > grf.YOffset && grf.realCoordsOfPoints[i].Y > TextRenderer.MeasureText(yAxis, Font).Height) 
            //    {
            //        e.Graphics.DrawString(grf.Points[i].Y.ToString(), Font, contraste, new PointF(grf.Location.X - Estilo.anchoLinea - TextRenderer.MeasureText(grf.Points[i].Y.ToString(), Font).Width, grf.realCoordsOfPoints[i].Y - Font.Height / 2));
            //    }
            //}

            
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pen.Alignment = PenAlignment.Right;
            e.Graphics.DrawLine(pen, new(grf.Location.X - Estilo.anchoLinea, grf.Height), new(Width, grf.Height));
            pen.Alignment = PenAlignment.Left;
            e.Graphics.DrawLine(pen, new(grf.Location.X - Estilo.medioAnchoLinea, grf.Height), new(grf.Location.X - Estilo.medioAnchoLinea, 0));

            for (int i = 1; i < 10; i++)
            {
                double x = Math.Round(grf.Scale.Width / 10d * i, 2);
                double y = Math.Round(grf.Scale.Height / 10d * i, 2);

                e.Graphics.DrawString(x.ToString(), Font, contraste, (int)(grf.Location.X + (grf.Width / 10d) * i - TextRenderer.MeasureText(x.ToString(), Font).Width / 2), grf.Height + Estilo.anchoLinea);
                e.Graphics.DrawLine(new(Estilo.contrasteLigero, Estilo.medioAnchoLinea), new Point(grf.Location.X + (grf.Width / 10) * i - Estilo.medioAnchoLinea / 2, grf.Height), new Point(grf.Location.X + (grf.Width / 10) * i - Estilo.medioAnchoLinea / 2, grf.Height + Estilo.anchoLinea + 2));

                e.Graphics.DrawString(y.ToString(), Font, contraste, new Point(grf.Location.X - Estilo.anchoLinea - TextRenderer.MeasureText(y.ToString(), Font).Width, grf.Height - (int)(grf.Height / 10d * i) - Font.Height / 2));
                e.Graphics.DrawLine(new(Estilo.contrasteLigero, Estilo.medioAnchoLinea), new Point(grf.Location.X, grf.Height - (int)(grf.Height / 10d * i) - Estilo.medioAnchoLinea / 2), new Point(grf.Location.X - Estilo.anchoLinea - 2, grf.Height - (int)(grf.Height / 10d * i) - Estilo.medioAnchoLinea / 2));
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
            Invalidate();
        }
        private void graficaContainer_Click(object sender, EventArgs e)
        {
        }

        private void graficaContainer_MouseClick(object sender, MouseEventArgs e)
        {
            //if(devMode)
            //{
            //    if (e.X > Width / 2 && e.Y > grf.Height)
            //    {
            //        grf.XOffset += 1;
            //    }
            //    else if (e.X < Width / 2 && e.Y > grf.Height)
            //    {
            //        grf.XOffset -= 1;
            //    }
            //    if (e.Y < Height / 2 && e.X < grf.Location.X)
            //    {
            //        grf.Scale = new(grf.Scale.Width - 1, grf.Scale.Height - 1);
            //    }
            //    else if (e.X < Width / 2 && e.Y < grf.Height)
            //    {
            //        grf.Scale = new(grf.Scale.Width + 1, grf.Scale.Height + 1);
            //    }
            //}
        }

        private void grf_Click(object sender, EventArgs e)
        {
            if (devMode)
            {
                Random random = new Random();

                Point[] buffer = new Point[grf.Scale.Width];

                for (int j = 0; j < grf.Scale.Width; j++)
                {
                    if(random.Next(3) == 1)
                    {
                        int y = random.Next(grf.Scale.Height);
                        buffer[j] = new(j - grf.XOffset, y - grf.YOffset);
                    }
                }

                Points = buffer;
            }
        }
    }
}
