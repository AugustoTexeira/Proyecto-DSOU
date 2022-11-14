using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWork
{
    internal class loadingGIF : PictureBox
    {
        public int delay { get; set; } = 250;
        private bool animar;
        public bool Animar 
        {
            get { return animar; }
            set { if (value) { talvezfunciona.Invoke(this, EventArgs.Empty); }; animar = value;  }
        }
        public loadingGIF()
        {
            SizeMode = PictureBoxSizeMode.Zoom;
            BackgroundImageLayout = ImageLayout.Zoom;
            talvezfunciona += moveGIF;
            talvezfunciona.Invoke(this, EventArgs.Empty);
        }
        private event EventHandler talvezfunciona;
        private async void moveGIF (object sender, EventArgs e)
        {
            Image = Properties.Resources.Gif2;
            await Task.Delay(delay);
            while (animar)
            {
                Image.Dispose();
                Image = Properties.Resources.Gif1;
                await Task.Delay(delay);
                Image.Dispose();
                Image = Properties.Resources.Gif2;
                await Task.Delay(delay);
            }
        }

    }
}
