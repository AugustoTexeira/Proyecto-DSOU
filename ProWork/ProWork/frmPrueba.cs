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
    public partial class frmPrueba : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=dbprowork; Uid=root; Pwd=;");
        public frmPrueba()
        {
            InitializeComponent();
            this.BackColor = Estilo.fondo;
        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            fileHolder1.Conectar(conexion);
            fileHolder1.MostrarCarpetas();
        }

        
    }
}
