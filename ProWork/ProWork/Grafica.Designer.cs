namespace ProWork
{
    partial class Grafica : UserControl
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
            this.components = new System.ComponentModel.Container();
            this.tmrBlend = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrBlend
            // 
            this.tmrBlend.Interval = 16;
            this.tmrBlend.Tick += new System.EventHandler(this.tmrBlend_Tick);
            // 
            // Grafica
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.DoubleBuffered = true;
            this.Name = "Grafica";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Grafica_Paint);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Grafica_Layout);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrBlend;
    }
}
