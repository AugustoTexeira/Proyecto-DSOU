using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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
            BackColor = Estilo.fondo;
            linksAlan.VisitedLinkColor = BackColor;
            linksAlan.LinkColor = BackColor;
            linksAlan.DisabledLinkColor = BackColor;
            linksAlan.ActiveLinkColor = BackColor;
            linkAugusto.VisitedLinkColor = BackColor;
            linkAugusto.LinkColor = BackColor;
            linkAugusto.DisabledLinkColor = BackColor;
            linkAugusto.ActiveLinkColor = BackColor;
            linkPinto.VisitedLinkColor = BackColor;
            linkPinto.LinkColor = BackColor;
            linkPinto.DisabledLinkColor = BackColor;
            linkCristian.ActiveLinkColor = BackColor;
            linkCristian.VisitedLinkColor = BackColor;
            linkCristian.LinkColor = BackColor;
            linkCristian.DisabledLinkColor = BackColor;
            linkCristian.ActiveLinkColor = BackColor;
            De_Configuración__Cristian_.ConfigContainer.ColorSwap += colorSwap;
        }

        private void colorSwap(object sender, EventArgs e)
        {
            BackColor = Estilo.fondo;
            linksAlan.ForeColor = Estilo.fondo;

            linksAlan.VisitedLinkColor = BackColor;
            linksAlan.LinkColor = BackColor;
            linksAlan.DisabledLinkColor = BackColor;
            linksAlan.ActiveLinkColor = BackColor;
            linkAugusto.VisitedLinkColor = BackColor;
            linkAugusto.LinkColor = BackColor;
            linkAugusto.DisabledLinkColor = BackColor;
            linkAugusto.ActiveLinkColor = BackColor;
            linkPinto.VisitedLinkColor = BackColor;
            linkPinto.LinkColor = BackColor;
            linkPinto.DisabledLinkColor = BackColor;
            linkCristian.ActiveLinkColor = BackColor;
            linkCristian.VisitedLinkColor = BackColor;
            linkCristian.LinkColor = BackColor;
            linkCristian.DisabledLinkColor = BackColor;
            linkCristian.ActiveLinkColor = BackColor;
        }

        private void epb_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("explorer", "https://ezponjares.wixsite.com/dsou");
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
            linksAlan.VisitedLinkColor = BackColor;
            linksAlan.LinkColor = BackColor;
            linksAlan.DisabledLinkColor = BackColor;
            linksAlan.ActiveLinkColor = BackColor;
            linkAugusto.VisitedLinkColor = BackColor;
            linkAugusto.LinkColor = BackColor;
            linkAugusto.DisabledLinkColor = BackColor;
            linkAugusto.ActiveLinkColor = BackColor;
            linkPinto.VisitedLinkColor = BackColor;
            linkPinto.LinkColor = BackColor;
            linkPinto.DisabledLinkColor = BackColor;
            linkCristian.ActiveLinkColor = BackColor;
            linkCristian.VisitedLinkColor = BackColor;
            linkCristian.LinkColor = BackColor;
            linkCristian.DisabledLinkColor = BackColor;
            linkCristian.ActiveLinkColor = BackColor;
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

        private void linksAlan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var destinationurl = "mailto:Alanmoreiramar2016@gmail.com" + "?subject=Soporte técnico de DSOU SRL";
            var sInfo = new System.Diagnostics.ProcessStartInfo(destinationurl)
            {
                UseShellExecute = true,
            };
            System.Diagnostics.Process.Start(sInfo);
        }

        private void linkAugusto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var destinationurl = "mailto:augustotexeira23@gmail.com" + "?subject=Soporte técnico de DSOU SRL";
            var sInfo = new System.Diagnostics.ProcessStartInfo(destinationurl)
            {
                UseShellExecute = true,
            };
            System.Diagnostics.Process.Start(sInfo);
        }

        private void linkPinto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var destinationurl = "mailto:julianpinto444@gmail.com" + "?subject=Soporte técnico de DSOU SRL";
            var sInfo = new System.Diagnostics.ProcessStartInfo(destinationurl)
            {
                UseShellExecute = true,
            };
            System.Diagnostics.Process.Start(sInfo);
        }

        private void linkCristian_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var destinationurl = "mailto:ezponjares@gmail.com" + "?subject=Soporte técnico de DSOU SRL";
            var sInfo = new System.Diagnostics.ProcessStartInfo(destinationurl)
            {
                UseShellExecute = true,
            };
            System.Diagnostics.Process.Start(sInfo);
        }

        private void epb_DoubleClick(object sender, EventArgs e)
        {
            r = BackColor.R;
            g = BackColor.G;
            b = BackColor.B;
            tmr60.Start();
            tmr15.Start();
            tmr30.Start();
        }
    }
}
