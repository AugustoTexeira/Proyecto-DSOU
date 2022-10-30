namespace ProWork
{
    partial class ContactosContainer
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
            this.clt = new ProWork.ContactosList();
            this.cbnAniadir = new ProWork.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.srbBuscar = new ProWork.searchBar();
            this.SuspendLayout();
            // 
            // clt
            // 
            this.clt.AutoScroll = true;
            this.clt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clt.Location = new System.Drawing.Point(23, 163);
            this.clt.Margin = new System.Windows.Forms.Padding(6);
            this.clt.Name = "clt";
            this.clt.Size = new System.Drawing.Size(931, 441);
            this.clt.TabIndex = 0;
            // 
            // cbnAniadir
            // 
            this.cbnAniadir.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbnAniadir.Location = new System.Drawing.Point(699, 628);
            this.cbnAniadir.Name = "cbnAniadir";
            this.cbnAniadir.Padding = new System.Windows.Forms.Padding(25);
            this.cbnAniadir.Size = new System.Drawing.Size(258, 63);
            this.cbnAniadir.TabIndex = 1;
            this.cbnAniadir.Texto = "Añadir ➕";
            this.cbnAniadir.ButtonClick += new System.EventHandler(this.cbnAniadir_Click);
            this.cbnAniadir.Click += new System.EventHandler(this.cbnAniadir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contactos";
            // 
            // srbBuscar
            // 
            this.srbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.srbBuscar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.srbBuscar.Location = new System.Drawing.Point(23, 99);
            this.srbBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.srbBuscar.Name = "srbBuscar";
            this.srbBuscar.Size = new System.Drawing.Size(931, 40);
            this.srbBuscar.TabIndex = 4;
            this.srbBuscar.Load += new System.EventHandler(this.searchBar1_Load);
            // 
            // ContactosContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.srbBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbnAniadir);
            this.Controls.Add(this.clt);
            this.Name = "ContactosContainer";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 25, 25);
            this.Size = new System.Drawing.Size(985, 719);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.ContactosContainer_Layout);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContactosList clt;
        private CustomButton cbnAniadir;
        private Label label1;
        private searchBar srbBuscar;
    }
}
