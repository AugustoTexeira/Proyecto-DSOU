using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProWork
{
    public partial class frmMain : Form
    {
        ////NOMENCLATURA
        //dpl: DoubleBufferedPanel

        private string user;
        private bool admin;
        private bool hover; //true = menu, false = main

        public frmMain(string user, bool admin)
        {
            InitializeComponent();
            this.user = user;
            this.admin = admin;
        }

        //InitializeComponent apareció solo. Mejor no lo toco.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dplMain = new ProWork.DoubleBufferedPanel();
            this.dplMenuP = new ProWork.DoubleBufferedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrMenu = new System.Windows.Forms.Timer(this.components);
            this.dplMenuProyectos = new ProWork.DoubleBufferedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dplMenuC = new ProWork.DoubleBufferedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dplMenuConfig = new ProWork.DoubleBufferedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.dplMenuP.SuspendLayout();
            this.dplMenuProyectos.SuspendLayout();
            this.dplMenuC.SuspendLayout();
            this.dplMenuConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // dplMain
            // 
            this.dplMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dplMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.dplMain.Location = new System.Drawing.Point(128, 0);
            this.dplMain.Margin = new System.Windows.Forms.Padding(0);
            this.dplMain.Name = "dplMain";
            this.dplMain.Size = new System.Drawing.Size(821, 542);
            this.dplMain.TabIndex = 0;
            this.dplMain.MouseEnter += new System.EventHandler(this.dplMain_MouseEnter);
            // 
            // dplMenuP
            // 
            this.dplMenuP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dplMenuP.Controls.Add(this.label1);
            this.dplMenuP.Location = new System.Drawing.Point(0, 136);
            this.dplMenuP.Margin = new System.Windows.Forms.Padding(0);
            this.dplMenuP.Name = "dplMenuP";
            this.dplMenuP.Size = new System.Drawing.Size(128, 64);
            this.dplMenuP.TabIndex = 1;
            this.dplMenuP.MouseEnter += new System.EventHandler(this.dplMenuP_MouseEnter);
            this.dplMenuP.MouseLeave += new System.EventHandler(this.dplMenuP_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.MouseEnter += new System.EventHandler(this.dplMenuP_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.dplMenuP_MouseLeave);
            // 
            // tmrMenu
            // 
            this.tmrMenu.Interval = 16;
            this.tmrMenu.Tick += new System.EventHandler(this.tmrMenu_Tick);
            // 
            // dplMenuProyectos
            // 
            this.dplMenuProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dplMenuProyectos.Controls.Add(this.label2);
            this.dplMenuProyectos.Location = new System.Drawing.Point(0, 200);
            this.dplMenuProyectos.Margin = new System.Windows.Forms.Padding(0);
            this.dplMenuProyectos.Name = "dplMenuProyectos";
            this.dplMenuProyectos.Size = new System.Drawing.Size(128, 64);
            this.dplMenuProyectos.TabIndex = 2;
            this.dplMenuProyectos.MouseEnter += new System.EventHandler(this.dplMenuProyectos_MouseEnter);
            this.dplMenuProyectos.MouseLeave += new System.EventHandler(this.dplMenuProyectos_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(28, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            this.label2.MouseEnter += new System.EventHandler(this.dplMenuProyectos_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.dplMenuProyectos_MouseLeave);
            // 
            // dplMenuC
            // 
            this.dplMenuC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dplMenuC.Controls.Add(this.label3);
            this.dplMenuC.Location = new System.Drawing.Point(0, 264);
            this.dplMenuC.Margin = new System.Windows.Forms.Padding(0);
            this.dplMenuC.Name = "dplMenuC";
            this.dplMenuC.Size = new System.Drawing.Size(128, 64);
            this.dplMenuC.TabIndex = 3;
            this.dplMenuC.MouseEnter += new System.EventHandler(this.dplMenuC_MouseEnter);
            this.dplMenuC.MouseLeave += new System.EventHandler(this.dplMenuC_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(28, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            this.label3.MouseEnter += new System.EventHandler(this.dplMenuC_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.dplMenuC_MouseLeave);
            // 
            // dplMenuConfig
            // 
            this.dplMenuConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dplMenuConfig.Controls.Add(this.label4);
            this.dplMenuConfig.Location = new System.Drawing.Point(0, 469);
            this.dplMenuConfig.Margin = new System.Windows.Forms.Padding(0);
            this.dplMenuConfig.Name = "dplMenuConfig";
            this.dplMenuConfig.Size = new System.Drawing.Size(128, 64);
            this.dplMenuConfig.TabIndex = 4;
            this.dplMenuConfig.MouseEnter += new System.EventHandler(this.dplMenuConfig_MouseEnter);
            this.dplMenuConfig.MouseLeave += new System.EventHandler(this.dplMenuConfig_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(28, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            this.label4.MouseEnter += new System.EventHandler(this.dplMenuConfig_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.dplMenuConfig_MouseLeave);
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(949, 542);
            this.Controls.Add(this.dplMain);
            this.Controls.Add(this.dplMenuConfig);
            this.Controls.Add(this.dplMenuC);
            this.Controls.Add(this.dplMenuProyectos);
            this.Controls.Add(this.dplMenuP);
            this.Name = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.MouseEnter += new System.EventHandler(this.Menu_MouseEnter);
            this.dplMenuP.ResumeLayout(false);
            this.dplMenuP.PerformLayout();
            this.dplMenuProyectos.ResumeLayout(false);
            this.dplMenuProyectos.PerformLayout();
            this.dplMenuC.ResumeLayout(false);
            this.dplMenuC.PerformLayout();
            this.dplMenuConfig.ResumeLayout(false);
            this.dplMenuConfig.PerformLayout();
            this.ResumeLayout(false);

        }
        private void tmrMenu_Tick(object sender, EventArgs e)
        {
            if(hover)
            {
                if(Deslizar(dplMain, this.ClientSize.Width - 128)) { tmrMenu.Stop(); MessageBox.Show("AAA"); }
            }
            else
            {
                if (Deslizar(dplMain, this.ClientSize.Width - 64)) { tmrMenu.Stop(); MessageBox.Show("AAA"); }
            }
        }

        private bool Deslizar(Control ctl, int aimWidth)
        {
            if (ctl.Width < aimWidth)
            {
                decimal cambio = (aimWidth - ctl.Width) / 4;
                ctl.Width += (int)Math.Ceiling(cambio);
                return false;
            }
            else if (ctl.Width > aimWidth)
            {
                decimal cambio = (aimWidth - ctl.Width) / 4;
                ctl.Width += (int)Math.Floor(cambio);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dplMenuP_MouseEnter(object sender, EventArgs e)
        {
            Menu_MouseEnter(sender, e);
            dplMenuP.BackColor = Color.DeepSkyBlue;
        }
        private void dplMenuP_MouseLeave(object sender, EventArgs e)
        {
            dplMenuP.BackColor = Color.FromArgb(48, 48, 48);
        }
        private void Menu_MouseEnter(object sender, EventArgs e)
        {
            tmrMenu.Start();
            hover = true;
        }
        private void dplMain_MouseEnter(object sender, EventArgs e)
        {
            tmrMenu.Start();
            hover = false;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dplMenuProyectos_MouseEnter(object sender, EventArgs e)
        {
            Menu_MouseEnter(sender, e);
            dplMenuProyectos.BackColor = Color.DeepSkyBlue;
        }
        private void dplMenuProyectos_MouseLeave(object sender, EventArgs e)
        {
            dplMenuProyectos.BackColor = Color.FromArgb(48, 48, 48);
        }

        private void dplMenuC_MouseEnter(object sender, EventArgs e)
        {
            Menu_MouseEnter(sender, e);
            dplMenuC.BackColor = Color.DeepSkyBlue;
        }

        private void dplMenuC_MouseLeave(object sender, EventArgs e)
        {
            dplMenuC.BackColor = Color.FromArgb(48, 48, 48);
        }

        private void dplMenuConfig_MouseEnter(object sender, EventArgs e)
        {
            Menu_MouseEnter(sender, e);
            dplMenuConfig.BackColor = Color.DeepSkyBlue;
        }

        private void dplMenuConfig_MouseLeave(object sender, EventArgs e)
        {
            dplMenuConfig.BackColor = Color.FromArgb(48, 48, 48);
        }
    }
}
