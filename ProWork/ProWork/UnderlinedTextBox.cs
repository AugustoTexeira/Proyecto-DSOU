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
    public partial class UnderlinedTextBox : UserControl
    {
        private decimal largo = 0;
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
            txb.ForeColor = Estilo.Contraste;
            txb.KeyPress += checkEnter;
            EnterPressed += paqnosequeje;
        }
        private void paqnosequeje (object sender, EventArgs e)
        {
            
        }

        private void checkEnter (object sender,KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EnterPressed.Invoke(this, EventArgs.Empty);
            }
        }
        public event EventHandler EnterPressed;

        private void UnderlinedTextBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (txb.Focused)
            {
                subrayar(e);
            }
            else
            {
                Pen pen = new(Estilo.Contraste, Estilo.anchoLinea);

                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                e.Graphics.DrawLine(
                    pen,
                    Estilo.medioAnchoLinea,
                    txb.Height + Estilo.medioAnchoLinea,
                    this.Width - Estilo.medioAnchoLinea - 1,
                    txb.Height + Estilo.medioAnchoLinea
                    );
            }
        }

        private void UnderlinedTextBox_Resize(object sender, EventArgs e)
        {
        }

        private void UnderlinedTextBox_Load(object sender, EventArgs e)
        {
            txb.SetBounds(Estilo.medioAnchoLinea, 0, this.Width - Estilo.anchoLinea, this.Height - Estilo.anchoLinea);
            this.BackColor = Parent.BackColor;
            this.Height = txb.Height + Estilo.anchoLinea + 1;
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
                Pen pen = new(Estilo.enfasis, Estilo.anchoLinea);

                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine(
                    pen,
                    Estilo.medioAnchoLinea,
                    txb.Height + Estilo.medioAnchoLinea,
                    this.Width - Estilo.medioAnchoLinea - 1,
                    txb.Height + Estilo.medioAnchoLinea
                    );
            }
            else
            {
                Pen pen = new(Estilo.Contraste, Estilo.anchoLinea);

                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine
                (
                    pen,
                    (int)((Width - Estilo.medioAnchoLinea - 1) * largo),
                    txb.Height + Estilo.medioAnchoLinea,
                    Width + Estilo.medioAnchoLinea - 1,
                    txb.Height + Estilo.medioAnchoLinea
                );

                pen.Color = Estilo.enfasis;
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine
                (
                    pen,
                    Estilo.medioAnchoLinea,
                    txb.Location.Y + txb.Height + Estilo.medioAnchoLinea,
                    (int)((Width - Estilo.medioAnchoLinea - 1) * largo),
                    txb.Location.Y + txb.Height + Estilo.medioAnchoLinea
                );
            }
        }
        private void InvalidateSubrayado()
        {
            Rectangle rect = new(0, txb.Height, this.Width, txb.Height + Estilo.anchoLinea);
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

        private void UnderlinedTextBox_BackColorChanged(object sender, EventArgs e)
        {
            txb.BackColor = this.BackColor;
        }

        private void UnderlinedTextBox_Layout(object sender, LayoutEventArgs e)
        {
            if (this.Height > txb.Height + Estilo.anchoLinea)
            {
                this.Height = txb.Height + Estilo.anchoLinea + 1;
            }
            txb.Location = new(Estilo.medioAnchoLinea, 0);
            txb.Width = this.Width - Estilo.anchoLinea;
            Invalidate();
        }
    }
}
