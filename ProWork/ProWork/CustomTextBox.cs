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
    public partial class CustomTextBox : TextBox
    {
        Color contraste = Color.White;
        Color enfasis = Color.Blue;

        System.Windows.Forms.Timer tmrSubrayado = new ();
        public CustomTextBox() : base()
        {
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //SetStyle(ControlStyles.UserPaint, true);
            //Font coso = new Font("Segoe UI", 16);
            //this.Font = coso;
        }

        protected override void OnPaint(PaintEventArgs e) 
        {
            ////base.OnPaint(e);

            //Pen pen = new(contraste, 5);

            //pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            //pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //e.Graphics.DrawLine
            //(
            //    pen,
            //    5,
            //    this.Height - 5,
            //    this.Width - 5,
            //    this.Height - 5
            //);
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
        }
    }
}
