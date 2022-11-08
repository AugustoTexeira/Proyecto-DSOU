namespace ProWork
{
    partial class mainMenu
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
            this.pnlConfig = new ProWork.DoubleBufferedPanel();
            this.tmrExtend = new System.Windows.Forms.Timer(this.components);
            this.tmrShorten = new System.Windows.Forms.Timer(this.components);
            this.pnlContactos = new ProWork.DoubleBufferedPanel();
            this.pnlProyectos = new ProWork.DoubleBufferedPanel();
            this.pnlInicio = new ProWork.DoubleBufferedPanel();
            this.SuspendLayout();
            // 
            // pnlConfig
            // 
            this.pnlConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.pnlConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlConfig.Location = new System.Drawing.Point(0, 496);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(326, 63);
            this.pnlConfig.TabIndex = 8;
            this.pnlConfig.Click += new System.EventHandler(this.pnlConfig_Click);
            this.pnlConfig.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConfig_Paint);
            this.pnlConfig.MouseEnter += new System.EventHandler(this.pnlConfig_MouseEnter);
            this.pnlConfig.MouseLeave += new System.EventHandler(this.pnlConfig_MouseLeave);
            // 
            // tmrExtend
            // 
            this.tmrExtend.Interval = 16;
            this.tmrExtend.Tick += new System.EventHandler(this.tmrExtend_Tick);
            // 
            // tmrShorten
            // 
            this.tmrShorten.Interval = 16;
            this.tmrShorten.Tick += new System.EventHandler(this.tmrShorten_Tick);
            // 
            // pnlContactos
            // 
            this.pnlContactos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.pnlContactos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlContactos.Location = new System.Drawing.Point(1, 325);
            this.pnlContactos.Name = "pnlContactos";
            this.pnlContactos.Size = new System.Drawing.Size(325, 63);
            this.pnlContactos.TabIndex = 9;
            this.pnlContactos.Click += new System.EventHandler(this.pnlContactos_Click);
            this.pnlContactos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContactos_Paint);
            this.pnlContactos.MouseEnter += new System.EventHandler(this.pnlContactos_MouseEnter);
            this.pnlContactos.MouseLeave += new System.EventHandler(this.pnlContactos_MouseLeave);
            // 
            // pnlProyectos
            // 
            this.pnlProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.pnlProyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlProyectos.Location = new System.Drawing.Point(0, 256);
            this.pnlProyectos.Name = "pnlProyectos";
            this.pnlProyectos.Size = new System.Drawing.Size(326, 63);
            this.pnlProyectos.TabIndex = 10;
            this.pnlProyectos.Click += new System.EventHandler(this.pnlProyectos_Click);
            this.pnlProyectos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProyectos_Paint);
            this.pnlProyectos.MouseEnter += new System.EventHandler(this.pnlProyectos_MouseEnter);
            this.pnlProyectos.MouseLeave += new System.EventHandler(this.pnlProyectos_MouseLeave);
            // 
            // pnlInicio
            // 
            this.pnlInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.pnlInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlInicio.ForeColor = System.Drawing.Color.White;
            this.pnlInicio.Location = new System.Drawing.Point(0, 187);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(326, 63);
            this.pnlInicio.TabIndex = 11;
            this.pnlInicio.Click += new System.EventHandler(this.pnlInicio_Click);
            this.pnlInicio.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInicio_Paint);
            this.pnlInicio.MouseEnter += new System.EventHandler(this.pnlInicio_MouseEnter);
            this.pnlInicio.MouseLeave += new System.EventHandler(this.pnlInicio_MouseLeave);
            // 
            // mainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pnlInicio);
            this.Controls.Add(this.pnlProyectos);
            this.Controls.Add(this.pnlContactos);
            this.Controls.Add(this.pnlConfig);
            this.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "mainMenu";
            this.Size = new System.Drawing.Size(326, 574);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainMenu_Paint);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.mainMenu_Layout);
            this.MouseEnter += new System.EventHandler(this.mainMenu_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.mainMenu_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
        private DoubleBufferedPanel pnlConfig;
        private System.Windows.Forms.Timer tmrExtend;
        private System.Windows.Forms.Timer tmrShorten;
        private DoubleBufferedPanel pnlContactos;
        private DoubleBufferedPanel pnlProyectos;
        private DoubleBufferedPanel pnlInicio;
    }
}
