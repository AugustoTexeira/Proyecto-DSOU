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
    public partial class frmCarpetaConf : Form
    {
        public event EventHandler<string> Filtrar;
        public string name;
        public string filtro;
        public frmCarpetaConf()
        {
            InitializeComponent();
            this.BackColor = Estilo.fondo;
            De_Configuración__Cristian_.ConfigContainer.ColorSwap += colorSwap;
        }

        public frmCarpetaConf(string filtros, string name)
        {
            InitializeComponent();
            this.BackColor = Estilo.fondo;
            De_Configuración__Cristian_.ConfigContainer.ColorSwap += colorSwap;
            filtro = filtros;
            stb.rtb.Text = filtro;
            this.name = name;
        }

        private void colorSwap(object sender, EventArgs e)
        {
            this.BackColor = Estilo.fondo;
            stb.ForeColor = Estilo.Contraste;
        }
        private void cbt_MouseClick(object sender, EventArgs e)
        {
            string str = stb.rtb.Text;
            Filtrar.Invoke(this, str);
            this.Close();
        }

        private void frmCarpetaConf_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
            this.Dispose();
        }
    }
}
