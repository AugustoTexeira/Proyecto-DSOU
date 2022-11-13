namespace ProWork
{
    partial class frmContactosConfig
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
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.utbEmail = new ProWork.UnderlinedTextBox();
            this.utbTel = new ProWork.UnderlinedTextBox();
            this.stbDesc = new ProWork.SurroundedTextBox();
            this.cbtGuardar = new ProWork.CustomButton();
            this.enhancedPictureBox1 = new ProWork.enhancedPictureBox();
            this.SuspendLayout();
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.txbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNombre.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbNombre.ForeColor = System.Drawing.Color.White;
            this.txbNombre.Location = new System.Drawing.Point(12, 205);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(507, 54);
            this.txbNombre.TabIndex = 1;
            this.txbNombre.Text = "Juan Pérez";
            this.txbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // utbEmail
            // 
            this.utbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.utbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbEmail.Location = new System.Drawing.Point(103, 278);
            this.utbEmail.Name = "utbEmail";
            this.utbEmail.PlaceholderText = "Email";
            this.utbEmail.Size = new System.Drawing.Size(324, 36);
            this.utbEmail.TabIndex = 2;
            this.utbEmail.txbText = "";
            this.utbEmail.UsePasswordChar = false;
            this.utbEmail.EnterPressed += new System.EventHandler(this.cbtGuardar_ButtonClick);
            // 
            // utbTel
            // 
            this.utbTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.utbTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbTel.Location = new System.Drawing.Point(103, 333);
            this.utbTel.Name = "utbTel";
            this.utbTel.PlaceholderText = "Teléfono";
            this.utbTel.Size = new System.Drawing.Size(324, 36);
            this.utbTel.TabIndex = 3;
            this.utbTel.txbText = "";
            this.utbTel.UsePasswordChar = false;
            this.utbTel.EnterPressed += new System.EventHandler(this.cbtGuardar_ButtonClick);
            // 
            // stbDesc
            // 
            this.stbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stbDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.stbDesc.fontTitulo = new System.Drawing.Font("Segoe UI", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stbDesc.Location = new System.Drawing.Point(103, 388);
            this.stbDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stbDesc.Name = "stbDesc";
            this.stbDesc.rtbText = "Hola";
            this.stbDesc.Size = new System.Drawing.Size(324, 158);
            this.stbDesc.TabIndex = 0;
            this.stbDesc.textTitulo = "";
            this.stbDesc.EnterPressed += new System.EventHandler(this.cbtGuardar_ButtonClick);
            // 
            // cbtGuardar
            // 
            this.cbtGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbtGuardar.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtGuardar.Location = new System.Drawing.Point(173, 565);
            this.cbtGuardar.Name = "cbtGuardar";
            this.cbtGuardar.Size = new System.Drawing.Size(185, 56);
            this.cbtGuardar.TabIndex = 5;
            this.cbtGuardar.Texto = "Guardar";
            this.cbtGuardar.ButtonClick += new System.EventHandler(this.cbtGuardar_ButtonClick);
            // 
            // enhancedPictureBox1
            // 
            this.enhancedPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enhancedPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.enhancedPictureBox1.BkgImage = global::ProWork.Properties.Resources.ContactoOscuro;
            this.enhancedPictureBox1.Circle = false;
            this.enhancedPictureBox1.Location = new System.Drawing.Point(190, 36);
            this.enhancedPictureBox1.Name = "enhancedPictureBox1";
            this.enhancedPictureBox1.Size = new System.Drawing.Size(150, 150);
            this.enhancedPictureBox1.TabIndex = 6;
            // 
            // frmContactosConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(531, 657);
            this.Controls.Add(this.cbtGuardar);
            this.Controls.Add(this.stbDesc);
            this.Controls.Add(this.utbTel);
            this.Controls.Add(this.utbEmail);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.enhancedPictureBox1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(549, 704);
            this.Name = "frmContactosConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContactosConfig";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmContactosConfig_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txbNombre;
        private UnderlinedTextBox utbEmail;
        private UnderlinedTextBox utbTel;
        private SurroundedTextBox stbDesc;
        private CustomButton cbtGuardar;
        private enhancedPictureBox enhancedPictureBox1;
    }
}