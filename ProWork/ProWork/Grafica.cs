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
using System.Collections;

namespace ProWork
{
    public partial class Grafica : UserControl
    {
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
                        realCoordsOfPoints[i] = new(Points[i].X * Width / Scale.Width, Height);
                    }
                    if (!tmrBlend.Enabled)
                    {
                        tmrBlend.Start();
                    }
                    return;
                }
                if(rc.Length < originalPoints.Length)
                {
                    Point[] buffer = new Point[value.Length];
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (i < rc.Length)
                        {
                            buffer[i] = rc[i];
                        }
                        else
                        {
                            buffer[i] = rc.Last();
                        }
                    }
                    rc = buffer;

                }
                if(!tmrBlend.Enabled)
                {
                    tmrBlend.Start();
                }
            }
        }
        private Size scale;
        public new Size Scale
        {
            get { return scale; }
            set
            {
                scale = value;

                if (scale.Width < 1)
                {
                    scale.Width = 1;
                }
                if(scale.Height < 1)
                {
                    scale.Height = 1;
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
            Scale = new(15, 15);
            Points = new Point[2] { new(0, 0), new(5, 0), };
        }

        private void Grafica_Paint(object sender, PaintEventArgs e)
        {
            if(realCoordsOfPoints != null && realCoordsOfPoints.Length > 1 && Scale != null)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                GraphicsPath path = new GraphicsPath();


                float maxHeight = 0;
                //float minHeight = Height;

                foreach (Point point in Points)
                {
                    if (Height - point.Y > maxHeight) { maxHeight = Height - point.Y; }
                    //if (Height - point.Y < minHeight) { minHeight = Height - point.Y; }
                }
                //minHeight /= Height;
                maxHeight /= Height;

                LinearGradientBrush brush = new(new(0, Height), new(0, 0), Color.FromArgb(128, Estilo.degrEnfasis.R, Estilo.degrEnfasis.G, Estilo.degrEnfasis.B), Estilo.enfasis);

                Blend blend = new(4);
                blend.Factors = new float[] { 0, 1, 0 };
                blend.Positions = new float[] { 0, maxHeight, 1 };

                brush.Blend = blend;

                path.AddLines(realCoordsOfPoints);
                path.AddLine(realCoordsOfPoints.Last(), new(realCoordsOfPoints.Last().X, Height));
                path.AddLine(new(realCoordsOfPoints.Last().X, Height), new(realCoordsOfPoints[0].X, Height));

                e.Graphics.FillPath(brush, path);



                Pen dottedPen = new(Color.FromArgb(64, Estilo.Contraste.R, Estilo.Contraste.G, Estilo.Contraste.B), Estilo.medioAnchoLinea);
                dottedPen.DashStyle = DashStyle.Dash;

                foreach (Point point in realCoordsOfPoints)
                {
                    e.Graphics.DrawLine(dottedPen, new(0, point.Y), point);
                    e.Graphics.DrawLine(dottedPen, new(point.X, Height), point);
                }


                e.Graphics.DrawLines(new(Estilo.Contraste, Estilo.medioAnchoLinea), realCoordsOfPoints);
                foreach (Point point in realCoordsOfPoints)
                {
                    e.Graphics.FillEllipse(new SolidBrush(Estilo.Contraste), new(new Point(point.X - Estilo.medioAnchoLinea * 3, point.Y - Estilo.medioAnchoLinea * 3), new(Estilo.anchoLinea * 3, Estilo.anchoLinea * 3)));
                }
            }
        }

        private void Grafica_Layout(object sender, LayoutEventArgs e)
        {
            Refresh();
        }

        private void tmrBlend_Tick(object sender, EventArgs e)
        {
            int yscale = Height / Scale.Height;
            int xscale = Width / Scale.Width;
            Point[] aimPoints = new Point[Points.Length];

            int contador = 0;

            for (int i = 0; i < realCoordsOfPoints.Length; i++)
            {
                if(aimPoints.Length > i)
                {
                    aimPoints[i] = new((Points[i].X + xOffset) * xscale, Height - (Points[i].Y + yOffset) * yscale);

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
                if (!(realCoordsOfPoints[0].Y <= aimPoints[0].Y + 3) || !(realCoordsOfPoints[0].Y >= aimPoints[0].Y - 3))
                {
                    MessageBox.Show("Que");
                }
                realCoordsOfPoints = aimPoints;
                Refresh();
                tmrBlend.Stop();
            }
            else
            {
                Point[] buffer = realCoordsOfPoints;
                for (int i = 0; i < realCoordsOfPoints.Length; i++)
                {
                    if(i < Points.Length)
                    {
                        buffer[i] = new((int)(realCoordsOfPoints[i].X + (aimPoints[i].X - realCoordsOfPoints[i].X) / 3d), (int)(realCoordsOfPoints[i].Y + (aimPoints[i].Y - realCoordsOfPoints[i].Y) / 3d));
                    }
                    else
                    {
                        buffer[i] = new((int)(realCoordsOfPoints[i].X + (aimPoints.Last().X - realCoordsOfPoints[i].X) / 3d), (int)(realCoordsOfPoints[i].Y + (aimPoints.Last().Y - realCoordsOfPoints[i].Y) / 3d));
                    }
                }
                realCoordsOfPoints = buffer;
                Refresh();
            }
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
