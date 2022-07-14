using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWork
{
    internal class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel ()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
    }
}
