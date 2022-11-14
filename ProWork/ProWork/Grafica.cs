using System.Collections;
using System.Drawing.Drawing2D;

namespace ProWork
{
    public partial class Grafica : UserControl
    {
        public bool highlightDots { get; set; } = false;
        public bool onlyDots { get; set; } = false;
        private LinearGradientBrush brush;
        private bool ibg = false;
        public bool isBarGraph
        {
            get { return ibg; }
            set { ibg = value; Invalidate(); }
        }
        private int xOffset = 0;
        private int yOffset = 0;
        public int XOffset
        {
            get { return xOffset; }
            set
            {
                xOffset = value;
                if (!tmrBlend.Enabled)
                {
                    tmrBlend.Start();
                }
            }
        }
        public int YOffset
        {
            get { return yOffset; }
            set
            {
                xOffset = value;
                if (!tmrBlend.Enabled)
                {
                    tmrBlend.Start();
                }
            }
        }


        private Point[] rc;
        public Point[] realCoordsOfPoints
        {
            get { return rc; }
            set
            {
                rc = value;
                if (realCoordsOfPointsChanged != null)
                {
                    realCoordsOfPointsChanged.Invoke(this, EventArgs.Empty);
                }
            }
        }
        public event EventHandler realCoordsOfPointsChanged;
        private Point[] originalPoints;
        public Point[] Points
        {
            get { return originalPoints; }
            set
            {
                if (value.Length == 0) { return; }
                originalPoints = value;
                Array.Sort(originalPoints, new xComparer());


                if (rc == null)
                {
                    realCoordsOfPoints = new Point[Points.Length];
                    for (int i = 0; i < Points.Length; i++)
                    {
                        realCoordsOfPoints[i] = new((int)((double)Points[i].X * Width / Scale.Width), Height);
                    }
                    if (!tmrBlend.Enabled)
                    {
                        tmrBlend.Start();
                    }
                    return;
                }
                if (rc.Length < originalPoints.Length)
                {
                    Point[] buffer = new Point[value.Length];
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (i < rc.Length)
                        {
                            buffer[i] = rc[i];
                        }
                        else if(rc.Length != 0) 
                        {
                            buffer[i] = rc.Last();
                        }
                    }
                    rc = buffer;
                }
                if (!tmrBlend.Enabled)
                {
                    tmrBlend.Start();
                }
            }
        }
        private Size scale = new(10, 10);
        public new Size Scale
        {
            get { return scale; }
            set
            {
                
                if (value.Width < 1)
                {
                    value.Width = 1;
                }
                if (scale.Height < 1)
                {
                    value.Height = 1;
                }
                scale = value;

                if (Points != null)
                {
                    int yscale = Height / Scale.Height;
                    int xscale = Width / Scale.Width;
                    Point[] aimPoints = new Point[Points.Length];

                    for (int i = 0; i < realCoordsOfPoints.Length; i++)
                    {
                        if (aimPoints.Length > i)
                        {
                            aimPoints[i] = new((Points[i].X + xOffset) * xscale, Height - (Points[i].Y + yOffset) * yscale);
                        }
                    }
                }
                if (!tmrBlend.Enabled)
                {
                    tmrBlend.Start();
                }
            }
        }
        private bool downwards = false;
        public bool Downwards
        {
            get { return downwards; }
            set
            {
                downwards = value;
                Grafica_Layout(this, null);
            }
        }
        public Grafica()
        {
            InitializeComponent();
            Points = new Point[] { new(0, 0) };
            Scale = new(1, 1);
        }

        private void Grafica_Paint(object sender, PaintEventArgs e)
        {
            Pen dottedPen = new(Color.FromArgb(64, Estilo.Contraste.R, Estilo.Contraste.G, Estilo.Contraste.B), 1);
            dottedPen.DashStyle = DashStyle.Solid;
            if (onlyDots)
            {
                foreach (Point point in realCoordsOfPoints)
                {
                    e.Graphics.DrawLine(dottedPen, new(0, point.Y), point);
                    e.Graphics.DrawLine(dottedPen, new(point.X, Height), point);
                }
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                foreach (Point point in realCoordsOfPoints)
                {
                    e.Graphics.FillEllipse(new SolidBrush(Estilo.Contraste), new(new Point(point.X - Estilo.anchoLinea, point.Y - Estilo.anchoLinea), new(Estilo.anchoLinea * 2, Estilo.anchoLinea * 2)));
                }
                return;
            }
            if (realCoordsOfPoints != null && realCoordsOfPoints.Length > 1)
            {
                GraphicsPath path = new GraphicsPath();
                int xscale = Width / Scale.Width;

                if (isBarGraph)
                {
                    foreach (Point point in realCoordsOfPoints)
                    {

                        path.AddRectangle(new Rectangle(point.X, point.Y, xscale, Height - point.Y));
                    }

                    e.Graphics.FillPath(brush, path);

                    foreach (Point point in realCoordsOfPoints)
                    {
                        e.Graphics.DrawLine(dottedPen, new(0, point.Y), point);
                    }
                    e.Graphics.DrawPath(new(Estilo.Contraste, Estilo.medioAnchoLinea), path);
                }
                else
                {
                    path.AddLines(realCoordsOfPoints);
                    path.AddLine(realCoordsOfPoints.Last(), new(realCoordsOfPoints.Last().X, Height));
                    path.AddLine(new(realCoordsOfPoints.Last().X, Height), new(realCoordsOfPoints[0].X, Height));

                    e.Graphics.FillPath(brush, path);

                    if (highlightDots)
                    {
                        foreach (Point point in realCoordsOfPoints)
                        {
                            e.Graphics.DrawLine(dottedPen, new(0, point.Y), point);
                            e.Graphics.DrawLine(dottedPen, new(point.X, Height), point);
                        }
                        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        foreach (Point point in realCoordsOfPoints)
                        {
                            e.Graphics.FillEllipse(new SolidBrush(Estilo.Contraste), new(new Point(point.X - Estilo.anchoLinea, point.Y - Estilo.anchoLinea), new(Estilo.anchoLinea * 2, Estilo.anchoLinea * 2)));
                        }
                    }


                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    e.Graphics.DrawPath(new(Color.White, Estilo.medioAnchoLinea), path);
                }
            }
        }

        private void Grafica_Layout(object sender, LayoutEventArgs e)
        {
            if (ClientSize.Height != 0)
            {
                brush = new(new(0, ClientSize.Height), new(0, 0), Color.FromArgb(Estilo.degrEnfasis.R, Estilo.degrEnfasis.G, Estilo.degrEnfasis.B), Estilo.enfasis);
            }
            tmrBlend.Start();
        }

        private void tmrBlend_Tick(object sender, EventArgs e)
        {
            double yscale = (double)Height / Scale.Height;
            double xscale = (double)Width / Scale.Width;
            Point[] aimPoints = new Point[Points.Length];
            int contador = 0;

            for (int i = 0; i < realCoordsOfPoints.Length; i++)
            {
                if (aimPoints.Length > i)
                {
                    aimPoints[i] = new((int)(((Points[i].X + xOffset) * (double)xscale)), (int)(Height - (Points[i].Y + yOffset) * (double)yscale));

                    if (realCoordsOfPoints[i].Y <= aimPoints[i].Y + 3 && realCoordsOfPoints[i].Y >= aimPoints[i].Y - 3 && realCoordsOfPoints[i].X <= aimPoints[i].X + 3 && realCoordsOfPoints[i].X >= aimPoints[i].X - 3)
                    {
                        contador++;
                    }
                }
                else
                {
                    if (realCoordsOfPoints[i].Y <= aimPoints.Last().Y + 3 && realCoordsOfPoints[i].Y >= aimPoints.Last().Y - 3 && realCoordsOfPoints[i].X <= aimPoints.Last().X + 3 && realCoordsOfPoints[i].X >= aimPoints.Last().X - 3)
                    {
                        contador++;
                    }
                }
            }

            if (contador >= realCoordsOfPoints.Length)
            {
                tmrBlend.Stop();
                realCoordsOfPoints = aimPoints;
                Invalidate();
            }
            else
            {
                Point[] buffer = realCoordsOfPoints;
                for (int i = 0; i < realCoordsOfPoints.Length; i++)
                {
                    if (i < Points.Length)
                    {
                        buffer[i] = new((int)(realCoordsOfPoints[i].X + (aimPoints[i].X - realCoordsOfPoints[i].X) / 3d), (int)(realCoordsOfPoints[i].Y + (aimPoints[i].Y - realCoordsOfPoints[i].Y) / 3d));
                    }
                    else
                    {
                        buffer[i] = new((int)(realCoordsOfPoints[i].X + (aimPoints.Last().X - realCoordsOfPoints[i].X) / 3d), (int)(realCoordsOfPoints[i].Y + (aimPoints.Last().Y - realCoordsOfPoints[i].Y) / 3d));
                    }
                }
                realCoordsOfPoints = buffer;
                Invalidate();
            }
        }
    }
    public class xComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Point)x).X - ((Point)y).X;
        }
    }
}
