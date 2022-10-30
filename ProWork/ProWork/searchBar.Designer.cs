namespace ProWork
{
    partial class searchBar
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
            this.txb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb
            // 
            this.txb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb.ForeColor = System.Drawing.Color.White;
            this.txb.Location = new System.Drawing.Point(85, 0);
            this.txb.Margin = new System.Windows.Forms.Padding(6);
            this.txb.Name = "txb";
            this.txb.Size = new System.Drawing.Size(665, 40);
            this.txb.TabIndex = 0;
            // 
            // searchBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.txb);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "searchBar";
            this.Size = new System.Drawing.Size(795, 40);
            this.FontChanged += new System.EventHandler(this.searchBar_FontChanged);
            this.Click += new System.EventHandler(this.searchBar_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.searchBar_Paint);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.searchBar_Layout);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox txb;
    }
}
