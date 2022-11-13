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
    public partial class InicioContainer : UserControl
    {
        public InicioContainer()
        {
            InitializeComponent();
            uTxtNombreCliente.Visible = false;
            uTxtNombreProyecto.Visible = false;
            uTxtTipoProyecto.Visible = false;
            sTxtDescripcion.Visible = false;
            BackColor = Estilo.fondo;
            De_Configuración__Cristian_.ConfigContainer.ColorSwap += colorSwap;
            if(BackColor == Color.White)
            {
                lblProyecto.ForeColor = Estilo.Contraste;
                lblArrastre.ForeColor = Estilo.Contraste;
            }
        }

        private void crearbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectArchivos = new OpenFileDialog();
            selectArchivos.Multiselect = true;

            if (selectArchivos.ShowDialog() == DialogResult.OK)
            {
                foreach (string archivo in selectArchivos.FileNames)
                {
                    MessageBox.Show(archivo);
                }
            }

            epbNuevoProyecto.Visible = false;
            lblArrastre.Visible = false;

            uTxtNombreCliente.Visible = true;
            uTxtNombreProyecto.Visible = true;
            uTxtTipoProyecto.Visible = true;
            sTxtDescripcion.Visible = true;

        }

        private void colorSwap (object sender, EventArgs e)
        {
            BackColor = Estilo.fondo;
            lblArrastre.ForeColor = Estilo.Contraste;
            lblProyecto.ForeColor = Estilo.Contraste;
        }

        private void InicioContainer_Load(object sender, EventArgs e)
        {
            epbNuevoProyecto.AllowDrop = true;
        }

        private void epbNuevoProyecto_DragDrop(object sender, DragEventArgs e)
        {
           OpenFileDialog selectArchivos = new OpenFileDialog();
            selectArchivos.Multiselect = true;

            if (selectArchivos.ShowDialog() == DialogResult.OK)
            {
                foreach (string archivo in selectArchivos.FileNames)
                {
                    MessageBox.Show(archivo);
                }
            }
        }

        private void epbNuevoProyecto_DragDropEnter(object sender, DragEventArgs e)
        {
            OpenFileDialog selectArchivos = new OpenFileDialog();
            selectArchivos.Multiselect = true;

            if (selectArchivos.ShowDialog() == DialogResult.OK)
            {
                foreach (string archivo in selectArchivos.FileNames)
                {
                    MessageBox.Show(archivo);
                }
            }
        }
    }
}
