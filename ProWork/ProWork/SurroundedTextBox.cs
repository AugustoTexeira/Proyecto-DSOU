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
    public partial class SurroundedTextBox : UserControl
    {
        Pen pen;
        private int ancho = 6;
        public int ma = 3;
        float largo = 0.0F;
        private string tex = "Placeholder";
        public Font Titulo
        {
            get { return lbl.Font; }
            set { lbl.Font = value; }
        }
        public int Ancho
        {
            get { return ancho / 2; }
            set 
            {
                    ancho = value * 2; ma = value;
                    this.Invalidate();
            }
        }
        public string Tex
        {
            get { return tex; }
            set 
            {
                tex = value.ToString();
                lbl.Text = tex;
            }
        }
        public string rtbText
        {
            [
                Category("Comportamiento")
            ]
            get { return rtb.Text; }
            set { rtb.Text = value; }
        }

        private int curva = 40;
        private int mc = 20;
        public SurroundedTextBox()
        {
            InitializeComponent();
            lbl.Location = new(mc, 0);
            rtb.BackColor = this.BackColor;
        }   

        private void ProWorkBigText_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //Anti-Aliasing
            int ma = ancho / 2; //Es la mitad del ancho, creo.
            pen = new Pen(Estilo.Contraste, ma);

            //Pone un color plano si no se esta hacinedo el degrade

            switch (largo)
            {
                case 0.0F:
                    pen.Color = Estilo.Contraste;
                    break;
                case 1.0F:
                    pen.Color = Estilo.enfasis;
                    break;
                 default:
                    LinearGradientBrush brush = new(new Point(0, lbl.Height), new Point(this.Width, this.Height), Estilo.enfasis, Estilo.Contraste);
                    Blend blend = new Blend(4);
                    blend.Factors = new float[] { 0.0F, 0.0F, 1.0F, 1.0F };
                    blend.Positions = new float[] { 0.0F, largo, largo * 1.5F, 1.0F };
                    brush.Blend = blend;
                    pen = new Pen(brush, ma);
                    break;
            }

            //Copie solo las lineas del CustomButton

            //Linea superior
            e.Graphics.DrawLine(pen, mc + ma - 1, ma + lbl.Height, this.Width - mc - 1 , ma + lbl.Height);

            //Lineas medio
            e.Graphics.DrawLine(pen, ma, mc + lbl.Height, ma, this.Height - mc);
            e.Graphics.DrawLine(pen, this.Width - ma, mc + 1 + lbl.Height, this.Width - ma, this.Height - mc + 1);

            //Linea inferior
            e.Graphics.DrawLine(pen, mc, this.Height - ma, this.Width - mc, this.Height - ma);

            //Por ahora solo copie los "DrawArc"

            //pen.Color = Color.FromArgb(128, 255, 0, 0);

            //Superior izquierda (No cambien "curva" por 0)
            e.Graphics.DrawArc(pen, ma, ma + lbl.Height, curva, curva, 180, 90);

            //Superior derecha
            e.Graphics.DrawArc(pen, this.Width - curva - ma, ma + lbl.Height, curva, curva, 270, 90);

            //Inferior izquierda
            e.Graphics.DrawArc(pen, ma, this.Height - curva - ma, curva, curva, 90, 90);

            //Inferior derecha
            e.Graphics.DrawArc(pen, this.Width - curva - ma, this.Height - curva - ma, curva, curva, 0, 90);
        }

        private void ProWorkBigText_Resize(object sender, EventArgs e)
        {
            lbl.Location = new(mc, 0);
            rtb.Location = new(curva / 2, lbl.Height + curva / 2);
            rtb.Width = this.Width - curva;
            rtb.Height = this.Height - curva - lbl.Height;
        }

        private void tmrSurayado_Tick(object sender, EventArgs e)
        {
            if (largo < (float)0.995)
            {
                largo += (1 - largo) / 10;

                this.Invalidate();
            }
            else
            {
                largo = 1;

                this.Invalidate();

                tmrSurayado.Stop();
            }
        }

        private void ProWorkBigText_Click(object sender, EventArgs e)
        {
            rtb.Focus();
        }

        private void rtb_Enter(object sender, EventArgs e)
        {
            tmrSurayadont.Stop();
            tmrSurayado.Start();
        }

        private void rtb_Leave(object sender, EventArgs e)
        {
            tmrSurayado.Stop();
            tmrSurayadont.Start();
        }

        private void tmrSurayadont_Tick(object sender, EventArgs e)
        {
            if (largo > (float)0.005)
            {
                largo -= largo / 5;

                this.Invalidate();
            }
            else
            {
                largo = 0;

                this.Invalidate();

                tmrSurayadont.Stop();
            }
        }

        private void ProWorkBigText_FontChanged(object sender, EventArgs e)
        {
            rtb.Font = this.Font;
        }
    }
}
