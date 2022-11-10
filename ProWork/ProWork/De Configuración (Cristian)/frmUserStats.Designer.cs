namespace ProWork.De_Configuración__Cristian_
{
    partial class frmUserStats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grf = new ProWork.graficaContainer();
            this.SuspendLayout();
            // 
            // grf
            // 
            this.grf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.grf.devMode = false;
            this.grf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grf.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grf.HighlightDots = false;
            this.grf.isBarGraph = false;
            this.grf.Location = new System.Drawing.Point(0, 0);
            this.grf.Name = "grf";
            this.grf.onlyDots = false;
            this.grf.Points = new System.Drawing.Point[] {
        new System.Drawing.Point(1, 3),
        new System.Drawing.Point(2, 2),
        new System.Drawing.Point(3, 5),
        new System.Drawing.Point(5, 0)};
            this.grf.Scale = new System.Drawing.Size(100, 100);
            this.grf.Size = new System.Drawing.Size(1019, 648);
            this.grf.TabIndex = 0;
            this.grf.XAxis = "nombre";
            this.grf.YAxis = "id";
            // 
            // frmUserStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1019, 648);
            this.Controls.Add(this.grf);
            this.Name = "frmUserStats";
            this.Text = "Estadísticas de usuario";
            this.ResumeLayout(false);

        }

        #endregion

        private graficaContainer grf;
    }
}