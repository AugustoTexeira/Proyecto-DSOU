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
using MySql.Data.MySqlClient;

namespace ProWork
{
    public partial class ContactosItem : UserControl
    {
        private string text = "Placeholder";

        //Si sobra tiempo habría que reducir el codigo redundante (sale de una copia de AccountItem, habria que hacerles una clase padre y dejar que hereden)
        //Para evitar flickering en los botones contextuales, necesito 3 booleanos.

        private bool hovered
        {
            get { if (hoveredI > 0 || hoveredU || hoveredC) { return true; } else { return false; } }
        }
        private byte hoveredI = 0; //Item
        private bool hoveredU = false;
        private bool hoveredC = false; //Config

        public override string Text
        {
            get { return text; }
            set { text = value; this.Refresh(); }
        }
        public int id = 0;
        public ContactosItem()
        {
            InitializeComponent();
            this.Height = (int)(this.Font.Height * 1.5);
        }

        private void ContactosItem_Paint(object sender, PaintEventArgs e)
        {
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

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

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
            if (btnUser.Visible)
            {
                e.Graphics.DrawString(text, Font, brush, new Rectangle(Estilo.anchoLinea * 4 + this.Height / 2, 0, btnUser.Location.X - Estilo.anchoLinea * 4 + this.Height / 2, this.Height), formato);
            }
            else
            {
                e.Graphics.DrawString(text, Font, brush, new Rectangle(Estilo.anchoLinea * 4 + this.Height / 2, 0, this.Width, this.Height), formato);
            }
        }



        private void ContactosItem_FontChanged(object sender, EventArgs e)
        {
            this.Height = (int)(this.Font.Height * 1.5);
        }

        private void ContactosItem_SizeChanged(object sender, EventArgs e)
        {
            btnConfig.Size = new(Height - Estilo.anchoLinea, Height - Estilo.anchoLinea);
            btnUser.Size = btnConfig.Size;

            btnConfig.Location = new(this.Width - (int)(btnConfig.Width * 1.1), Estilo.medioAnchoLinea);
            btnUser.Location = new(this.Width - (int)(btnConfig.Width * 2.2), btnConfig.Location.Y);

            this.Refresh();
        }
        public void showButtons()
        {
            btnConfig.Visible = true;
            btnUser.Visible = true;
        }
        public void HideButtons()
        {
            btnConfig.Visible = false;
            btnUser.Visible = false;
        }
        private void ContactosItem_MouseEnter(object sender, EventArgs e)
        {
            hoveredI++;
            this.Refresh();
        }

        private async void ContactosItem_MouseLeave(object sender, EventArgs e)
        {
            await Task.Delay(1);
            hoveredI--;
            this.Refresh();
        }

        private void btnUser_MouseEnter(object sender, EventArgs e)
        {
            hoveredU = true;
            this.Refresh();
        }

        private async void btnUser_MouseLeave(object sender, EventArgs e)
        {
            await Task.Delay(1);
            hoveredU = false;
            this.Refresh();
        }

        private void btnConfig_MouseEnter(object sender, EventArgs e)
        {
            hoveredC = true;
            this.Refresh();
        }

        private async void btnConfig_MouseLeave(object sender, EventArgs e)
        {
            await Task.Delay(1);
            hoveredC = false;
            this.Refresh();
        }
        private void CallReset(object sender, EventArgs e)
        {
            text = sender.ToString();
            Refresh();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Esta seguro que desea eliminar el contacto {Text}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.tryToConnect();

                MySqlCommand cmd = new($"delete from contacto where idcontacto='{id}';", Program.connection);
                cmd.ExecuteNonQuery();
                ResetParent.Invoke(null, e);
            }
        }
        public event EventHandler ResetParent;

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmContactosConfig config = new(id, Text);
            config.CambioExitoso += CallReset;
            config.Show();
        }

        private void ContactosItem_Click(object sender, EventArgs e)
        {
            frmMostrarContacto frm = new();
            frm.Show();
        }
    }
}
