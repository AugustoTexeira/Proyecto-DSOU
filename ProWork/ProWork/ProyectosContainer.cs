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
    public partial class ProyectosContainer : UserControl
    {
        public ProyectosContainer()
        {
            InitializeComponent();
            flh.Entrar += PasarDatos;
        }

        public void Conectar(MySqlConnection conexion)
        {
            flh.Conectar(conexion);
            rt.Conectar(conexion);
        }

        private void PasarDatos(object sender, EventArgs e)
        {
            rt.DefinirRuta(sender);
        }
    }
}
