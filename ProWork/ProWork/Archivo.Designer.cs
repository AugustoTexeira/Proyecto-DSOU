namespace ProWork
{
    partial class Archivo
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
            this.descargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epb = new ProWork.enhancedPictureBox();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(0, 92);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(114, 41);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Carpeta indefinida";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.Archivo_DragEnter);
            this.lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Archivo_MouseUp);
            this.lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Archivo_MouseMove);
            this.lbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Archivo_MouseUp);
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descargarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(127, 48);
            // 
            // descargarToolStripMenuItem
            // 
            this.descargarToolStripMenuItem.Name = "descargarToolStripMenuItem";
            this.descargarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.descargarToolStripMenuItem.Text = "Descargar";
            this.descargarToolStripMenuItem.Click += new System.EventHandler(this.descargarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // epb
            // 
            this.epb.BackColor = System.Drawing.Color.Transparent;
            this.epb.BkgImage = global::ProWork.Properties.Resources.Otros;
            this.epb.Circle = false;
            this.epb.Location = new System.Drawing.Point(0, 0);
            this.epb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.epb.Name = "epb";
            this.epb.Size = new System.Drawing.Size(114, 92);
            this.epb.TabIndex = 3;
            this.epb.TabStop = false;
            this.epb.DragEnter += new System.Windows.Forms.DragEventHandler(this.Archivo_DragEnter);
            this.epb.DoubleClick += new System.EventHandler(this.Archivo_DoubleClick);
            this.epb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Archivo_MouseClick);
            this.epb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Archivo_MouseDown);
            this.epb.MouseEnter += new System.EventHandler(this.epb_MouseEnter);
            this.epb.MouseLeave += new System.EventHandler(this.epb_MouseLeave);
            this.epb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Archivo_MouseMove);
            this.epb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Archivo_MouseUp);
            // 
            // Archivo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.epb);
            this.Controls.Add(this.lbl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Archivo";
            this.Size = new System.Drawing.Size(114, 133);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Archivo_DragEnter);
            this.DoubleClick += new System.EventHandler(this.Archivo_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Archivo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Archivo_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Archivo_MouseUp);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ContextMenuStrip cms;
        private ToolStripMenuItem descargarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        public enhancedPictureBox epb;
        public Label lbl;
    }
}
