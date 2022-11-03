using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

namespace ProWork
{
    public partial class Item : UserControl
    {
        private enhancedPictureBox epbConfig = new();
        private enhancedPictureBox epbDelete = new();
        public byte mode = 0; // 0=usuarios; 1=contactos; 2=usuario admin; >2 = indefinido
        private string text = "Placeholder";
        public static TextureBrush defaultImage = new(Estilo.ResizeImage(Properties.Resources.ContactoOscuro, 1, 1));
        public static Image trashImage = Estilo.ResizeImage(Properties.Resources.Basura, 1, 1);
        public static Image gearImage = Estilo.ResizeImage(Properties.Resources.Configuración, 1, 1);
        //Si sobra tiempo habría que reducir el codigo redundante (sale de una copia de AccountItem, habria que hacerles una clase padre y dejar que hereden)
        private bool hovered
        {
            get { return (hover > 0); }
        }
        private byte hover = 0;

        public override string Text
        {
            get { return text; }
            set { text = value; this.Refresh(); }
        }
        public int id = 0;
        public Item()
        {
            InitializeComponent();
            this.Height = (int)(this.Font.Height * 1.5);
            if (defaultImage.Image.Height != (int)(Height / 1.5))
            {
                defaultImage = new(Estilo.ResizeImage(Properties.Resources.ContactoOscuro, (int)(Height / 1.5), (int)(Height / 1.5)));
                defaultImage.TranslateTransform(Height / 4 + 1, Height / 4 + 1);
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

        private void ContactosItem_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //Botones
            if (hovered && Program.userAdmin)
            {
                showButtons();
            }
            else
            {
                HideButtons();
            }

            //Degradado on hover
            if (hovered)
            {
                LinearGradientBrush grdBrush = new(
                    new(0, 0),
                    new(this.Width, 0),
                    Estilo.fondo,
                    Estilo.contrasteLigero
                    );

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

                    GraphicsPath path = new GraphicsPath();

                    path.AddEllipse(Height / 4, Height / 4, Height / 2, Height / 2);
                    e.Graphics.FillPath(defaultImage, path);

                    e.Graphics.DrawPath(new(Estilo.Contraste, 3), path);

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

            if (defaultImage.Image.Height != (int)(Height / 2))
            {
                defaultImage = new(Estilo.ResizeImage(Properties.Resources.ContactoOscuro, (int)(Height / 2), (int)(Height / 2)));
                defaultImage.TranslateTransform(Height / 4 + 0.5F, Height / 4 + 0.5F);
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
            hover++;
            this.Refresh();
        }

        private async void ContactosItem_MouseLeave(object sender, EventArgs e)
        {
            await Task.Delay(1);
            hover--;
            this.Refresh();
        }

        private void epbDelete_MouseEnter(object sender, EventArgs e)
        {
            hover++;
            this.Refresh();
        }

        private async void epbDelete_MouseLeave(object sender, EventArgs e)
        {
            await Task.Delay(1);
            hover--;
            this.Refresh();
        }

        private void btnConfig_MouseEnter(object sender, EventArgs e)
        {
            hover++;
            this.Refresh();
        }

        private async void btnConfig_MouseLeave(object sender, EventArgs e)
        {
            await Task.Delay(1);
            hover--;
            this.Refresh();
        }
        public void CallReset(object sender, EventArgs e)
        {
            text = sender.ToString();
            Refresh();
        }

        private void epbDelete_Click(object sender, EventArgs e)
        {
            trashClicked.Invoke(this, e);
        }
        public event EventHandler ResetParent;
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
