namespace ProWork
{
    partial class SurroundedTextBox
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
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.tmrSurayado = new System.Windows.Forms.Timer(this.components);
            this.tmrSurayadont = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rtb
            // 
            this.rtb.BackColor = System.Drawing.Color.Yellow;
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.rtb.Location = new System.Drawing.Point(29, 90);
            this.rtb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtb.Name = "rtb";
            this.rtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb.Size = new System.Drawing.Size(114, 133);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "";
            this.rtb.Enter += new System.EventHandler(this.rtb_Enter);
            this.rtb.Leave += new System.EventHandler(this.rtb_Leave);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(313, 46);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "SurroundedTextBox";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // tmrSurayado
            // 
            this.tmrSurayado.Interval = 16;
            this.tmrSurayado.Tick += new System.EventHandler(this.tmrSurayado_Tick);
            // 
            // tmrSurayadont
            // 
            this.tmrSurayadont.Interval = 16;
            this.tmrSurayadont.Tick += new System.EventHandler(this.tmrSurayadont_Tick);
            // 
            // SurroundedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.rtb);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SurroundedTextBox";
            this.Size = new System.Drawing.Size(338, 238);
            this.Load += new System.EventHandler(this.SurroundedTextBox_Load);
            this.FontChanged += new System.EventHandler(this.ProWorkBigText_FontChanged);
            this.Click += new System.EventHandler(this.ProWorkBigText_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProWorkBigText_Paint);
            this.Resize += new System.EventHandler(this.ProWorkBigText_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl;
        private System.Windows.Forms.Timer tmrSurayado;
        private System.Windows.Forms.Timer tmrSurayadont;
        public RichTextBox rtb;
    }
}
