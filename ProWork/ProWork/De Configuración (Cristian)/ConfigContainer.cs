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
            List<Point> buffer = new List<Point>();

            MySqlCommand cmd = new("Select fecha, count(fecha) from carga group by fecha order by fecha", con);

            MySqlDataReader rdr = await cmd.ExecuteReaderAsync();
            if (rdr.HasRows)
            {
                await rdr.ReadAsync();
                List<DateTime> datelist = new();
                List<long> countList = new();

                dtpStart.Value = rdr.GetDateTime(0);
                grf.Scale = new(grf.Scale.Width, (int)(rdr.GetInt64(1) * 1.2));

                TimeSpan ts = dtpEnd.Value - rdr.GetDateTime(0);


                ts = dtpEnd.Value - rdr.GetDateTime(0);
                datelist.Add(rdr.GetDateTime(0));
                countList.Add(rdr.GetInt64(1));

                while (await rdr.ReadAsync())
                {
                    if (rdr.GetDateTime(0) < dtpStart.Value)
                    {
                        dtpStart.Value = rdr.GetDateTime(0);
                        startDateMemory = dtpStart.Value;
                    }
                    if (rdr.GetInt64(1) * 1.2 > grf.Scale.Height)
                    {
                        grf.Scale = new(grf.Scale.Width, (int)(rdr.GetInt64(1) * 1.2));
                    }
                    datelist.Add(rdr.GetDateTime(0));
                    countList.Add(rdr.GetInt64(1));
                }
                string s = "";
                for (int i = 0; i < datelist.Count; i++)
                {
                    ts = datelist[i] - dtpStart.Value;
                    buffer.Add(new((int)ts.TotalDays, (int)countList[i]));
                    s += buffer[i].ToString();
                }

                ts = dtpEnd.Value - dtpStart.Value;
                Point[] buffer2 = buffer.ToArray();
                Array.Sort(buffer2, new xComparer());
                buffer = buffer2.ToList();

                //for (int i = 0; i < buffer.Count; i++)
                //{
                //    if (buffer[i + 1].X - buffer[i].X > 1)
                //    {
                        
                //    }
                //}

                grf.Points = buffer.ToArray();
                grf.Scale = new((int)ts.TotalDays, grf.Scale.Height);

                

                DateTime shift = dtpEnd.Value;
                shift.AddDays(-1);
                dtpStart.MaxDate = shift;
                shift = dtpStart.Value;
                shift.AddDays(2);
                dtpEnd.MinDate = shift;
                MessageBox.Show(s);
                MessageBox.Show($"{grf.Scale.Width} {grf.XOffset}");
            }
            await rdr.CloseAsync();
            Program.closeOpenConnection();
        }

        private async void lst_itemEnterHover(object sender, EventArgs e)
        {
        }


        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts = dtpEnd.Value - dtpStart.Value;
            grf.Scale = new((int)ts.TotalDays, grf.Scale.Height);
            DateTime shift = dtpEnd.Value;
            shift.AddDays(-10);
            dtpStart.MaxDate = shift;
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            //TimeSpan ts = dtpEnd.Value - dtpStart.Value;
            //grf.Scale = new((int)ts.TotalDays, grf.Scale.Height);

            //if (grf.Points.Length > 1)
            //{
            //    ts += dtpStart.Value - startDateMemory;
            //    grf.XOffset = (int)ts.TotalDays;
            //}
            //DateTime shift = dtpStart.Value;
            //shift.AddDays(10);
            //dtpEnd.MinDate = shift;
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
        }

        private void cbtAnadir_Click(object sender, EventArgs e)
        {
            frmTinyRegister registro = new();
            registro.Show();
            this.ParentForm.Close();
        }

        private async void lst_trashClicked(object sender, EventArgs e)
        {
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void lst_itemClicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var con = await Program.openConnectionAsync();
                MySqlCommand cmd = new($"Select fecha, count(fecha) from carga where idusuario={((Item)sender).id} group by fecha order by fecha", con);
                MySqlDataReader rdr = await cmd.ExecuteReaderAsync();

                TimeSpan ts;
                List<Point> buffer = new();
                while (await rdr.ReadAsync())
                {
                    ts = rdr.GetDateTime(0) - startDateMemory;
                    buffer.Add(new((int)ts.TotalDays, rdr.GetInt32(1)));
                }
                grf.Points = buffer.ToArray();
                await rdr.CloseAsync();
                Program.closeOpenConnection();
            }
            if (e.Button == MouseButtons.Right && Program.userAdmin)
            {
                frmAniadirAdministrador frm = new(((Item)sender).Text, ((Item)sender).id, ((Item)sender).mode == 2);
                frm.ascendido += ((Item)sender).cambioPrivilegio;
                frm.Show();
            }
        }
    }
}
