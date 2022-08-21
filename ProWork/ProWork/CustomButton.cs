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
using System.Windows.Input;
using System.Drawing.Text;

namespace ProWork
{
    public partial class CustomButton : UserControl
    {
        private LinearGradientBrush brush;
        private bool hovered = false;
        private string texto = "Button";
        public string Texto
        {
            get { return texto; }
            set 
            { 
                texto = value;
                //SizeF size = TextRenderer.MeasureText(texto, this.Font);
                //Rectangle rect = new((int)(this.Width / 2 - size.Width / 2), this.Height / 2 - this.Size.Height / 2, (int)size.Width, (int)size.Height);
                this.Invalidate(); 
            }
        }
        public CustomButton()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            brush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(this.Width, 0),
                Estilo.enfasis,
                Estilo.degrEnfasis
                );
        }

        private void CustomButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            Pen pen;
            if (hovered) { pen = new(Estilo.Contraste, Estilo.anchoLinea); } else { pen = new(brush, Estilo.anchoLinea); }

            //Relleno
            Estilo.RellenarMarco(brush, sender, e, this.ClientRectangle);

            //Borde
            Estilo.Enmarcar(pen, sender, e, this.ClientRectangle);

            ////Texto
            
            //Formato
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            //Broche
            SolidBrush bTexto = new(Estilo.Contraste);

            //Dibujado
            e.Graphics.DrawString(texto, this.Font, bTexto, this.ClientRectangle, stringFormat);
        }

        private void CustomButton_Resize(object sender, EventArgs e)
        {
            updateBrush();
        }
        private void updateBrush()
        {
            brush = new(
                new Point(0, 0),
                new Point(this.Width, 0),
                Estilo.enfasis,
                Estilo.degrEnfasis
                );
            this.Invalidate();
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            if (!hovered)
            {
                this.hovered = true;
                this.Invalidate();
            }
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            if(hovered)
            {
                this.hovered = false;
                this.Invalidate();
            }
        }

        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (hovered)
            {
                this.hovered = false;
                this.Invalidate();
            }
        }

        private void lbl_MouseUp(object sender, MouseEventArgs e)
        {
            if (!hovered)
            {
                this.hovered = true;
                this.Invalidate();
            }
        }
        [Browsable(true)]
        [Category("Action")]
        [Description("Se invoca al hacer click. El click regular no se utiliza.")]
        public event EventHandler ButtonClick;

        protected void lbl_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(this, e);
        }
    }
}
