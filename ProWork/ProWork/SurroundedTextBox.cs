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
        float largo = 0.0F;
        public Font fontTitulo
        {
            get { return lbl.Font; }
            set { lbl.Font = value; }
        }
        public string textTitulo
        {
            get { return lbl.Text; }
            set { lbl.Text = value; }
        }
        public string rtbText
        {
            [
                Category("Comportamiento")
            ]
            get { return rtb.Text; }
            set { rtb.Text = value; }
        }
        public SurroundedTextBox()
        {
            InitializeComponent();
            lbl.Location = new(Estilo.mediaCurva, 0);
            rtb.BackColor = this.BackColor;
        }   

        private void ProWorkBigText_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //Anti-Aliasing
            Pen pen;

            //Pone un color plano si no se esta hacinedo el degradado

            switch (largo)
            {
                case 0.0F:
                    pen = new(Estilo.Contraste, Estilo.anchoLinea);
                    break;
                case 1.0F:
                    pen = new(Estilo.enfasis, Estilo.anchoLinea);
                    break;
                 default:
                    LinearGradientBrush brush = new(new Point(0, lbl.Height), new Point(this.Width, this.Height), Estilo.enfasis, Estilo.Contraste);
                    Blend blend = new Blend(4);
                    blend.Factors = new float[] { 0.0F, 0.0F, 1.0F, 1.0F };
                    blend.Positions = new float[] { 0.0F, largo, largo * 1.5F, 1.0F };
                    brush.Blend = blend;
                    pen = new Pen(brush, Estilo.anchoLinea);
                    break;
            }

            //Linea superior
            e.Graphics.DrawLine(pen, Estilo.mediaCurva + Estilo.medioAnchoLinea - 1, Estilo.medioAnchoLinea + lbl.Height, this.Width - Estilo.mediaCurva - Estilo.medioAnchoLinea + 1, Estilo.medioAnchoLinea + lbl.Height);

            //Lineas medio
            e.Graphics.DrawLine(pen, Estilo.medioAnchoLinea, Estilo.mediaCurva + Estilo.medioAnchoLinea - 1 + lbl.Height, Estilo.medioAnchoLinea, this.Height - Estilo.mediaCurva - Estilo.medioAnchoLinea + 1);
            e.Graphics.DrawLine(pen, this.Width - Estilo.medioAnchoLinea, Estilo.mediaCurva + Estilo.medioAnchoLinea - 1 + lbl.Height, this.Width - Estilo.medioAnchoLinea, this.Height - Estilo.mediaCurva - Estilo.medioAnchoLinea + 1);

            //Linea inferior
            e.Graphics.DrawLine(pen, Estilo.mediaCurva + Estilo.medioAnchoLinea - 1, this.Height - Estilo.medioAnchoLinea, this.Width - Estilo.mediaCurva - Estilo.medioAnchoLinea + 1, this.Height - Estilo.medioAnchoLinea);

            //Por ahora solo copie los "DrawArc"

            //pen.Color = Color.FromArgb(128, 255, 0, 0);

            //Superior izquierda (No cambien "curva" por 0)
            e.Graphics.DrawArc(pen, Estilo.medioAnchoLinea, Estilo.medioAnchoLinea + lbl.Height, Estilo.curva, Estilo.curva, 180, 90);

            //Superior derecha
            e.Graphics.DrawArc(pen, this.Width - Estilo.curva - Estilo.medioAnchoLinea, Estilo.medioAnchoLinea + lbl.Height, Estilo.curva, Estilo.curva, 270, 90);

            //Inferior izquierda
            e.Graphics.DrawArc(pen, Estilo.medioAnchoLinea, this.Height - Estilo.curva - Estilo.medioAnchoLinea, Estilo.curva, Estilo.curva, 90, 90);

            //Inferior derecha
            e.Graphics.DrawArc(pen, this.Width - Estilo.curva - Estilo.medioAnchoLinea, this.Height - Estilo.curva - Estilo.medioAnchoLinea, Estilo.curva, Estilo.curva, 0, 90);
        }

        private void ProWorkBigText_Resize(object sender, EventArgs e)
        {
            lbl.Location = new(Estilo.mediaCurva, 0);
            rtb.Location = new(Estilo.mediaCurva, lbl.Height + Estilo.mediaCurva);
            rtb.Width = this.Width - Estilo.curva;
            rtb.Height = this.Height - Estilo.curva - lbl.Height;
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

        private void SurroundedTextBox_Load(object sender, EventArgs e)
        {
            this.BackColor = Parent.BackColor;
            rtb.BackColor = Parent.BackColor;
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            rtb.Focus();
        }
    }
}
