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
            this.lblProyectos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flh
            // 
            this.flh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flh.AutoScroll = true;
            this.flh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.flh.Location = new System.Drawing.Point(26, 157);
            this.flh.Name = "flh";
            this.flh.Size = new System.Drawing.Size(576, 210);
            this.flh.TabIndex = 0;
            // 
            // rt
            // 
            this.rt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.rt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rt.Location = new System.Drawing.Point(25, 117);
            this.rt.Margin = new System.Windows.Forms.Padding(5);
            this.rt.Name = "rt";
            this.rt.Size = new System.Drawing.Size(577, 32);
            this.rt.TabIndex = 1;
            // 
            // lblProyectos
            // 
            this.lblProyectos.AutoSize = true;
            this.lblProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProyectos.ForeColor = System.Drawing.Color.White;
            this.lblProyectos.Location = new System.Drawing.Point(23, 20);
            this.lblProyectos.Name = "lblProyectos";
            this.lblProyectos.Size = new System.Drawing.Size(167, 37);
            this.lblProyectos.TabIndex = 3;
            this.lblProyectos.Text = "Proyectos";
            // 
            // ProyectosContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.lblProyectos);
            this.Controls.Add(this.rt);
            this.Controls.Add(this.flh);
            this.Name = "ProyectosContainer";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(625, 390);
            this.Load += new System.EventHandler(this.ProyectosContainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileHolder flh;
        private Ruta rt;
        private Label lblProyectos;
    }
}
