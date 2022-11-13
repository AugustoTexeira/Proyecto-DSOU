namespace ProWork
{
    partial class frmAñadirContacto
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
            this.utbNombre = new ProWork.UnderlinedTextBox();
            this.utbCorreo = new ProWork.UnderlinedTextBox();
            this.stbDesc = new ProWork.SurroundedTextBox();
            this.cbtAniadir = new ProWork.CustomButton();
            this.utbTel = new ProWork.UnderlinedTextBox();
            this.enhancedPictureBox1 = new ProWork.enhancedPictureBox();
            this.SuspendLayout();
            // 
            // utbNombre
            // 
            this.utbNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.utbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbNombre.Location = new System.Drawing.Point(38, 151);
            this.utbNombre.Name = "utbNombre";
            this.utbNombre.PlaceholderText = "Nombre";
            this.utbNombre.Size = new System.Drawing.Size(324, 36);
            this.utbNombre.TabIndex = 1;
            this.utbNombre.txbText = "";
            this.utbNombre.UsePasswordChar = false;
            this.utbNombre.EnterPressed += new System.EventHandler(this.cbtAniadir_ButtonClick);
            // 
            // utbCorreo
            // 
            this.utbCorreo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.utbCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbCorreo.Location = new System.Drawing.Point(38, 204);
            this.utbCorreo.Name = "utbCorreo";
            this.utbCorreo.PlaceholderText = "Correo electrónico";
            this.utbCorreo.Size = new System.Drawing.Size(324, 36);
            this.utbCorreo.TabIndex = 2;
            this.utbCorreo.txbText = "";
            this.utbCorreo.UsePasswordChar = false;
            this.utbCorreo.EnterPressed += new System.EventHandler(this.cbtAniadir_ButtonClick);
            // 
            // stbDesc
            // 
            this.stbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stbDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.stbDesc.fontTitulo = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stbDesc.Location = new System.Drawing.Point(397, 25);
            this.stbDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stbDesc.Name = "stbDesc";
            this.stbDesc.rtbText = "";
            this.stbDesc.Size = new System.Drawing.Size(382, 364);
            this.stbDesc.TabIndex = 0;
            this.stbDesc.textTitulo = "Descripción";
            this.stbDesc.EnterPressed += new System.EventHandler(this.cbtAniadir_ButtonClick);
            // 
            // cbtAniadir
            // 
            this.cbtAniadir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbtAniadir.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtAniadir.Location = new System.Drawing.Point(38, 311);
            this.cbtAniadir.Name = "cbtAniadir";
            this.cbtAniadir.Size = new System.Drawing.Size(324, 68);
            this.cbtAniadir.TabIndex = 4;
            this.cbtAniadir.Texto = "Confirmar";
            this.cbtAniadir.ButtonClick += new System.EventHandler(this.cbtAniadir_ButtonClick);
            // 
            // utbTel
            // 
            this.utbTel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.utbTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbTel.Location = new System.Drawing.Point(38, 257);
            this.utbTel.Name = "utbTel";
            this.utbTel.PlaceholderText = "Teléfono";
            this.utbTel.Size = new System.Drawing.Size(324, 36);
            this.utbTel.TabIndex = 3;
            this.utbTel.txbText = "";
            this.utbTel.UsePasswordChar = false;
            this.utbTel.EnterPressed += new System.EventHandler(this.cbtAniadir_ButtonClick);
            // 
            // enhancedPictureBox1
            // 
            this.enhancedPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.enhancedPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.enhancedPictureBox1.BkgImage = global::ProWork.Properties.Resources.ContactoOscuro;
            this.enhancedPictureBox1.Circle = false;
            this.enhancedPictureBox1.Location = new System.Drawing.Point(150, 36);
            this.enhancedPictureBox1.Name = "enhancedPictureBox1";
            this.enhancedPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.enhancedPictureBox1.TabIndex = 5;
            // 
            // frmAñadirContacto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(817, 415);
            this.Controls.Add(this.utbTel);
            this.Controls.Add(this.cbtAniadir);
            this.Controls.Add(this.stbDesc);
            this.Controls.Add(this.utbCorreo);
            this.Controls.Add(this.utbNombre);
            this.Controls.Add(this.enhancedPictureBox1);
            this.MinimumSize = new System.Drawing.Size(835, 462);
            this.Name = "frmAñadirContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "➕ Añadir contacto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAñadirContacto_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private UnderlinedTextBox utbNombre;
        private UnderlinedTextBox utbCorreo;
        private SurroundedTextBox stbDesc;
        private CustomButton cbtAniadir;
        private UnderlinedTextBox utbTel;
        private enhancedPictureBox enhancedPictureBox1;
    }
}