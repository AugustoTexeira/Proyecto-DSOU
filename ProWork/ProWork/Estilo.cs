using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ProWork
{
    internal static class Estilo
    {
        public static Color enfasis = Color.FromArgb(5, 49, 247);
        public static Color degrEnfasis = Color.FromArgb(5, 233, 237);
        public static Color fondo = Color.FromArgb(15, 12, 15);
        private static Color contraste = Color.White;
        public static Color contrasteLigero = Color.FromArgb(102, 102, 102);
        public static Color degrContraste = Color.FromArgb(204, 204, 204);
        public static Color contrasteEnfasis = Color.White;

        public static byte selectedStyle = 0; //0 = Modo oscuro; 1 = Modo claro; El resto son personalizados.
        public static Color Contraste
        {
            get { return contraste; }
            set 
            { 
                contraste = value;
            }
        }
        public const int anchoLinea = 4;
        public const int medioAnchoLinea = 2;
        public const int curva = 20;
        public static void Enmarcar (Pen pen, object sender, PaintEventArgs e, Rectangle posicion)
        {
            int c;
            int mc;

            if (curva + medioAnchoLinea > posicion.Height && posicion.Width >= posicion.Height)
            {
                c = posicion.Height - medioAnchoLinea;
            }
            else if (curva + medioAnchoLinea > posicion.Width)
            {
                c = posicion.Width - medioAnchoLinea;
            }
            else
            {
                c = curva;
            }

            if (c % 2 != 0) { c++; }
            mc = c / 2;

            ////Lados

            //Linea superior
            e.Graphics.DrawLine(pen, posicion.X + mc + medioAnchoLinea - 1, posicion.Y + medioAnchoLinea, posicion.X + posicion.Width - mc - medioAnchoLinea, medioAnchoLinea + posicion.Y);

            //Lineas medio
            e.Graphics.DrawLine(pen, posicion.X + medioAnchoLinea, posicion.Y + mc + medioAnchoLinea - 1, posicion.X + medioAnchoLinea, posicion.Y + posicion.Height - mc - medioAnchoLinea); // Izquierda
            e.Graphics.DrawLine(pen, posicion.X + posicion.Width - medioAnchoLinea - 1, posicion.Y + mc + medioAnchoLinea - 1, posicion.X + posicion.Width - medioAnchoLinea - 1, posicion.Y + posicion.Height - mc - medioAnchoLinea + 1); //Derecha

            //Linea inferior
            e.Graphics.DrawLine(pen, posicion.X + mc + medioAnchoLinea, posicion.Y + posicion.Height - medioAnchoLinea - 1, posicion.X + posicion.Width - mc - medioAnchoLinea , posicion.Y + posicion.Height - medioAnchoLinea - 1);

            ////Esquinas

            //Superior izquierda
            e.Graphics.DrawArc(pen, posicion.X + medioAnchoLinea, posicion.Y + medioAnchoLinea, c, c, 180, 90);

            //Superior derecha
            e.Graphics.DrawArc(pen, posicion.X + posicion.Width - c - medioAnchoLinea - 1, posicion.Y + medioAnchoLinea, c, c, 270, 90);

            //Inferior izquierda
            e.Graphics.DrawArc(pen, posicion.X + medioAnchoLinea, posicion.Y + posicion.Height - c - medioAnchoLinea - 1, c, c, 90, 90);

            //Inferior derecha
            e.Graphics.DrawArc(pen, posicion.X + posicion.Width - c - medioAnchoLinea - 1, posicion.Y + posicion.Height - c - medioAnchoLinea - 1, c, c, 0, 90);
        }
        public static void RellenarMarco (Brush brush, object sender, PaintEventArgs e, Rectangle posicion)
        {
            ////Ajustar a espacio y evitar flickering.
            
            int c;
            int mc;

            if (curva + medioAnchoLinea > posicion.Height && posicion.Width >= posicion.Height)
            {
                c = posicion.Height - medioAnchoLinea;
            }
            else if (curva + medioAnchoLinea > posicion.Width)
            {
                c = posicion.Width - medioAnchoLinea;
            }
            else
            {
                c = curva;
            }

            if (c % 2 != 0) { c--; }
            mc = c / 2;

            ////Rectangulos

            //Superior
            e.Graphics.FillRectangle(brush, posicion.X + mc + medioAnchoLinea - 1, posicion.Y + medioAnchoLinea, posicion.Width - c + 2, mc - medioAnchoLinea);

            //Medio
            e.Graphics.FillRectangle(brush, posicion.X + medioAnchoLinea, posicion.Y + mc - 1, posicion.Width - anchoLinea, posicion.Height - c + 2);

            //Inferior
            e.Graphics.FillRectangle(brush, posicion.X + mc + medioAnchoLinea - 1, posicion.Y + posicion.Height - mc, posicion.X + posicion.Width - c + 2, mc - medioAnchoLinea);

            ////Esquinas

            //Superior izquierda
            e.Graphics.FillPie(brush, posicion.X + medioAnchoLinea, posicion.Y + medioAnchoLinea, c, c, 180, 90);

            //Superior derecha
            e.Graphics.FillPie(brush, posicion.X + posicion.Width - c - medioAnchoLinea - 1, posicion.Y + medioAnchoLinea, c, c, 270, 90);

            //Inferior izquierda
            e.Graphics.FillPie(brush, posicion.X + medioAnchoLinea, posicion.Y + posicion.Height - c - medioAnchoLinea - 1, c, c, 90, 90);

            //Inferior derecha
            e.Graphics.FillPie(brush, posicion.X + posicion.Width - c - medioAnchoLinea - 1, posicion.Y + posicion.Height - c - medioAnchoLinea - 1, c, c, 0, 90);
        }
        public static Bitmap ResizeImage(Image image, int width, int height) //Esta funcion no es mía, fue copiada y pegada de https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp - CR
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }

        public static Image sizeToHeight(Image image, int height)
        {
            return ResizeImage(image, (int)(height * ((double)image.Width / image.Height)), height);
        }
        public static Image sizeToWidth(Image image, int width)
        {
            return ResizeImage(image, width, (int)(width * ((double)image.Height / image.Width)));
        }
    }
}
