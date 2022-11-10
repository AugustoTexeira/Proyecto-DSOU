using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ProWork
{
    public partial class mainMenu : UserControl
    {
        private enhancedPictureBox epbLogo = new();
        private TextureBrush inicioImage;
        private TextureBrush proyectosImage;
        private TextureBrush contactosImage;
        private TextureBrush configImage;
        private LinearGradientBrush brush;
        private byte previousScreen;
        public int minWidth;
        public byte PreviousScreen
        {
            get { return previousScreen; }
        }
        private byte selectedScreen = 0; //0 = inicio; 1 = proyectos; 2 = contactos; 3 = configuracion
        public byte SelectedScreen
        {
            get { return selectedScreen; }
            set 
            {
                previousScreen = selectedScreen;
                selectedScreen = value;
                SelectedScreenChanged.Invoke(this, null);
                switch (value)
                {
                    case 0:
                        if (pnlProyectos.ForeColor == Color.White)
                        {
                            proyectosImage = new(Estilo.sizeToHeight(Properties.Resources.Proyectos_Gris, (pnlConfig.Height / 4) * 3));
                            proyectosImage.TranslateTransform(proyectosImage.Image.Height / 2, (pnlConfig.Height - proyectosImage.Image.Height) / 2);
                            pnlProyectos.ForeColor = calculateColor();
                        }
                        if (pnlContactos.ForeColor == Color.White)
                        {
                            contactosImage = new(Estilo.sizeToHeight(Properties.Resources.Contactos_Gris, (pnlConfig.Height / 4) * 3));
                            contactosImage.TranslateTransform(contactosImage.Image.Height / 2, (pnlConfig.Height - contactosImage.Image.Height) / 2);
                            pnlContactos.ForeColor = calculateColor();
                        }
                        if (pnlConfig.ForeColor == Color.White)
                        {
                            configImage = new(Estilo.sizeToHeight(Properties.Resources.Ajustes_Gris, (pnlConfig.Height / 4) * 3));
                            configImage.TranslateTransform(configImage.Image.Height / 2, (pnlConfig.Height - configImage.Image.Height) / 2);
                            pnlConfig.ForeColor = Estilo.contrasteLigero;
                        }
                        pnlInicio.ForeColor = Color.White;
                        pnlInicio.Refresh();
                        break;
                    case 1:
                        if (pnlInicio.ForeColor == Color.White)
                        {
                            inicioImage = new(Estilo.sizeToHeight(Properties.Resources.Home_Gris, (pnlConfig.Height / 4) * 3));
                            inicioImage.TranslateTransform(inicioImage.Image.Height / 2, (pnlConfig.Height - inicioImage.Image.Height) / 2);
                            pnlInicio.ForeColor = calculateColor();
                        }
                        if (pnlContactos.ForeColor == Color.White)
                        {
                            contactosImage = new(Estilo.sizeToHeight(Properties.Resources.Contactos_Gris, (pnlConfig.Height / 4) * 3));
                            contactosImage.TranslateTransform(contactosImage.Image.Height / 2, (pnlConfig.Height - contactosImage.Image.Height) / 2);
                            pnlContactos.ForeColor = calculateColor();
                        }
                        if (pnlConfig.ForeColor == Color.White)
                        {
                            configImage = new(Estilo.sizeToHeight(Properties.Resources.Ajustes_Gris, (pnlConfig.Height / 4) * 3));
                            configImage.TranslateTransform(configImage.Image.Height / 2, (pnlConfig.Height - configImage.Image.Height) / 2);
                            pnlConfig.ForeColor = calculateColor();
                        }
                        pnlProyectos.ForeColor = Color.White;
                        pnlProyectos.Refresh();
                        break;
                    case 2:
                        if (pnlInicio.ForeColor == Color.White)
                        {
                            inicioImage = new(Estilo.sizeToHeight(Properties.Resources.Home_Gris, (pnlConfig.Height / 4) * 3));
                            inicioImage.TranslateTransform(inicioImage.Image.Height / 2, (pnlConfig.Height - inicioImage.Image.Height) / 2);
                            pnlInicio.ForeColor = calculateColor();;
                        }
                        if (pnlProyectos.ForeColor == Color.White)
                        {
                            proyectosImage = new(Estilo.sizeToHeight(Properties.Resources.Proyectos_Gris, (pnlConfig.Height / 4) * 3));
                            proyectosImage.TranslateTransform(proyectosImage.Image.Height / 2, (pnlConfig.Height - proyectosImage.Image.Height) / 2);
                            pnlProyectos.ForeColor = calculateColor();;
                        }
                        if (pnlConfig.ForeColor == Color.White)
                        {
                            configImage = new(Estilo.sizeToHeight(Properties.Resources.Ajustes_Gris, (pnlConfig.Height / 4) * 3));
                            configImage.TranslateTransform(configImage.Image.Height / 2, (pnlConfig.Height - configImage.Image.Height) / 2);
                            pnlConfig.ForeColor = calculateColor();;
                        }
                        pnlContactos.ForeColor = Color.White;
                        pnlContactos.Refresh();
                        break;
                    case 3:
                        if (pnlInicio.ForeColor == Color.White)
                        {
                            inicioImage = new(Estilo.sizeToHeight(Properties.Resources.Home_Gris, (pnlConfig.Height / 4) * 3));
                            inicioImage.TranslateTransform(inicioImage.Image.Height / 2, (pnlConfig.Height - inicioImage.Image.Height) / 2);
                            pnlInicio.ForeColor = calculateColor();;
                        }
                        if (pnlProyectos.ForeColor == Color.White)
                        {
                            proyectosImage = new(Estilo.sizeToHeight(Properties.Resources.Proyectos_Gris, (pnlConfig.Height / 4) * 3));
                            proyectosImage.TranslateTransform(proyectosImage.Image.Height / 2, (pnlConfig.Height - proyectosImage.Image.Height) / 2);
                            pnlProyectos.ForeColor = calculateColor();;
                        }
                        if (pnlContactos.ForeColor == Color.White)
                        {
                            contactosImage = new(Estilo.sizeToHeight(Properties.Resources.Contactos_Gris, (pnlConfig.Height / 4) * 3));
                            contactosImage.TranslateTransform(contactosImage.Image.Height / 2, (pnlConfig.Height - contactosImage.Image.Height) / 2);
                            pnlContactos.ForeColor = calculateColor();;
                        }
                        pnlConfig.ForeColor = Color.White;
                        pnlConfig.Refresh();
                        break;
                }
            }
        }
        public mainMenu()
        {
            SelectedScreenChanged += Paqnosequeje;
            De_Configuración__Cristian_.ConfigContainer.ColorSwap += colorSwap;
            InitializeComponent();

            //Paneles

            pnlConfig.Height = (int)(Font.Height * 1.5);
            pnlInicio.Height = pnlConfig.Height;
            pnlProyectos.Height = pnlConfig.Height;
            pnlContactos.Height = pnlConfig.Height;
            pnlProyectos.Location = new(0, pnlInicio.Location.Y + pnlInicio.Height + Estilo.medioAnchoLinea);
            pnlContactos.Location = new(0, pnlInicio.Location.Y + pnlInicio.Height * 2 + Estilo.anchoLinea);

            if(Estilo.fondo == Color.White)
            {
                pnlInicio.BackColor = Estilo.fondo;
                pnlProyectos.BackColor = Estilo.fondo;
                pnlContactos.BackColor = Estilo.fondo;
                pnlConfig.BackColor = Estilo.fondo;
            }

            configImage = new(Estilo.sizeToHeight(Properties.Resources.Ajustes_Gris, (pnlConfig.Height / 4) * 3));
            configImage.TranslateTransform(configImage.Image.Height / 2, (pnlConfig.Height - configImage.Image.Height) / 2);

            inicioImage = new(Estilo.sizeToHeight(Properties.Resources.Home_Blanco, (pnlConfig.Height / 4) * 3));
            inicioImage.TranslateTransform(inicioImage.Image.Height / 2, (pnlConfig.Height - inicioImage.Image.Height) / 2);

            proyectosImage = new(Estilo.sizeToHeight(Properties.Resources.Proyectos_Gris, (pnlConfig.Height / 4) * 3));
            proyectosImage.TranslateTransform(proyectosImage.Image.Height / 2, (pnlConfig.Height - proyectosImage.Image.Height) / 2);

            contactosImage = new(Estilo.sizeToHeight(Properties.Resources.Contactos_Gris, (pnlConfig.Height / 4) * 3));
            contactosImage.TranslateTransform(contactosImage.Image.Height / 2, (pnlConfig.Height - contactosImage.Image.Height) / 2);

            pnlConfig.Width = configImage.Image.Width * 2 + TextRenderer.MeasureText("Configuración", Font).Width;
            brush = new(new(0, 0), new(pnlConfig.Width, pnlConfig.Height), Estilo.enfasis, Estilo.degrEnfasis);

            Width = configImage.Image.Width * 2;
            minWidth = Width;

            pnlInicio.Width = pnlConfig.Width;
            pnlProyectos.Width = pnlConfig.Width;
            pnlContactos.Width = pnlConfig.Width;

            //Logo
            Controls.Add(epbLogo);
            epbLogo.BkgImage = Properties.Resources.Carpetas;
            epbLogo.sizeToWidth((int)(pnlConfig.Width / 2));
            epbLogo.Location = new((pnlConfig.Width- epbLogo.Width) / 2, (pnlInicio.Location.Y - epbLogo.Height) / 2);
            epbLogo.Cursor = Cursors.Hand;
            epbLogo.MouseEnter += mainMenu_MouseEnter;
            epbLogo.MouseLeave += mainMenu_MouseLeave;
            epbLogo.Click += click;
        }
        private void click(object sender, EventArgs e)
        {
            Properties.frmCreditos frm = new();
            frm.Show();
        }
        private void colorSwap(object sender, EventArgs e)
        {
            if ((bool)sender)
            {
                BackColor = Estilo.contrasteLigero;
                switch (selectedScreen)
                {
                    case 0:
                        pnlConfig.ForeColor = Estilo.degrContraste;
                        pnlContactos.ForeColor = Estilo.degrContraste;
                        pnlProyectos.ForeColor = Estilo.degrContraste;
                        break;
                    case 1:
                        pnlConfig.ForeColor = Estilo.degrContraste;
                        pnlContactos.ForeColor = Estilo.degrContraste;
                        pnlInicio.ForeColor = Estilo.degrContraste;
                        break;
                    case 2:
                        pnlConfig.ForeColor = Estilo.degrContraste;
                        pnlInicio.ForeColor = Estilo.degrContraste;
                        pnlProyectos.ForeColor = Estilo.degrContraste;
                        break;
                    case 3:
                        pnlContactos.ForeColor = Estilo.degrContraste;
                        pnlInicio.ForeColor = Estilo.degrContraste;
                        pnlProyectos.ForeColor = Estilo.degrContraste;
                        break;
                }
            }
            else
            {
                BackColor = Color.Black;
                switch (selectedScreen)
                {
                    case 0:
                        pnlConfig.ForeColor = Estilo.contrasteLigero;
                        pnlContactos.ForeColor = Estilo.contrasteLigero;
                        pnlProyectos.ForeColor = Estilo.contrasteLigero;
                        break;
                    case 1:
                        pnlConfig.ForeColor = Estilo.contrasteLigero;
                        pnlContactos.ForeColor = Estilo.contrasteLigero;
                        pnlInicio.ForeColor = Estilo.contrasteLigero;
                        break;
                    case 2:
                        pnlConfig.ForeColor = Estilo.contrasteLigero;
                        pnlInicio.ForeColor = Estilo.contrasteLigero;
                        pnlProyectos.ForeColor = Estilo.contrasteLigero;
                        break;
                    case 3:
                        pnlContactos.ForeColor = Estilo.contrasteLigero;
                        pnlInicio.ForeColor = Estilo.contrasteLigero;
                        pnlProyectos.ForeColor = Estilo.contrasteLigero;
                        break;
                }
            }
            pnlConfig.BackColor = Estilo.fondo;
            pnlContactos.BackColor = Estilo.fondo;
            pnlInicio.BackColor = Estilo.fondo;
            pnlProyectos.BackColor = Estilo.fondo;
        }

        private void mainMenu_Layout(object sender, LayoutEventArgs e)
        {
            pnlConfig.Location = new(0, (int)(Height - pnlConfig.Height - 20));
        }
        private void Paqnosequeje(object sender, EventArgs e)
        {
        }

        private void tmrExtend_Tick(object sender, EventArgs e)
        {
            if(Width > pnlConfig.Width - 2)
            {
                Width = pnlConfig.Width;
                tmrExtend.Stop();
                return;
            }
            else
            {
                Width += (int)((pnlConfig.Width - Width) / 2);
            }
        }

        private void tmrShorten_Tick(object sender, EventArgs e)
        {
            if (Width < configImage.Image.Width * 2 + 2)
            {
                Width = configImage.Image.Width * 2;
                tmrExtend.Stop();
                return;
            }
            else
            {
                Width -= (int)((Width - configImage.Image.Width * 2) / 2);
            }
        }

        private void mainMenu_MouseEnter(object sender, EventArgs e)
        {
            tmrShorten.Stop();
            tmrExtend.Start();
        }

        private void mainMenu_MouseLeave(object sender, EventArgs e)
        {
            tmrExtend.Stop();
            tmrShorten.Start();
        }
        private void pnlConfig_Paint(object sender, PaintEventArgs e)
        {
            if (selectedScreen == 3)
            {
                e.Graphics.FillRectangle(brush, pnlConfig.ClientRectangle);
            }

            e.Graphics.FillRectangle(configImage, new Rectangle(new(configImage.Image.Height / 2, (pnlConfig.Height - configImage.Image.Height) / 2), new(configImage.Image.Width, configImage.Image.Height)));
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.DrawString("Configuración", Font, new SolidBrush(pnlConfig.ForeColor), new Point(configImage.Image.Width * 2, pnlConfig.Height / 5));
        }

        private void pnlContactos_Paint(object sender, PaintEventArgs e)
        {
            if (selectedScreen == 2)
            {
                e.Graphics.FillRectangle(brush, pnlContactos.ClientRectangle);
            }

            e.Graphics.FillRectangle(contactosImage, new Rectangle(new(contactosImage.Image.Height / 2, (pnlConfig.Height - contactosImage.Image.Height) / 2), new(contactosImage.Image.Width, contactosImage.Image.Height)));
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.DrawString("Contactos", Font, new SolidBrush(pnlContactos.ForeColor), new Point(contactosImage.Image.Width * 2, pnlConfig.Height / 5));
        }

        private void pnlProyectos_Paint(object sender, PaintEventArgs e)
        {
            if (selectedScreen == 1)
            {
                e.Graphics.FillRectangle(brush, pnlProyectos.ClientRectangle);
            }

            e.Graphics.FillRectangle(proyectosImage, new Rectangle(new(proyectosImage.Image.Height / 2, (pnlProyectos.Height - proyectosImage.Image.Height) / 2), new(proyectosImage.Image.Width, proyectosImage.Image.Height)));
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.DrawString("Proyectos", Font, new SolidBrush(pnlProyectos.ForeColor), new Point(proyectosImage.Image.Width * 2, pnlProyectos.Height / 5));
        }

        private void pnlInicio_Paint(object sender, PaintEventArgs e)
        {
            if (selectedScreen == 0)
            {
                e.Graphics.FillRectangle(brush, pnlInicio.ClientRectangle);
            }

            e.Graphics.FillRectangle(inicioImage, new Rectangle(new(inicioImage.Image.Height / 2, (pnlInicio.Height - inicioImage.Image.Height) / 2), new(inicioImage.Image.Width, inicioImage.Image.Height)));
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.DrawString("Inicio", Font, new SolidBrush(pnlInicio.ForeColor), new Point(inicioImage.Image.Width * 2, pnlInicio.Height / 5));
        }
        private void pnlConfig_MouseEnter(object sender, EventArgs e)
        {
            configImage = new(Estilo.sizeToHeight(Properties.Resources.Configuración, (pnlConfig.Height / 4) * 3));
            configImage.TranslateTransform(configImage.Image.Height / 2, (pnlConfig.Height - configImage.Image.Height) / 2);
            pnlConfig.ForeColor = Color.White;
            if (Estilo.fondo == Color.White)
            {
                pnlConfig.BackColor = Estilo.degrContraste;
            }
            else
            {
                pnlConfig.BackColor = Estilo.contrasteLigero;
            }
            tmrShorten.Stop();
            tmrExtend.Start();
        }

        private void pnlContactos_MouseEnter(object sender, EventArgs e)
        {
            contactosImage = new(Estilo.sizeToHeight(Properties.Resources.Contactos_Blanco, (pnlConfig.Height / 4) * 3));
            contactosImage.TranslateTransform(contactosImage.Image.Height / 2, (pnlConfig.Height - contactosImage.Image.Height) / 2);
            pnlContactos.ForeColor = Color.White;
            if (Estilo.fondo == Color.White)
            {
                pnlContactos.BackColor = Estilo.degrContraste;
            }
            else
            {
                pnlContactos.BackColor = Estilo.contrasteLigero;
            }
            tmrShorten.Stop();
            tmrExtend.Start();
        }

        private void pnlInicio_MouseEnter(object sender, EventArgs e)
        {
            inicioImage = new(Estilo.sizeToHeight(Properties.Resources.Home_Blanco, (pnlConfig.Height / 4) * 3));
            inicioImage.TranslateTransform(inicioImage.Image.Height / 2, (pnlConfig.Height - inicioImage.Image.Height) / 2);
            pnlInicio.ForeColor = Color.White;
            if (Estilo.fondo == Color.White)
            {
                pnlInicio.BackColor = Estilo.degrContraste;
            }
            else
            {
                pnlInicio.BackColor = Estilo.contrasteLigero;
            }
            tmrShorten.Stop();
            tmrExtend.Start();
        }

        private void pnlProyectos_MouseEnter(object sender, EventArgs e)
        {
            proyectosImage = new(Estilo.sizeToHeight(Properties.Resources.Proyectos_Blanco, (pnlConfig.Height / 4) * 3));
            proyectosImage.TranslateTransform(proyectosImage.Image.Height / 2, (pnlConfig.Height - proyectosImage.Image.Height) / 2);
            pnlProyectos.ForeColor = Color.White;
            if (Estilo.fondo == Color.White)
            {
                pnlProyectos.BackColor = Estilo.degrContraste;
            }
            else
            {
                pnlProyectos.BackColor = Estilo.contrasteLigero;
            }
            tmrShorten.Stop();
            tmrExtend.Start();
        }
        private async void pnlConfig_MouseLeave(object sender, EventArgs e)
        {
            tmrExtend.Stop();
            tmrShorten.Start();
            await Task.Delay(25);
            if(selectedScreen != 3)
            {
                configImage = new(Estilo.sizeToHeight(Properties.Resources.Ajustes_Gris, (pnlConfig.Height / 4) * 3));
                configImage.TranslateTransform(configImage.Image.Height / 2, (pnlConfig.Height - configImage.Image.Height) / 2);
                
                if (Estilo.fondo == Color.White)
                {
                    pnlConfig.ForeColor = Estilo.degrContraste;
                }
                else
                {
                    pnlConfig.ForeColor = Estilo.contrasteLigero;
                }
            }
            pnlConfig.BackColor = Estilo.fondo;
        }

        private async void pnlInicio_MouseLeave(object sender, EventArgs e)
        {
            tmrExtend.Stop();
            tmrShorten.Start();
            await Task.Delay(25);
            if (selectedScreen != 0)
            {
                inicioImage = new(Estilo.sizeToHeight(Properties.Resources.Home_Gris, (pnlConfig.Height / 4) * 3));
                inicioImage.TranslateTransform(inicioImage.Image.Height / 2, (pnlConfig.Height - inicioImage.Image.Height) / 2);

                if (Estilo.fondo == Color.White)
                {
                    pnlInicio.ForeColor = Estilo.degrContraste;
                }
                else
                {
                    pnlInicio.ForeColor = Estilo.contrasteLigero;
                }
            }
            pnlInicio.BackColor = Estilo.fondo;
        }

        private async void pnlProyectos_MouseLeave(object sender, EventArgs e)
        {
            tmrExtend.Stop();
            tmrShorten.Start();
            await Task.Delay(25);
            if (selectedScreen != 1)
            {
                proyectosImage = new(Estilo.sizeToHeight(Properties.Resources.Proyectos_Gris, (pnlConfig.Height / 4) * 3));
                proyectosImage.TranslateTransform(proyectosImage.Image.Height / 2, (pnlConfig.Height - proyectosImage.Image.Height) / 2);

                if (Estilo.fondo == Color.White)
                {
                    pnlProyectos.ForeColor = Estilo.degrContraste;
                }
                else
                {
                    pnlProyectos.ForeColor = Estilo.contrasteLigero;
                }
            }
            pnlProyectos.BackColor = Estilo.fondo;
        }

        private async void pnlContactos_MouseLeave(object sender, EventArgs e)
        {
            tmrExtend.Stop();
            tmrShorten.Start();
            await Task.Delay(25);
            if (selectedScreen != 2)
            {
                contactosImage = new(Estilo.sizeToHeight(Properties.Resources.Contactos_Gris, (pnlConfig.Height / 4) * 3));
                contactosImage.TranslateTransform(contactosImage.Image.Height / 2, (pnlConfig.Height - contactosImage.Image.Height) / 2);

                if (Estilo.fondo == Color.White)
                {
                    pnlContactos.ForeColor = Estilo.degrContraste;
                }
                else
                {
                    pnlContactos.ForeColor = Estilo.contrasteLigero;
                }
            }
            pnlContactos.BackColor = Estilo.fondo;
        }

        private void mainMenu_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush solidBrush;

            if (Estilo.fondo == Color.White)
            {
                solidBrush = new(Estilo.degrContraste);
            }
            else
            {
                solidBrush = new(Estilo.contrasteLigero);
            }

            e.Graphics.FillRectangle(solidBrush, new(new(0, pnlInicio.Location.Y + pnlInicio.Height),new(pnlInicio.Width, Estilo.medioAnchoLinea)));
            e.Graphics.FillRectangle(solidBrush, new(new(0, pnlProyectos.Location.Y + pnlProyectos.Height), new(pnlProyectos.Width, Estilo.medioAnchoLinea)));
        }

        private void pnlConfig_Click(object sender, EventArgs e)
        {
            SelectedScreen = 3;
        }

        private void pnlInicio_Click(object sender, EventArgs e)
        {
            SelectedScreen = 0;
        }

        private void pnlProyectos_Click(object sender, EventArgs e)
        {
            SelectedScreen = 1;
        }

        private void pnlContactos_Click(object sender, EventArgs e)
        {
            SelectedScreen = 2;
        }
        
        private Color calculateColor()
        {
            if (Estilo.fondo == Color.White)
            {
                return Estilo.degrContraste;
            }
            else
            {
                return Estilo.contrasteLigero;
            }
        }

        public event EventHandler SelectedScreenChanged;
    }
}
