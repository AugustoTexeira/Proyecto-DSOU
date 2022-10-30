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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.utbEmail = new ProWork.UnderlinedTextBox();
            this.utbTel = new ProWork.UnderlinedTextBox();
            this.stbDesc = new ProWork.SurroundedTextBox();
            this.cbtGuardar = new ProWork.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Purple;
            this.pictureBox1.Location = new System.Drawing.Point(190, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txbNombre
            // 
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
            this.utbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbEmail.Location = new System.Drawing.Point(103, 278);
            this.utbEmail.Name = "utbEmail";
            this.utbEmail.PlaceholderText = "Email";
            this.utbEmail.Size = new System.Drawing.Size(324, 36);
            this.utbEmail.TabIndex = 2;
            this.utbEmail.txbText = "";
            this.utbEmail.UsePasswordChar = false;
            // 
            // utbTel
            // 
            this.utbTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbTel.Location = new System.Drawing.Point(103, 333);
            this.utbTel.Name = "utbTel";
            this.utbTel.PlaceholderText = "Teléfono";
            this.utbTel.Size = new System.Drawing.Size(324, 36);
            this.utbTel.TabIndex = 3;
            this.utbTel.txbText = "";
            this.utbTel.UsePasswordChar = false;
            // 
            // stbDesc
            // 
            this.stbDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.stbDesc.fontTitulo = new System.Drawing.Font("Segoe UI", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stbDesc.Location = new System.Drawing.Point(103, 388);
            this.stbDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stbDesc.Name = "stbDesc";
            this.stbDesc.rtbText = "Hola";
            this.stbDesc.Size = new System.Drawing.Size(324, 158);
            this.stbDesc.TabIndex = 0;
            this.stbDesc.textTitulo = "";
            // 
            // cbtGuardar
            // 
            this.cbtGuardar.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtGuardar.Location = new System.Drawing.Point(173, 565);
            this.cbtGuardar.Name = "cbtGuardar";
            this.cbtGuardar.Size = new System.Drawing.Size(185, 56);
            this.cbtGuardar.TabIndex = 5;
            this.cbtGuardar.Texto = "Guardar";
            this.cbtGuardar.ButtonClick += new System.EventHandler(this.cbtGuardar_ButtonClick);
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
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmContactosConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContactosConfig";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmContactosConfig_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txbNombre;
        private UnderlinedTextBox utbEmail;
        private UnderlinedTextBox utbTel;
        private SurroundedTextBox stbDesc;
        private CustomButton cbtGuardar;
    }
}