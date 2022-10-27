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
    public partial class frmPruebaa : Form
    {
        public frmPruebaa()
        {
            InitializeComponent();
            
            this.BackColor = Estilo.fondo;
        }
        public frmPruebaa(string user, bool admin)
        {
            InitializeComponent();
            this.BackColor = Estilo.fondo;
            De_Configuración__Cristian_.ConfigContainer contenedor = new(user, admin);
            contenedor.Dock = DockStyle.Fill;
            this.Controls.Add(contenedor);
        }
        private void Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPruebaa_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
        }

    }
}
