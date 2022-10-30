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

namespace ProWork
{
    public partial class ContactosContainer : UserControl
    {
        public ContactosContainer()
        {
            InitializeComponent();
            clt.ResetElementos(new MySqlCommand("Select idcontacto, nombre from contacto order by nombre;", Program.connection));
            srbBuscar.txb.KeyPress += txb_KeyPress;
        }

        private void cbnAniadir_Click(object sender, EventArgs e)
        {
            frmAñadirContacto frm = new();
            frm.Show();
        }

        private void ContactosContainer_Layout(object sender, LayoutEventArgs e)
        {
            cbnAniadir.Location = new(this.Width - cbnAniadir.Width - 25, this.Height - cbnAniadir.Height - 25);
            srbBuscar.Width = Width - srbBuscar.Location.X - 25;
            clt.Width = srbBuscar.Width;
            clt.Height = cbnAniadir.Location.Y - clt.Location.Y - 25;
        }

        private void searchBar1_Load(object sender, EventArgs e)
        {

        }
        private void txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(srbBuscar.txb.Text == "")
                {
                    clt.ResetElementos(new MySqlCommand("Select idcontacto, nombre from contacto order by nombre;", Program.connection));
                }
                else
                {
                    clt.ResetElementos(new($"select idcontacto, nombre from contacto where match(correoElectronico, nombre, número, descripcion) against('{srbBuscar.txb.Text}')", Program.connection));
                }
            }
        }
    }
}
