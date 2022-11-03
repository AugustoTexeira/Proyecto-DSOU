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
    public partial class searchBar : UserControl
    {
        public searchBar()
        {
            InitializeComponent();
        }

        private void searchBar_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new(Color.FromArgb(102, 102, 102));
            e.Graphics.FillRectangle(brush, Height / 2 + 1, 0, Height / 2, Height);
            
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            e.Graphics.FillRectangle(brush, Height / 2, 0, 1, Height - 1);
            e.Graphics.FillEllipse(brush, 0, -1, Height - 1, Height + 1);
            e.Graphics.FillEllipse(brush, Width - Height - 1, -1, Height, Height + 1);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
        }

        private void searchBar_Layout(object sender, LayoutEventArgs e)
        {
            Height = Font.Height;
            txb.Location = new(Height, 0);
            txb.Width = Width - (int)(Height * 1.5) - 1;
            epb.Location = new(Height / 4, Height / 4);
            epb.sizeToHeight(Height / 2);

            Refresh();
        }

        private void searchBar_FontChanged(object sender, EventArgs e)
        {
            txb.Font = Font;
        }

        private void searchBar_Click(object sender, EventArgs e)
        {
            txb.Select();
        }
    }
}
