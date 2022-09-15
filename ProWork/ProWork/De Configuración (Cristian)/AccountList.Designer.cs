namespace ProWork
{
    partial class AccountList
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
            this.SuspendLayout();
            // 
            // AccountList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Name = "AccountList";
            this.Load += new System.EventHandler(this.AccountList_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AccountList_Paint);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.AccountList_Layout);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
