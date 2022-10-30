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
        /*NOMENCLATURA
         * acl = AccountList
         * 
         */
        public ConfigContainer()
        {
            InitializeComponent();
        }
        public ConfigContainer(string user)
        {
            InitializeComponent();

            aclCuentas.User = user;
        }

        private void ConfigContainer_Layout(object sender, LayoutEventArgs e)
        {
            aclCuentas.Width = this.Width / 5 * 4;

            if (this.Width < 960)
            {
                pbxClaro.Location = new(this.Padding.Left + (this.Width - this.Padding.Left - this.Padding.Right) / 2 - pbxClaro.Width / 2, pbxClaro.Location.Y);
                pbxPersonalizado.Location = new(this.Width - Padding.Right - pbxPersonalizado.Width, pbxPersonalizado.Location.Y);
            }
            else
            {
                pbxClaro.Location = new(this.Padding.Left + (960 - this.Padding.Left - this.Padding.Right) / 2 - pbxClaro.Width / 2, pbxClaro.Location.Y);
                pbxPersonalizado.Location = new(960 - Padding.Right - pbxPersonalizado.Width, pbxPersonalizado.Location.Y);
            }

            lblClaro.Location = new(pbxClaro.Location.X, lblClaro.Location.Y);
            lblPersonalizado.Location = new(pbxPersonalizado.Location.X, lblPersonalizado.Location.Y);

            aclCuentas.Height = this.Height - aclCuentas.Location.Y - cbtAnadir.Height * 2;
            cbtAnadir.Location = new(cbtAnadir.Location.X, aclCuentas.Location.Y + aclCuentas.Height + Estilo.anchoLinea);

            this.Refresh();
        }

        private void ConfigContainer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Pen pen = new(Estilo.Contraste, Estilo.anchoLinea);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            e.Graphics.DrawLine(pen, new(Padding.Left, aclCuentas.Location.Y - 79), new(this.Width - Padding.Right, aclCuentas.Location.Y - 79));
        }

        private void ConfigContainer_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.fondo;
            lblConfig.ForeColor = Estilo.Contraste;
            lblTema.ForeColor = Estilo.Contraste;
            lblClaro.ForeColor = Estilo.Contraste;
            lblOscuro.ForeColor = Estilo.Contraste;
            lblPersonalizado.ForeColor = Estilo.Contraste;
            lblCuentas.ForeColor = Estilo.Contraste;
            aclCuentas.BackColor = Estilo.fondo;
            aclCuentas.ResetElementos();
            switch (Estilo.selectedStyle)
            {
                case 0:
                    pbxOscuro.Image = Properties.Resources.Selección_Tema;
                    break;
                case 1:
                    pbxClaro.Image = Properties.Resources.Selección_Tema;
                    break;
                default:
                    pbxPersonalizado.Image = Properties.Resources.Selección_Tema;
                    break;
            }
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

        private void pbxPersonalizado_MouseEnter(object sender, EventArgs e)
        {
            if (Estilo.selectedStyle < 2) { pbxPersonalizado.Image = Properties.Resources.Fondo_seleccion_tema; }
            lblPersonalizado.ForeColor = Estilo.enfasis;
        }

        private void pbxPersonalizado_MouseLeave(object sender, EventArgs e)
        {
            if (Estilo.selectedStyle < 2) { pbxPersonalizado.Image = null; }
            lblPersonalizado.ForeColor = Estilo.Contraste;
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
            pbxPersonalizado.Image = null;

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
            pbxPersonalizado.Image = null;

            RecolorControl();
        }

        private void pbxPersonalizado_Click(object sender, EventArgs e)
        {
            Estilo.selectedStyle = 2;
            pbxPersonalizado.Image = Properties.Resources.Selección_Tema;
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
            lblPersonalizado.ForeColor = Estilo.Contraste;
            lblTema.ForeColor = Estilo.Contraste;
            aclCuentas.BackColor = Estilo.fondo;

            Form.ActiveForm.Refresh();
        }

        private void cbtAnadir_Click(object sender, EventArgs e)
        {
            frmTinyRegister registro = new();
            registro.Show();
            this.ParentForm.Close();
        }
    }
}
