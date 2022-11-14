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
    public partial class boringList : UserControl
    {
        public boringList()
        {
            InitializeComponent();
        }
        private void resetElementos()
        {
            Refresh();
        }
        private void deleteItem (object sender, EventArgs e)
        {
            Controls.Remove((Control)sender);
            resetElementos();
        }
        public void addItem(string Text, string id)
        {
            Item item = new Item();
            Controls.Add(item);
            item.mode = 3;
            item.Font = Font;
            item.Text = Text;
            item.varcharId = id;
            item.Location = new(0, Estilo.medioAnchoLinea + item.Height * Controls.Count);
            item.gearClicked += gearClicked;
            item.trashClicked += trashClicked;
            item.trashClicked += deleteItem;
            item.MouseClick += itemClicked;
            resetElementos();
        }
        public event EventHandler gearClicked;
        public event EventHandler trashClicked;
        public event MouseEventHandler itemClicked;

        private void boringList_Paint(object sender, PaintEventArgs e)
        {
            if (this.Controls.Count != 0)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Pen pen = new(Estilo.Contraste, Estilo.anchoLinea);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                e.Graphics.DrawLine(pen, new(Estilo.medioAnchoLinea, this.Controls[0].Location.Y), new(this.Controls[0].Width - Estilo.medioAnchoLinea, this.Controls[0].Location.Y));
                e.Graphics.DrawLine(pen, new(Estilo.medioAnchoLinea, this.Controls[this.Controls.Count - 1].Location.Y + this.Controls[this.Controls.Count - 1].Height), new(this.Controls[this.Controls.Count - 1].Width - Estilo.medioAnchoLinea, this.Controls[this.Controls.Count - 1].Location.Y + this.Controls[this.Controls.Count - 1].Height));
            }
        }

        private void boringList_Layout(object sender, LayoutEventArgs e)
        {
            int i = 0;
            foreach (Item item in Controls)
            {
                item.Location = new Point(0, Estilo.medioAnchoLinea + Controls[i].Height * i);
                item.Width = Width - SystemInformation.VerticalScrollBarWidth - 10;
                i++;
            }
        }
    }
}
