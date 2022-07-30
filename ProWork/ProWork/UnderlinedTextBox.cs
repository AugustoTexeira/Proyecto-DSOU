using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoCustoTextBox
{
    public partial class UnderlinedTextBox : UserControl
    {
        private Color contraste = Color.Black;
        private Color enfasis = Color.Blue;
        public Color Contraste
        {
            get { return contraste; }
            set { contraste = value; txb.ForeColor = value; }
        }
        public Color Enfasis
        {
            get { return enfasis; }
            set { enfasis = value; }
        }
        private int ancho = 5;
        public int Ancho
        {
            get { return ancho; }
            set
            {
                ancho = value;
                this.Height = txb.Height + ancho;
                InvalidateSubrayado();
            }
        }
        decimal largo = 0;
        public string PlaceholderText
        {
            [
                Category("Comportamiento")
            ]
            get { return txb.PlaceholderText; }
            set { txb.PlaceholderText = value; }
        }
        public string txbText
        {
            [
                Category("Comportamiento")
            ]
            get { return txb.Text; }
            set { txb.Text = value; }
        }
        public bool UsePasswordChar
        {
            get { return txb.UseSystemPasswordChar; }
            set { txb.UseSystemPasswordChar = value; }
        }
        public UnderlinedTextBox()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void UnderlinedTextBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (txb.Focused)
            {
                subrayar(e);
            }
            else
            {
                Pen pen = new(contraste, ancho);

                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                e.Graphics.DrawLine(
                    pen,
                    ancho / 2,
                    txb.Height + ancho / 2,
                    this.Width - ancho / 2 - 1,
                    txb.Height + ancho / 2
                    );
            }
        }

        private void UnderlinedTextBox_Resize(object sender, EventArgs e)
        {
            if (this.Height > txb.Height)
            {
                ancho = this.Height - txb.Height;
            }
            txb.Location = new(ancho / 2, 0);
            txb.Width = this.Width - ancho;
        }

        private void UnderlinedTextBox_Load(object sender, EventArgs e)
        {
            txb.SetBounds(ancho / 2, 0, this.Width - ancho, this.Height - ancho);
            this.BackColor = Parent.BackColor;
            txb.BackColor = Parent.BackColor;
        }

        private void tmrSubrayado_Tick(object sender, EventArgs e)
        {
            if (largo < (decimal)0.995)
            {
                largo += decimal.Round((1 - largo) / 3, 4);

                InvalidateSubrayado();
            }
            else
            {
                largo = 1;

                InvalidateSubrayado();

                tmrSubrayado.Stop();
            }
        }
        void subrayar(PaintEventArgs e)
        {
            if (largo == 1)
            {
                Pen pen = new(enfasis, ancho);

                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine(
                    pen,
                    ancho / 2,
                    txb.Height + ancho / 2,
                    this.Width - ancho / 2 - 1,
                    txb.Height + ancho / 2
                    );
            }
            else
            {
                Pen pen = new(contraste, ancho);

                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine
                (
                    pen,
                    (int)((txb.Width + ancho / 2 - 1) * largo),
                    txb.Height + ancho / 2,
                    txb.Width + ancho / 2 - 1,
                    txb.Height + ancho / 2
                );

                pen.Color = enfasis;
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine
                (
                    pen,
                    ancho / 2,
                    txb.Location.Y + txb.Height + ancho / 2,
                    (int)((txb.Width + ancho / 2 - 1) * largo),
                    txb.Location.Y + txb.Height + ancho / 2
                );
            }
        }
        private void InvalidateSubrayado()
        {
            Rectangle rect = new(0, txb.Height, this.Width, txb.Height + ancho);
            this.Invalidate(rect);
        }

        private void txb_Enter(object sender, EventArgs e)
        {
            largo = 0;

            tmrSubrayado.Start();
        }

        private void txb_Leave(object sender, EventArgs e)
        {
            tmrSubrayado.Stop();

            InvalidateSubrayado();
        }

        private void UnderlinedTextBox_Enter(object sender, EventArgs e)
        {
            txb.Focus();
        }

        private void UnderlinedTextBox_FontChanged(object sender, EventArgs e)
        {
            txb.Font = this.Font;
        }
    }
}
