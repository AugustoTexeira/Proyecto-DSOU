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
using ProWork.De_Configuración__Cristian_;
namespace ProWork
{
    public partial class frmPruebaa : Form
    {
        public frmPruebaa()
        {
            InitializeComponent();
            this.BackColor = Estilo.fondo;
            ConfigContainer contenedor = new();
            contenedor.Dock = DockStyle.Fill;
            this.Controls.Add(contenedor);
        }

        private void frmPruebaa_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
        }
    }
}
