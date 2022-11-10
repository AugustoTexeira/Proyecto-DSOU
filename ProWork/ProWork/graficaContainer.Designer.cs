namespace ProWork
{
    partial class graficaContainer
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
            this.grf = new ProWork.Grafica();
            this.SuspendLayout();
            // 
            // grf
            // 
            this.grf.BackColor = System.Drawing.Color.Transparent;
            this.grf.Downwards = false;
            this.grf.highlightDots = false;
            this.grf.isBarGraph = false;
            this.grf.Location = new System.Drawing.Point(0, 0);
            this.grf.Name = "grf";
            this.grf.onlyDots = false;
            this.grf.Points = new System.Drawing.Point[] {
        new System.Drawing.Point(1, 3),
        new System.Drawing.Point(2, 2),
        new System.Drawing.Point(3, 5),
        new System.Drawing.Point(5, 0)};
            this.grf.realCoordsOfPoints = new System.Drawing.Point[] {
        new System.Drawing.Point(4, 345),
        new System.Drawing.Point(9, 348),
        new System.Drawing.Point(13, 338),
        new System.Drawing.Point(22, 356)};
            this.grf.Scale = new System.Drawing.Size(100, 100);
            this.grf.Size = new System.Drawing.Size(451, 356);
            this.grf.TabIndex = 0;
            this.grf.XOffset = 0;
            this.grf.YOffset = 0;
            this.grf.Click += new System.EventHandler(this.grf_Click);
            this.grf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graficaContainer_MouseClick);
            // 
            // graficaContainer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.grf);
            this.DoubleBuffered = true;
            this.Name = "graficaContainer";
            this.Size = new System.Drawing.Size(451, 356);
            this.FontChanged += new System.EventHandler(this.graficaContainer_FontChanged);
            this.Click += new System.EventHandler(this.graficaContainer_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.graficaContainer_Paint);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.graficaContainer_Layout);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graficaContainer_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private Grafica grf;
    }
}
