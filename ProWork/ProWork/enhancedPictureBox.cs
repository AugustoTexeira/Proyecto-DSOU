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
                Refresh();
            }
        }
        public Image BkgImage
        {
            get { return bkgImage; }
            set 
            { 
                bkgImage = value;
                txtBrush = new(Estilo.ResizeImage(bkgImage, Width, Height));
                Refresh();
            }
        }
        public enhancedPictureBox()
        {
            InitializeComponent();
        }

        private void enhancedPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if(txtBrush != null)
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
            if(bkgImage != null && txtBrush.Image.Size != Size)
            {
                txtBrush = new(Estilo.ResizeImage(bkgImage, (int)Width, (int)Height));
            }
        }

        public void sizeToHeight(int height)
        {
            if(bkgImage != null && height > 0 && (int)(height * ((double)bkgImage.Height / bkgImage.Width)) > 0)
            {
                Size = new((int)(height * ((double)bkgImage.Height / bkgImage.Width)), height);
            }
            else
            {
                //Testing
                //MessageBox.Show(
                //    $"Height: {height}\n" +
                //    $"bkgImage.Height: {bkgImage.Height}\n" +
                //    $"bkgImage.Width: {bkgImage.Width}\n" +
                //    $"bkgImage.Height / bkgImage.Width: {(double)bkgImage.Height / bkgImage.Width}\n" +
                //    $"height * (bkgImage.Height / bkgImage.Width): {height * ((double)bkgImage.Height / bkgImage.Width)}"
                //    );
            }
        }
        public void sizeToWidth(int width)
        {
            Size = new(width, width * (bkgImage.Width / Height));
        }
    }
}
