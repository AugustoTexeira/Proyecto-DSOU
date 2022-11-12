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
    public partial class ProyectosContainer : UserControl
    {
        public ProyectosContainer()
        {
            InitializeComponent();
            flh.Entrar += PasarDatos;
            flh.BackColor = Color.White;
            rt.Clack += DatosPasar;
        }

        private void PasarDatos(object sender, EventArgs e)
        {
            rt.DefinirRuta(sender);
        }

        private void DatosPasar(object sender, EventArgs e)
        {
            if((int)sender == 0)
            {
                flh.MostrarCarpetas();
            }
            else
            {
                flh.Open(sender, e);
            }
        }

        private void ProyectosContainer_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.fondo;
        }
    }
}
