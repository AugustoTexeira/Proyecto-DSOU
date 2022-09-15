namespace ProWork
{
    partial class frmTinyLogin
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
            this.lblRegistrarme = new System.Windows.Forms.Label();
            this.utbNombre = new ProWork.UnderlinedTextBox();
            this.utbContra = new ProWork.UnderlinedTextBox();
            this.cbtCrear = new ProWork.CustomButton();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnContra = new System.Windows.Forms.Button();
            this.bgwCheck = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProWork.Properties.Resources.Usuario;
            this.pictureBox1.Location = new System.Drawing.Point(209, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblRegistrarme
            // 
            this.lblRegistrarme.AutoSize = true;
            this.lblRegistrarme.Font = new System.Drawing.Font("Raleway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistrarme.ForeColor = System.Drawing.Color.White;
            this.lblRegistrarme.Location = new System.Drawing.Point(49, 286);
            this.lblRegistrarme.Name = "lblRegistrarme";
            this.lblRegistrarme.Size = new System.Drawing.Size(485, 83);
            this.lblRegistrarme.TabIndex = 1;
            this.lblRegistrarme.Text = "INICIAR SESIÓN";
            // 
            // utbNombre
            // 
            this.utbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbNombre.Location = new System.Drawing.Point(119, 372);
            this.utbNombre.Name = "utbNombre";
            this.utbNombre.PlaceholderText = "Nombre";
            this.utbNombre.Size = new System.Drawing.Size(344, 36);
            this.utbNombre.TabIndex = 2;
            this.utbNombre.txbText = "";
            this.utbNombre.UsePasswordChar = false;
            // 
            // utbContra
            // 
            this.utbContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbContra.Location = new System.Drawing.Point(119, 423);
            this.utbContra.Name = "utbContra";
            this.utbContra.PlaceholderText = "Contraseña";
            this.utbContra.Size = new System.Drawing.Size(344, 36);
            this.utbContra.TabIndex = 3;
            this.utbContra.txbText = "";
            this.utbContra.UsePasswordChar = true;
            // 
            // cbtCrear
            // 
            this.cbtCrear.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtCrear.Location = new System.Drawing.Point(108, 536);
            this.cbtCrear.Name = "cbtCrear";
            this.cbtCrear.Size = new System.Drawing.Size(366, 68);
            this.cbtCrear.TabIndex = 5;
            this.cbtCrear.Texto = "INGRESAR";
            this.cbtCrear.ButtonClick += new System.EventHandler(this.cbtCrear_Click);
            this.cbtCrear.Click += new System.EventHandler(this.cbtCrear_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLogin.Location = new System.Drawing.Point(119, 471);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(344, 25);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "¿No tienes una cuenta? Regístrate";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            this.lblLogin.MouseEnter += new System.EventHandler(this.lblLogin_MouseEnter);
            this.lblLogin.MouseLeave += new System.EventHandler(this.lblLogin_MouseLeave);
            // 
            // btnContra
            // 
            this.btnContra.BackColor = System.Drawing.Color.Transparent;
            this.btnContra.BackgroundImage = global::ProWork.Properties.Resources.ojitosi32;
            this.btnContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnContra.FlatAppearance.BorderSize = 0;
            this.btnContra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContra.ForeColor = System.Drawing.Color.White;
            this.btnContra.Location = new System.Drawing.Point(425, 423);
            this.btnContra.Name = "btnContra";
            this.btnContra.Size = new System.Drawing.Size(38, 36);
            this.btnContra.TabIndex = 7;
            this.btnContra.UseVisualStyleBackColor = false;
            this.btnContra.Click += new System.EventHandler(this.btnContra_Click);
            this.btnContra.Paint += new System.Windows.Forms.PaintEventHandler(this.btnContra_Paint);
            // 
            // bgwCheck
            // 
            this.bgwCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCheck_DoWork);
            this.bgwCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCheck_RunWorkerCompleted);
            // 
            // frmTinyLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(582, 674);
            this.Controls.Add(this.btnContra);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.cbtCrear);
            this.Controls.Add(this.utbContra);
            this.Controls.Add(this.utbNombre);
            this.Controls.Add(this.lblRegistrarme);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTinyLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTinyRegister_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblRegistrarme;
        private UnderlinedTextBox utbNombre;
        private UnderlinedTextBox utbContra;
        private CustomButton cbtCrear;
        private Label lblLogin;
        private Button btnContra;
        private System.ComponentModel.BackgroundWorker bgwCheck;
    }
}