using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWork
{
    internal static class Estilo
    {
        public static Color enfasis = Color.FromArgb(5, 49, 247);
        public static Color degrEnfasis = Color.FromArgb(5, 233, 237);
        public static Color fondo = Color.FromArgb(15, 12, 15);
        private static Color contraste = Color.White;
        public static Color contrasteLigero = Color.Gray;
        public static Color degrContraste = Color.LightGray;
        public static Color contrasteEnfasis = Color.White;

        public static byte selectedStyle = 0; //0 = Modo oscuro; 1 = Modo claro; El resto son personalizados.
        public static Color Contraste
        {
            get { return contraste; }
            set 
            { 
                contraste = value;
                int r;
                int g;
                int b;
                if (fondo.R < contraste.R) { r = fondo.R + (Math.Abs(fondo.R - contraste.R) / 2); } else { r = contraste.R + (Math.Abs(contraste.R - fondo.R) / 2); }
                if (fondo.G < contraste.G) { g = fondo.G + (Math.Abs(fondo.G - contraste.G) / 2); } else { g = contraste.G + (Math.Abs(contraste.G - fondo.G) / 2); }
                if (fondo.B < contraste.B) { b = fondo.B + (Math.Abs(fondo.B - contraste.B) / 2); } else { b = contraste.B + (Math.Abs(contraste.B - fondo.B) / 2); }
                contrasteLigero = Color.FromArgb(r, g, b);
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
    }
}
