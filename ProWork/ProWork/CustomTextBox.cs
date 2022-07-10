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
        public CustomTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Pen pen = new(contraste, 5);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine
            (
                pen,
                5,
                0,
                this.Width - 5,
                this.Height - 5
            );
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
        }
    }
}
