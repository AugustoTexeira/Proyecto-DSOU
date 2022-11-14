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
    public partial class Archivo : UserControl
    {
        public string Nombre;
        public string id;
        public Archivo(Image imagen)
        {
            InitializeComponent();
        }

        public Archivo()
        {
            InitializeComponent();
        }
    }
}
