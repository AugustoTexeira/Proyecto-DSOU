namespace ProWork
{
    partial class ControlCuentas
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
            this.tmrScroll = new System.Windows.Forms.Timer(this.components);
            this.tmrDragScroll = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrScroll
            // 
            this.tmrScroll.Interval = 16;
            this.tmrScroll.Tick += new System.EventHandler(this.tmrScroll_Tick);
            // 
            // tmrDragScroll
            // 
            this.tmrDragScroll.Interval = 16;
            this.tmrDragScroll.Tick += new System.EventHandler(this.tmrDragScroll_Tick);
            // 
            // ControlCuentas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ControlCuentas";
            this.Size = new System.Drawing.Size(259, 153);
            this.Load += new System.EventHandler(this.ControlCuentas_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ControlCuentas_Scroll);
            this.Click += new System.EventHandler(this.ControlCuentas_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlCuentas_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlCuentas_MouseDown);
            this.MouseEnter += new System.EventHandler(this.ControlCuentas_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ControlCuentas_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlCuentas_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlCuentas_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrScroll;
        private System.Windows.Forms.Timer tmrDragScroll;
    }
}
