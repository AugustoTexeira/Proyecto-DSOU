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


namespace ProWork.De_Configuración__Cristian_
{
    public partial class ConfigContainer : UserControl
    {
        public static event EventHandler ColorSwap;
        private DateTime startDateMemory = new();
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
            //lst.Width = (Width - Padding.Right) / 3 * 2;
            //cbtAnadir.Width = lst.Width;

            //lst.Height = this.Height - lst.Location.Y - cbtAnadir.Height * 2 - Estilo.anchoLinea;

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

        private async void ConfigContainer_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.fondo;
            lblConfig.ForeColor = Estilo.Contraste;
            lblTema.ForeColor = Estilo.Contraste;
            lblClaro.ForeColor = Estilo.Contraste;
            lblOscuro.ForeColor = Estilo.Contraste;
            lblCuentas.ForeColor = Estilo.Contraste;
            lst.BackColor = Estilo.fondo;
            lst.mode = 0;
            tree.BackColor = Estilo.fondo;
            tree.ForeColor = Estilo.Contraste;
            lblActividad.ForeColor = Estilo.Contraste;
            switch (Estilo.selectedStyle)
            {
                case 0:
                    pbxOscuro.Image = Properties.Resources.Selección_Tema;
                    break;
                case 1:
                    pbxClaro.Image = Properties.Resources.Selección_Tema;
                    break;
            }
            await ResetElementos();
        }

        public async Task ResetElementos()
        {
            await lst.ResetElementos(new("select idusuario, nombre, administrador from usuario order by nombre"));

            var con = await Program.openConnectionAsync();

            MySqlCommand cmd = new(
                "select u.nombre as nombreUsuario, nombreProyecto, a.nombre as nombreArchivo, ca.nombre as nombreCarpeta, c.descripcion, c.fecha " +
                "from carga c left join usuario u on c.idusuario=u.idusuario " +
                "left join proyecto p on p.idproyecto=c.idproyecto " +
                "left join carpeta ca on ca.idcarpeta=c.idcarpeta " +
                "left join archivo a on a.idarchivo=c.idarchivo " +
                "order by c.fecha DESC",
                con);

            MySqlDataReader rdr = await cmd.ExecuteReaderAsync();

            while (await rdr.ReadAsync())
            {
                string s = "";
                if (!rdr.IsDBNull(0))
                {
                    s += rdr.GetString(0);
                }
                if (!rdr.IsDBNull(4))
                {
                    switch (rdr.GetString(4))
                    {
                        case "s":
                            s += " subió ";
                            break;
                        case "e":
                            s += " eliminó ";
                            break;
                        case "c":
                            s += " creó ";
                            break;
                    }
                }
                if (!rdr.IsDBNull(2))
                {
                    s += "el archivo " + rdr.GetString(2) + " ";
                }
                if (!rdr.IsDBNull(3))
                {
                    if (!rdr.IsDBNull(2))
                    {
                        s += "de ";
                    }
                    s += "la carpeta " + rdr.GetString(3) + " ";
                }
                if (!rdr.IsDBNull(1))
                {
                    if (!rdr.IsDBNull(2) || !rdr.IsDBNull(3))
                    {
                        s += "del proyecto " + rdr.GetString(1);
                    }
                    else
                    {
                        s += "el proyecto " + rdr.GetString(1);
                    }
                }
                s += ".";
                if (!(await rdr.IsDBNullAsync(5)) && (tree.Nodes.Count == 0 || tree.Nodes[tree.Nodes.Count - 1].Text != rdr.GetDateOnly(5).ToString()))
                {
                    tree.Nodes.Add(rdr.GetDateOnly(5).ToString());

                }
                if (!(await rdr.IsDBNullAsync(5)))
                {
                    foreach (TreeNode node in tree.Nodes)
                    {
                        if (node.Text == rdr.GetDateOnly(5).ToString())
                        {
                            node.Nodes.Add(s);
                        }
                    }
                }
            }
            await rdr.CloseAsync();
            Program.closeOpenConnection();

            List<Point> buffer = new();
            for (int i = tree.Nodes.Count - 1; i >= 0; i--)
            {
                if (tree.Nodes[i].Parent == null)
                {
                    string[] s = tree.Nodes[i].Text.Split("/");
                    DateOnly date = new(int.Parse(s[2]), int.Parse(s[1]), int.Parse(s[0]));
                    buffer.Add(new(date.DayNumber, tree.Nodes[i].Nodes.Count));
                    if(buffer.Count == 1)
                    {
                    }
                }
            }
            int minDays = buffer[0].X;
            int maxHeight = 0;
            for (int i = 0; i < buffer.Count; i++)
            {
                buffer[i] = new(buffer[i].X - minDays, buffer[i].Y);
                if (maxHeight < buffer[i].Y)
                {
                    maxHeight = buffer[i].Y;
                }
            }
            grf.Scale = new(buffer.Last().X, maxHeight);
            grf.Points = buffer.ToArray();
        }
        private async void lst_itemEnterHover(object sender, EventArgs e)
        {
        }

        public async void ResetElementos(MySqlCommand cmd)
        {
            await lst.ResetElementos(cmd);
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
        private void RecolorControl()
        {
            BackColor = Estilo.fondo;
            lblConfig.ForeColor = Estilo.Contraste;
            lblClaro.ForeColor = Estilo.Contraste;
            lblCuentas.ForeColor = Estilo.Contraste;
            lblOscuro.ForeColor = Estilo.Contraste;
            lblTema.ForeColor = Estilo.Contraste;
            lst.BackColor = Estilo.fondo;
            tree.BackColor = Estilo.fondo;
            tree.ForeColor = Estilo.Contraste;
            lblActividad.ForeColor = Estilo.Contraste;
        }

        private void cbtAnadir_Click(object sender, EventArgs e)
        {
            frmTinyRegister registro = new();
            registro.Show();
            this.ParentForm.Close();
        }

        private async void lst_trashClicked(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Item item in lst.Controls)
            {
                if (item.mode == 2)
                {
                    i++;
                }
            }
            if (i == 1 && ((Item)sender).id == Program.userId)
            {
                MessageBox.Show("Debe haber por lo menos un administrador.");
                return;
            }
            var con = await Program.openConnectionAsync();
            if (((Item)sender).Text == Program.user)
            {
                if (MessageBox.Show($"¿Esta seguro que desea eliminar SU cuenta?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    MySqlCommand cmd = new($"delete from usuario where nombre='{((Item)sender).Text}';", con);
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
                    MySqlCommand cmd = new($"delete from usuario where nombre='{((Item)sender).Text}';", con);
                    cmd.ExecuteNonQuery();
                    await lst.ResetElementos(null);
                }
            }
            Program.closeOpenConnection();
        }

        private void lst_gearClicked(object sender, EventArgs e)
        {
            frmAccConfig config = new frmAccConfig(((Item)sender).Text);
            config.CambioExitoso += ((Item)sender).CallReset;
            config.Show();
        }

        private void lblDudas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Properties.frmCreditos frm = new();
            frm.Show();
        }

        private void grf_Load_1(object sender, EventArgs e)
        {

        }
        private async void lst_itemClicked(object sender, MouseEventArgs e)
        {
            int i = 0;
            foreach(Item item in lst.Controls)
            {
                if (item.mode == 2)
                {
                    i++;
                }
            }
            if(i == 1 && ((Item)sender).id == Program.userId)
            {
                MessageBox.Show("Debe haber por lo menos un administrador.");
                return;
            }
            frmAniadirAdministrador frm = new(((Item)sender).Text, ((Item)sender).id, ((Item)sender).mode == 2);
            frm.ascendido += ((Item)sender).cambioPrivilegio;
            frm.Show();
        }

        private void lblActividad_Click(object sender, EventArgs e)
        {
            grf.Visible = !grf.Visible;
        }
    }
}
