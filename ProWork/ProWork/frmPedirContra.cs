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
    public partial class frmPedirContra : Form
    {
        public frmPedirContra()
        {
            InitializeComponent();
            cbtConfirmar.ButtonClick += confirmado;
            utbContra.EnterPressed += confirmado;
        }

        public event EventHandler confirmado;
    }
}
