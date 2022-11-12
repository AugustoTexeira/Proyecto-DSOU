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
            this.crearbtn = new ProWork.CustomButton();
            this.epbNuevoProyecto = new ProWork.enhancedPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crearbtn
            // 
            this.crearbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.crearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crearbtn.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.crearbtn.Location = new System.Drawing.Point(575, 445);
            this.crearbtn.Name = "crearbtn";
            this.crearbtn.Size = new System.Drawing.Size(258, 63);
            this.crearbtn.TabIndex = 0;
            this.crearbtn.Texto = "Crear";
            this.crearbtn.ButtonClick += new System.EventHandler(this.crearbtn_Click);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Raleway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = " Arrastre los archivos aquí o presione el botón de crear\r\npara crear un nuevo pro" +
    "yecto ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nuevo proyecto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InicioContainer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.crearbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.epbNuevoProyecto);
            this.Name = "InicioContainer";
            this.Size = new System.Drawing.Size(859, 529);
            this.Load += new System.EventHandler(this.InicioContainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton crearbtn;
        private enhancedPictureBox epbNuevoProyecto;
        private Label label1;
        private Label label2;
    }
}
