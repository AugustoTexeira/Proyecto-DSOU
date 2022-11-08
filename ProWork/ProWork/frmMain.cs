using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProWork.De_Configuración__Cristian_;
namespace ProWork
{
    public partial class frmMain : Form
    {
        private ConfigContainer configContainer = new();
        private ContactosContainer contactosContainer = new();
        private ProyectosContainer proyectosContainer = new();
        private InicioContainer inicioContainer = new();
        public frmMain()
        {
            InitializeComponent();
            menu.SelectedScreenChanged += menu_SelectedScreenChanged;
            ShowIcon = false;
            Size = new(1280, 720);
            MinimumSize = new(960, 540);
            contactosContainer.Enabled = false;
            contactosContainer.Visible = false;
            proyectosContainer.Enabled = false;
            proyectosContainer.Visible = false;
            configContainer.Enabled = false;
            configContainer.Visible = false;

            Controls.Add(inicioContainer);
            Controls.Add(configContainer);
            Controls.Add(contactosContainer);
            Controls.Add(proyectosContainer);

            if(Estilo.fondo == Color.White)
            {
                menu.BackColor = Estilo.contrasteLigero;
                BackColor = Estilo.fondo;
            }

            ConfigContainer.ColorSwap += colorSwap;
        }

        private void colorSwap(object sender, EventArgs e)
        {
            BackColor = Estilo.fondo;
        }

        private void frmPruebaa_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
            Dispose();
        }

        private void frmPruebaa_Layout(object sender, LayoutEventArgs e)
        {
            if(configContainer.Enabled)
            {
                configContainer.Location = new(menu.Width, configContainer.Location.Y);
                configContainer.Size = new(ClientSize.Width - menu.minWidth, ClientSize.Height);
            }

            if(contactosContainer.Enabled)
            {
                contactosContainer.Location = new(menu.Width, contactosContainer.Location.Y);
                contactosContainer.Size = new(ClientSize.Width - menu.minWidth, ClientSize.Height);
            }

            if(proyectosContainer.Enabled)
            {
                proyectosContainer.Location = new(menu.Width, proyectosContainer.Location.Y);
                proyectosContainer.Size = new(ClientSize.Width - menu.minWidth, ClientSize.Height);
            }
            
            if(inicioContainer.Enabled)
            {
                inicioContainer.Location = new(menu.Width, inicioContainer.Location.Y);
                inicioContainer.Size = new(ClientSize.Width - menu.minWidth, ClientSize.Height);
            }
        }

        private void menu_SelectedScreenChanged(object sender, EventArgs e)
        {
            switch (menu.SelectedScreen)
            {
                case byte i when i > menu.PreviousScreen:
                    switch (menu.SelectedScreen)
                    {
                        case 1:
                            proyectosContainer.Enabled = true;
                            proyectosContainer.Visible = true;
                            proyectosContainer.BringToFront();
                            proyectosContainer.Location = new(proyectosContainer.Location.X, Height);
                            break;
                        case 2:
                            contactosContainer.Enabled = true;
                            contactosContainer.Visible = true;
                            contactosContainer.BringToFront();
                            contactosContainer.Location = new(contactosContainer.Location.X, Height);
                            break;
                        case 3:
                            configContainer.Enabled = true;
                            configContainer.Visible = true;
                            configContainer.BringToFront();
                            configContainer.Location = new(configContainer.Location.X, Height);
                            break;
                    }
                    frmPruebaa_Layout(this, null);
                    tmrDown.Start();
                    break;
                case byte i when i < menu.PreviousScreen:
                    switch (menu.SelectedScreen)
                    {
                        case 0:
                            inicioContainer.Enabled = true;
                            inicioContainer.Visible = true;
                            inicioContainer.BringToFront();
                            inicioContainer.Location = new(inicioContainer.Location.X, -Height);
                            break;
                        case 1:
                            proyectosContainer.Enabled = true;
                            proyectosContainer.Visible = true;
                            proyectosContainer.BringToFront();
                            proyectosContainer.Location = new(proyectosContainer.Location.X, -Height);
                            break;
                        case 2:
                            contactosContainer.Enabled = true;
                            contactosContainer.Visible = true;
                            contactosContainer.BringToFront();
                            contactosContainer.Location = new(contactosContainer.Location.X, -Height);
                            break;
                    }
                    frmPruebaa_Layout(this, null);
                    tmrUp.Start();
                    break;
                case byte i when i == menu.PreviousScreen:
                    switch (menu.SelectedScreen)
                    {
                        case 0:
                            break;
                        case 1:
                            break;
                        case 2:
                            contactosContainer.ResetElementos(this, e);
                            break;
                        case 3:
                            configContainer.ResetElementos(null);
                            break;
                    }
                    break;
            }
        }

        private void tmrDown_Tick(object sender, EventArgs e) // de menor a mayor; de mas arriba a mas abajo
        {
            switch (menu.PreviousScreen)
            {
                case 0:
                    switch (menu.SelectedScreen)
                    {
                        case 1:
                            if (proyectosContainer.Location.Y < 2)
                            {
                                inicioContainer.Location = new(proyectosContainer.Location.X, Height);
                                proyectosContainer.Location = new(proyectosContainer.Location.X, 0);
                                inicioContainer.Enabled = false;
                                inicioContainer.Visible = false;
                                tmrDown.Stop();
                                return;
                            }
                            else
                            {
                                int cambio = proyectosContainer.Location.Y / 5;
                                inicioContainer.Location = new(inicioContainer.Location.X, inicioContainer.Location.Y - cambio);
                                proyectosContainer.Location = new(proyectosContainer.Location.X, proyectosContainer.Location.Y - cambio);
                            }
                            break;
                        case 2:
                            if (contactosContainer.Location.Y < 2)
                            {
                                inicioContainer.Location = new(contactosContainer.Location.X, Height);
                                contactosContainer.Location = new(contactosContainer.Location.X, 0);
                                inicioContainer.Enabled = false;
                                inicioContainer.Visible = false;
                                tmrDown.Stop();
                                return;
                            }
                            else
                            {
                                int cambio = contactosContainer.Location.Y / 5;
                                inicioContainer.Location = new(inicioContainer.Location.X, inicioContainer.Location.Y - cambio);
                                contactosContainer.Location = new(contactosContainer.Location.X, contactosContainer.Location.Y - cambio);
                            }
                            break;
                        case 3:
                            if (configContainer.Location.Y < 2)
                            {
                                inicioContainer.Location = new(configContainer.Location.X, Height);
                                configContainer.Location = new(configContainer.Location.X, 0);
                                inicioContainer.Enabled = false;
                                inicioContainer.Visible = false;
                                tmrDown.Stop();
                                return;
                            }
                            else
                            {
                                int cambio = configContainer.Location.Y / 5;
                                inicioContainer.Location = new(inicioContainer.Location.X, inicioContainer.Location.Y - cambio);
                                configContainer.Location = new(configContainer.Location.X, configContainer.Location.Y - cambio);
                            }
                            break;
                    }
                    break;
                case 1:
                    switch (menu.SelectedScreen)
                    {
                        case 2:
                            if (contactosContainer.Location.Y < 2)
                            {
                                proyectosContainer.Location = new(contactosContainer.Location.X, Height);
                                contactosContainer.Location = new(contactosContainer.Location.X, 0);
                                proyectosContainer.Enabled = false;
                                proyectosContainer.Visible = false;
                                tmrDown.Stop();
                                return;
                            }
                            else
                            {
                                int cambio = contactosContainer.Location.Y / 5;
                                proyectosContainer.Location = new(proyectosContainer.Location.X, proyectosContainer.Location.Y - cambio);
                                contactosContainer.Location = new(contactosContainer.Location.X, contactosContainer.Location.Y - cambio);
                            }
                            break;
                        case 3:
                            if (configContainer.Location.Y < 2)
                            {
                                proyectosContainer.Location = new(configContainer.Location.X, Height);
                                configContainer.Location = new(configContainer.Location.X, 0);
                                proyectosContainer.Enabled = false;
                                proyectosContainer.Visible = false;
                                tmrDown.Stop();
                                return;
                            }
                            else
                            {
                                int cambio = configContainer.Location.Y / 5;
                                proyectosContainer.Location = new(proyectosContainer.Location.X, proyectosContainer.Location.Y - cambio);
                                configContainer.Location = new(configContainer.Location.X, configContainer.Location.Y - cambio);
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (menu.SelectedScreen)
                    {
                        case 3:
                            if (configContainer.Location.Y < 2)
                            {
                                contactosContainer.Location = new(configContainer.Location.X, Height);
                                configContainer.Location = new(configContainer.Location.X, 0);
                                contactosContainer.Enabled = false;
                                contactosContainer.Visible = false;
                                tmrDown.Stop();
                                return;
                            }
                            else
                            {
                                int cambio = configContainer.Location.Y / 5;
                                contactosContainer.Location = new(contactosContainer.Location.X, contactosContainer.Location.Y - cambio);
                                configContainer.Location = new(configContainer.Location.X, configContainer.Location.Y - cambio);
                            }
                            break;
                    }
                    break;
            }
        }

        private void tmrUp_Tick(object sender, EventArgs e) //de mayor a menor; de mas abajo a mas arriba
        {
            switch (menu.PreviousScreen)
            {
                case 1:
                    switch (menu.SelectedScreen)
                    {
                        case 0:
                            if (inicioContainer.Location.Y > -2)
                            {
                                proyectosContainer.Location = new(proyectosContainer.Location.X, Height);
                                inicioContainer.Location = new(inicioContainer.Location.X, 0);
                                proyectosContainer.Enabled = false;
                                proyectosContainer.Visible = false;
                                tmrDown.Stop();
                                return;
                            }
                            else
                            {
                                int cambio = inicioContainer.Location.Y / -5;
                                inicioContainer.Location = new(inicioContainer.Location.X, inicioContainer.Location.Y + cambio);
                                proyectosContainer.Location = new(proyectosContainer.Location.X, proyectosContainer.Location.Y + cambio);
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (menu.SelectedScreen)
                    {
                        case 0:
                            if (inicioContainer.Location.Y > -2)
                            {
                                contactosContainer.Location = new(contactosContainer.Location.X, Height);
                                inicioContainer.Location = new(inicioContainer.Location.X, 0);
                                contactosContainer.Enabled = false;
                                contactosContainer.Visible = false;
                                tmrDown.Stop();
                                return;
                            }
                            else
                            {
                                int cambio = inicioContainer.Location.Y / -5;
                                inicioContainer.Location = new(inicioContainer.Location.X, inicioContainer.Location.Y + cambio);
                                contactosContainer.Location = new(contactosContainer.Location.X, contactosContainer.Location.Y + cambio);
                            }
                            break;
                        case 1:
                            if (proyectosContainer.Location.Y > -2)
                            {
                                contactosContainer.Location = new(contactosContainer.Location.X, Height);
                                proyectosContainer.Location = new(proyectosContainer.Location.X, 0);
                                contactosContainer.Enabled = false;
                                contactosContainer.Visible = false;
                                tmrDown.Stop();
                                return;
                            }
                            else
                            {
                                int cambio = proyectosContainer.Location.Y / -5;
                                proyectosContainer.Location = new(proyectosContainer.Location.X, proyectosContainer.Location.Y + cambio);
                                contactosContainer.Location = new(contactosContainer.Location.X, contactosContainer.Location.Y + cambio);
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (menu.SelectedScreen)
                    {
                        case 0:
                            if (inicioContainer.Location.Y > -2)
                            {
                                configContainer.Location = new(configContainer.Location.X, Height);
                                inicioContainer.Location = new(inicioContainer.Location.X, 0);
                                configContainer.Enabled = false;
                                configContainer.Visible = false;
                                tmrDown.Stop();
                                return;
                            }
                            else
                            {
                                int cambio = inicioContainer.Location.Y / -5;
                                inicioContainer.Location = new(inicioContainer.Location.X, inicioContainer.Location.Y + cambio);
                                configContainer.Location = new(configContainer.Location.X, configContainer.Location.Y + cambio);
                            }
                            break;
                        case 1:
                            if (proyectosContainer.Location.Y > -2)
                            {
                                configContainer.Location = new(configContainer.Location.X, Height);
                                proyectosContainer.Location = new(proyectosContainer.Location.X, 0);
                                configContainer.Enabled = false;
                                configContainer.Visible = false;
                                tmrDown.Stop();
                                return;
                            }
                            else
                            {
                                int cambio = proyectosContainer.Location.Y / -5;
                                proyectosContainer.Location = new(proyectosContainer.Location.X, proyectosContainer.Location.Y + cambio);
                                configContainer.Location = new(configContainer.Location.X, configContainer.Location.Y + cambio);
                            }
                            break;
                        case 2:
                            if (contactosContainer.Location.Y > -2)
                            {
                                configContainer.Location = new(configContainer.Location.X, Height);
                                contactosContainer.Location = new(contactosContainer.Location.X, 0);
                                configContainer.Enabled = false;
                                configContainer.Visible = false;
                                tmrDown.Stop();
                                return;
                            }
                            else
                            {
                                int cambio = contactosContainer.Location.Y / 5;
                                contactosContainer.Location = new(contactosContainer.Location.X, contactosContainer.Location.Y - cambio);
                                configContainer.Location = new(configContainer.Location.X, configContainer.Location.Y - cambio);
                            }
                            break;
                    }
                    break;
            }
        }

        private void frmMain_ResizeEnd(object sender, EventArgs e)
        {
            switch (menu.SelectedScreen)
            {
                case 0:
                    inicioContainer.PerformLayout();
                    break;
                case 1:
                    proyectosContainer.PerformLayout();
                    break;
                case 2:
                    contactosContainer.PerformLayout();
                    break;
                case 3:
                    configContainer.PerformLayout();
                    break;
            }
        }
    }
}
