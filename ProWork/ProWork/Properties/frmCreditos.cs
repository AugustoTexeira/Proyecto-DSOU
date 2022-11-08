using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProWork.Properties
{
    public partial class frmCreditos : Form
    {
        private byte r;
        private bool rd = true;
        private byte g;
        private bool gd = true;
        private byte b;
        private bool bd = true;
        private const int speed = 3;
        public frmCreditos()
        {
            InitializeComponent();
            lbl.Text = "Alan Moreira \nAugusto Texeira\nJulián Pinto \nCristian Rodríguez";
            BackColor = Estilo.fondo;
            lbl.ForeColor = Estilo.fondo;
            De_Configuración__Cristian_.ConfigContainer.ColorSwap += colorSwap;
        }

        private void colorSwap(object sender, EventArgs e)
        {
            BackColor = Estilo.fondo;
            lbl.ForeColor = Estilo.fondo;
        }

        private void epb_Click(object sender, EventArgs e)
        {
            r = BackColor.R;
            g = BackColor.G;
            b = BackColor.B;
            tmr60.Start();
            tmr15.Start();
            tmr30.Start();
        }

        private void frmCreditos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
            Dispose();
        }

        private void tmr60_Tick(object sender, EventArgs e)
        {
            if(bd)
            {
                b += speed;
                if (b == 255)
                {
                    bd = false;
                }
            }
            else
            {
                b -= speed;
                if (b == 0)
                {
                    bd = true;
                }
            }
            BackColor = Color.FromArgb(255, r, g, b);
            lbl.ForeColor = BackColor;
        }

        private void tmr15_Tick(object sender, EventArgs e)
        {
            if (gd)
            {
                g += speed;
                if(g == 255)
                {
                    gd = false;
                }
            }
            else
            {
                g -= speed;
                if (g == 0)
                {
                    gd = true;
                }
            }
        }

        private void tmr30_Tick(object sender, EventArgs e)
        {
            if (rd)
            {
                r += speed;
                if (r == 255)
                {
                    rd = false;
                }
            }
            else
            {
                r -= speed;
                if (r == 0)
                {
                    rd = true;
                }
            }
        }
    }
}
