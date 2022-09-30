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
    public partial class Carpeta : UserControl
    {
        public string Nombre
        {
            get { return lbl.Text; }
            set { lbl.Text = value; }
        }
        public int id;
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

        public virtual void OnDoubleClick(EventArgs e)
        {
            CarpetaDoubleClick.Invoke(id, e);
        }
        public virtual void Carpeta_DoubleClick(object sender, EventArgs e)
        {
            OnDoubleClick(e);
        }
    }
}