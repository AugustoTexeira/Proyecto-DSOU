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
            if(!Program.userAdmin)
            {
                cbnAniadir.Visible = false;
            }
        }

        private void cbnAniadir_Click(object sender, EventArgs e)
        {
            frmAñadirContacto frm = new();
            frm.CambioExitoso += callReset;
            frm.Show();
        }
        private void callReset(object sender, EventArgs e)
        {
            clt.ResetElementos(new MySqlCommand("Select idcontacto, nombre from contacto order by nombre;", Program.connection));
        }

        private void ContactosContainer_Layout(object sender, LayoutEventArgs e)
        {
            cbnAniadir.Location = new(this.Width - cbnAniadir.Width - 25, this.Height - cbnAniadir.Height - 25);
            srbBuscar.Width = Width - srbBuscar.Location.X - 25;
            clt.Width = srbBuscar.Width;
            clt.Height = cbnAniadir.Location.Y - clt.Location.Y - 25;
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
                    string texto = srbBuscar.txb.Text.Replace($"\\", String.Empty);
                    clt.ResetElementos(new($"select idcontacto, nombre from (select * from contacto where match(correoElectronico, nombre, número, descripcion) against('%{texto}%' in boolean mode)) as tabla order by nombre != '{texto}' and correoElectronico != '{texto}' and número != '{texto}' and descripcion != '{texto}';", Program.connection));
                }
                e.Handled = true;
            }
        }

        private void clt_gearClicked(object sender, EventArgs e)
        {
            frmContactosConfig config = new(((Item)sender).id, ((Item)sender).Text);
            config.CambioExitoso += ((Item)sender).CallReset;
            config.Show();
        }

        private void clt_trashClicked(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Esta seguro que desea eliminar el contacto {((Item)sender).Text}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.tryToConnect();

                MySqlCommand cmd = new($"delete from contacto where idcontacto='{((Item)sender).id}';", Program.connection);
                cmd.ExecuteNonQuery();
                clt.ResetElementos(null);
            }
        }

        private void clt_itemClicked(object sender, EventArgs e)
        {
            frmMostrarContacto frm = new(((Item)sender).id, ((Item)sender).Text);
            frm.Show();
        }
    }
}
