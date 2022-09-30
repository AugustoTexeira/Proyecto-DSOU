namespace ProWork
{
    partial class Carpeta
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
            this.lbl = new System.Windows.Forms.Label();
            this.pcb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(0, 69);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(100, 31);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Carpeta indefinida";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl.DoubleClick += new System.EventHandler(this.Carpeta_DoubleClick);
            // 
            // pcb
            // 
            this.pcb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcb.Image = global::ProWork.Properties.Resources.Carpetas;
            this.pcb.Location = new System.Drawing.Point(0, 0);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(100, 69);
            this.pcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb.TabIndex = 1;
            this.pcb.TabStop = false;
            this.pcb.DoubleClick += new System.EventHandler(this.Carpeta_DoubleClick);
            // 
            // Carpeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.pcb);
            this.Controls.Add(this.lbl);
            this.Name = "Carpeta";
            this.Size = new System.Drawing.Size(100, 100);
            this.Load += new System.EventHandler(this.Carpeta_Load);
            this.DoubleClick += new System.EventHandler(this.Carpeta_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl;
        private PictureBox pcb;
    }
}
