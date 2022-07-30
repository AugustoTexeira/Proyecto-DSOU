namespace PrototipoCustoTextBox
{
    partial class CustomButton
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
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(163, 54);
            this.lbl.TabIndex = 0;
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            this.lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            this.lbl.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            // 
            // CustomButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lbl);
            this.Name = "CustomButton";
            this.Size = new System.Drawing.Size(163, 54);
            this.FontChanged += new System.EventHandler(this.CustomButton_FontChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CustomButton_Paint);
            this.Enter += new System.EventHandler(this.lbl_MouseEnter);
            this.Leave += new System.EventHandler(this.lbl_MouseLeave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.Resize += new System.EventHandler(this.CustomButton_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl;
    }
}
