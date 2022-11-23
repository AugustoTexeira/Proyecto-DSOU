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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileHolder));
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gifcarga = new ProWork.loadingGIF();
            this.cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gifcarga)).BeginInit();
            this.SuspendLayout();
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirCarpetaToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(152, 26);
            // 
            // añadirCarpetaToolStripMenuItem
            // 
            this.añadirCarpetaToolStripMenuItem.Name = "añadirCarpetaToolStripMenuItem";
            this.añadirCarpetaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.añadirCarpetaToolStripMenuItem.Text = "Añadir carpeta";
            this.añadirCarpetaToolStripMenuItem.Click += new System.EventHandler(this.añadirCarpetaToolStripMenuItem_Click);
            // 
            // gifcarga
            // 
            this.gifcarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gifcarga.Animar = false;
            this.gifcarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gifcarga.delay = 250;
            this.gifcarga.Image = ((System.Drawing.Image)(resources.GetObject("gifcarga.Image")));
            this.gifcarga.Location = new System.Drawing.Point(171, 159);
            this.gifcarga.Name = "gifcarga";
            this.gifcarga.Size = new System.Drawing.Size(113, 84);
            this.gifcarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gifcarga.TabIndex = 1;
            this.gifcarga.TabStop = false;
            // 
            // FileHolder
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.gifcarga);
            this.Name = "FileHolder";
            this.Size = new System.Drawing.Size(455, 403);
            this.Load += new System.EventHandler(this.FileHolder_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileHolder_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileHolder_DragEnter);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FileHolder_MouseClick);
            this.Resize += new System.EventHandler(this.FileHolder_Resize);
            this.cms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gifcarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip cms;
        private ToolStripMenuItem añadirCarpetaToolStripMenuItem;
        private loadingGIF gifcarga;
    }
}
