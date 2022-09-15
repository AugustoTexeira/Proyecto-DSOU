using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProWork
{
    public partial class ControlCuentas : UserControl
    {
        /* BUGS:
         * Al reducir el tamanio del control la scrollbar no se ve apropiadamente.
         * 
         * POR HACER:
         * Anadir manipulacion de scrollbar
         * Devolver el item clicado
         */
        private List<string> lista = new List<string>();

        private float aimShift = 0;
        private float shift = 0;
        private float vSpeed;
        private int mY; // Coordenada 'Y' del mouse; altura
        private int mX; // Corrdenada 'X' del mouse
        private bool hovered = false;
        private bool scrollHovered = false;
        private bool held = false;
        private bool released = false;
        public ControlCuentas()
        {
            InitializeComponent();
        }

        private void ControlCuentas_Load(object sender, EventArgs e)
        {
            this.BackColor = Parent.BackColor;
            lista.Add("Juan");
            lista.Add("Pintos");
            lista.Add("Victoria");
            lista.Add("Lucas Silva");
            lista.Add("Juan");
            lista.Add("Pintos");
            lista.Add("Victoria");
            lista.Add("Lucas Silva");
            lista.Add("Juan");
            lista.Add("Pintos");
            lista.Add("Victoria");
            lista.Add("Lucas Silva");
            lista.Add("Juan");
            lista.Add("Pintos");
            lista.Add("Victoria");
            lista.Add("Lucas Silva");
            lista.Add("Juan");
            lista.Add("Pintos");
            lista.Add("Victoria");
            lista.Add("Lucas Silva");
            lista.Add("Juan");
            lista.Add("Pintos");
            lista.Add("Victoria");
            lista.Add("Lucas Silva");
            lista.Add("Juan");
            lista.Add("Pintos");
            lista.Add("Victoria");
            lista.Add("Lucas Silva");
            lista.Add("Juan");
            lista.Add("Pintos");
            lista.Add("Victoria");
            lista.Add("Lucas Silva");
        }

        private void ControlCuentas_Paint(object sender, PaintEventArgs e)
        {
            //Estilo
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            Pen pen = new(Estilo.contrasteLigero, Estilo.anchoLinea);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            //Lista

           for (int i = 0; i < lista.Count; i++)
            {
                if(hovered)
                {
                    if (mY >= (i - 1) * this.Font.Height - shift && mY < (i + 1) * this.Font.Height - shift && !scrollHovered)
                    {
                        pen.Color = Estilo.enfasis;
                        e.Graphics.DrawLine(pen, Estilo.medioAnchoLinea, i * this.Font.Height + Estilo.medioAnchoLinea - shift, this.Width - Estilo.anchoLinea * 12, Estilo.medioAnchoLinea + i * this.Font.Height - shift);
                        pen.Color = Estilo.contrasteLigero;
                    }
                    else
                    {
                        e.Graphics.DrawLine(pen, Estilo.medioAnchoLinea, i * this.Font.Height + Estilo.medioAnchoLinea - shift, this.Width - Estilo.anchoLinea * 12, Estilo.medioAnchoLinea + i * this.Font.Height - shift);
                    }
                }
                else
                {
                    e.Graphics.DrawLine(pen, Estilo.medioAnchoLinea, i * this.Font.Height + Estilo.medioAnchoLinea - shift, this.Width - Estilo.anchoLinea * 12, Estilo.medioAnchoLinea + i * this.Font.Height - shift);
                }
                e.Graphics.DrawString("Nombre: " + lista[i], this.Font, new SolidBrush(Estilo.Contraste), Estilo.medioAnchoLinea, i * this.Font.Height - shift);
            }

            if (mY >= (lista.Count - 1) * this.Font.Height - shift && mY < (lista.Count) * this.Font.Height - shift) 
            { 
                pen.Color = Estilo.enfasis;
            }
            e.Graphics.DrawLine(pen, Estilo.medioAnchoLinea, lista.Count * this.Font.Height + Estilo.medioAnchoLinea - shift, this.Width - Estilo.anchoLinea * 12, Estilo.medioAnchoLinea + lista.Count * this.Font.Height - shift);


            //Scrollbar
            if (lista.Count * this.Font.Height > this.Height)
            {
                pen.Color = Estilo.Contraste;

                if (scrollHovered)
                {
                    pen.Width = (float)(Estilo.anchoLinea * 2.5);
                }
                else
                {
                    pen.Width = Estilo.anchoLinea * 2;
                }

                float uplim = 0; //UpperLimit
                float lwLim = 0; //LowerLimit
                float scbHeight = 1;

                if (this.Height / (lista.Count * this.Font.Height / shift) + this.Height * this.Height / ((lista.Count + 2) * this.Font.Height) > this.Height)
                {
                    lwLim = this.Height - (this.Height / (lista.Count * this.Font.Height / shift) + this.Height * this.Height / ((lista.Count + 2) * this.Font.Height));
                }

                if (this.Height / (lista.Count * this.Font.Height / shift) < uplim)
                {
                    uplim = this.Height / (lista.Count * this.Font.Height / shift);
                }

                if (this.Height * this.Height / ((lista.Count + 2) * this.Font.Height) - Estilo.anchoLinea * 4 > 1)
                {
                    scbHeight = this.Height * this.Height / ((lista.Count + 2) * this.Font.Height) - Estilo.anchoLinea * 4;
                }

                e.Graphics.DrawLine(
                    pen,
                    this.Width - Estilo.anchoLinea * 6, //x1
                    Estilo.medioAnchoLinea * 4 + this.Height / (lista.Count * this.Font.Height / shift) - //y1
                    uplim, //En caso de que la scrollbar fuese a salirse de pantalla, reduzco su tamanio para evitarlo
                    this.Width - Estilo.anchoLinea * 6, //x2
                    this.Height / (lista.Count * this.Font.Height / shift) +  //le aniado y1 a y2
                    scbHeight + lwLim); //(lwLim)En caso de que la scrollbar fuese a salirse de pantalla, reduzco su tamanio para evitarlo
            }
            

            ////Testing stats

            e.Graphics.DrawString(
                "shift: " + shift.ToString() + "\n" +
            //    "mY: " + mY.ToString() + "\n" +
                "aimShift: " + aimShift.ToString() + "\n"
                 //    "vSpeed: " + vSpeed.ToString() + "\n"
                 //  "y1: " + (this.Height / (lista.Count * this.Font.Height / shift)).ToString() + "\n" +
                 //  "y2: " + (this.Height * this.Height / ((lista.Count + 2) * this.Font.Height)).ToString() + "\n" +
                 //"height: " + this.Height.ToString() + "\n" +
                 //"coso: " + (this.Height / (lista.Count * this.Font.Height / shift) + this.Height * this.Height / ((lista.Count + 2) * this.Font.Height)).ToString() + "\n" +
                 //  "y2: " + (lista.Count * this.Font.Height).ToString()
                 //"lwlim: " + (this.Height - (this.Height / (lista.Count * this.Font.Height / shift) + this.Height * this.Height / ((lista.Count + 2) * this.Font.Height))).ToString()
                 //"%shift: " + (shift % this.Font.Height).ToString()
                ,
                this.Font, new SolidBrush(Color.Red), 0, 0);
        }

        private void ControlCuentas_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void tmrScroll_Tick(object sender, EventArgs e)
        {
            if (shift <= aimShift + 1 && aimShift - 1 <= shift)
            {
                shift = aimShift;
                this.Refresh();
                tmrScroll.Stop();
            }
            else
            {
                shift += (aimShift - shift) / 5;
                this.Refresh();
            }
        }

        private void ControlCuentas_Click(object sender, EventArgs e)
        {
        }

        

        private void ControlCuentas_MouseEnter(object sender, EventArgs e)
        {
            hovered = true;
            this.Refresh();
        }

        private void ControlCuentas_MouseLeave(object sender, EventArgs e)
        {
            hovered = false;
            scrollHovered = false;
            this.Refresh();
        }

        private void ControlCuentas_MouseDown(object sender, MouseEventArgs e)
        {
            tmrScroll.Stop();
            tmrDragScroll.Stop();
            held = true;
            this.Refresh();
        }

        private void ControlCuentas_MouseUp(object sender, MouseEventArgs e)
        {
            held = false;
            released = true;
        }
        private void ControlCuentas_MouseMove(object sender, MouseEventArgs e)
        {
            if (held)
            {
                if(!scrollHovered)
                {
                    if (shift < 0 && mY - e.Y < 0)
                    {
                        shift -= (float)(Math.Log(Math.Abs(e.Y), 1.015)) - (float)Math.Log(Math.Abs(mY), 1.015);
                    }
                    else if (shift > shiftAltura() && mY - e.Y > 0)
                    {
                        shift += (float)Math.Log(Math.Abs(e.Y - shiftAltura()), 1.015) - (float)Math.Log(Math.Abs(mY - shiftAltura()), 1.015);
                    }
                    else
                    {
                        shift += mY - e.Y;
                    }
                }
                else
                {
                    aimShift += (e.Y * 100 / this.Height) * shiftAltura() ;
                    tmrScroll.Start();
                }
            }
            if (released)
            {
                if (!scrollHovered)
                {
                    if (mY - e.Y != 0)
                    {
                        shift += mY - e.Y;
                        vSpeed = mY - e.Y;
                        tmrDragScroll.Start();
                    }
                    else if (shift > shiftAltura())
                    {
                        aimShift = shiftAltura();
                        tmrScroll.Start();
                    }
                    else if (shift < 0)
                    {
                        aimShift = 0;
                        tmrScroll.Start();
                    }
                    else
                    {
                        aimShift = (int)shift;

                        if (shift % this.Font.Height < this.Font.Height / 2)
                        {
                            while (aimShift % this.Font.Height != 0)
                            {
                                aimShift--;
                            }
                        }
                        else
                        {
                            while (aimShift % this.Font.Height != 0)
                            {
                                aimShift++;
                            }
                        }

                        tmrScroll.Start();
                    }
                }
                else
                {

                }
                released = false;
            }

            if (e.X > this.Width - Estilo.anchoLinea * 12)
            {
                if (!scrollHovered)
                {
                    scrollHovered = true;
                    this.Refresh();
                }
            }
            else if (scrollHovered)
            {
                scrollHovered = false;
                this.Refresh();
            }
            
            if (!tmrDragScroll.Enabled && !tmrScroll.Enabled && (held || released || Math.Ceiling((double)(mY / this.Font.Height)) != Math.Ceiling((double)(e.Y / this.Font.Height))))
            {
                this.Refresh();
            }

            mY = e.Y;
            mX = e.X;
        }

        private void tmrDragScroll_Tick(object sender, EventArgs e)
        {
            if (vSpeed >= -1 && vSpeed < 0)
            {
                aimShift = shift;

                if (aimShift < 0)
                {
                    aimShift = 0;
                }

                aimShift = (int)aimShift;

                while (aimShift % this.Font.Height != 0)
                {
                    aimShift--;
                }
                tmrDragScroll.Stop();
                tmrScroll.Start();
            }
            else if (vSpeed > 0 && vSpeed <= 1)
            {
                aimShift = shift;

                if (aimShift > shiftAltura())
                {
                    aimShift = shiftAltura();
                }

                aimShift = (int)aimShift;

                while (aimShift % this.Font.Height != 0)
                {
                    aimShift++;
                }
                tmrDragScroll.Stop();
                tmrScroll.Start();
            }
            else
            {
                if (shift < 0 || shift > shiftAltura())
                {
                    shift += (float)Math.Log(Math.Abs(vSpeed)) * Math.Sign(vSpeed);
                    vSpeed -= vSpeed / 3;
                }
                else
                {
                    shift += vSpeed;
                    vSpeed -= Math.Sign(vSpeed);
                }
            }
            this.Refresh();
        }
        private int shiftAltura ()
        {
            return lista.Count * this.Font.Height - this.Height;
        }
    }
}
