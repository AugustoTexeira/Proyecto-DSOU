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
            this.tmrIntoLogin = new System.Windows.Forms.Timer(this.components);
            this.tmrIntoRegister = new System.Windows.Forms.Timer(this.components);
            this.bgwCheck = new System.ComponentModel.BackgroundWorker();
            this.btnLogin = new ProWork.CustomButton();
            this.ctbNombre = new ProWork.UnderlinedTextBox();
            this.epbUser = new ProWork.enhancedPictureBox();
            this.epbPlusUser = new ProWork.enhancedPictureBox();
            this.ctbContra = new ProWork.PasswordUnderlinedTextBox();
            this.ctbCContra = new ProWork.PasswordUnderlinedTextBox();
            this.graficaContainer1 = new ProWork.graficaContainer();
            this.pnlForeground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondoVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondoLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSwap
            // 
            this.btnSwap.BackColor = System.Drawing.Color.Transparent;
            this.btnSwap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwap.FlatAppearance.BorderSize = 0;
            this.btnSwap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSwap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(49)))), ((int)(((byte)(247)))));
            this.btnSwap.Location = new System.Drawing.Point(914, 472);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(297, 29);
            this.btnSwap.TabIndex = 1;
            this.btnSwap.Text = "¿Tienes una cuenta? Inicia sesión";
            this.btnSwap.UseVisualStyleBackColor = false;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            this.btnSwap.MouseEnter += new System.EventHandler(this.btnSwap_MouseEnter);
            this.btnSwap.MouseLeave += new System.EventHandler(this.btnSwap_MouseLeave);
            // 
            // pnlForeground
            // 
            this.pnlForeground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlForeground.Controls.Add(this.graficaContainer1);
            this.pnlForeground.Controls.Add(this.lblVersion);
            this.pnlForeground.Controls.Add(this.pbxFondoVersion);
            this.pnlForeground.Controls.Add(this.pbxFondoLogo);
            this.pnlForeground.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlForeground.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(15)))));
            this.pnlForeground.Location = new System.Drawing.Point(0, 0);
            this.pnlForeground.Name = "pnlForeground";
            this.pnlForeground.Size = new System.Drawing.Size(857, 692);
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
            this.lblVersion.Text = "Versión 0.1";
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
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(914, 413);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(297, 51);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Texto = "Crear";
            this.btnLogin.ButtonClick += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ctbNombre
            // 
            this.ctbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ctbNombre.Location = new System.Drawing.Point(913, 263);
            this.ctbNombre.Name = "ctbNombre";
            this.ctbNombre.PlaceholderText = "Nombre";
            this.ctbNombre.Size = new System.Drawing.Size(313, 36);
            this.ctbNombre.TabIndex = 19;
            this.ctbNombre.txbText = "";
            this.ctbNombre.UsePasswordChar = false;
            // 
            // epbUser
            // 
            this.epbUser.BackColor = System.Drawing.Color.Transparent;
            this.epbUser.BkgImage = global::ProWork.Properties.Resources.Usuario;
            this.epbUser.Circle = false;
            this.epbUser.Location = new System.Drawing.Point(1017, 59);
            this.epbUser.Name = "epbUser";
            this.epbUser.Size = new System.Drawing.Size(104, 141);
            this.epbUser.TabIndex = 20;
            // 
            // epbPlusUser
            // 
            this.epbPlusUser.BackColor = System.Drawing.Color.Transparent;
            this.epbPlusUser.BkgImage = global::ProWork.Properties.Resources.MasUsuario;
            this.epbPlusUser.Circle = false;
            this.epbPlusUser.Location = new System.Drawing.Point(1114, 105);
            this.epbPlusUser.Name = "epbPlusUser";
            this.epbPlusUser.Size = new System.Drawing.Size(37, 37);
            this.epbPlusUser.TabIndex = 21;
            // 
            // ctbContra
            // 
            this.ctbContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ctbContra.Location = new System.Drawing.Point(913, 306);
            this.ctbContra.Name = "ctbContra";
            this.ctbContra.PlaceholderText = "Contraseña";
            this.ctbContra.Size = new System.Drawing.Size(312, 36);
            this.ctbContra.TabIndex = 22;
            this.ctbContra.txbText = "";
            this.ctbContra.UsePasswordChar = true;
            // 
            // ctbCContra
            // 
            this.ctbCContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ctbCContra.Location = new System.Drawing.Point(913, 348);
            this.ctbCContra.Name = "ctbCContra";
            this.ctbCContra.PlaceholderText = "Confirmar contraseña";
            this.ctbCContra.Size = new System.Drawing.Size(313, 36);
            this.ctbCContra.TabIndex = 23;
            this.ctbCContra.txbText = "";
            this.ctbCContra.UsePasswordChar = true;
            // 
            // graficaContainer1
            // 
            this.graficaContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.graficaContainer1.Location = new System.Drawing.Point(78, 59);
            this.graficaContainer1.Name = "graficaContainer1";
            this.graficaContainer1.Points = new System.Drawing.Point[] {
        new System.Drawing.Point(0, 9),
        new System.Drawing.Point(2, 5),
        new System.Drawing.Point(5, 5),
        new System.Drawing.Point(6, 7),
        new System.Drawing.Point(8, 9)};
            this.graficaContainer1.Size = new System.Drawing.Size(717, 567);
            this.graficaContainer1.TabIndex = 3;
            this.graficaContainer1.XAxis = "x";
            this.graficaContainer1.YAxis = "y";
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1262, 692);
            this.Controls.Add(this.epbPlusUser);
            this.Controls.Add(this.ctbNombre);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.pnlForeground);
            this.Controls.Add(this.epbUser);
            this.Controls.Add(this.ctbContra);
            this.Controls.Add(this.ctbCContra);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prowork";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.pnlForeground.ResumeLayout(false);
            this.pnlForeground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondoVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondoLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnSwap;
        private Panel pnlForeground;
        private System.Windows.Forms.Timer tmrIntoLogin;
        private System.Windows.Forms.Timer tmrIntoRegister;
        private System.ComponentModel.BackgroundWorker bgwCheck;
        private PictureBox pbxFondoLogo;
        private Label lblVersion;
        private PictureBox pbxFondoVersion;
        private ProWork.CustomButton btnLogin;
        private UnderlinedTextBox ctbNombre;
        private enhancedPictureBox epbUser;
        private enhancedPictureBox epbPlusUser;
        private PasswordUnderlinedTextBox ctbContra;
        private PasswordUnderlinedTextBox ctbCContra;
        private graficaContainer graficaContainer1;
    }
}