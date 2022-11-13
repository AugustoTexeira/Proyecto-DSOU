
using System.Drawing.Drawing2D;

namespace ProWork
{
    public partial class Item : UserControl
    {
        private enhancedPictureBox epbConfig = new();
        private enhancedPictureBox epbDelete = new();
        private byte pmode = 0; // 0=usuarios; 1=contactos; 2=usuario admin; >2 = indefinido
        public byte mode
        {
            get { return pmode; }
            set 
            { 
                pmode = value; 
                if (text == Program.user)
                {
                    switch (pmode)
                    {
                        case 0:
                            Program.userAdmin = false;
                            break;
                        case 2:
                            Program.userAdmin = true;
                            break;
                    }
                }
            }
        }
        private string text = "Placeholder";
        public static TextureBrush defaultImage = new(Estilo.ResizeImage(Properties.Resources.ContactoOscuro, 1, 1));
        public static Image trashImage = Estilo.ResizeImage(Properties.Resources.Basura, 1, 1);
        public static Image gearImage = Estilo.ResizeImage(Properties.Resources.Configuración, 1, 1);
        private byte hovered
        {
            get { return hover; }
            set
            {
                if (hover < value && value == 1)
                {
                    enterHover.Invoke(this, EventArgs.Empty);
                }
                if (value == 0)
                {
                    exitHover.Invoke(this, EventArgs.Empty);
                }
                hover = value;
            }
        }
        public event EventHandler enterHover;
        public event EventHandler exitHover;
        private void paqnosequejen (object sender, EventArgs e)
        {

        }
        private byte hover = 0;
        private static bool theme = false; //Oscuro = false; Claro = true;

        public override string Text
        {
            get { return text; }
            set { text = value; this.Invalidate(); }
        }
        public int id = 0;
        public Item()
        {
            
            enterHover += paqnosequejen;
            exitHover += paqnosequejen;
            InitializeComponent();
            De_Configuración__Cristian_.ConfigContainer.ColorSwap += colorSwap;

            De_Configuración__Cristian_.ConfigContainer.ColorSwap += colorSwapS;
            this.Height = (int)(this.Font.Height * 1.5);

            if(Estilo.fondo == Color.White)
            {
                if (defaultImage.Image.Height != (int)(Height / 1.5) && !theme)
                {
                    defaultImage = new(Estilo.ResizeImage(Properties.Resources.ContactoModoClaro, (int)(Height / 1.5), (int)(Height / 1.5)));
                    defaultImage.TranslateTransform(Height / 4 + 1, Height / 4 + 1);
                }
                theme = true;
            }
            else
            {
                if (defaultImage.Image.Height != (int)(Height / 1.5) && theme)
                {
                    defaultImage = new(Estilo.ResizeImage(Properties.Resources.ContactoModoClaro, (int)(Height / 1.5), (int)(Height / 1.5)));
                    defaultImage.TranslateTransform(Height / 4 + 1, Height / 4 + 1);
                }
                theme = false;
            }
            if (Program.userAdmin)
            {
                //Config
                
                epbConfig.Cursor = Cursors.Hand;
                epbConfig.Location = new(Width - (int)(epbDelete.Width * 1.5), Height / 4);
                epbConfig.Name = "epbConfig";
                epbConfig.BackColor = Color.Transparent;
                epbConfig.TabIndex = 1;
                epbConfig.Click += new System.EventHandler(this.btnConfig_Click);
                epbConfig.MouseEnter += new System.EventHandler(this.btnConfig_MouseEnter);
                epbConfig.MouseLeave += new System.EventHandler(this.btnConfig_MouseLeave);
                epbConfig.Location = new(Width, Height);
                epbConfig.Size = new(1, 1);

                //Delete

                epbDelete.AutoSize = false;
                epbDelete.BackColor = Color.Transparent;
                epbDelete.Name = "epbDelete";
                epbConfig.Size = new(Height / 2, (int)(Height / 2 * ((double)trashImage.Height / trashImage.Width)));
                epbDelete.TabIndex = 1;
                epbDelete.Click += new EventHandler(epbDelete_Click);
                epbDelete.MouseEnter += new EventHandler(epbDelete_MouseEnter);
                epbDelete.MouseLeave += new EventHandler(epbDelete_MouseLeave);
                epbDelete.Cursor = Cursors.Hand;
                epbDelete.Size = new(1, 1);

                Controls.Add(epbConfig);
                Controls.Add(epbDelete);
            }
        }
        public void cambioPrivilegio(object sender, EventArgs e)
        {
            if((bool)sender)
            {
                mode = 2;
            }
            else
            {
                mode = 0;
                if (text == Program.user) { Program.userAdmin = false; }
            }
            Invalidate();
        }

        private void colorSwap(object sender, EventArgs e)
        {
            BackColor = Estilo.fondo;
        }
        private static void colorSwapS(object sender, EventArgs e)
        {
            if ((bool)sender)
            {
                int transform = (int)defaultImage.Transform.OffsetX;
                defaultImage = new(Estilo.ResizeImage(Properties.Resources.ContactoModoClaro, defaultImage.Image.Height, defaultImage.Image.Height));
                defaultImage.TranslateTransform(transform, transform);
            }
            else
            {
                int transform = (int)defaultImage.Transform.OffsetX;
                defaultImage = new(Estilo.ResizeImage(Properties.Resources.ContactoOscuro, defaultImage.Image.Height, defaultImage.Image.Height));
                defaultImage.TranslateTransform(transform, transform);
            }
            theme = (bool)sender;
        }

        private void ContactosItem_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //Botones
            if (hovered > 0 && Program.userAdmin)
            {
                showButtons();
            }
            else
            {
                HideButtons();
            }

            //Degradado on hover
            if (hovered > 0)
            {
                LinearGradientBrush grdBrush;
                if(Estilo.fondo == Color.White)
                {
                    grdBrush = new(
                    new(0, 0),
                    new(this.Width, 0),
                    Estilo.fondo,
                    Estilo.degrContraste
                    );
                }
                else
                {
                    grdBrush = new(
                    new(0, 0),
                    new(this.Width, 0),
                    Estilo.fondo,
                    Estilo.contrasteLigero
                    );
                }
                

                e.Graphics.FillRectangle(grdBrush, 0, 0, this.Width, this.Height);
            }
            //Bordes

            Pen pen = new(Estilo.Contraste, Estilo.anchoLinea);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            e.Graphics.DrawLine(pen, new(Estilo.medioAnchoLinea, 0), new(this.Width - Estilo.medioAnchoLinea, 0));
            e.Graphics.DrawLine(pen, new(Estilo.medioAnchoLinea, this.Height), new(this.Width - Estilo.medioAnchoLinea, this.Height));

            //Texto
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            SolidBrush brush = new(Estilo.Contraste);
            StringFormat formato = new();
            formato.Alignment = StringAlignment.Near;
            formato.LineAlignment = StringAlignment.Center;
            if (Program.userAdmin && epbConfig.Visible)
            {
                e.Graphics.DrawString(text, Font, brush, new Rectangle(Height, 0, epbDelete.Location.X - Height, Height), formato);
            }
            else
            {
                e.Graphics.DrawString(text, Font, brush, new Rectangle(Height, 0, Width - Height, Height), formato);
            }

            //Imagenes
            switch (mode)
            {
                case 0:
                    if (Text == Program.user) { brush.Color = Color.Lime; } else { brush.Color = Estilo.enfasis; };
                    e.Graphics.FillEllipse(brush, new(Estilo.anchoLinea * 2 + (int)(this.Height * 0.107142857), (int)(this.Height * 0.357142857), (int)(this.Height / 3.5), (int)(this.Height / 3.5)));
                    break;
                case 1:
                    e.Graphics.SmoothingMode = SmoothingMode.None;

                    //GraphicsPath path = new GraphicsPath();

                    //path.AddEllipse();
                    e.Graphics.FillRectangle(defaultImage, new(Height / 4, Height / 4, Height / 2, Height / 2 ));

                    //e.Graphics.DrawPath(new(Estilo.Contraste, 3), path);

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    break;
                case 2:
                    if (Text == Program.user) { brush.Color = Color.Lime; } else { brush.Color = Estilo.enfasis; };

                    e.Graphics.FillEllipse(brush, new Rectangle(new(Estilo.anchoLinea * 2 + (int)(this.Height * 0.107142857), this.Height / 4), new((int)(this.Height / 3.5), (int)(this.Height / 3.5))));
                    e.Graphics.FillPie(brush, new Rectangle(new(Estilo.anchoLinea * 2, (int)(this.Height * 0.6)), new(this.Height / 2, this.Height / 2)), 180, 180);
                    break;
            }

        }



        private void ContactosItem_FontChanged(object sender, EventArgs e)
        {
            this.Height = (int)(this.Font.Height * 1.5);

            if(theme)
            {
                if (defaultImage.Image.Height != (int)(Height / 2))
                {
                    defaultImage = new(Estilo.ResizeImage(Properties.Resources.ContactoModoClaro, (int)(Height / 2), (int)(Height / 2)));
                    defaultImage.TranslateTransform(Height / 4 + 0.5F, Height / 4 + 0.5F);
                }
            }
            else
            {
                if (defaultImage.Image.Height != (int)(Height / 2))
                {
                    defaultImage = new(Estilo.ResizeImage(Properties.Resources.ContactoOscuro, (int)(Height / 2), (int)(Height / 2)));
                    defaultImage.TranslateTransform(Height / 4 + 0.5F, Height / 4 + 0.5F);
                }
            }
            if (trashImage.Height != (int)(Height / 2) && Program.userAdmin)
            {
                trashImage = Estilo.sizeToHeight(Properties.Resources.Basura, Height / 2);
            }
            if (gearImage.Height != (int)(Height / 2) && Program.userAdmin)
            {
                gearImage = Estilo.sizeToHeight(Properties.Resources.Configuración, Height / 2);
            }
        }

        private void ContactosItem_SizeChanged(object sender, EventArgs e)
        {
            epbConfig.Location = new(this.Width - (int)(epbDelete.Width * 1.5), Height / 4);
            epbDelete.Location = new(this.Width - epbDelete.Width * 3, Height / 4);
        }
        private void trash_OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(trashImage, epbDelete.ClientRectangle);
        }
        public void showButtons()
        {
            epbConfig.Size = gearImage.Size;
            epbDelete.Size = trashImage.Size;
            epbConfig.BackgroundImage = gearImage;
            epbDelete.BackgroundImage = trashImage;
            epbConfig.Location = new(Width - (int)(epbConfig.Width * 1.5), Height / 4);
            epbDelete.Location = new(Width - (epbConfig.Width * 3), Height / 4);

            epbConfig.Visible = true;
            epbDelete.Visible = true;
        }
        public void HideButtons()
        {
            epbConfig.BackgroundImage = null;
            epbDelete.BackgroundImage = null;
            epbConfig.Visible = false;
            epbDelete.Visible = false;
        }
        private void ContactosItem_MouseEnter(object sender, EventArgs e)
        {
            hovered++;
            this.Invalidate();
        }

        private async void ContactosItem_MouseLeave(object sender, EventArgs e)
        {
            await Task.Delay(1);
            hovered--;
            this.Invalidate();
        }

        private void epbDelete_MouseEnter(object sender, EventArgs e)
        {
            hovered++;
            this.Invalidate();
        }

        private async void epbDelete_MouseLeave(object sender, EventArgs e)
        {
            await Task.Delay(1);
            hovered--;
            this.Invalidate();
        }

        private void btnConfig_MouseEnter(object sender, EventArgs e)
        {
            hovered++;
            this.Invalidate();
        }

        private async void btnConfig_MouseLeave(object sender, EventArgs e)
        {
            await Task.Delay(1);
            hovered--;
            this.Invalidate();
        }
        public void CallReset(object sender, EventArgs e)
        {
            text = sender.ToString();
            Invalidate();
        }

        private void epbDelete_Click(object sender, EventArgs e)
        {
            trashClicked.Invoke(this, e);
        }
        public event EventHandler gearClicked;
        public event EventHandler trashClicked;

        private void btnConfig_Click(object sender, EventArgs e)
        {
            gearClicked.Invoke(this, e);
        }

        private void ContactosItem_Click(object sender, EventArgs e)
        {
        }
    }
}
