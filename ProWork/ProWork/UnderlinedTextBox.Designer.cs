namespace ProWork
{
    partial class UnderlinedTextBox
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
            this.txb = new System.Windows.Forms.TextBox();
            this.tmrSubrayado = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txb
            // 
            this.txb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb.Location = new System.Drawing.Point(0, 3);
            this.txb.Name = "txb";
            this.txb.PlaceholderText = "Yyy";
            this.txb.Size = new System.Drawing.Size(256, 31);
            this.txb.TabIndex = 0;
            this.txb.Enter += new System.EventHandler(this.txb_Enter);
            this.txb.Validated += new System.EventHandler(this.txb_Leave);
            // 
            // tmrSubrayado
            // 
            this.tmrSubrayado.Interval = 16;
            this.tmrSubrayado.Tick += new System.EventHandler(this.tmrSubrayado_Tick);
            // 
            // UnderlinedTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txb);
            this.Name = "UnderlinedTextBox";
            this.Size = new System.Drawing.Size(259, 41);
            this.Load += new System.EventHandler(this.UnderlinedTextBox_Load);
            this.FontChanged += new System.EventHandler(this.UnderlinedTextBox_FontChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UnderlinedTextBox_Paint);
            this.Enter += new System.EventHandler(this.UnderlinedTextBox_Enter);
            this.Resize += new System.EventHandler(this.UnderlinedTextBox_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrSubrayado;
        public TextBox txb;
    }
}
