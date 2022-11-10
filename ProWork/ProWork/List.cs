using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

namespace ProWork
{
    public partial class List : UserControl
    {
        public byte mode = 0; // 0=usuarios; 1=contactos; >1 = indefinido
        private MySqlCommand cmd;
        public List()
        {
            InitializeComponent();
            De_Configuración__Cristian_.ConfigContainer.ColorSwap += colorSwap;
        }

        private void colorSwap(object sender, EventArgs e)
        {
            BackColor = Estilo.fondo;
        }

        public void ResetElementos(MySqlCommand select)
        {
            Program.tryToConnect();
            if (select != null)
            {
                cmd = select;
            }

            MySqlDataReader lector = cmd.ExecuteReader();

            this.Controls.Clear();

            int i = 0;

            switch (mode)
            {
                case 0:
                    while (lector.Read())
                    {
                        Item item = new Item();

                        if(lector.GetBoolean(2))
                        {
                            item.mode = 2;
                        }
                        else
                        {
                            item.mode = 0;
                        }
                        item.Text = lector.GetString(1);
                        item.id = lector.GetInt32(0);
                        item.Font = this.Font;
                        item.Width = this.Width - SystemInformation.VerticalScrollBarWidth - 10;
                        item.Location = new Point(0, Estilo.medioAnchoLinea + i * item.Height);
                        item.gearClicked += gearClicked;
                        item.trashClicked += trashClicked;
                        item.Click += itemClicked;
                        this.Controls.Add(item);

                        i++;
                    }
                    break;
                case 1:

                    while (lector.Read())
                    {
                        Item item = new Item();

                        item.mode = 1;
                        item.Text = lector.GetString(1);
                        item.id = lector.GetInt32(0);
                        item.Font = this.Font;
                        item.Width = this.Width - SystemInformation.VerticalScrollBarWidth - 10;
                        item.Location = new Point(0, Estilo.medioAnchoLinea + i * item.Height);
                        item.gearClicked += gearClicked;
                        item.trashClicked += trashClicked;
                        item.Click += itemClicked;
                        this.Controls.Add(item);

                        i++;
                    }
                    break;
            }

            lector.Close();
            this.Refresh();
        }
        private void CallReset(object sender, EventArgs e)
        {
            ResetElementos(new MySqlCommand("Select idcontacto, nombre from contacto order by nombre;", Program.connection));
        }

        private void AccountList_Paint(object sender, PaintEventArgs e)
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

        private void AccountList_Load(object sender, EventArgs e)
        {
            this.HorizontalScroll.Maximum = 0;
            this.AutoScroll = false;
            this.VerticalScroll.Visible = false;
            this.AutoScroll = true;
        }

        private void AccountList_Layout(object sender, LayoutEventArgs e)
        {
            this.AutoScroll = false;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                this.Controls[i].Width = this.Width - SystemInformation.VerticalScrollBarWidth - 10;
            }
            this.AutoScroll = true;
            Refresh();
        }

        public event EventHandler gearClicked;
        public event EventHandler trashClicked;
        public event EventHandler itemClicked;
        public event EventHandler statsClicked;
    }
}
