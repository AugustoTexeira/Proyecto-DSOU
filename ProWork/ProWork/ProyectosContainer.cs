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
            flh.Cargar += PantCarga;
            rt.Clack += DatosPasar;
            De_Configuración__Cristian_.ConfigContainer.ColorSwap += colorSwap;
        }
        public void PantCarga(object sender, bool b)
        {
            if (b == true)
            {
                flh.Visible = false;
                rt.Visible = false;
            }
            else
            {
                flh.Visible = true;
                rt.Visible = true;

            }
           
        }
        private void colorSwap(object sender, EventArgs e)
        {
            this.BackColor = Estilo.fondo;
            lblProyectos.ForeColor = Estilo.Contraste;
            flh.BackColor = Estilo.fondo;
            rt.BackColor = Estilo.fondo;
            rt.ForeColor = Estilo.Contraste;
        }

        private void PasarDatos(object sender, EventArgs e)
        {
            rt.DefinirRuta(sender);
        }

        private void DatosPasar(object sender, EventArgs e)
        {
            if (sender.ToString() == "0")
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
