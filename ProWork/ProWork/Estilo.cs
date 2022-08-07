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
        public const int anchoLinea = 6;
        public const int medioAnchoLinea = 3;
        public const int curva = 40;
        public const int mediaCurva = 20;
    }
}
