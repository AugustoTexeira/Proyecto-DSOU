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
    public partial class ContactosContainer : UserControl
    {
        public ContactosContainer()
        {
            InitializeComponent();
            BackColor = Estilo.fondo;
            srbBuscar.BackColor = Estilo.fondo;
            lblContactos.ForeColor = Estilo.Contraste;
            clt.mode = 1;
            clt.ResetElementos(new MySqlCommand("Select idcontacto, nombre from contacto order by nombre;"));
            srbBuscar.txb.KeyPress += txb_KeyPress;
            if(!Program.userAdmin)
            {
                cbnAniadir.Visible = false;
            }
            De_Configuración__Cristian_.ConfigContainer.ColorSwap += colorSwap;
        }

        private void colorSwap(object sender, EventArgs e)
        {
            BackColor = Estilo.fondo;
            lblContactos.ForeColor = Estilo.Contraste;
        }

        private void cbnAniadir_Click(object sender, EventArgs e)
        {
            frmAñadirContacto frm = new();
            frm.CambioExitoso += ResetElementos;
            frm.Show();
        }
        public async void ResetElementos(object sender, EventArgs e)
        {
            await clt.ResetElementos(null);
        }

        private void ContactosContainer_Layout(object sender, LayoutEventArgs e)
        {
            srbBuscar.Width = Width - srbBuscar.Location.X - 25;
            clt.Width = srbBuscar.Width;
            clt.Height = this.Height - cbnAniadir.Height - 25 - clt.Location.Y - 25;
        }
        private async void txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                var con = await Program.openConnectionAsync();
                if(srbBuscar.txb.Text == "")
                {
                    await clt.ResetElementos(new MySqlCommand("Select idcontacto, nombre from contacto order by nombre;", con));
                }
                else
                {
                    string texto = srbBuscar.txb.Text.Replace($"\\", String.Empty);
                    await clt.ResetElementos(new($"select idcontacto, nombre from (select * from contacto where match(correoElectronico, nombre, número, descripción) against('%{texto}%' in boolean mode)) as tabla order by nombre != '{texto}' and correoElectronico != '{texto}' and número != '{texto}' and descripción != '{texto}';", con));
                }
                await Program.closeOpenConnectionAsync(con);
                e.Handled = true;
            }
        }

        private async void clt_gearClicked(object sender, EventArgs e)
        {
            var con = await Program.openConnectionAsync();
            MySqlCommand cmd = new MySqlCommand($"select correoElectronico, número, descripción from contacto where idcontacto={((Item)sender).id}", con);
            MySqlDataReader reader = await cmd.ExecuteReaderAsync();
            frmContactosConfig config = new(((Item)sender).id, ((Item)sender).Text, reader);
            config.CambioExitoso += ((Item)sender).CallReset;
            await reader.CloseAsync();
            await Program.closeOpenConnectionAsync(con);
            config.Show();
        }

        private async void clt_trashClicked(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Esta seguro que desea eliminar el contacto {((Item)sender).Text}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var con = await Program.openConnectionAsync();
                MySqlCommand cmd = new($"delete from contacto where idcontacto='{((Item)sender).id}';", con);
                await cmd.ExecuteNonQueryAsync();
                await clt.ResetElementos(null);
                await Program.closeOpenConnectionAsync(con);
            }
        }

        private async void clt_itemClicked(object sender, EventArgs e)
        {
            var con = await Program.openConnectionAsync();

            MySqlCommand cmd = new MySqlCommand($"select correoElectronico, número, descripción from contacto where idcontacto={((Item)sender).id}", con);
            MySqlDataReader reader = await cmd.ExecuteReaderAsync();
            frmMostrarContacto frm = new(((Item)sender).id, ((Item)sender).Text, reader);
            await reader.CloseAsync();
            await Program.closeOpenConnectionAsync(con);
            frm.Show();
        }
    }
}
