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
    public partial class AccountList : UserControl
    {
        public bool userAdmin = false; //Si el usuario actual (el que usa la app) es admin
        public string User;
        public AccountList()
        {
            InitializeComponent();
        }

        public void ResetElementos()
        {
            Program.tryToConnect();

            MySqlCommand select = new MySqlCommand("Select nombre, administrador from usuario order by nombre;", Program.connection);
            MySqlDataReader lector = select.ExecuteReader();

            this.Controls.Clear();

            int i = 0;

            while (lector.Read())
            {
                AccountItem item = new AccountItem();

                item.Text = lector.GetString(0);
                item.isAdmin = lector.GetBoolean(1);
                if (lector.GetString(0) == User) { item.isCurrentUser = true; }
                if (lector.GetString(0) == User && lector.GetBoolean(1) == true) { item.isAdmin = true; }
                item.userAdmin = userAdmin;
                item.Width = this.Width - SystemInformation.VerticalScrollBarWidth - 10;
                item.Location = new Point(0, Estilo.medioAnchoLinea + i * item.Height);
                item.ResetParent += CallReset;

                this.Controls.Add(item);

                i++;
            }

            lector.Close();
            this.Refresh();
        }
        private void CallReset(object sender, EventArgs e)
        {
            if (sender != null) { User = sender.ToString(); }
            ResetElementos();
        }

        private void AccountList_Paint(object sender, PaintEventArgs e)
        {
            if(this.Controls.Count != 0)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Pen pen = new(Estilo.contrasteLigero, Estilo.anchoLinea);
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
        }
    }
}
