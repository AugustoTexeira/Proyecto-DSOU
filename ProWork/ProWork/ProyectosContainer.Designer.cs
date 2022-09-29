namespace ProWork
{
    partial class ProyectosContainer
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
            this.flh = new ProWork.FileHolder();
            this.rt = new ProWork.Ruta();
            this.SuspendLayout();
            // 
            // flh
            // 
            this.flh.AutoScroll = true;
            this.flh.Location = new System.Drawing.Point(13, 43);
            this.flh.Name = "flh";
            this.flh.Size = new System.Drawing.Size(759, 714);
            this.flh.TabIndex = 0;
            // 
            // rt
            // 
            this.rt.BackColor = System.Drawing.Color.Coral;
            this.rt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rt.Location = new System.Drawing.Point(24, 6);
            this.rt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rt.Name = "rt";
            this.rt.Size = new System.Drawing.Size(1205, 73);
            this.rt.TabIndex = 1;
            // 
            // ProyectosContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.rt);
            this.Controls.Add(this.flh);
            this.Name = "ProyectosContainer";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);

        }

        #endregion

        private FileHolder flh;
        private Ruta rt;
    }
}
