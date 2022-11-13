using System.Drawing.Drawing2D;

namespace ProWork
{
    public partial class enhancedPictureBox : UserControl
    {
        private Image bkgImage;
        private TextureBrush txtBrush;
        private bool circle = false;
        public bool Circle
        {
            get { return circle; }
            set
            {
                circle = value;
                Invalidate();
            }
        }
        public Image BkgImage
        {
            get { return bkgImage; }
            set
            {
                bkgImage = value;
                txtBrush = new(Estilo.ResizeImage(bkgImage, Width, Height));
                Invalidate();
            }
        }
        public enhancedPictureBox()
        {
            InitializeComponent();
        }

        private void enhancedPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (txtBrush != null)
            {
                if (circle)
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    GraphicsPath path = new GraphicsPath();

                    path.AddEllipse(0, 0, Width, Height);
                    e.Graphics.FillPath(txtBrush, path);

                    e.Graphics.SmoothingMode = SmoothingMode.None;
                }
                else
                {
                    e.Graphics.DrawImage(txtBrush.Image, 0, 0, Width, Height);
                }
            }
        }

        private void enhancedPictureBox_Layout(object sender, LayoutEventArgs e)
        {
            if (bkgImage != null && txtBrush.Image.Size != Size && Size.Height != 0 && Size.Width != 0)
            {
                txtBrush = new(Estilo.ResizeImage(bkgImage, (int)Width, (int)Height));
            }
        }

        public void sizeToHeight(int height)
        {
            if (bkgImage != null && height > 0 && (int)(height * ((double)bkgImage.Height / bkgImage.Width)) > 0)
            {
                Size = new((int)(height * ((double)bkgImage.Width / bkgImage.Height)), height);
            }
        }
        public void sizeToWidth(int width)
        {
            if (bkgImage != null && width > 0 && (int)(width * ((double)bkgImage.Width / bkgImage.Height)) > 0)
            {
                Size = new(width, (int)(width * ((double)bkgImage.Height / bkgImage.Width)));
            }
        }
    }
}
