﻿using System;
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
    public partial class Carpeta : UserControl
    {
        private bool clicked = false;
        private Point ClickPoint;
        public string Nombre
        {
            get { return lbl.Text; }
            set { lbl.Text = value; }
        }
        public string id;
        public string mimeTypes;
        public RichTextBox rtb;
        public bool seleccionado;
        public bool proyecto = false;
        public Carpeta()
        {
            InitializeComponent();
        }

        private void Carpeta_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.fondo;
            lbl.ForeColor = Estilo.Contraste;
            pcb.BackColor = Estilo.fondo;
        }
        public event EventHandler CarpetaDoubleClick;
        public event EventHandler LostFoco;
        public event EventHandler Eliminar;
        public event EventHandler Deseleccionar;
        public event EventHandler DescargarCarpeta;
        public event EventHandler<string> CambiarFiltros;
        public virtual void OnDoubleClick(EventArgs e)
        {
            CarpetaDoubleClick.Invoke(id, e);
        }

        public async Task CambiarNombre()
        {
            rtb = new RichTextBox();
            Controls.Add(rtb);
            rtb.Size = lbl.Size;
            rtb.Location = lbl.Location;
            rtb.Text = lbl.Text;
            rtb.Dock = lbl.Dock;

            lbl.Visible = false;

            rtb.KeyPress += LostFoc;
        }

        public void LostFoc(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Nombre = ((RichTextBox)sender).Text;
                LostFoco.Invoke(this, e);
                Controls.Remove((RichTextBox)sender);
                lbl.Visible = true;
            }
        }

        private void Carpeta_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                if (Control.ModifierKeys == Keys.Control)
                {
                    seleccionado = true;
                    this.BackColor = Color.FromArgb(69, Estilo.enfasis);
                }
                else
                {
                    Deseleccionar.Invoke(this, e);
                    this.BackColor = Estilo.fondo;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                cms.Show(this, new Point(e.Location.X + ((Control)sender).Location.X, e.Location.Y + ((Control)sender).Location.Y));
            }
        }

        private void Carpeta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                OnDoubleClick(e);
            }
        }

        private void cambiarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarNombre();
        }

        private void Filtros(object sender, string filtros)
        {
            mimeTypes = filtros;
            CambiarFiltros.Invoke(this, filtros);
        }
        private void eliminarCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar.Invoke(this, e);
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seleccionado == true)
            {
                DescargarCarpeta.Invoke(this, e);
            }
            else
            {
                MessageBox.Show("Seleccione la carpeta correctamente.");
            }
        }

        private void cambiarFiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(proyecto == false)
            {
                frmCarpetaConf config = new(mimeTypes, Nombre);
                config.Show();
                config.Filtrar += Filtros;
            }
            else
            {
                MessageBox.Show("No puedes configurar una carpeta de proyecto", "Error");
            }
        }

        private void Carpeta_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            ClickPoint = e.Location;
        }

        private void Carpeta_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        private void Carpeta_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked && e.Location != ClickPoint)
            {
                DoDragDrop(id, DragDropEffects.Move);
            }
        }

        private void Carpeta_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat) && (string)e.Data.GetData(DataFormats.StringFormat) != id) 
                e.Effect = DragDropEffects.Move;
        }
    }
}   