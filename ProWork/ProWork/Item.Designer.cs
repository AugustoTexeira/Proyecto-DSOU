namespace ProWork
{
    partial class Item
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.Name = "Item";
            this.Size = new System.Drawing.Size(505, 265);
            this.FontChanged += new System.EventHandler(this.ContactosItem_FontChanged);
            this.SizeChanged += new System.EventHandler(this.ContactosItem_SizeChanged);
            this.Click += new System.EventHandler(this.ContactosItem_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ContactosItem_Paint);
            this.MouseEnter += new System.EventHandler(this.ContactosItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ContactosItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Item_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
