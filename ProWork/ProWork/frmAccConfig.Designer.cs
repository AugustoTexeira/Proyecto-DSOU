namespace ProWork
{
    partial class frmAccConfig
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
            this.cbtGuardar = new ProWork.CustomButton();
            this.utbNombre = new ProWork.UnderlinedTextBox();
            this.utbContra = new ProWork.UnderlinedTextBox();
            this.utbCContra = new ProWork.UnderlinedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblCContra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbtGuardar
            // 
            this.cbtGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbtGuardar.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtGuardar.Location = new System.Drawing.Point(291, 197);
            this.cbtGuardar.Name = "cbtGuardar";
            this.cbtGuardar.Size = new System.Drawing.Size(219, 59);
            this.cbtGuardar.TabIndex = 4;
            this.cbtGuardar.TabStop = false;
            this.cbtGuardar.Texto = "Guardar";
            this.cbtGuardar.ButtonClick += new System.EventHandler(this.cbtGuardar_Click);
            this.cbtGuardar.Click += new System.EventHandler(this.cbtGuardar_Click);
            // 
            // utbNombre
            // 
            this.utbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.utbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbNombre.Location = new System.Drawing.Point(329, 53);
            this.utbNombre.Name = "utbNombre";
            this.utbNombre.PlaceholderText = "Pepito Gonzales";
            this.utbNombre.Size = new System.Drawing.Size(401, 36);
            this.utbNombre.TabIndex = 1;
            this.utbNombre.txbText = "";
            this.utbNombre.UsePasswordChar = false;
            this.utbNombre.EnterPressed += new System.EventHandler(this.cbtGuardar_Click);
            // 
            // utbContra
            // 
            this.utbContra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.utbContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbContra.Location = new System.Drawing.Point(329, 95);
            this.utbContra.Name = "utbContra";
            this.utbContra.PlaceholderText = "Vacío: Contraseña anterior";
            this.utbContra.Size = new System.Drawing.Size(401, 36);
            this.utbContra.TabIndex = 2;
            this.utbContra.txbText = "";
            this.utbContra.UsePasswordChar = true;
            this.utbContra.EnterPressed += new System.EventHandler(this.cbtGuardar_Click);
            // 
            // utbCContra
            // 
            this.utbCContra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.utbCContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbCContra.Location = new System.Drawing.Point(329, 137);
            this.utbCContra.Name = "utbCContra";
            this.utbCContra.PlaceholderText = "Vacío: Contraseña anterior";
            this.utbCContra.Size = new System.Drawing.Size(401, 36);
            this.utbCContra.TabIndex = 3;
            this.utbCContra.txbText = "";
            this.utbCContra.UsePasswordChar = true;
            this.utbCContra.EnterPressed += new System.EventHandler(this.cbtGuardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(183, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(140, 36);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblContra
            // 
            this.lblContra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblContra.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContra.ForeColor = System.Drawing.Color.White;
            this.lblContra.Location = new System.Drawing.Point(127, 95);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(196, 36);
            this.lblContra.TabIndex = 6;
            this.lblContra.Text = "Contraseña:";
            this.lblContra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCContra
            // 
            this.lblCContra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCContra.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCContra.ForeColor = System.Drawing.Color.White;
            this.lblCContra.Location = new System.Drawing.Point(70, 137);
            this.lblCContra.Name = "lblCContra";
            this.lblCContra.Size = new System.Drawing.Size(253, 36);
            this.lblCContra.TabIndex = 7;
            this.lblCContra.Text = "Confirmar Contraseña:";
            this.lblCContra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAccConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.lblCContra);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.utbCContra);
            this.Controls.Add(this.utbContra);
            this.Controls.Add(this.utbNombre);
            this.Controls.Add(this.cbtGuardar);
            this.MinimumSize = new System.Drawing.Size(818, 356);
            this.Name = "frmAccConfig";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "⚙️ Configuración";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAccConfig_FormClosed);
            this.Load += new System.EventHandler(this.frmAccConfig_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton cbtGuardar;
        private UnderlinedTextBox utbNombre;
        private UnderlinedTextBox utbContra;
        private UnderlinedTextBox utbCContra;
        private Label lblNombre;
        private Label lblContra;
        private Label lblCContra;
    }
}