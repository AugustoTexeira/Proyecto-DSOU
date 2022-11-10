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
using MySql.Data.MySqlClient;

namespace ProWork.De_Configuración__Cristian_
{
    public partial class ConfigContainer : UserControl
    {
        public static event EventHandler ColorSwap;
        /*NOMENCLATURA
         * acl = AccountList
         * 
         */
        public ConfigContainer()
        {
            InitializeComponent();
            pbxClaro.Location = new(this.Padding.Left + (this.Width - this.Padding.Left - this.Padding.Right) / 2 - pbxClaro.Width / 2, pbxClaro.Location.Y);
            pbxClaro.Location = new(this.Padding.Left + (960 - this.Padding.Left - this.Padding.Right) / 2 - pbxClaro.Width / 2, pbxClaro.Location.Y);
            lblClaro.Location = new(pbxClaro.Location.X, lblClaro.Location.Y);
            pbxClaro.Anchor = AnchorStyles.Top;
            lblClaro.Anchor = AnchorStyles.Top;
        }

        private void ConfigContainer_Layout(object sender, LayoutEventArgs e)
        {
            //lst.Width = Width - Padding.Right;

            //lst.Height = this.Height - lst.Location.Y - cbtAnadir.Height * 2 - Estilo.anchoLinea;
            //cbtAnadir.Location = new(cbtAnadir.Location.X, lst.Location.Y + lst.Height + Estilo.anchoLinea);

            Invalidate();
        }

        private void ConfigContainer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Pen pen = new(Estilo.Contraste, Estilo.anchoLinea);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            e.Graphics.DrawLine(pen, new(Padding.Left, lst.Location.Y - 79), new(this.Width - Padding.Right, lst.Location.Y - 79));
        }

        private void ConfigContainer_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.fondo;
            lblConfig.ForeColor = Estilo.Contraste;
            lblTema.ForeColor = Estilo.Contraste;
            lblClaro.ForeColor = Estilo.Contraste;
            lblOscuro.ForeColor = Estilo.Contraste;
            lblCuentas.ForeColor = Estilo.Contraste;
            lst.BackColor = Estilo.fondo;
            lst.mode = 0;
            switch (Estilo.selectedStyle)
            {
                case 0:
                    pbxOscuro.Image = Properties.Resources.Selección_Tema;
                    break;
                case 1:
                    pbxClaro.Image = Properties.Resources.Selección_Tema;
                    break;
            }
            Program.tryToConnect();
            lst.ResetElementos(new("select idusuario, nombre, administrador from usuario", Program.connection));
            //MySqlCommand cmd = new("Select fecha, count(fecha) from carga order by fecha", Program.connection);

            //MySqlDataReader rdr = cmd.ExecuteReader();
            //List<Point> buffer = new List<Point>();
            //int i = 0;
            //while (rdr.Read())
            //{
            //    buffer.Add(new(i, rdr.GetInt32(1)));
            //    i++;
            //}
            //rdr.Read();
            //grf.Scale = new(10, 10);
            //grf.Points = buffer.ToArray();
        }

        public void ResetElementos(MySqlCommand cmd)
        {
            lst.ResetElementos(cmd);
        }

        private void pbxOscuro_MouseEnter(object sender, EventArgs e)
        {
            if (Estilo.selectedStyle != 0) { pbxOscuro.Image = Properties.Resources.Fondo_seleccion_tema; }
            lblOscuro.ForeColor = Estilo.enfasis;
        }

        private void pbxOscuro_MouseLeave(object sender, EventArgs e)
        {
            if (Estilo.selectedStyle != 0) { pbxOscuro.Image = null; }
            lblOscuro.ForeColor = Estilo.Contraste;
        }

        private void pbxClaro_MouseEnter(object sender, EventArgs e)
        {
            if (Estilo.selectedStyle != 1) { pbxClaro.Image = Properties.Resources.Fondo_seleccion_tema; }
            lblClaro.ForeColor = Estilo.enfasis;
        }

        private void pbxClaro_MouseLeave(object sender, EventArgs e)
        {
            if (Estilo.selectedStyle != 1) { pbxClaro.Image = null; }
            lblClaro.ForeColor = Estilo.Contraste;
        }

        private void pbxClaro_Click(object sender, EventArgs e)
        {
            Estilo.selectedStyle = 1;
            Estilo.enfasis = Color.FromArgb(5, 49, 247);
            Estilo.degrEnfasis = Color.FromArgb(5, 233, 237);
            Estilo.fondo = Color.White;
            Estilo.Contraste = Color.FromArgb(15, 12, 15);
            Estilo.contrasteLigero = Color.LightGray;
            Estilo.degrContraste = Color.Gray;

            pbxClaro.Image = Properties.Resources.Selección_Tema;
            pbxOscuro.Image = null;
            ColorSwap.Invoke(true, e);
            RecolorControl();
        }

        private void pbxOscuro_Click(object sender, EventArgs e)
        {
            Estilo.selectedStyle = 0;
            Estilo.enfasis = Color.FromArgb(5, 49, 247);
            Estilo.degrEnfasis = Color.FromArgb(5, 233, 237);
            Estilo.fondo = Color.FromArgb(15, 12, 15);
            Estilo.Contraste = Color.White;
            Estilo.contrasteLigero = Color.Gray;
            Estilo.degrContraste = Color.LightGray;

            pbxOscuro.Image = Properties.Resources.Selección_Tema;
            pbxClaro.Image = null;

            ColorSwap.Invoke(false, e);
            RecolorControl();
        }

        private void pbxPersonalizado_Click(object sender, EventArgs e)
        {
            Estilo.selectedStyle = 2;
            pbxOscuro.Image = null;
            pbxClaro.Image = null;
        }
        private void RecolorControl()
        {
            BackColor = Estilo.fondo;
            lblConfig.ForeColor = Estilo.Contraste;
            lblClaro.ForeColor = Estilo.Contraste;
            lblCuentas.ForeColor = Estilo.Contraste;
            lblOscuro.ForeColor = Estilo.Contraste;
            lblTema.ForeColor = Estilo.Contraste;
            lst.BackColor = Estilo.fondo;
        }

        private void cbtAnadir_Click(object sender, EventArgs e)
        {
            frmTinyRegister registro = new();
            registro.Show();
            this.ParentForm.Close();
        }

        private void lst_trashClicked(object sender, EventArgs e)
        {
            if (((Item)sender).Text == Program.user)
            {
                if (MessageBox.Show($"¿Esta seguro que desea eliminar SU cuenta?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Program.tryToConnect();

                    MySqlCommand cmd = new($"delete from usuario where nombre='{((Item)sender).Text}';", Program.connection);
                    cmd.ExecuteNonQuery();

                    frmTinyRegister register = new frmTinyRegister();
                    register.Show();
                    this.ParentForm.Close();
                }
            }
            else
            {
                if (MessageBox.Show($"¿Esta seguro que desea eliminar la cuenta {((Item)sender).Text}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Program.tryToConnect();

                    MySqlCommand cmd = new($"delete from usuario where nombre='{((Item)sender).Text}';", Program.connection);
                    cmd.ExecuteNonQuery();
                    lst.ResetElementos(null);
                }
            }
        }

        private void lst_gearClicked(object sender, EventArgs e)
        {
            frmAccConfig config = new frmAccConfig(((Item)sender).Text);
            config.CambioExitoso += ((Item)sender).CallReset;
            config.Show();
        }

        private void lst_itemClicked(object sender, EventArgs e)
        {
            if (!Program.userAdmin) { return; }

            int i = 0;

            foreach (Item item in lst.Controls)
            {
                if(item.mode == 2)
                {
                    i++;
                }
            }

            if(((Item)sender).Text == Program.user && i == 1)
            {
                MessageBox.Show("Siempre debe existir por lo menos un administrador.\nSi desea descenderse, primero otorgue privilegios de administrador a otro usuario.");
                return;
            }

            frmAniadirAdministrador frm = new(((Item)sender).Text, ((Item)sender).id, ((Item)sender).mode == 0);
            frm.ascendido += ((Item)sender).cambioPrivilegio;
            frm.Show();
        }

        private void lblDudas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Properties.frmCreditos frm = new();
            frm.Show();
        }

        private void lst_statsClicked(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grf_Load(object sender, EventArgs e)
        {
        }

        private void grf_Load_1(object sender, EventArgs e)
        {

        }
    }
}
