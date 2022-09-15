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
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=dbprowork; Uid=root; Pwd=;");
        private string user;
        private bool admin;
        public frmPruebaa()
        {
            InitializeComponent();
            this.BackColor = Estilo.fondo;
            admin = true;
            conexion.Open();
            ctlConfig.conectar(conexion, "usuario", false);
        }
        public frmPruebaa(MySqlConnection connection, string user, bool admin)
        {
            InitializeComponent();
            this.BackColor = Estilo.fondo;
            this.user = user;
            this.admin = admin;
            conexion = connection;

            ctlConfig.conectar(conexion, user, admin);
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
