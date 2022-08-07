namespace ProWork
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSwap = new System.Windows.Forms.Button();
            this.pnlForeground = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pbxFondoVersion = new System.Windows.Forms.PictureBox();
            this.pbxFondoLogo = new System.Windows.Forms.PictureBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.btnContra = new System.Windows.Forms.Button();
            this.btnCContra = new System.Windows.Forms.Button();
            this.tmrIntoLogin = new System.Windows.Forms.Timer(this.components);
            this.tmrIntoRegister = new System.Windows.Forms.Timer(this.components);
            this.bgwCheck = new System.ComponentModel.BackgroundWorker();
            this.pbPlusUser = new System.Windows.Forms.PictureBox();
            this.btnLogin = new ProWork.CustomButton();
            this.ctbCContra = new ProWork.UnderlinedTextBox();
            this.ctbContra = new ProWork.UnderlinedTextBox();
            this.ctbNombre = new ProWork.UnderlinedTextBox();
            this.pnlForeground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondoVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondoLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlusUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSwap
            // 
            this.btnSwap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.btnSwap.FlatAppearance.BorderSize = 0;
            this.btnSwap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSwap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(49)))), ((int)(((byte)(247)))));
            this.btnSwap.Location = new System.Drawing.Point(822, 354);
            this.btnSwap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(209, 22);
            this.btnSwap.TabIndex = 1;
            this.btnSwap.Text = "¿Tienes una cuenta? Inicia sesión";
            this.btnSwap.UseVisualStyleBackColor = false;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // pnlForeground
            // 
            this.pnlForeground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlForeground.Controls.Add(this.lblVersion);
            this.pnlForeground.Controls.Add(this.pbxFondoVersion);
            this.pnlForeground.Controls.Add(this.pbxFondoLogo);
            this.pnlForeground.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlForeground.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(15)))));
            this.pnlForeground.Location = new System.Drawing.Point(0, 0);
            this.pnlForeground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlForeground.Name = "pnlForeground";
            this.pnlForeground.Size = new System.Drawing.Size(750, 505);
            this.pnlForeground.TabIndex = 8;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.lblVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(12, 468);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(107, 28);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Versión 0.1";
            // 
            // pbxFondoVersion
            // 
            this.pbxFondoVersion.Image = global::ProWork.Properties.Resources.Version_fondo1;
            this.pbxFondoVersion.Location = new System.Drawing.Point(-25, 404);
            this.pbxFondoVersion.Name = "pbxFondoVersion";
            this.pbxFondoVersion.Size = new System.Drawing.Size(188, 160);
            this.pbxFondoVersion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFondoVersion.TabIndex = 1;
            this.pbxFondoVersion.TabStop = false;
            // 
            // pbxFondoLogo
            // 
            this.pbxFondoLogo.Image = global::ProWork.Properties.Resources.Logo_en_login;
            this.pbxFondoLogo.Location = new System.Drawing.Point(68, 44);
            this.pbxFondoLogo.Name = "pbxFondoLogo";
            this.pbxFondoLogo.Size = new System.Drawing.Size(627, 425);
            this.pbxFondoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFondoLogo.TabIndex = 0;
            this.pbxFondoLogo.TabStop = false;
            // 
            // pbxUser
            // 
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUser.Image = global::ProWork.Properties.Resources.Usuario;
            this.pbxUser.Location = new System.Drawing.Point(890, 44);
            this.pbxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(91, 106);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUser.TabIndex = 9;
            this.pbxUser.TabStop = false;
            // 
            // btnContra
            // 
            this.btnContra.BackColor = System.Drawing.Color.Transparent;
            this.btnContra.BackgroundImage = global::ProWork.Properties.Resources.ojitosi32;
            this.btnContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContra.FlatAppearance.BorderSize = 0;
            this.btnContra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContra.ForeColor = System.Drawing.Color.White;
            this.btnContra.Location = new System.Drawing.Point(1040, 229);
            this.btnContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContra.Name = "btnContra";
            this.btnContra.Size = new System.Drawing.Size(33, 20);
            this.btnContra.TabIndex = 3;
            this.btnContra.UseVisualStyleBackColor = false;
            this.btnContra.Click += new System.EventHandler(this.pbxOContra_Click);
            this.btnContra.Paint += new System.Windows.Forms.PaintEventHandler(this.btnContra_Paint);
            // 
            // btnCContra
            // 
            this.btnCContra.BackgroundImage = global::ProWork.Properties.Resources.ojitosi32;
            this.btnCContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCContra.FlatAppearance.BorderSize = 0;
            this.btnCContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnCContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCContra.Location = new System.Drawing.Point(1040, 260);
            this.btnCContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCContra.Name = "btnCContra";
            this.btnCContra.Size = new System.Drawing.Size(32, 20);
            this.btnCContra.TabIndex = 5;
            this.btnCContra.UseVisualStyleBackColor = true;
            this.btnCContra.Click += new System.EventHandler(this.btnCContra_Click);
            this.btnCContra.Paint += new System.Windows.Forms.PaintEventHandler(this.btnCContra_Paint);
            // 
            // tmrIntoLogin
            // 
            this.tmrIntoLogin.Interval = 16;
            this.tmrIntoLogin.Tick += new System.EventHandler(this.tmrIntoLogin_Tick);
            // 
            // tmrIntoRegister
            // 
            this.tmrIntoRegister.Interval = 16;
            this.tmrIntoRegister.Tick += new System.EventHandler(this.tmrIntoRegister_Tick);
            // 
            // bgwCheck
            // 
            this.bgwCheck.WorkerReportsProgress = true;
            this.bgwCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkLogin);
            this.bgwCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCheck_RunWorkerCompleted);
            // 
            // pbPlusUser
            // 
            this.pbPlusUser.Image = global::ProWork.Properties.Resources.MasUsuario;
            this.pbPlusUser.Location = new System.Drawing.Point(975, 79);
            this.pbPlusUser.Name = "pbPlusUser";
            this.pbPlusUser.Size = new System.Drawing.Size(32, 28);
            this.pbPlusUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlusUser.TabIndex = 13;
            this.pbPlusUser.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Curva = 16;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(809, 310);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(242, 37);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Texto = "Crear";
            this.btnLogin.ButtonClick += new System.EventHandler(this.btnLogin_Click);
            // 
            // ctbCContra
            // 
            this.ctbCContra.Ancho = 2;
            this.ctbCContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ctbCContra.Location = new System.Drawing.Point(799, 260);
            this.ctbCContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctbCContra.Name = "ctbCContra";
            this.ctbCContra.PlaceholderText = "Confirmar contraseña";
            this.ctbCContra.Size = new System.Drawing.Size(274, 27);
            this.ctbCContra.TabIndex = 18;
            this.ctbCContra.txbText = "";
            this.ctbCContra.UsePasswordChar = false;
            // 
            // ctbContra
            // 
            this.ctbContra.Ancho = 2;
            this.ctbContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ctbContra.Location = new System.Drawing.Point(799, 229);
            this.ctbContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctbContra.Name = "ctbContra";
            this.ctbContra.PlaceholderText = "Contraseña";
            this.ctbContra.Size = new System.Drawing.Size(274, 27);
            this.ctbContra.TabIndex = 17;
            this.ctbContra.txbText = "";
            this.ctbContra.UsePasswordChar = false;
            // 
            // ctbNombre
            // 
            this.ctbNombre.Ancho = 2;
            this.ctbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ctbNombre.Location = new System.Drawing.Point(799, 197);
            this.ctbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctbNombre.Name = "ctbNombre";
            this.ctbNombre.PlaceholderText = "Nombre";
            this.ctbNombre.Size = new System.Drawing.Size(274, 27);
            this.ctbNombre.TabIndex = 19;
            this.ctbNombre.txbText = "";
            this.ctbNombre.UsePasswordChar = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.ctbNombre);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pbPlusUser);
            this.Controls.Add(this.btnCContra);
            this.Controls.Add(this.btnContra);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.pnlForeground);
            this.Controls.Add(this.ctbContra);
            this.Controls.Add(this.ctbCContra);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prowork";
            this.pnlForeground.ResumeLayout(false);
            this.pnlForeground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondoVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondoLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlusUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnSwap;
        private Panel pnlForeground;
        private PictureBox pbxUser;
        private Button btnContra;
        private Button btnCContra;
        private System.Windows.Forms.Timer tmrIntoLogin;
        private System.Windows.Forms.Timer tmrIntoRegister;
        private System.ComponentModel.BackgroundWorker bgwCheck;
        private PictureBox pbxFondoLogo;
        private Label lblVersion;
        private PictureBox pbxFondoVersion;
        private PictureBox pbPlusUser;
        private ProWork.CustomButton btnLogin;
        private UnderlinedTextBox ctbCContra;
        private UnderlinedTextBox ctbContra;
        private UnderlinedTextBox ctbNombre;
    }
}