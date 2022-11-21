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
            this.components = new System.ComponentModel.Container();
            this.lbl = new System.Windows.Forms.Label();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cambiarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarFiltrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcb = new ProWork.enhancedPictureBox();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AllowDrop = true;
            this.lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(0, 59);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(100, 41);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Carpeta indefinida";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.Carpeta_DragEnter);
            this.lbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Carpeta_MouseClick);
            this.lbl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Carpeta_MouseDoubleClick);
            this.lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Carpeta_MouseMove);
            this.lbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Carpeta_MouseUp);
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarNombreToolStripMenuItem,
            this.eliminarCarpetaToolStripMenuItem,
            this.descargarToolStripMenuItem,
            this.cambiarFiltrosToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(191, 100);
            // 
            // cambiarNombreToolStripMenuItem
            // 
            this.cambiarNombreToolStripMenuItem.Name = "cambiarNombreToolStripMenuItem";
            this.cambiarNombreToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.cambiarNombreToolStripMenuItem.Text = "Cambiar nombre";
            this.cambiarNombreToolStripMenuItem.Click += new System.EventHandler(this.cambiarNombreToolStripMenuItem_Click);
            // 
            // eliminarCarpetaToolStripMenuItem
            // 
            this.eliminarCarpetaToolStripMenuItem.Name = "eliminarCarpetaToolStripMenuItem";
            this.eliminarCarpetaToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.eliminarCarpetaToolStripMenuItem.Text = "Eliminar carpeta";
            this.eliminarCarpetaToolStripMenuItem.Click += new System.EventHandler(this.eliminarCarpetaToolStripMenuItem_Click);
            // 
            // descargarToolStripMenuItem
            // 
            this.descargarToolStripMenuItem.Name = "descargarToolStripMenuItem";
            this.descargarToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.descargarToolStripMenuItem.Text = "Descargar";
            this.descargarToolStripMenuItem.Click += new System.EventHandler(this.descargarToolStripMenuItem_Click);
            // 
            // cambiarFiltrosToolStripMenuItem
            // 
            this.cambiarFiltrosToolStripMenuItem.Name = "cambiarFiltrosToolStripMenuItem";
            this.cambiarFiltrosToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.cambiarFiltrosToolStripMenuItem.Text = "Cambiar filtros";
            this.cambiarFiltrosToolStripMenuItem.Click += new System.EventHandler(this.cambiarFiltrosToolStripMenuItem_Click);
            // 
            // pcb
            // 
            this.pcb.AllowDrop = true;
            this.pcb.BackColor = System.Drawing.Color.Transparent;
            this.pcb.BkgImage = global::ProWork.Properties.Resources.Carpetas;
            this.pcb.Circle = false;
            this.pcb.Location = new System.Drawing.Point(11, 0);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(79, 59);
            this.pcb.TabIndex = 4;
            this.pcb.TabStop = false;
            this.pcb.DragEnter += new System.Windows.Forms.DragEventHandler(this.Carpeta_DragEnter);
            this.pcb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Carpeta_MouseClick);
            this.pcb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Carpeta_MouseDoubleClick);
            this.pcb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Carpeta_MouseDown);
            this.pcb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Carpeta_MouseMove);
            this.pcb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Carpeta_MouseUp);
            // 
            // Carpeta
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.pcb);
            this.Controls.Add(this.lbl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Carpeta";
            this.Size = new System.Drawing.Size(100, 100);
            this.Load += new System.EventHandler(this.Carpeta_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Carpeta_DragEnter);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Carpeta_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Carpeta_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Carpeta_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Carpeta_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Carpeta_MouseUp);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl;
        private ContextMenuStrip cms;
        private ToolStripMenuItem cambiarNombreToolStripMenuItem;
        private ToolStripMenuItem eliminarCarpetaToolStripMenuItem;
        private ToolStripMenuItem descargarToolStripMenuItem;
        private ToolStripMenuItem cambiarFiltrosToolStripMenuItem;
        private enhancedPictureBox pcb;
    }
}
