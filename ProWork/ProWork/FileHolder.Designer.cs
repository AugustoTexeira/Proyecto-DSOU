namespace ProWork
{
    partial class FileHolder
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
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirCarpetaToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(181, 48);
            // 
            // añadirCarpetaToolStripMenuItem
            // 
            this.añadirCarpetaToolStripMenuItem.Name = "añadirCarpetaToolStripMenuItem";
            this.añadirCarpetaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.añadirCarpetaToolStripMenuItem.Text = "Añadir carpeta";
            // 
            // FileHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Name = "FileHolder";
            this.Size = new System.Drawing.Size(455, 403);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FileHolder_MouseClick);
            this.Resize += new System.EventHandler(this.FileHolder_Resize);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip cms;
        private ToolStripMenuItem añadirCarpetaToolStripMenuItem;
    }
}
