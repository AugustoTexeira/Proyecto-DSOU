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

        private int curva = 40;
        private float mc = 20;
        public int Curva
        {
            get { return curva; }
            set { curva = value; mc = value / 2; }
        }
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
            

            Pen pen;
            if (hovered) { pen = new(Estilo.Contraste, 2); } else { pen = new(brush, 2); }

            ////Rectangulos

            //Superior
            e.Graphics.FillRectangle(brush, mc - 1, 0, this.Width - curva + 2, mc);
            e.Graphics.DrawLine(pen, mc, 0, this.Width - mc, 0);

            //Medio
            e.Graphics.FillRectangle(brush, 0, mc - 1,this.Width, this.Height - curva + 2);
            e.Graphics.DrawLine(pen, 0, mc, 0, this.Height - mc);
            e.Graphics.DrawLine(pen, this.Width - 1, mc, this.Width - 1, this.Height - mc);

            //Inferior
            e.Graphics.FillRectangle(brush, mc - 1, this.Height - mc,  this.Width - curva + 2, mc);
            e.Graphics.DrawLine(pen, mc, this.Height - 1, this.Width - mc, this.Height - 1);

            ////Esquinas
            
            //Superior izquierda
            e.Graphics.FillPie(brush, 0, 0, curva - 1, curva - 1, 180, 90);
            e.Graphics.DrawArc(pen, 0, 0, curva, curva, 180, 90);

            //Superior derecha
            e.Graphics.FillPie(brush, this.Width - curva, 0, curva - 1, curva - 1, 270, 90);
            e.Graphics.DrawArc(pen, this.Width - curva - 1, 0, curva, curva, 270, 90);

            //Inferior izquierda
            e.Graphics.FillPie(brush, 0, this.Height - curva, curva - 1, curva - 1, 90, 90);
            e.Graphics.DrawArc(pen, 0, this.Height - curva - 1, curva, curva, 90, 90);

            //Inferior derecha
            e.Graphics.FillPie(brush, this.Width - curva, this.Height - curva, curva - 1, curva - 1, 0, 90);
            e.Graphics.DrawArc(pen, this.Width - curva - 1, this.Height - curva - 1, curva, curva, 0, 90);

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
