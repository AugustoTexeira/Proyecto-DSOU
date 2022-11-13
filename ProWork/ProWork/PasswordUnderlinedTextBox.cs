using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWork
{
    internal class PasswordUnderlinedTextBox : UnderlinedTextBox
    {
        private enhancedPictureBox epb = new();
        public PasswordUnderlinedTextBox()
        {
            Layout += epblayout;
            epb.Click += epbClick;
            txb.UseSystemPasswordChar = true;
            epb.BackColor = Color.Transparent;
            epb.BkgImage = Properties.Resources.OJoOcultoModoClaro;
            epb.sizeToHeight(txb.Height);
            epb.Location = new(txb.Width - epb.Width, 0);
            epb.Cursor = Cursors.Hand;
            epb.TabStop = false;
            Controls.Add(epb);
            epb.BringToFront();
        }

        private void epblayout(object sender, LayoutEventArgs e)
        {
            if(txb.UseSystemPasswordChar)
            {
                epb.sizeToHeight(txb.Height);
                epb.Location = new(Width - epb.Width - Estilo.medioAnchoLinea, 0);
            }
            else
            {
                epb.sizeToWidth(epb.Width);
                epb.Location = new(Width - epb.Width - Estilo.medioAnchoLinea, (txb.Height - epb.Height) / 2);
            }
            txb.Width = epb.Location.X - txb.Location.X;
        }
        private void epbClick(object sender, EventArgs e)
        {
            SuspendLayout();
            txb.UseSystemPasswordChar = !txb.UseSystemPasswordChar;
            if(txb.UseSystemPasswordChar)
            {
                epb.BkgImage = Properties.Resources.OJoOcultoModoClaro;
                epb.sizeToWidth(epb.Width);
                epb.Location = new(epb.Location.X, 0);
            }
            else
            {
                epb.BkgImage = Properties.Resources.OjoModoClaro;
                epb.sizeToWidth(epb.Width);
                epb.Location = new(epb.Location.X, (txb.Height - epb.Height) / 2);
            }
            ResumeLayout();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // txb
            // 
            this.txb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txb.Location = new System.Drawing.Point(2, 0);
            this.txb.PlaceholderText = "Contraseña";
            this.txb.Size = new System.Drawing.Size(255, 31);
            // 
            // PasswordUnderlinedTextBox
            // 
            this.Name = "PasswordUnderlinedTextBox";
            this.PlaceholderText = "Contraseña";
            this.Size = new System.Drawing.Size(259, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
