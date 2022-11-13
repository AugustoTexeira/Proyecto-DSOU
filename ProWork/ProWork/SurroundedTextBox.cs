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
            lbl.Location = new(Estilo.curva / 2, 0);
            rtb.BackColor = this.BackColor;
            EnterPressed += paqnosequeje;
        }
        private void paqnosequeje (object sender, EventArgs e)
        {

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

            Estilo.Enmarcar(pen, sender, e, new(0, lbl.Height, this.Width, this.ClientSize.Height - lbl.Height));
        }

        private void ProWorkBigText_Resize(object sender, EventArgs e)
        {
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

        private void rtb_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", e.LinkText);
        }

        private void SurroundedTextBox_Layout(object sender, LayoutEventArgs e)
        {
            lbl.Location = new(Estilo.curva / 2, 0);
            lbl.Height = this.fontTitulo.Height;
            rtb.Location = new(Estilo.curva / 2, lbl.Height + Estilo.curva / 2);
            rtb.Width = this.Width - Estilo.curva;
            rtb.Height = this.Height - Estilo.curva - lbl.Height;
            Invalidate();
        }

        private void rtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EnterPressed.Invoke(this, EventArgs.Empty);
            }
        }
        public event EventHandler EnterPressed;
    }
}
