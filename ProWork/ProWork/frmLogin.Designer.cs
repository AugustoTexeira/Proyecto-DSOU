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
            this.btnLogin = new PrototipoCustoTextBox.CustomButton();
            this.ctbContra = new PrototipoCustoTextBox.UnderlinedTextBox();
            this.ctbCContra = new PrototipoCustoTextBox.UnderlinedTextBox();
            this.ctbNombre = new PrototipoCustoTextBox.UnderlinedTextBox();
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
            this.btnSwap.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSwap.Location = new System.Drawing.Point(940, 472);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(239, 29);
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
            this.pnlForeground.Name = "pnlForeground";
            this.pnlForeground.Size = new System.Drawing.Size(857, 673);
            this.pnlForeground.TabIndex = 8;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.lblVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(14, 624);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(135, 35);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Versión 1.0";
            // 
            // pbxFondoVersion
            // 
            this.pbxFondoVersion.Image = global::ProWork.Properties.Resources.Version_fondo1;
            this.pbxFondoVersion.Location = new System.Drawing.Point(-29, 539);
            this.pbxFondoVersion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxFondoVersion.Name = "pbxFondoVersion";
            this.pbxFondoVersion.Size = new System.Drawing.Size(215, 213);
            this.pbxFondoVersion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFondoVersion.TabIndex = 1;
            this.pbxFondoVersion.TabStop = false;
            // 
            // pbxFondoLogo
            // 
            this.pbxFondoLogo.Image = global::ProWork.Properties.Resources.Logo_en_login;
            this.pbxFondoLogo.Location = new System.Drawing.Point(78, 59);
            this.pbxFondoLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxFondoLogo.Name = "pbxFondoLogo";
            this.pbxFondoLogo.Size = new System.Drawing.Size(717, 567);
            this.pbxFondoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFondoLogo.TabIndex = 0;
            this.pbxFondoLogo.TabStop = false;
            // 
            // pbxUser
            // 
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUser.Image = global::ProWork.Properties.Resources.Usuario;
            this.pbxUser.Location = new System.Drawing.Point(1017, 59);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(104, 141);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUser.TabIndex = 9;
            this.pbxUser.TabStop = false;
            // 
            // btnContra
            // 
            this.btnContra.BackColor = System.Drawing.Color.Transparent;
            this.btnContra.FlatAppearance.BorderSize = 0;
            this.btnContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContra.Image = global::ProWork.Properties.Resources.ojitosi321;
            this.btnContra.Location = new System.Drawing.Point(1189, 305);
            this.btnContra.Name = "btnContra";
            this.btnContra.Size = new System.Drawing.Size(37, 26);
            this.btnContra.TabIndex = 3;
            this.btnContra.UseVisualStyleBackColor = false;
            this.btnContra.Click += new System.EventHandler(this.pbxOContra_Click);
            this.btnContra.Paint += new System.Windows.Forms.PaintEventHandler(this.btnContra_Paint);
            // 
            // btnCContra
            // 
            this.btnCContra.FlatAppearance.BorderSize = 0;
            this.btnCContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnCContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCContra.Image = global::ProWork.Properties.Resources.ojitosi321;
            this.btnCContra.Location = new System.Drawing.Point(1189, 347);
            this.btnCContra.Name = "btnCContra";
            this.btnCContra.Size = new System.Drawing.Size(37, 26);
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
            this.pbPlusUser.Location = new System.Drawing.Point(1114, 105);
            this.pbPlusUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPlusUser.Name = "pbPlusUser";
            this.pbPlusUser.Size = new System.Drawing.Size(37, 37);
            this.pbPlusUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlusUser.TabIndex = 13;
            this.pbPlusUser.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Contraste = System.Drawing.Color.AliceBlue;
            this.btnLogin.Curva = 26;
            this.btnLogin.Enfasis = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(49)))), ((int)(((byte)(247)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(925, 414);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Secundario = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.btnLogin.Size = new System.Drawing.Size(276, 49);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Texto = "Button";
            this.btnLogin.ButtonClick += new System.EventHandler(this.btnLogin_Click);
            // 
            // ctbContra
            // 
            this.ctbContra.Ancho = 5;
            this.ctbContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ctbContra.Contraste = System.Drawing.Color.White;
            this.ctbContra.Enfasis = System.Drawing.Color.Blue;
            this.ctbContra.Location = new System.Drawing.Point(913, 305);
            this.ctbContra.Name = "ctbContra";
            this.ctbContra.PlaceholderText = "Contraseña";
            this.ctbContra.Size = new System.Drawing.Size(313, 36);
            this.ctbContra.TabIndex = 17;
            this.ctbContra.txbText = "";
            this.ctbContra.UsePasswordChar = false;
            // 
            // ctbCContra
            // 
            this.ctbCContra.Ancho = 5;
            this.ctbCContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ctbCContra.Contraste = System.Drawing.Color.White;
            this.ctbCContra.Enfasis = System.Drawing.Color.Blue;
            this.ctbCContra.Location = new System.Drawing.Point(913, 347);
            this.ctbCContra.Name = "ctbCContra";
            this.ctbCContra.PlaceholderText = "Placeholder";
            this.ctbCContra.Size = new System.Drawing.Size(313, 36);
            this.ctbCContra.TabIndex = 18;
            this.ctbCContra.txbText = "";
            this.ctbCContra.UsePasswordChar = false;
            // 
            // ctbNombre
            // 
            this.ctbNombre.Ancho = 5;
            this.ctbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ctbNombre.Contraste = System.Drawing.Color.White;
            this.ctbNombre.Enfasis = System.Drawing.Color.Blue;
            this.ctbNombre.Location = new System.Drawing.Point(913, 263);
            this.ctbNombre.Name = "ctbNombre";
            this.ctbNombre.PlaceholderText = "Nombre";
            this.ctbNombre.Size = new System.Drawing.Size(313, 36);
            this.ctbNombre.TabIndex = 19;
            this.ctbNombre.txbText = "";
            this.ctbNombre.UsePasswordChar = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
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
        private PrototipoCustoTextBox.CustomButton btnLogin;
        private PrototipoCustoTextBox.UnderlinedTextBox ctbContra;
        private PrototipoCustoTextBox.UnderlinedTextBox ctbCContra;
        private PrototipoCustoTextBox.UnderlinedTextBox ctbNombre;
    }
}