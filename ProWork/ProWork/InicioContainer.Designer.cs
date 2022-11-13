namespace ProWork
{
    partial class InicioContainer
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
            this.btnCrear = new ProWork.CustomButton();
            this.epbNuevoProyecto = new ProWork.enhancedPictureBox();
            this.lblArrastre = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrear.Location = new System.Drawing.Point(575, 445);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(258, 63);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Texto = "Crear";
            this.btnCrear.ButtonClick += new System.EventHandler(this.crearbtn_Click);
            // 
            // epbNuevoProyecto
            // 
            this.epbNuevoProyecto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.epbNuevoProyecto.BackColor = System.Drawing.Color.Transparent;
            this.epbNuevoProyecto.BkgImage = global::ProWork.Properties.Resources.InicioProyecto;
            this.epbNuevoProyecto.Circle = false;
            this.epbNuevoProyecto.Location = new System.Drawing.Point(367, 160);
            this.epbNuevoProyecto.Name = "epbNuevoProyecto";
            this.epbNuevoProyecto.Size = new System.Drawing.Size(125, 121);
            this.epbNuevoProyecto.TabIndex = 1;
            this.epbNuevoProyecto.DragDrop += new System.Windows.Forms.DragEventHandler(this.epbNuevoProyecto_DragDrop);
            this.epbNuevoProyecto.DragEnter += new System.Windows.Forms.DragEventHandler(this.epbNuevoProyecto_DragDropEnter);
            // 
            // lblArrastre
            // 
            this.lblArrastre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArrastre.AutoSize = true;
            this.lblArrastre.BackColor = System.Drawing.Color.Transparent;
            this.lblArrastre.Font = new System.Drawing.Font("Raleway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArrastre.ForeColor = System.Drawing.Color.White;
            this.lblArrastre.Location = new System.Drawing.Point(123, 301);
            this.lblArrastre.Name = "lblArrastre";
            this.lblArrastre.Size = new System.Drawing.Size(613, 68);
            this.lblArrastre.TabIndex = 2;
            this.lblArrastre.Text = " Arrastre los archivos aquí o presione el botón de crear\r\npara crear un nuevo pro" +
    "yecto ";
            this.lblArrastre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.BackColor = System.Drawing.Color.Transparent;
            this.lblProyecto.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProyecto.ForeColor = System.Drawing.Color.White;
            this.lblProyecto.Location = new System.Drawing.Point(17, 19);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(328, 55);
            this.lblProyecto.TabIndex = 3;
            this.lblProyecto.Text = "Nuevo proyecto";
            this.lblProyecto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InicioContainer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.lblArrastre);
            this.Controls.Add(this.epbNuevoProyecto);
            this.Name = "InicioContainer";
            this.Size = new System.Drawing.Size(859, 529);
            this.Load += new System.EventHandler(this.InicioContainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton btnCrear;
        private enhancedPictureBox epbNuevoProyecto;
        private Label lblArrastre;
        private Label lblProyecto;
    }
}
